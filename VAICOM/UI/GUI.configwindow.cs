using VAICOM.Static;
using VAICOM.Client;
using System;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.Versioning;

namespace VAICOM
{

    namespace UI
    {

        [SupportedOSPlatform("windows")]
        public partial class Initialize
        {

            public static void OpenConfiguration(dynamic vaProxy, bool resetwindow)
            {
                if (!State.configwindowopen)
                {
                    try
                    {
                        State.configwindowopen = true;

                        vaProxy.WriteToLog("Opening Configuration window", Colors.Message);

                        ParameterizedThreadStart newwindow = new ParameterizedThreadStart(StartConfigWindow);
                        State.configwindowthread = new Thread(newwindow);
                        State.configwindowthread.IsBackground = true;
                        State.configwindowthread.SetApartmentState(ApartmentState.STA);
                        State.configwindowthread.Start(resetwindow);

                        UI.Playsound.Startup();

                        DcsClient.SendUpdateRequest();
                    }
                    catch (Exception a)
                    {
                        Log.Write("There was a problem opening the configuration window: " + a.Message, Colors.Text);
                    }
                }
                else
                {
                    if (resetwindow && State.configurationwindow != null)
                    {
                        State.configurationwindow.Dispatcher.BeginInvoke((MethodInvoker)delegate
                        {
                            State.configurationwindow.Left = 20;
                            State.configurationwindow.Top = 20;
                        });
                    }
                }
            }


            public static void StartConfigWindow(Object resetwindow)
            {
                
                State.configurationwindow = new ConfigWindow();

                if ((bool)resetwindow)
                {
                    State.configurationwindow.Left = 20;
                    State.configurationwindow.Top = 20;
                }

                State.configurationwindow.ShowDialog();

            }
        }
    }  
}
