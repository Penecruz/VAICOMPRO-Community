using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;

namespace VAICOM_App
{
    partial class Program
    {



        public static int timesincelastheartbeat = 0;
        public static int heartbeattreshold = 5;


        public static void SendUDPMessage(string formatmessage)
        {
            try
            {
                byte[] sendbuffer = Encoding.UTF8.GetBytes(formatmessage);
                UDPSendSocket.SendTo(sendbuffer, SendIpEndPoint);
            }
            catch
            {
            }
        }

        public static void TrayReceiveMessages(IAsyncResult res)
        {
            byte[] receivedbytes = ReceivingTrayMessages.EndReceive(res, ref IpEndPoint);
            ReceivingTrayMessages.BeginReceive(TrayMessages, null);

            try
            {
                // received something (heartbeat).
                string receivedstring = Encoding.UTF8.GetString(receivedbytes);

                if (!receivedstring.ToLower().Contains("error"))
                {
                    // OK
                    timesincelastheartbeat = 0;
                }
                else
                {
                    if (forceprofile && receivedstring.ToLower().Contains("profile"))
                    {
                        // Fail, heartbeat not reset
                        VA_needsreload = true;
                        return;
                    }

                    // OK
                    timesincelastheartbeat = 0;
                }

            }
            catch
            {
            }
        }

        public static UdpClient ReceivingTrayMessages = new UdpClient(49303);
        public static AsyncCallback TrayMessages = new AsyncCallback(TrayReceiveMessages);
        public static IPEndPoint IpEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 49303);

