using VAICOM.Static;
using System;

namespace VAICOM
{

    namespace Client
    {

        public partial class DcsClient
        {

            public static partial class Message
            {

                public static void RadioControl_TuneChan()
                {
                    try
                    {


                        RadioTuneMessage SendMessage = new RadioTuneMessage();
                        SendMessage.tgtdevid = Message.GetSendDeviceId();

                        int chan = 0;
                        string header = State.Proxy.Utility.ParseTokens("{CMDSEGMENT:0}");
                        Int32.TryParse(State.Proxy.Utility.ParseTokens("{CMDSEGMENT:1}"), out chan);

                        int chnoffset = State.currentmodule.chnoffset; // 1 for A10C, varies per module

                        SendMessage.tunechn = (chan - chnoffset).ToString();
 
                        SendRadioControlMessage(SendMessage);

                        Log.Write("Select Channel " + chan.ToString(), Colors.Message);

                        UI.Playsound.Commandcomplete();

                        State.MessageReset();

                    }
                    catch (Exception e)
                    {
                        Log.Write("Error setting Radio: " + e.StackTrace, Colors.Inline);
                    }
                }

            }
        }
    }
}



