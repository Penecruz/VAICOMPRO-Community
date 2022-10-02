using System.Collections.Generic;
using System;

namespace VAICOM
{
    namespace Database
    {

        public static partial class Aliases
        {

            public static Dictionary<string, string> aicues = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "Engage",                 "engage"               },
                { "Attack",                 "engage"               },
                { "Strike",                 "engage"               },
                { "Weapons Free",           "engage"               },
                { "Cleared Hot",            "engage"               },

            };

        }
    }
}
