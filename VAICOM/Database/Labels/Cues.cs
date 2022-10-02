using System.Collections.Generic;
using System;

namespace VAICOM
{
    namespace Database
    {

        public static partial class Labels
        {

            public static Dictionary<string, string> aicues = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {

                { "",                   " "                     },
                { "engage",             "Engage"                },

            };
        }
    }
}
