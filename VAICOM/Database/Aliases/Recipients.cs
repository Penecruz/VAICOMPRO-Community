using System;
using System.Collections.Generic;

namespace VAICOM
{
    namespace Database
    {

        public static partial class Aliases
        {

            public static Dictionary<string, string> airecipients = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
            
                // flight

                { "Flight",                 "flight"                },
                { "Element",                "element"               },
                { "Section",                "element"               },
                { "One",                    "wingman1"              },
                { "Lead",                   "wingman1"              },
                { "Winger",                 "wingman2"              },
                { "Two",                    "wingman2"              },
                { "Three",                  "wingman3"              },
                { "Four",                   "wingman4"              },

                { "Gopher",                 "wingman2"              },
                { "Pyro",                   "wingman3"              },
                { "Bozo",                   "wingman4"              },

                // JTAC

                { "JTAC",                   "jtac"                  },
                { "Patrol",                 "jtac"                  },
                { "Operator",               "jtac"                  },

                { "Axeman",                 "axeman"                },
                { "Darknight",              "darknight"             },
                { "Eyeball",                "eyeball"               },
                { "Finger",                 "finger"                },
                { "Firefly",                "firefly"               },
                { "Moonbeam",               "moonbeam"              },
                { "Playboy",                "playboy"               },
                { "Pointer",                "pointer"               },
                { "Warrior",                "warrior"               },
                { "Whiplash",               "whiplash"              },

                { "Pinpoint",               "pinpoint"              },
                { "Ferret",                 "ferret"                },
                { "Shaba",                  "shaba"                 },
                { "Hammer",                 "hammer"                },
                { "Jaguar",                 "jaguar"                },
                { "Deathstar",              "deathstar"             },
                { "Anvil",                  "anvil"                 },
                { "Mantis",                 "mantis"                },
                { "Badger",                 "badger"                },

                { "Boar",                   "boar"                  },
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

                { "Nearest Patrol",         "nearestjtac"           },

                //ATC

                { "ATC",                    "atc"                   },
                { "Tower",                  "atc"                   },
                { "Traffic",                "atc"                   },
                { "Nearest ATC",            "nearestairfield"       },
                { "Nearest Airfield",       "nearestairfield"       },
                { "Proxy",                  "nearestairfield"       },
                //{ "Alternate",              "alternateatc"          },

                // caucasus

                { "Anapa",                  "Anapa-Vityazevo"       },
                { "Batumi",                 "Batumi"                },
                { "Beslan",                 "Beslan"                },
                { "Gelendzhik",             "Gelendzhik"            },
                { "Gudauta",                "Gudauta"               },
                { "Khanskaya",              "Maykop-Khanskaya"      },
                { "Kobuleti",               "Kobuleti"              },
                { "Kolkhi",                 "Senaki-Kolkhi"         },
                { "Senaki",                 "Senaki-Kolkhi"         },
                { "Krasnodar",              "Krasnodar-Center"      },
                { "Krymsk",                 "Krymsk"                },
                { "Kutaisi",                "Kutaisi"               },
                { "Lochini",                "Tbilisi-Lochini"       },
                { "Tbilisi",                "Tbilisi-Lochini"       },
                { "Minvody",                "Mineralnye Vody"       },
                { "Mozdok",                 "Mozdok"                },
                { "Nalchik",                "Nalchik"               },
                { "Novorossiysk",           "Novorossiysk"          },
                { "Pashkovsky",             "Krasnodar-Pashkovsky"  },
                { "Sochi",                  "Sochi-Adler"           },
                { "Soganlug",               "Soganlug"              },
                { "Sukhumi",                "Sukhumi-Babushara"     },
                { "Vaziani",                "Vaziani"               },

                // Nevada

                { "Creech",                 "Creech AFB"                    },
                { "Indian Springs",         "Creech AFB"                    },
                { "North Las Vegas",        "North Las Vegas"               },
                { "Graceland",              "North Las Vegas"               },
                { "Henderson",              "Henderson Executive Airport"   },
                { "McCarran",               "McCarran International Airport"},
                { "Las Vegas",              "McCarran International Airport"},
                { "Laughlin",               "Laughlin Airport"              },
                { "Bullhead",               "Laughlin Airport"              },
                { "Tonopah",                "Tonopah Test Range Airfield"   },
                { "Silverbow",              "Tonopah Test Range Airfield"   },
                { "Groom Lake",             "Groom Lake AFB"                },
                { "Dreamland",              "Groom Lake AFB"                },
                { "Nellis",                 "Nellis AFB"                    },
                { "NellisControl",          "Nellis AFB"                    },

                // Normandy

