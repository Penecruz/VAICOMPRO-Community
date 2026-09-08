using System;
using System.Threading;
using VAICOM.Static;

namespace VAICOM
{
    namespace Client
    {

        public partial class DcsClient
        {
            public static partial class Message
            {
                // For AI comms. An optional delay can be specified after which the the server update request
                // is sent. If no delay is specified then this will use the default 0 delay, or the radio delay
                // from the current module is used.
                public static void SendNewMessage(int delay = 0)
                {
                    try
                    {
                        string outputstring = SendClientMessage();
                        Log.Write("CLIENT MESSAGE SENT: " + outputstring, Colors.Inline);
                        Log.Write("Message sent successfully for recipient class " + State.currentrecipientclass.Name + ".", Colors.Inline);

                        if (State.currentmessage.command.Equals(4000))
                        {
                            int updateDelay = delay > 0 ? delay : State.currentmodule.radiodelay;
                            Thread.Sleep(updateDelay);
                            DcsClient.SendUpdateRequest(); // get an update directly after
                        }
                    }
                    catch (Exception)
                    {
                        Log.Write("A problem occured while sending client JSON message.", Colors.Inline);
                        //UI.Playsound.error();
                    }
                }

            }
        }
    }

}



