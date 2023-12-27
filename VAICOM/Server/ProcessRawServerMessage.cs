using Newtonsoft.Json;
using System;
using VAICOM.Static;

namespace VAICOM
{

    namespace Servers
    {

        public static partial class Server
        {

            public static void ProcessRawServerMessage(string receivedString)
            {
                try
                {
                    if (!ValidateRaw(receivedString))
                    {
                        Log.Write("VOID SERVER MESSAGE: " + receivedString, Static.Colors.Inline);
                        return;
                    }

                    if (DetectEndMission(receivedString))
                    {
                        EndMission();
                        return;
                    }
                    ServerMessage decodedMessage = DecodeRawMessage(receivedString);
                    if (decodedMessage == null)
                    {
                        Log.Write("NOT DECODED: " + receivedString, Static.Colors.Inline);
                        return;
                    }

                    UpdateServerState(decodedMessage);

                }
                catch (Exception e)
                {
                    Log.Write("There was a problem processing server message: " + e.StackTrace, Static.Colors.Inline);
                }
            }

            public static bool ValidateRaw(string receivedString)
            {
                string inputfilter = "missiondata.update";
                if (!receivedString.Contains(inputfilter))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            public static ServerMessage DecodeRawMessage(string receivedString)
            {


                try
                {
                    return JsonConvert.DeserializeObject<ServerMessage>(receivedString);
                }
                catch (Exception e)
                {
                    Log.Write("JSON eror - server message decoding failed: " + e.Message, Colors.Inline);
                    return null;
                }

            }


        }
    }
}
