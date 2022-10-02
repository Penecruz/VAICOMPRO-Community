using VAICOM.Static;
using System;
using Newtonsoft.Json;

namespace VAICOM
{

    namespace Servers
    {

        public static partial class Server
        {

            public static void ProcessRawServerMessage()
            {
                try
                {
                    if (!ValidateRaw())
                    {
                        Log.Write("VOID SERVER MESSAGE: " + State.udpreceivedstring, Static.Colors.Inline);
                        return;
                    }
           
                    if (DetectEndMission(State.udpreceivedstring))
                    {
                        EndMission();
                        return;
                    }

                    if (!DecodeRawMessage())
                    {
                        Log.Write("NOT DECODED: " + State.udpreceivedstring, Static.Colors.Inline);
                        return;
                    }

                    UpdateServerState();

                }
                catch (Exception e)
                {
                    Log.Write("There was a problem processing server message: " + e.StackTrace, Static.Colors.Inline);
                }
            }

            public static bool ValidateRaw()
            {
                string inputfilter = "missiondata.update";
                if (!State.udpreceivedstring.Contains(inputfilter))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            public static bool DecodeRawMessage()
            {

                string jsonstring = State.udpreceivedstring;
                try
                {             
                    State.receivedchunk = JsonConvert.DeserializeObject<ServerMessage>(jsonstring);                                                                                                   
                    return true;
                }
                catch (Exception e)
                {
                    Log.Write("JSON eror - server message decoding failed: " + e.Message, Colors.Inline);
                    return false;
                }

            }


        }
    }
}
