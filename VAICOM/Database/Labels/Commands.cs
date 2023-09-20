﻿using System.Collections.Generic;
using System;

namespace VAICOM
{
    namespace Database
    {

        public static partial class Labels
        {

            public static Dictionary<string, string> aicommands = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {

                { "",                           " "                             },

                { "mytarget",                   "Engage My Target"              },
                { "bandit",                     "Engage Bandits"                },
                { "groundtarget",               "Engage Ground Targets"         },
                { "armor",                      "Engage Armor"                  },
                { "artillery",                  "Engage Artillery"              },
                { "airdefense",                 "Engage Air Defenses"           },
                { "utility",                    "Engage Utility Vehicles"       },
                { "infantry",                   "Engage Infantry"               },
                { "ship",                       "Engage Ships"                  },
                { "dlinktarget",                "Engage Datalink Target"        },
                { "dlinktargets",               "Engage Datalink Targets"       },
                { "dlinktargetbytype",          "Datalink Target by Type"       },
                { "dlinktargetsbytype",         "Datalink Targets by Type"      },
                { "completeandrejoin",          "Complete and Rejoin"           },
                { "completeandrtb",             "Complete and RTB"              },
                { "raytarget",                  "Ray Target"                    },
                { "myenemy",                    "Engage My Enemy"               },
                { "coverme",                    "Cover Me"                      },
                { "flightcheckin",              "Radio Check"                   },
                { "pincerright",                "Pincer Right"                  },
                { "pincerleft",                 "Pincer Left"                   },
                { "pincerhigh",                 "Pincer High"                   },
                { "pincerlow",                  "Pincer Low"                    },
                { "breakright",                 "Break Right"                   },
                { "breakleft",                  "Break Left"                    },
                { "breakhigh",                  "Break High"                    },
                { "breaklow",                   "Break Low"                     },
                { "clearright",                 "Clear Right"                   },
                { "clearleft",                  "Clear Left"                    },
                { "pump",                       "Pump"                          },
                { "anchorhere",                 "Anchor Here"                   },
                { "anchoratsteerpoint",         "Anchor at Steerpoint"          },
                { "anchoratspi",                "Anchor at SPI"                 },
                { "anchoratpoint",              "Anchor at Point"               },
                { "returntobase",               "Return To Base"                },
                { "flytotanker",                "Fly to Tanker"                 },
                { "joinup",                     "Join Up"                       },
                { "flyroute",                   "Fly Route"                     },
                { "makerecon1",                 "Make Recon 1 Mile"             },
                { "makerecon2",                 "Make Recon 2 Miles"            },
                { "makerecon3",                 "Make Recon 3 Miles"            },
                { "makerecon5",                 "Make Recon 5 Miles"            },
                { "makerecon8",                 "Make Recon 8 Miles"            },
                { "makerecon10",                "Make Recon 10 Miles"           },
                { "makereconatpoint",           "Make Recon at Point"           },
                { "radaron",                    "Radar On"                      },
                { "radaroff",                   "Radar Off"                     },
                { "ecmon",                      "ECM On"                        },
                { "ecmoff",                     "ECM Off"                       },
                { "smokeon",                    "Smoke On"                      },
                { "smokeoff",                   "Smoke Off"                     },
                { "jettisonweapons",            "Jettison Weapons"              },
                { "fencein",                    "Fence In"                      },
                { "fenceout",                   "Fence Out"                     },
                { "out",                        "Out"                           },
                { "golineabreast",              "Go Line Abreast"               },
                { "gotrail",                    "Go Trail"                      },
                { "gowedge",                    "Go Wedge"                      },
                { "goechelonright",             "Go Echelon Right"              },
                { "goechelonleft",              "Go Echelon Left"               },
                { "gofingerfour",               "Go Finger Four"                },
                { "gospreadfour",               "Go Spread Four"                },
                { "closeformation",             "Close Formation"               },
                { "openformation",              "Open Formation"                },
                { "closegroupformation",        "Close Group Formation"         },
                { "helogoheavy",                "Helo Go Heavy"                 },
                { "helogoechelon",              "Helo Go Echelon"               },
                { "helogospread",               "Helo Go Spread"                },
                { "helogotrail",                "Helo Go Trail"                 },
                { "helogooverwatch",            "Helo Go Overwatch"             },
                { "helogoleft",                 "Helo Go Left"                  },
                { "helogoright",                "Helo Go Right"                 },
                { "helogotight",                "Helo Go Tight"                 },
                { "helogocruise",               "Helo Go Cruise"                },
                { "helogocombat",               "Helo Go Combat"                },

                { "checkin05",          "Check In 5 minutes"     },
                { "checkin10",          "Check In 10 minutes"    },
                { "checkin15",          "Check In 15 minutes"    },
                { "checkin20",          "Check In 20 minutes"    },
                { "checkin25",          "Check In 25 minutes"    },
                { "checkin30",          "Check In 30 minutes"    },
                { "checkin35",          "Check In 35 minutes"    },
                { "checkin40",          "Check In 40 minutes"    },
                { "checkin45",          "Check In 45 minutes"    },
                { "checkin50",          "Check In 50 minutes"    },
                { "checkin55",          "Check In 55 minutes"    },
                { "checkin60",          "Check In 60 minutes"    },
                { "checkin",            "Check In"               },
                { "checkout",           "Check Out"              },
                { "readytocopy",        "Ready to Copy"         },
                { "readyforremarks",    "Ready for Remarks"     },
                { "ninelinereadback",   "Nine-line Readback"    },
                { "requesttasking",     "Request Tasking"       },
                { "requestbda",         "Request BDA"           },
                { "requesttargetdescr", "What is my Target"     },
                { "unabletocomply",     "Unable to Comply"      },

                { "ipinbound",          "IP Inbound"            },
                { "oneminute",          "One Minute"            },
                { "in",                 "IN"                    },
                { "off",                "OFF"                   },
                { "attackcomplete",     "Attack Complete"       },
                { "advisereadyforbda",  "Advise Ready for BDA"  },
                { "contact",            "Contact"               },
                { "nojoy",              "No Joy"                },
                { "contactthemark",     "Contact the Mark"      },
                { "sparkle",            "Sparkle"               },
                { "snake",              "Snake"                 },
                { "pulse",              "Pulse"                 },
                { "steady",             "Steady"                },
                { "rope",               "Rope"                  },
                { "contactsparkle",     "Contact Sparkle"       },
                { "stop",               "Stop"                  },
                { "tenseconds",         "Ten Seconds"           },
                { "laseron",            "Laser On"              },
                { "shift",              "Shift"                 },
                { "spot",               "Spot"                  },
                { "terminate",          "Terminate"             },
                { "gunsgunsguns",       "Guns!Guns!Guns!"       },
                { "bombsaway",          "Bombs Away!"           },
                { "rifles",             "Rifle!"                },
                { "rockets",            "Rockets!"              },
                { "bda",                "BDA"                   },
                { "inflightrep",        "In-flight Rep"         },

                { "requestenginesstart","Request Engines Start"     },
                { "requesthover",       "Request Hover"             },
                { "requesttaxitorunway","Request Taxi to Runway"    },
                { "requesttakeoff",     "Request Takeoff"           },
                { "aborttakeoff",       "Abort Takeoff"             },
                { "requestazimuth",     "Request Azimuth"           },
                { "inbound",            "Inbound"                   },
                { "abortinbound",       "Abort Inbound"             },
                { "requestlanding",     "Request Landing"           },
                { "reqtaxifortakeoff",  "Request Taxi for Takeoff"  },
                { "reqtaxitoparking",   "Request Taxi to Parking"   },
                { "towerreqtakeoff",    "Tower Request Takeoff"     },
                { "inboundstraight",    "Inbound Straight"          },
                { "approachoverhead",   "Approach Overhead"         },
                { "approachstraight",   "Approach Straight"         },
                { "approachinstrument", "Approach Instrument"       },

                { "vectortobullseye",   "Vector to Bullseye"        },
                { "vectortobandit",     "Vector to Bandit"          },
                { "vectortobase",       "Vector to Base"            },
                { "vectortotanker",     "Vector to Tanker"          },
                { "declare",            "Declare"                   },
                { "requestpicture",     "Request Picture"           },

                { "intenttorefuel",     "Intent to Refuel"          },
                { "abortrefuel",        "Abort Refuel"              },
                { "readyprecontact",    "Ready Precontact"          },
                { "stoprefueling",      "Stop Refueling"            },

                { "requestrefueling",   "Request Refueling"     },
                { "requestcannonreload","Request Cannon Reload" },
                { "requestrearming",    "Request Rearming"      },
                { "applyair",           "Apply Air"             },
                { "requestrepair",      "Request Repair"        },
                { "stowboardingladder", "Stow Boarding Ladder"  },
                { "runinertialstarter", "Run Inertial Starter"  },
                { "requesthmd",         "Request HMD"           },
                { "requestnvg",         "Request NVG"           },
                { "turboon",            "Turbo On"              },
                { "turbooff",           "Turbo Off"             },
                { "eppuon",             "EPPU On"               },
                { "eppuoff",            "EPPU Off"              },
                { "groundpoweron",      "Ground Power On"       },
                { "groundpoweroff",     "Ground Power Off"      },
                { "wheelchocksplace",   "Wheelchocks Place"     },
                { "wheelchocksremove",  "Wheelchocks Remove"    },
                { "Seq_J_CANOPY_OPEN",         "Canopy Open"           },
                { "Seq_J_CANOPY_CLOSE",        "Canopy Close"          },
                { "airsupplyconnect",   "Connect Air Supply"    },
                { "airsupplydisconnect","Disconnect Air Supply" },
                //{ "performaction",      "Perform Action"        },
                //{ "dospecial",          "Do Special"            },

                // Carrier Comms

                { "wMsgLeaderInboundCarrier" ,          "Inbound for Carrier"          },
                { "wMsgLeaderConfirm" ,                 "Confirm"                      },
                { "wMsgLeaderConfirmRemainingFuel" ,    "Confirm Remaining Fuel"       },
                { "wMsgLeaderInboundMarshallRespond" ,  "Inbound Marshall Response"    },
                { "wMsgLeaderEsteblished" ,             "Established"                  },
                { "wMsgLeaderCommencing" ,              "Commencing"                   },
                { "wMsgLeaderCheckingIn" ,              "Approach Check In"            },
                { "wMsgLeaderPlatform" ,                "Platform"                     },
                { "wMsgLeaderSayNeedle" ,               "Say Needles"                  },
                { "wMsgLeaderSeeYouAtTen" ,             "See You At Ten"               },
                { "wMsgLeaderHornetBall" ,              "Call Ball"                    },
                { "wMsgLeaderCLARA" ,                   "Clara"                        },
                { "wMsgLeaderBall" ,                    "Reference Ball"               },
                { "wMsgLeaderTowerOverhead" ,           "Overhead"                     },
                { "wMsgLeaderFlightKissOff" ,           "Flight Kiss Off"              },
                { "wMsgLeaderAirborn" ,                 "Airborne"                     },
                { "wMsgLeaderPassing2_5Kilo" ,          "Passing 2 5 Kilo"             },

                // supercarrier crew
                { "crewsalute",                         "Salute"                       },
                { "crewrequestcatlaunch"    ,           "Request Catapult Launch"      },
                                

                // Replies

                { "roger" ,             "Roger"                 },
                { "copy" ,              "Copy"                  },
                { "affirm" ,            "Affirm"                },
                { "wilco" ,             "Wilco"                 },
                { "negative" ,          "Negative"              },
                { "repeat",             "Repeat"                },

                { "menu01" ,            "Menu Item 1"           },
                { "menu02" ,            "Menu Item 2"           },
                { "menu03" ,            "Menu Item 3"           },
                { "menu04" ,            "Menu Item 4"           },
                { "menu05" ,            "Menu Item 5"           },
                { "menu06" ,            "Menu Item 6"           },
                { "menu07" ,            "Menu Item 7"           },
                { "menu08" ,            "Menu Item 8"           },
                { "menu09" ,            "Menu Item 9"           },
                { "menu10" ,            "Menu Item 10"          },
                { "menu11" ,            "Menu Item 11"          },
                { "menu12" ,            "Menu Item 12"          },

                { "switch",             "Switch to VoIP"        },
                { "select",             "Select Recipient"      },
                { "options",            "Show Options"          },
                { "state",              "Check Unit"            },
                { "readbriefing",       "Read Mission Briefing" },

                { "wMsgKneeboardDictateStart", "Dictation Start"  },
                { "wMsgKneeboardDictateStop", "Dictation Stop"    },
                { "wMsgKneeboardCorrection", "Dictation Correction" },
                { "wMsgKneeboardClearNotes", "Dictation Clear Notes" },
                { "wMsgKneeboardShowNotes", "Flip to Notes tab" },
                { "wMsgKneeboardShowLog", "Flip to LOG/ATO tab" },
                { "wMsgShowKneeboardTab", "Show kneeboard tab" },

                // Moose Airboss
                { "Radio Check Marshal", "Radio Check Marshal" },
                { "Radio Check LSO",     "Radio Check LSO"     },
                { "Request Commence",    "Request Commence"    },
                { "Emergency Landing",   "Emergency Landing"   },
            };

        }
    }
}