                { "Beny",                   "Beny-sur-Mer"                  },
                { "Sainte Croix",           "Sainte-Croix-sur-Mer"          },
                { "Lantheuil",              "Lantheuil"                     },
                { "Bazenville",             "Bazenville"                    },
                { "Sommervieu",             "Sommervieu"                    },
                { "Longues",                "Longues-sur-Mer"               },
                { "Molay",                  "Le Molay"                      },
                { "Saint Laurent",          "Sainte-Laurent-sur-Mer"        },
                { "Saint Pierre",           "Saint Pierre du Mont"          },
                { "Deux Jumeaux",           "Deux Jumeaux"                  },
                { "Chippelle",              "Chippelle"                     },
                { "Cricqueville",           "Cricqueville-en-Bessin"        },
                { "Cardonville",            "Cardonville"                   },
                { "Brucheville",            "Brucheville"                   },
                { "Meautis",                "Meautis"                       },
                { "Azeville",               "Azeville"                      },
                { "Cretteville",            "Cretteville"                   },
                { "Picauville",             "Picauville"                    },
                { "Biniville",              "Biniville"                     },
                { "Lessay",                 "Lessay"                        },
                { "Maupertus",              "Maupertus"                     },
                { "Evreux",                 "Evreux"                        },
                { "Forde",                  "Forde"                         },
                { "Tangmere",               "Tangmere"                      },
                { "Funtington",             "Funtington"                    },
                { "Chailey",                "Chailey"                       },
                { "Needs Oar",              "Needs Oar Point"               },

                // Persian Gulf

                { "Al Maktoum",             "Al Maktoum Intl"               },
                //{ "OMDW",                   "Al Maktoum Intl"               },
                { "Al Minhad",              "Al Minhad AFB"                  },
                //{ "OMDM",                   "Al Minhad AB"                  },
                { "Dubai",                  "Dubai Intl"                    },
                //{ "OMDB",                   "Dubai Intl"                    },
                { "Sharjah",                "Sharjah Intl"                  },
                //{ "OMSJ",                   "Sharjah Intl"                  },
                { "Abu Musa",               "Abu Musa Island Airport"       },
                { "Sirri",                  "Sirri Island"                  },
                //{ "OIBS",                   "Sirri Island"                  },
                { "Fujairah",               "Fujairah Intl"                 },
                //{ "OMFJ",                   "Fujairah Intl"                 },
                { "Bandar",                 "Bandar Lengeh"                 },
                //{ "OIBL",                   "Bandar Lengeh"                 },
                { "Khasab",                 "Khasab"                        },
                { "Qeshm Island",           "Qeshm Island"                  },
                { "Havadarya",              "Havadarya"                     },
                { "Bandar Abbas",           "Bandar Abbas Intl"             },
                //{ "OIKB",                   "Bandar Abbas Intl"             },
                { "Lar Airbase",            "Lar Airbase"                   },
                //{ "OISL",                   "Lar Airbase"                   },
                { "Kerman Airport",         "Kerman Airport"                },
                //{ "KERMAN",                 "Kerman Airport"                },
                { "Shiraz Airport",         "Shiraz International Airport"  },
                //{ "SHIRAZ",                 "Shiraz International Airport"  },
                { "Al Dhafra",              "Al Dhafra AB"                  },
                //{ "OMAM",                   "Al Dhafra AB"                  },

                { "Al Bateen",              "Al-Bateen Airport"             },

                { "Kish Island",            "Kish International Airport"    },
                { "Lavan Island",           "Lavan Island Airport"          },
                { "Al Ain Airport",         "Al Ain International Airport"               },
                //{ "Bandar-e-Jask",          "Bandar-e-Jask"                 },
                { "Abu Dhabi",              "Abu Dhabi International Airport"   },
                { "Sas Al Nakheel",         "Sas Al Nakheel Airport"            },
                { "Jiroft",                 "Jiroft Airport"                },
                { "Liwa Airbase",           "Liwa Airbase"                  },
                { "Ras Al Khaimah",         "Ras Al Khaimah"                },

                //Channel map
                { "Dunkirk",                "Dunkirk Mardyck" },
                { "Hawkinge",               "Hawkinge" },
                { "Saint Omer",             "Saint Omer Longuenesse" },
                { "Calonne",                "Merville Calonne" },
                { "High Halden",            "High Halden" },
                { "Detling",                "Detling" },
                { "Drucat",                 "Abbeville Drucat" },
                { "Lympne",                 "Lympne" },
                { "Manston",                "Manston" },

                // Syria map

