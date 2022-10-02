using System.Collections.Generic;
using System;

namespace VAICOM
{
    namespace Database
    {

        public static partial class Labels
        {

            public static Dictionary<string, string> aiappendiceswpn = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {

                { "",                           " "                         },

                { "withmissile",                "with Missiles"             },
                { "withunguided",               "with Unguided Bombs"       },
                { "withguided",                 "with Guided Bombs"         },
                { "withrocket",                 "with Rockets"              },
                { "withmarker",                 "with Markers"              },
                { "withgun",                    "with Guns"                 },

            };

            public static Dictionary<string, string> aiappendicesdir = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "",                           " "                         },

                { "fromthenorth",              "from the North"             },
                { "fromthenortheast",          "from the NorthEast"         },
                { "fromtheeast",               "from the East"              },
                { "fromthesoutheast",          "from the SouthEast"         },
                { "fromthesouth",              "from the South"             },
                { "fromthesouthwest",          "from the SouthWest"         },
                { "fromthewest",               "from the West"              },
                { "fromthenorthwest",          "from the NorthWest"         },

            };
        }
    }
}
