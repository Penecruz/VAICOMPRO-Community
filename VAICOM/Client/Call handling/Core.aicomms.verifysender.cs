using VAICOM.Database;
using VAICOM.Static;

namespace VAICOM
{
    namespace Client
    {

        public partial class DcsClient
        {
            public static partial class Message
            {

                public static void verifysender()
                {

                    Log.Write("NOTE: have sender = " + State.have["sender"].ToString(), Colors.Message);

                    string recipientname = State.currentkey["recipient"];
                    string sendername = State.currentkey["sender"];

                    Log.Write("NOTE: used recipient callsign " + recipientname, Colors.Message);
                    Log.Write("NOTE: used sender callsign " + sendername, Colors.Message);

                    if (State.have["sender"])
                    {

                        if ((State.currentstate.availablerecipients["Player"].Count > 0) & !(State.have["sender"] & State.currentstate.playercallsign.ToLower().Contains(State.currentkey["sender"].ToLower())))
                        {
                            string callsign = State.currentkey["sender"];
                            if (callsign != "")
                            {
                                Log.Write("NOTE: used sender callsign " + Labels.playercallsigns[callsign] + " is invalid against " + State.currentstate.playercallsign + " (ignored)", Colors.Message);
                            }

                        }

                    }
                    else
                    {
                        // no sender specified
                    }

                }
            }
        }
    }
}



