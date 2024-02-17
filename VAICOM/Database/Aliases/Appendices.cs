using System;
using System.Collections.Generic;

namespace VAICOM
{
    namespace Database
    {

        public static partial class Aliases
        {

            public static Dictionary<string, string> appendiceswpn = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {

                { "Missile*",                "withmissile"              },
                { "Maverick*",               "withmissile"              },
                { "Pickle*",                 "withunguided"             },
                { "Bomb*",                   "withunguided"             },
                { "Stores*",                 "withunguided"             },
                { "Guided*",                 "withguided"               },
                { "GBU*",                    "withguided"               },
                { "Paveway*",                "withguided"               },
                { "Rocket*",                 "withrocket"               },
                { "Dart*",                   "withrocket"               },
                { "Marker*",                 "withmarker"               },
                { "Paint*",                  "withmarker"               },
                { "Smoke*",                  "withmarker"               },
                { "Gun*",                    "withgun"                  },
                { "Strafe*",                 "withgun"                  },
                { "Bullet*",                 "withgun"                  },

            };

            public static Dictionary<string, string> appendicesdir = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {

                { "*from the North",         "fromthenorth"                },
                { "*from the NorthEast",     "fromthenortheast"            },
                { "*from the East",          "fromtheeast"                 },
                { "*from the SouthEast",     "fromthesoutheast"            },
                { "*from the South",         "fromthesouth"                },
                { "*from the SouthWest",     "fromthesouthwest"            },
                { "*from the West",          "fromthewest"                 },
                { "*from the NorthWest",     "fromthenorthwest"            },

            };



        }
    }

}
