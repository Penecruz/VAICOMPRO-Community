using System.Collections.Generic;
using System;
using Newtonsoft.Json.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.SqlTypes;
using System.Drawing;

namespace VAICOM
{

    namespace Database
    {

        public static partial class Aliases
        {

            public static Dictionary<string, string> playercallsigns = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {

                { "Boar",                   "boar"                  },//Original DCS
                { "Chevy",                  "chevy"                 },
                { "Colt",                   "colt"                  },
                { "Dodge",                  "dodge"                 },
                { "Enfield",                "enfield"               },
                { "Ford",                   "ford"                  },
                { "Hawg",                   "hawg"                  },
                { "Pig",                    "pig"                   },
                { "Pontiac",                "pontiac"               },
                { "Springfield",            "springfield"           },
                { "Tusk",                   "tusk"                  },
                { "Uzi",                    "uzi"                   },

                { "Viper",                  "viper"                 },//F-16
                { "Venom",                  "venom"                 },
                { "Lobo",                   "lobo"                  },
                { "Cowboy",                 "cowboy"                },
                { "Python",                 "python"                },
                { "Rattler",                "rattler"               },
                { "Panther",                "panther"               },
                { "Wolf",                   "wolf"                  },
                { "Weasel",                 "weasel"                },
                { "Wild",                   "wild"                  },
                { "Ninja",                  "ninja"                 },
                { "Jedi",                   "jedi"                  },

                { "Hornet",                 "Hornet"                },//F/A-18
                { "Squid",                  "Squid"                 },
                { "Ragin",                  "Ragin"                 },
                { "Sting",                  "Sting"                 },
                { "Jury",                   "Jury"                  },
                { "Joker",                  "Joker"                 },
                { "Ram",                    "Ram"                   },
                { "Hawk",                   "Hawk"                  },
                { "Devil",                  "Devil"                 },
                { "Check",                  "Check"                 },
                { "Snake",                  "Snake"                 },

                { "Dude",                   "Dude"                  },//F-15E
                { "Thud",                   "Thud"                  },
                { "Gunny",                  "Gunny"                 },
                { "Trek",                   "Trek"                  },
                { "Sniper",                 "Sniper"                },
                { "Sled",                   "Sled"                  },
                { "Best",                   "Best"                  },
                { "Jazz",                   "Jazz"                  },
                { "Rage",                   "Rage"                  },
                { "Tahoe",                  "Tahoe"                 },

                { "Army Air",               "Army Air"              },//AH-64
                { "Apache",                 "Apache"                },
                { "Crow",                   "Crow"                  },
                { "Sioux",                  "Sioux"                 },
                { "Gatling",                "gatling"               },
                { "Gun Slinger",            "Gun Slinger"           },
                { "Hammer Head",            "Hammer Head"           },
                { "Bootleg",                "Bootleg"               },
                { "Pale Horse",             "Pale Horse"            },
                { "Carnivor",               "Carnivor"              },
                { "Saber",                  "Saber"                 },

                { "Heavy",                  "Heavy"                 },//C-130-C-17
                { "Trash",                  "Trash"                 },
                { "Cargo",                  "Cargo"                 },
                { "Ascot",                  "Ascot"                 },
                { "Reech",                  "Reach"                 },

            };

        }
    }
}
