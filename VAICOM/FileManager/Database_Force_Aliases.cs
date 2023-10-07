using VAICOM.Static;
using VAICOM.Database;
using System.Collections.Generic;

namespace VAICOM
{
    namespace FileManager
    {

        public partial class FileHandler
        {

            public partial class Database
            {

                public static void ForceAddAliases()
                {


                    Log.Write("Updating aliases..", Colors.Text);

                    // Alias remove / add tables

                    Dictionary<string, string> RemoveAliasesRecipients = new Dictionary<string, string>()
                    {
                    };

                    Dictionary<string, string> ForceAliasesRecipients = new Dictionary<string, string>()
                    {
                        { "Carrier", "nearestcarrier" }, 
                        { "Cats","nearestcarrier" }, 
                        { "Marshal","nearestcarrier" }, 
                        { "Approach","nearestcarrier" },
                        { "LSO", "nearestcarrier" }, 
                        { "Paddles", "nearestcarrier" }, 

                        { "Rough Rider",           "CVN-71 Theodore Roosevelt"      },
                        { "Union",                 "CVN-72 Abraham Lincoln"         },
                        { "Warfighter",            "CVN-73 George Washington"       },
                        { "Courage",               "CVN-74 John C. Stennis"         },
                        { "Lone Warrior",          "CVN-75 Harry S. Truman"         },
                        { "Hand Book",             "CV-59 Forrestal"                },

                    };

                    Dictionary<string, string> RemoveAliasesCommands = new Dictionary<string, string>()
                    {
                        { "Ball" ,                     "wMsgLeaderBall"                         },
                        { "Say Needle" ,               "wMsgLeaderSayNeedle"                   },
                        { "Flight Kiss Off" ,          "wMsgLeaderFlightKissOff"               },
                        { "Inbound Marshall Respond" , "wMsgLeaderInboundMarshallRespond"      },

                    };

                    Dictionary<string, string> ForceAliasesCommands = new Dictionary<string, string>()
                    {
                        { "Status",                     "state"                                 },
                        { "Marking Moms" ,              "wMsgLeaderInboundCarrier"              },
                        { "Overhead" ,                  "wMsgLeaderTowerOverhead"               },
                        { "Kiss Off" ,                  "wMsgLeaderFlightKissOff"               },
                        { "Ball" ,                      "wMsgLeaderHornetBall"                  },
                        { "Needles" ,                   "wMsgLeaderSayNeedle"                   }, 
                        { "Low State" ,                 "wMsgLeaderConfirmRemainingFuel"        },
                        { "Approach Check In" ,         "wMsgLeaderCheckingIn"                  },
                        { "Expect On Time" ,            "wMsgLeaderInboundMarshallRespond"      }, 
                        { "Meatball" ,                  "wMsgLeaderBall"                        },

                        { "Hornet Ball" ,              "wMsgLeaderHornetBall"                  },
                        { "Tomcat Ball" ,              "wMsgLeaderHornetBall"                  },
                        { "Hawkeye Ball" ,             "wMsgLeaderHornetBall"                  },
                        { "Viking Ball" ,              "wMsgLeaderHornetBall"                  },
                        { "Phantom Ball" ,             "wMsgLeaderHornetBall"                  },
                        { "Greyhound Ball" ,           "wMsgLeaderHornetBall"                  },
                        { "Intruder Ball" ,            "wMsgLeaderHornetBall"                  },
                        { "Lightning Ball" ,           "wMsgLeaderHornetBall"                  },
                        { "Prowler Ball" ,             "wMsgLeaderHornetBall"                  },
                        { "Skyhawk Ball" ,             "wMsgLeaderHornetBall"                  },
                        { "Goshawk Ball" ,             "wMsgLeaderHornetBall"                  },

                    };

                    // recipients: clear first then add new 

                    foreach (KeyValuePair<string, string> entry in RemoveAliasesRecipients)
                    {
                        try
                        {
                            Aliases.airecipients.Remove(entry.Key);
                        }
                        catch
                        {
                        }
                    }

                    // for safety remove new ones also

                    foreach (KeyValuePair<string, string> entry in ForceAliasesRecipients)
                    {
                        try
                        {
                            Aliases.airecipients.Remove(entry.Key);
                        }
                        catch
                        {
                        }
                    }

                    // add the forced list

                    foreach (KeyValuePair<string, string> entry in ForceAliasesRecipients)
                    {
                        try
                        {
                            Aliases.airecipients.Add(entry.Key, entry.Value);
                        }
                        catch
                        {
                        }
                    }

                    // commands: clear first then add new 

                    foreach (KeyValuePair<string, string> entry in RemoveAliasesCommands)
                    {
                        try
                        {
                            Aliases.aicommands.Remove(entry.Key);
                        }
                        catch
                        {
                        }
                    }

                    // for safety commands also

                    foreach (KeyValuePair<string, string> entry in ForceAliasesCommands)
                    {
                        try
                        {
                            Aliases.aicommands.Remove(entry.Key);
                        }
                        catch
                        {
                        }
                    }

                    foreach (KeyValuePair<string,string> entry in ForceAliasesCommands)
                    {
                        try
                        {
                            Aliases.aicommands.Add(entry.Key, entry.Value);
                        }
                        catch
                        {
                        }
                    }

                    Log.Write("Done.", Colors.Text);

                    State.activeconfig.ForceAliasFinished = true;
                    Settings.ConfigFile.WriteConfigToFile(true);

                }

            }
        }
    }
}
