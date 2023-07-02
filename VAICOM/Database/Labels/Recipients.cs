using System.Collections.Generic;
using System;

namespace VAICOM
{
    namespace Database
    {

        public static partial class Labels
        {

            public static Dictionary<string, string> airecipients = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {

                { "",                       " "                     },

                { "Undefined",              "Undefined"             },

                { "flight",                 "Flight"                },
                { "element",                "Element"               },
                { "wingman1",               "Wingman 1"             },
                { "wingman2",               "Wingman 2"             },
                { "wingman3",               "Wingman 3"             },
                { "wingman4",               "Wingman 4"             },

                { "jtac",                   "JTAC"                  },

                { "axeman",                 "Axeman"                },
                { "darknight",              "Darknight"             },
                { "eyeball",                "Eyeball"               },
                { "finger",                 "Finger"                },
                { "firefly",                "Firefly"               },
                { "moonbeam",               "Moonbeam"              },
                { "playboy",                "Playboy"               },
                { "pointer",                "Pointer"               },
                { "warrior",                "Warrior"               },
                { "whiplash",               "Whiplash"              },

                { "pinpoint",               "Pinpoint"              },
                { "ferret",                 "Ferret"                },
                { "shaba",                  "Shaba"                 },
                { "hammer",                 "Hammer"                },
                { "jaguar",                 "Jaguar"                },
                { "deathstar",              "Deathstar"             },
                { "anvil",                  "Anvil"                 },
                { "mantis",                 "Mantis"                },
                { "badger",                 "Badger"                },

                { "boar",                   "Boar"                  },
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

                { "nearestjtac",            "Nearest JTAC"          },

                // ATC general

                { "atc",                    "Air Traffic Controller" },
                { "nearestairfield",        "Nearest Airfield"      },
                //{ "alternateatc",           "Alternate Airfield"    },
                
                
                // Caucuases map
                
                { "wAIUnitATCCaucasusNull", "wAIUnitATCCaucasusNull"},
                { "Anapa-Vityazevo",        "Anapa-Vityazevo"       },
                { "Batumi",                 "Batumi"                },
                { "Beslan",                 "Beslan"                },
                { "Gelendzhik",             "Gelendzhik"            },
                { "Gudauta",                "Gudauta"               },
                { "Maykop-Khanskaya",       "Maykop-Khanskaya"      },
                { "Kobuleti",               "Kobuleti"              },
                { "Senaki-Kolkhi",          "Senaki-Kolkhi"         },
                { "Krasnodar-Center",       "Krasnodar-Center"      },
                { "Krymsk",                 "Krymsk"                },
                { "Kutaisi",                "Kutaisi"               },
                { "Tbilisi-Lochini",        "Tbilisi-Lochini"       },
                { "Mineralnye Vody",        "Mineralnye Vody"       },
                { "Mozdok",                 "Mozdok"                },
                { "Nalchik",                "Nalchik"               },
                { "Novorossiysk",           "Novorossiysk"          },
                { "Krasnodar-Pashkovsky",   "Krasnodar-Pashkovsky"  },
                { "Sochi-Adler",            "Sochi-Adler"           },
                { "Soganlug",               "Soganlug"              },
                { "Sukhumi-Babushara",      "Sukhumi-Babushara"     },
                { "Vaziani",                "Vaziani"               },

                // Nevanda map

                { "Creech",                 "Creech"                 },
                { "Henderson Executive",    "Henderson Executive"    },
                { "McCarran International", "McCarran International" },
                { "Laughlin",               "Laughlin"               },
                { "North Las Vegas",        "North Las Vegas"        },
                { "Tonopah Test Range",     "Tonopah Test Range"     },
                { "Groom Lake",             "Groom Lake"             },
                { "Nellis",                 "Nellis"                 },
                { "Boulder City",           "Boulder City"           },

                // Normanday map

                { "Beny-sur-Mer",           "Beny-sur-Mer"                  },
                { "Sainte-Croix-sur-Mer",   "Sainte-Croix-sur-Mer"          },
                { "Lantheuil",              "Lantheuil"                     },
                { "Bazenville",             "Bazenville"                    },
                { "Sommervieu",             "Sommervieu"                    },
                { "Longues-sur-Mer",        "Longues-sur-Mer"               },
                { "Le Molay",               "Le Molay"                      },
                { "Sainte-Laurent-sur-Mer", "Sainte-Laurent-sur-Mer"        },
                { "Saint Pierre du Mont",   "Saint Pierre du Mont"          },
                { "Deux Jumeaux",           "Deux Jumeaux"                  },
                { "Chippelle",              "Chippelle"                     },
                { "Cricqueville-en-Bessin", "Cricqueville-en-Bessin"        },
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
                { "Needs Oar Point",        "Needs Oar Point"               },

                // Persian Gulf Map

                { "Al Maktoum Intl",        "Al Maktoum Intl"               },
                { "Al Minhad AFB",          "Al Minhad AFB"                 },
                { "Dubai Intl",             "Dubai Intl"                    },
                { "Sharjah Intl",           "Sharjah Intl"                  },
                { "Abu Musa Island Airport","Abu Musa Island Airport"       },
                { "Sirri Island",           "Sirri Island"                  },
                { "Fujairah Intl",          "Fujairah Intl"                 },
                { "Bandar Lengeh",          "Bandar Lengeh"                 },
                { "Khasab",                 "Khasab"                        },
                { "Qeshm Island",           "Qeshm Island"                  },
                { "Havadarya",              "Havadarya"                     },
                { "Bandar Abbas Intl",      "Bandar Abbas Intl"             },
                { "Lar Airbase",            "Lar Airbase"                   },
                { "Kerman Airport",         "Kerman Airport"                },
                { "Shiraz International Airport","Shiraz Intl Airport"      },
                { "Al Dhafra AB",           "Al Dhafra AB"                  },
                { "Al-Bateen Airport",      "Al-Bateen Airport"             },
                { "Kish International Airport", "Kish International Airport"},
                { "Lavan Island Airport",   "Lavan Island Airport"          },
                { "Al Ain International Airport","Al Ain International Airport"},
                { "Bandar-e-Jask",          "Bandar-e-Jask"                 },
                { "Abu Dhabi International Airport","Abu Dhabi International"},
                { "Sas Al Nakheel Airport",         "Sas Al Nakheel Airport"},
                { "Jiroft Airport",         "Jiroft Airport"                },
                { "Liwa Airbase",           "Liwa Airbase"                  },
                { "Ras Al Khaimah",         "Ras Al Khaimah"                },

                //Channel map
                { "Dunkirk Mardyck",        "Dunkirk Mardyck" },
                { "Hawkinge",               "Hawkinge" },
                { "Saint Omer Longuenesse", "Saint Omer Longuenesse" },
                { "Merville Calonne",       "Merville Calonne" },
                { "High Halden",            "High Halden" },
                { "Detling",                "Detling" },
                { "Abbeville Drucat",       "Abbeville Drucat" },
                { "Lympne",                 "Lympne" },
                { "Manston",                "Manston" },

                // Syria map

                { "Beirut-Rafic Hariri",    "Beirut-Rafic Hariri"   },
                { "Rayak",                  "Rayak"                 },
                { "Wujah Al Hajar",         "Wujah Al Hajar"        },
                { "Kiryat Shmona",          "Kiryat Shmona"         },
                { "Mezzeh",                 "Mezzeh"                },
                { "Qabr as Sitt",           "Qabr as Sitt"          },
                { "Rene Mouawad",           "Rene Mouawad"          },
                { "Marj as Sultan North",   "Marj as Sultan North"  },
                { "Marj as Sultan South",   "Marj as Sultan South"  },
                { "Marj Ruhayyil",          "Marj Ruhayyil"         },
                { "Al-Dumayr",              "Al-Dumayr"             },
                { "Haifa",                  "Haifa"                 },
                { "An Nasiriyah",           "An Nasiriyah"          },
                { "Al Qusayr",              "Al Qusayr"             },
                { "Khalkhalah",             "Khalkhalah"            },
                { "Ramat David",            "Ramat David"           },
                { "Megiddo",                "Megiddo"               },
                { "Eyn Shemer",             "Eyn Shemer"            },
                { "Bassel Al-Assad",        "Bassel Al-Assad"       },
                { "Abu al-Duhur",           "Abu al-Duhur"          },
                { "Taftanaz",               "Taftanaz"              },
                { "Hatay",                  "Hatay"                 },
                { "Kuweires",               "Kuweires"              },
                { "Minakh",                 "Minakh"                },
                { "Jirah",                  "Jirah"                 },
                { "Adana Sakirpasa",        "Adana Sakirpasa"       },
                { "Incirlik",               "Incirlik"              },

                // Sinai map

                { "Al Mansurah",            "Al Mansurah"           },
                { "AzZaqaziq",              "AzZaqaziq"             },
                { "As Salihiyah",           "As Salihiyah"          },
                { "Bilbeis Air Base",       "Bilbeis Air Base"      },
                { "Inshas Airbase",         "Inshas Airbase"        },
                { "Abu Suwayr",             "Abu Suwayr"            },
                { "Al Ismailiyah",          "Al Ismailiyah"         },//
                { "Cairo International Airport", "Cairo International Airport"  },
                { "Difarsuwar Airfield",    "Difarsuwar Airfield"   },//
                { "Wadi al Jandali",        "Wadi al Jandali"       },
                { "Fayed",                  "Fayed"                 },
                { "Baluza",                 "Baluza"                },
                { "Cairo West",             "Cairo West"            },
                { "Kibrit Air Base",        "Kibrit Air Base"       },
                { "Melez",                  "Melez"                 },
                { "Bir Hasanah",            "Bir Hasanah"           },
                { "El Arish",               "El Arish"              },
                { "El Gora",                "El Gora"               },
                { "Abu Rudeis",             "Abu Rudeis"            },
                { "Kedem",                  "Kedem"                 },
                { "Ramon Airbase",          "Ramon Airbase"         },
                { "Hatzerim",               "Hatzerim"              },
                { "Hatzor",                 "Hatzor"                },
                { "Palmahim",               "Palmahim"              },
                { "Tel Nof",                "Tel Nof"               },
                { "Nevatim",                "Nevatim"               },
                { "Sde Dov",                "Sde Dov"               },
                { "Ben-Gurion",             "Ben-Gurion"            },
                { "Ovda",                   "Ovda"                  },
                { "St Catherine",           "St Catherine"          },

                // South Atlantic map

                { "Mount Pleasant",         "Mount Pleasant"        },
                { "Goose Green",            "Goose Green"           },
                { "San Carlos FOB",         "San Carlos FOB"        },
                { "Port Stanley",           "Port Stanley"          },
                { "Aerodromo De Tolhuin",   "Aerodromo De Tolhuin"  },
                { "Rio Grande",             "Rio Grande"            },
                { "Puerto Williams",        "Puerto Williams"       },
                { "San Julian",             "San Julian"            },
                { "Ushuaia Helo Port",      "Ushuaia Helo Port"     },
                { "Ushuaia",                "Ushuaia"               },
                { "Pampa Guanaco",          "Pampa Guanaco"         },
                { "Puerto Santa Cruz",      "Puerto Santa Cruz"     },
                { "Rio Chico",              "Rio Chico"             },
                { "Rio Gallegos",           "Rio Gallegos"          },
                { "Franco Bianco",          "Franco Bianco"         },
                { "Comandante Luis Piedrabuena",  "Comandante Luis Piedrabuena"        },
                { "Porvenir Airfield",      "Porvenir Airfield"     },
                { "Punta Arenas",           "Punta Arenas"          },
                { "Aeropuerto de Gobernador Gregores",  "Aeropuerto de Gobernador Gregores"    },
                { "Rio Turbio",             "Rio Turbio"            },
                { "El Calafate",            "El Calafate"           },
                { "Puerto Natales",         "Puerto Natales"        },
                { "Aerodromo O'Higgins",    "Aerodromo O'Higgins"   },
                
                // FARP

                { "platform",               "Helipad"               },

                { "berlin",                 "Berlin"                },
                { "dallas",                 "Dallas"                },
                { "dublin",                 "Dublin"                },
                { "london",                 "London"                },
                { "madrid",                 "Madrid"                },
                { "moscow",                 "Moscow"                },
                { "paris",                  "Paris"                 },
                { "perth",                  "Perth"                 },
                { "rome",                   "Rome"                  },
                { "warsaw",                 "Warsaw"                },

                { "kaemka",                 "Kaemka"                },
                { "kalitka",                "Kalitka"               },
                { "kapel",                  "Kapel"                 },
                { "otkrytka",               "Otkrytka"              },
                { "podkova",                "Podkova"               },
                { "shpora",                 "Shpora"                },
                { "skala",                  "Skala"                 },
                { "torba",                  "Torba"                 },
                { "vetka",                  "Vetka"                 },
                { "yunga",                  "Yunga"                 },

                { "carrier",                        "Carrier"                       },
                { "nearestcarrier",                 "Carrier Operations"            },
                { "CV 1143.5 Admiral Kuznetsov",    "CV 1143.5 Admiral Kuznetsov"   },
                { "CVN-70 Carl Vinson",             "CVN-70 Carl Vinson"            },
                { "LHA-1 Tarawa",                   "LHA-1 Tarawa"                  },
                { "FFG-7CL Oliver Hazzard Perry",   "FFG-7CL Oliver Hazzard Perry"  },
                { "CVN-74 John C. Stennis",         "CVN-74 John C. Stennis"        },
                { "CG-60 Normandy",                 "CG-60 Normandy"                },
                { "CV-59 Forrestal",                "CV-59 Forrestal"               },
                
                // new carriers
                { "CVN-71 Theodore Roosevelt",                          "CVN-71 Theodore Roosevelt"             },
                { "CVN-72 Abraham Lincoln",                             "CVN-72 Abraham Lincoln"                },
                { "CVN-73 George Washington",                           "CVN-73 George Washington"              },
                { "CVN-75 Harry S. Truman",                             "CVN-75 Harry S. Truman"                },

                // new roles

                { "CarrierDeparture", "Carrier Departure" },
                { "CarrierMarshal",   "Carrier Marshal" },
                { "CarrierApproachTower", "Carrier Approach" },
                { "CarrierLSO", "Carrier LSO" },

                { "awacs",                  "AWACS"                 },
                { "darkstar",               "Darkstar"              },
                { "focus",                  "Focus"                 },
                { "magic",                  "Magic"                 },
                { "overlord",               "Overlord"              },
                { "wizard",                 "Wizard"                },
                { "nearestawacs",           "Nearest AWACS"         },

                { "tanker",                 "Tanker"                },
                { "texaco",                 "Texaco"                },
                { "shell",                  "Shell"                 },
                { "arco",                   "Arco"                  },
                { "nearesttanker",          "Nearest Tanker"        },

                { "crew",                   "Ground Crew"           },

                { "aocs",                   "AOCS"                  },

                { "aux",                    "F10 Menu"              },

                { "cargo",                  "Cargo"                 },
                { "descent",                "Descent"               },

                { "kneeboard",              "Kneeboard"             },
                //{ "kneeboardnotes",         "Flip to Notes tab"     },

            };

        }
    }
}