                { "Hariri",                 "Beirut-Rafic Hariri"   },
                { "Riyaq",                  "Rayak"                 },
                { "Hamat",                  "Wujah Al Hajar"        },
                { "Kiryat",                 "Kiryat Shmona"         },
                { "Mezzeh",                 "Mezzeh"                },
                { "Qabr as Sitt",           "Qabr as Sitt"          },
                { "Rene Mouawad",           "Rene Mouawad"          },
                { "Marj as Sultan",         "Marj as Sultan North"  },
                { "Der Salman",             "Marj as Sultan South"  },
                { "Marj Ruhayyil",          "Marj Ruhayyil"         },
                { "Dumayr",                 "Al-Dumayr"             },
                { "Haifa",                  "Haifa"                 },
                { "An Nasiriyah",           "An Nasiriyah"          },
                { "Al Qusayr",              "Al Qusayr"             },
                { "Khalkhalah",             "Khalkhalah"            },
                { "Ramat David",            "Ramat David"           },
                { "Megiddo",                "Megiddo"               },
                { "Eyn Shemer",             "Eyn Shemer"            },
                { "Latakia",                "Bassel Al-Assad"       },
                { "Abu al-Duhur",           "Abu al-Duhur"          },
                { "Taftanaz",               "Taftanaz"              },
                { "Hatay",                  "Hatay"                 },
                { "Rasin",                  "Kuweires"              },
                { "Minakh",                 "Minakh"                },
                { "Jirah",                  "Jirah"                 },
                { "Adana",                  "Adana Sakirpasa"       },
                { "Incirlik",               "Incirlik"              },

                // farp

                { "Platform",               "platform"              },
                { "FARP",                   "platform"              },
                //{ "Nearest Platform",       "nearestfarp"           },

                // farps (blue)

                { "Berlin",                 "berlin"                },
                { "Dallas",                 "dallas"                },
                { "Dublin",                 "dublin"                },
                { "London",                 "london"                },
                { "Madrid",                 "madrid"                },
                { "Moscow",                 "moscow"                },
                { "Paris",                  "paris"                 },
                { "Perth",                  "perth"                 },
                { "Rome",                   "rome"                  },
                { "Warsaw",                 "warsaw"                },

                // farps (red)

                { "Kaemka",                 "kaemka"                },
                { "Kalitka",                "kalitka"               },
                { "Kapel",                  "kapel"                 },
                { "Otkrytka",               "otkrytka"              },
                { "Podkova",                "podkova"               },
                { "Shpora",                 "shpora"                },
                { "Skala",                  "skala"                 },
                { "Torba",                  "torba"                 },
                { "Vetka",                  "vetka"                 },
                { "Yunga",                  "yunga"                 },

                { "Carrier",                "carrier"                   },
                { "Nearest Carrier",        "nearestcarrier"            },

                { "Admiral Kuznetsov",      "CV 1143.5 Admiral Kuznetsov"   },
                { "Carl Vinson",            "CVN-70 Carl Vinson"            },
                { "Tarawa",                 "LHA-1 Tarawa"                  },
                { "Perry",                  "FFG-7CL Oliver Hazzard Perry"  },
                { "Normandy",               "CG-60 Normandy"                },
                { "CV-59 Forrestal",        "CV-59 Forrestal"               },

                // supercarriers
                { "Roosevelt",             "CVN-71 Theodore Roosevelt"      },
                { "Rough Rider",           "CVN-71 Theodore Roosevelt"      },

                { "Lincoln",               "CVN-72 Abraham Lincoln"         },
                { "Union",                 "CVN-72 Abraham Lincoln"         },

                { "Washington",            "CVN-73 George Washington"       },
                { "Warfighter",            "CVN-73 George Washington"       },

                { "Stennis",               "CVN-74 John C. Stennis"         },
                { "Courage",               "CVN-74 John C. Stennis"         },

                { "Truman",                "CVN-75 Harry S. Truman"         },
                { "Lone Warrior",          "CVN-75 Harry S. Truman"         },

                //new roles

                { "Cats","nearestcarrier" }, // was ATC
                { "Marshal","nearestcarrier" }, // 
                { "Approach","nearestcarrier" }, // 
                { "LSO", "nearestcarrier" }, //
                { "Paddles", "nearestcarrier" }, //

                // awacs

                { "Awacs",                  "awacs"                 },
                { "Darkstar",               "darkstar"              },
                { "Focus",                  "focus"                 },
                { "Magic",                  "magic"                 },
                { "Overlord",               "overlord"              },
                { "Wizard",                 "wizard"                },
                { "Nearest AWACS",          "nearestawacs"          },

                // tanker

                { "Tanker",                 "tanker"                },
                { "Texaco",                 "texaco"                },
                { "Shell",                  "shell"                 },
                { "Arco",                   "arco"                  },
                { "Nearest Tanker",         "nearesttanker"         },

                   // crew

                { "Crew",                   "crew"                   },
                { "Chief",                  "crew"                   },
                { "Sarge",                  "crew"                   },

                // AOCS

                { "Crystal Palace",         "aocs"                   },

                // other

                { "Server",                 "aux"                    },
                { "Mystery",                "aux"                    },
                { "Mission",                "aux"                    },

                { "Cargo",                  "cargo"                  },
                { "Descent",                "descent"                },

                { "Kneeboard",              "kneeboard"              },

            };

        }

    }

}