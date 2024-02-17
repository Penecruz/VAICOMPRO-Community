using System;
using System.Collections.Generic;

namespace VAICOM
{
    namespace Servers
    {

        public static partial class Server
        {
            public class MenuItem
            {
                public string server;
                public string menuname;
                public string itemname;
                public int actionIndex;

            }

            public static Dictionary<string, MenuItem> auxmenuitems = new Dictionary<string, MenuItem>(StringComparer.OrdinalIgnoreCase);

        }
    }
}