        public static Socket UDPSendSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        public static IPEndPoint SendIpEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 19300);

        public static System.Timers.Timer BeaconTimer = new System.Timers.Timer(5000);
        public static System.Timers.Timer TrayBlinkTimer = new System.Timers.Timer(1000);

        static string TryGetVAPath()
        {

            // default if all else fails

            string path = "C:\\Program Files (x86)\\VoiceAttack";

            try
            {
                // assume vaicom.exe is in the default location

                string currentpath = System.Reflection.Assembly.GetExecutingAssembly().Location;

                if (currentpath.Contains("\\Apps\\VAICOMPRO\\VAICOMPRO.exe"))
                {
                    string correctedpath = currentpath.Replace("\\Apps\\VAICOMPRO\\VAICOMPRO.exe", "");
                    path = correctedpath;
                }
                else
                {
                    throw new Exception();
                }

            }
            catch
            {
                // if there's a snag, try path from registry

                try
                {
                    RegistryKey getkey = Registry.CurrentUser.OpenSubKey("Software\\VoiceAttack.com\\VoiceAttack");
                    string pathstring = getkey.GetValue("InstallPath").ToString();
                    getkey.Close();

                    path = pathstring;
                }
                catch
                {
                }
            }


            path += "\\" + "VoiceAttack.exe";
            return path;
        }

        static void KickStartVA()
        {
            try
            {
                Process[] pname = Process.GetProcessesByName("voiceattack");
                bool VA_not_running = (pname.Length == 0);
                bool VA_hangs = !VA_not_running && !pname[0].Responding;

                if (VA_not_running || VA_hangs || VA_needsreload)
                {

                    if (VA_needsreload)
                    {
                        TerminateProcess("voiceattack"); // hard reset, soft without
                        VA_needsreload = false;
                    }

                    VA_isrunning = false;

                    if (VA_keepalive)
                    {

                        string VA_arguments = "";
                        VA_arguments += "-minimize";
                        VA_arguments += " " + "-nofocus";
                        VA_arguments += " " + "-punload 1000";

                        if (runasadmin)
                        {
                            VA_arguments += " " + "-asadmin";
                        }
                        else
                        {
                            VA_arguments += " " + "-clearasadmin";
                        }

                        if (forceprofile)
                        {
                            string vaicomprofilename = "\"VAICOM PRO for DCS World\"";
                            VA_arguments += " " + "-profile" + " " + vaicomprofilename;
                        }

                        Process.Start(VA_path, VA_arguments);

                        timesincelastheartbeat = 0;
                    }
                }
                else
                {
                    VA_isrunning = true;
                }

            }
            catch
            {
            }

        }

        private static void Beacon_Timer_Elapsed_Handler(object sender, ElapsedEventArgs e)
        {
            timesincelastheartbeat += 5;
            KickStartVA();
        }

        static bool runasadmin = true;
        static bool VA_keepalive = false;
        static bool VA_isrunning = false;
        static bool forceprofile = false;
        static bool VA_needsreload = false;
        static string VA_path = "";

        static void ProcessArguments(string[] args)
        {
            try
            {
                if (args.Length > 0)
                {
                    // arguments are used

                    foreach (string arg in args)
                    {
                        switch (arg.Replace(" ", "").ToLower())
                        {
                            case "-forceprofile":
                                forceprofile = true;
                                break;
                            case "-noadmin":
                                runasadmin = false;
                                break;

                            default:
                                break;
                        }
                    }
                }
                else
                {
                    //use defaults
                    forceprofile = false;
                }

                VA_keepalive = true;
                VA_path = TryGetVAPath();
            }
            catch
            {
            }
        }

        static void TerminateProcess(string processname)
        {
            try
            {
                Process[] runningProcesses = Process.GetProcesses();
                foreach (Process process in runningProcesses)
                {
                    if (process.ProcessName.ToLower().Equals(processname))
                    {
                        process.Kill();
                    }
                }
            }
            catch
            {
            }
        }

        //public class heartbeatmessage
        //{
        //    public string messagetype;
        //    public string status;

        //}

        static bool TerminateIfRunningProcesses(string processname)
        {
            bool terminate = false;

            try
            {
                Process[] runningProcesses = Process.GetProcesses();

                int counter = 0;

                foreach (Process process in runningProcesses)
                {
                    if (process.ProcessName.ToLower().Equals(processname))
                    {
                        counter += 1;
                    }
                }

                if (counter > 1)
                {
                    terminate = true;
                }
            }
            catch
            {
                terminate = true;
            }

            return terminate;
        }

        private static void OnApplicationExit(object sender, EventArgs e)
        {
            try
            {
                BeaconTimer.Elapsed -= Beacon_Timer_Elapsed_Handler;
                string jsonstring = "{\"APIcommand\":\"exitapp\"}";
                SendUDPMessage(jsonstring);
                Thread.Sleep(1000);
                TerminateProcess("voiceattack");
            }
            catch
            {
            }
        }

        private static void trayIcon_DoubleClick(object sender, EventArgs e)
        {
            string jsonstring = "{\"APIcommand\":\"config\"}";
            SendUDPMessage(jsonstring);
        }

        public class CustomApplicationContext : ApplicationContext
        {
            public NotifyIcon trayIcon;

            public static bool blink = false;

            private void TrayBlink_Elapsed_Handler(object sender, ElapsedEventArgs e)
            {
                if (!VA_isrunning)
                {

                    if (blink)
                    {
                        this.trayIcon.Icon = Properties.Resources.Tray_icon_64;
                    }
                    else
                    {
                        this.trayIcon.Icon = Properties.Resources.vaicompro_icon_32;
                    }

                    blink = !blink;
                }
                else
                {
                    if (timesincelastheartbeat > heartbeattreshold)
                    {
                        this.trayIcon.Icon = Properties.Resources.vaicompro_icon_32;
                        this.trayIcon.Text = "VAICOM PRO: check VA status";
                    }
                    else
                    {
                        this.trayIcon.Icon = Properties.Resources.Tray_icon_64;
                        this.trayIcon.Text = "VAICOM PRO is active";
                    }
                }
            }

            public CustomApplicationContext()
            {

                trayIcon = new NotifyIcon()
                {
                    Icon = Properties.Resources.Tray_icon_64,
                    ContextMenu = new ContextMenu(new MenuItem[] { new MenuItem("Restart", ForceVARestart), new MenuItem("Reset Window", ResetWindow), new MenuItem("Exit", Exit) }), //new MenuItem("API Test", APITest),
                    Visible = true,

                };

                trayIcon.DoubleClick += trayIcon_DoubleClick;
                Application.ApplicationExit += new EventHandler(OnApplicationExit);

                TerminateProcess("voiceattack");
                Thread.Sleep(500);
                KickStartVA();

                ReceivingTrayMessages.BeginReceive(TrayMessages, null);

                BeaconTimer.Elapsed += Beacon_Timer_Elapsed_Handler;
                BeaconTimer.Start();

                TrayBlinkTimer.Elapsed += TrayBlink_Elapsed_Handler;
                TrayBlinkTimer.Start();

            }

            void Exit(object sender, EventArgs e)
            {
                trayIcon.Visible = false;
                Application.Exit();
            }

            void ForceVARestart(object sender, EventArgs e)
            {
                TerminateProcess("voiceattack");
            }

            void ResetWindow(object sender, EventArgs e)
            {
                string jsonstring = "{\"APIcommand\":\"resetwindow\"}";
                SendUDPMessage(jsonstring);
            }

            void APITest(object sender, EventArgs e)
            {
                //API_Test();
            }

        }

        //public class TrayMessage
        //{
        //    public string APIcommand;
        //}

        static void Main(string[] args)
        {
            try
            {

                if (TerminateIfRunningProcesses("vaicompro"))
                {
                    return;
                }

                ProcessArguments(args);

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new CustomApplicationContext());

            }
            catch
            {
            }
        }
    }
}
