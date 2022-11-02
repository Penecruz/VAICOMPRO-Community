using VAICOM.Static;
using VAICOM.Servers;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Runtime.Versioning;

namespace VAICOM
{
    namespace Interfaces
    {

        [SupportedOSPlatform("windows")]
        public partial class Network
        {

            public static void UDPsetup()
            {

               try
                {
                    // --------------------------------------------------------------------
                    // DCS JSON I/O

                    try
                    {
                        if (State.activeconfig.ClientSendIP.Equals(null) || State.activeconfig.ClientSendIP.Equals(0))
                        {
                            State.activeconfig.ClientSendIP = "127.0.0.1";
                        }
                    }
                    catch
                    {
                        State.activeconfig.ClientSendIP = "127.0.0.1";
                    }

                    try
                    {
                        if (State.activeconfig.ClientSendPort.Equals(null) || State.activeconfig.ClientSendPort.Equals(0))
                        {
                            State.activeconfig.ClientSendPort = 33491;
                        }
                    }
                    catch
                    {
                        State.activeconfig.ClientSendPort = 33491;
                    }

                    try
                    {
                        if (State.activeconfig.ClientReceivePort.Equals(null) || State.activeconfig.ClientReceivePort.Equals(0))
                        {
                            State.activeconfig.ClientReceivePort = 33492;
                        }
                    }
                    catch
                    {
                        State.activeconfig.ClientReceivePort = 33492;
                    }

                    State.SendSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                    State.SendIpEndPoint = new IPEndPoint(IPAddress.Parse(State.activeconfig.ClientSendIP), State.activeconfig.ClientSendPort);
                    State.ReceivingUdpClient = new UdpClient(State.activeconfig.ClientReceivePort);
                    State.ReceiveIpEndPoint = new IPEndPoint(IPAddress.Any, State.activeconfig.ClientReceivePort);
                    State.ReturnCall = new AsyncCallback(UDPreceive);

                    // --------------------------------------------------------------------
                }
                catch (Exception a)
                {
                    Log.Write("UDP general setup error " + a.StackTrace, Colors.Text);
                }

                try
                {
                    // --------------------------------------------------------------------
                    // for receiving messages separately

                    try
                    {
                        if (State.activeconfig.ClientReceivePortMessages.Equals(null) || State.activeconfig.ClientReceivePortMessages.Equals(0))
                        {
                            State.activeconfig.ClientReceivePortMessages = 44111;
                        }
                    }
                    catch
                    {
                        State.activeconfig.ClientReceivePortMessages = 44111;
                    }

                    State.ReceivingUdpClientMessages = new UdpClient(State.activeconfig.ClientReceivePortMessages);
                    State.ReceiveIpEndPointMessages = new IPEndPoint(IPAddress.Any, State.activeconfig.ClientReceivePortMessages);
                    State.ReturnCallMessages = new AsyncCallback(UDPreceiveMessages);
                    // --------------------------------------------------------------------
                }
                catch (Exception a)
                {
                    Log.Write("UDP message setup error " + a.StackTrace, Colors.Text);
                }


                // --------------------------------------------------------------------
                // for receiving messages from tray icon

                try
                {               
                    int traymessagesport = 19300;
                    State.ReceivingTrayMessages = new UdpClient(traymessagesport);
                    State.ReceiveIpTrayMessages = new IPEndPoint(IPAddress.Any, traymessagesport);
                    State.TrayMessages = new AsyncCallback(TrayReceiveMessages);
                    // --------------------------------------------------------------------
                }
                catch (Exception a)
                {
                    Log.Write("UDP Tray setup error (Receive)" + a.StackTrace, Colors.Text);
                }

                // --------------------------------------------------------------------
                // for sending messageg to tray icon

                try
                {
                    int traymessagessendport = 49303;
                    State.SendingIpTrayMessages = new IPEndPoint(IPAddress.Parse("127.0.0.1"), traymessagessendport);
                    // --------------------------------------------------------------------
                }
                catch (Exception a)
                {
                    Log.Write("UDP Tray setup error (Send)" + a.Message, Colors.Text);
                }


                try
                {
                    // --------------------------------------------------------------------
                    // SRS JSON I/O

                    //failsafe
                    try
                    {
                        if (State.activeconfig.SRS_ClientSendIP.Equals(null) || State.activeconfig.SRS_ClientSendIP.Equals(0))
                        {
                            State.activeconfig.SRS_ClientSendIP = "127.0.0.1";
                        }
                    }
                    catch
                    {
                        State.activeconfig.SRS_ClientSendIP = "127.0.0.1";
                    }

                    try
                    {
                        if (State.activeconfig.SRS_ClientSendPort.Equals(null) || State.activeconfig.SRS_ClientSendPort.Equals(0))
                        {
                            State.activeconfig.SRS_ClientSendPort = 33501;
                        }
                    }
                    catch
                    {
                        State.activeconfig.SRS_ClientSendPort = 33501;
                    }
                    try
                    {
                        if (State.activeconfig.SRS_ClientReceivePort.Equals(null) || State.activeconfig.SRS_ClientReceivePort.Equals(0))
                        {
                            State.activeconfig.SRS_ClientReceivePort = 33502;
                        }
                    }
                    catch
                    {
                        State.activeconfig.SRS_ClientReceivePort = 33502;
                    }

                    State.SRS_SendSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                    State.SRS_SendIpEndPoint = new IPEndPoint(IPAddress.Parse(State.activeconfig.SRS_ClientSendIP), State.activeconfig.SRS_ClientSendPort);
                    State.SRS_ReceivingUdpClient = new UdpClient(State.activeconfig.SRS_ClientReceivePort);
                    State.SRS_ReceiveIpEndPoint = new IPEndPoint(IPAddress.Any, State.activeconfig.SRS_ClientReceivePort);
                    State.SRS_ReturnCall = new AsyncCallback(SRS_UDPreceive);
                    // --------------------------------------------------------------------
                }
                catch (Exception a)
                {
                    Log.Write("UDP SRS setup error " + a.StackTrace, Colors.Text);
                }

                try
                {
                    // --------------------------------------------------------------------
                    // KNEEBOARD SEND

                    string Kneeboard_SendIP ="127.0.0.1";
                    int Kneeboard_SendPort = 52341;

                    State.Kneeboard_SendSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                    State.Kneeboard_SendIpEndPoint = new IPEndPoint(IPAddress.Parse(Kneeboard_SendIP), Kneeboard_SendPort);

                    // --------------------------------------------------------------------
                }
                catch (Exception a)
                {
                    Log.Write("UDP Kneeboard setup error " + a.StackTrace, Colors.Text);
                }


            }

