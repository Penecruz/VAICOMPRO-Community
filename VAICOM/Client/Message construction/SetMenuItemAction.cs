using VAICOM.Static;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Collections.Generic;

using Newtonsoft.Json;

using System.Media;

namespace VAICOM
{

    namespace Client
    {

        public partial class DcsClient
        {
            public static partial class Message
            {
                public static void SetMenuItemAction()
                {
                    State.currentmessage.actionsequence.Add(State.currentcommand.actionIndex);
                }
            }
        }
    }
}



