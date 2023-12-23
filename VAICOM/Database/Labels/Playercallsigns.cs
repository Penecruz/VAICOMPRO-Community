using System.Collections.Generic;
using System;

namespace VAICOM
{
    namespace Database
    {

        public static partial class Labels
        {

            public static Dictionary<string, string> playercallsigns = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {

                { "",                       " "                     },

                { "boar",                   "Boar"                  },//Original DCS
                { "chevy",                  "Chevy"                 },
                { "colt",                   "Colt"                  },
                { "dodge",                  "Dodge"                 },
                { "enfield",                "Enfield"               },
                { "ford",                   "Ford"                  },
                { "hawg",                   "Hawg"                  },
                { "pig",                    "Pig"                   },
                { "pontiac",                "Pontiac"               },
                { "springfield",            "Springfield"           },
                { "tusk",                   "Tusk"                  },
                { "uzi",                    "Uzi"                   },

                { "viper",                  "Viper"                 },//F-16
                { "venom",                  "Venom"                 },
                { "lobo",                   "Lobo"                  },
                { "cowboy",                 "Cowboy"                },
                { "python",                 "Python"                },
                { "rattler",                "Rattler"               },
                { "panther",                "Panther"               },
                { "wolf",                   "Wolf"                  },
                { "weasel",                 "Weasel"                },
                { "wild",                   "Wild"                  },
                { "ninja",                  "Ninja"                 },
                { "jedi",                   "Jedi"                  },

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