            // ----------------------------------------------------------------------------------------------------------

            public static void UDPstart()
            {
                State.ReceivingUdpClient.BeginReceive(State.ReturnCall, null); 
                State.ReceivingUdpClientMessages.BeginReceive(State.ReturnCallMessages, null);

                //. for tray
                State.ReceivingTrayMessages.BeginReceive(State.TrayMessages, null);
            }

            // ----------------------------------------------------------------------------------------------------------
            // RECEIVERS

            // invoked when new DCS server packet was received (async)
            public static void UDPreceive(IAsyncResult res) 
            {
                byte[] receivedbytes = State.ReceivingUdpClient.EndReceive(res, ref State.ReceiveIpEndPoint);
                State.ReceivingUdpClient.BeginReceive(State.ReturnCall, null);

                try
                {
                    State.udpreceivedstring = Encoding.UTF8.GetString(receivedbytes);
                }
                catch (Exception e)
                {
                    Log.Write("Processing UTF8 input failed: " + e.Message, Colors.Inline);
                    State.udpreceivedstring = "";
                }

                try
                {
                    Server.ProcessRawServerMessage();
                }
                catch (Exception e)
                {
                    Log.Write("Problem with processing raw server message: " + e.StackTrace, Colors.Inline);
                }
            }

            // for incoming messages
            public static void UDPreceiveMessages(IAsyncResult res) 
            {
                byte[] receivedbytes = State.ReceivingUdpClientMessages.EndReceive(res, ref State.ReceiveIpEndPointMessages);
                State.ReceivingUdpClientMessages.BeginReceive(State.ReturnCallMessages, null);

                try
                {
                    string receivedstring = Encoding.UTF8.GetString(receivedbytes);
                    Log.Write("RECEIVED MESSAGE: " + receivedstring, Colors.Inline);
                    Server.ProcessCommsMessage(receivedstring);

                 }
                catch
                {
                }
            }

            // for tray stuff
            public static void TrayReceiveMessages(IAsyncResult res)
            {
                byte[] receivedbytes = State.ReceivingTrayMessages.EndReceive(res, ref State.ReceiveIpTrayMessages);
                State.ReceivingTrayMessages.BeginReceive(State.TrayMessages, null);

                try
                {
                    string receivedstring = Encoding.UTF8.GetString(receivedbytes);
                    Server.ProcessTrayMessage(receivedstring);

                }
                catch
                {
                }
            }

            // SRS Receiver
            public static void SRS_UDPreceive(IAsyncResult res) 
            {
                byte[] receivedbytes = State.SRS_ReceivingUdpClient.EndReceive(res, ref State.SRS_ReceiveIpEndPoint);
                State.SRS_ReceivingUdpClient.BeginReceive(State.SRS_ReturnCall, null);

                string SRS_receivedstring = "";
                try
                {
                    SRS_receivedstring = Encoding.UTF8.GetString(receivedbytes);
                }
                catch (Exception e)
                {
                    Log.Write("SRS message: processing UTF8 input failed: " + e.Message, Colors.Inline);
                }

            }
        }
    }
}
