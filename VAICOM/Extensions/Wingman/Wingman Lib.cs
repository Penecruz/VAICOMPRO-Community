using System;
using System.Collections.Generic;


namespace VAICOM
{
    namespace Extensions
    {
        namespace WorldAudio
        {
            public static partial class Processor
            {
                public static Dictionary<string, string> wavfileroots = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
                {
                // resource (starts with), filepathroot

                // Digits

                { "digits/0-begin",         "_0_begin"                          },
                { "digits/0-continue",      "_0_continue"                       },
                { "digits/0-end",           "_0_end"                            },
                { "digits/1-begin",         "_1_begin"                          },
                { "digits/1-continue",      "_1_continue"                       },
                { "digits/1-end",           "_1_end"                            },
                { "digits/2-begin",         "_2_begin"                          },
                { "digits/2-continue",      "_2_continue"                       },
                { "digits/2-end",           "_2_end"                            },
                { "digits/3-begin",         "_3_begin"                          },
                { "digits/3-continue",      "_3_continue"                       },
                { "digits/3-end",           "_3_end"                            },
                { "digits/4-begin",         "_4_begin"                          },
                { "digits/4-continue",      "_4_continue"                       },
                { "digits/4-end",           "_4_end"                            },
                { "digits/5-begin",         "_5_begin"                          },
                { "digits/5-continue",      "_5_continue"                       },
                { "digits/5-end",           "_5_end"                            },
                { "digits/6-begin",         "_6_begin"                          },
                { "digits/6-continue",      "_6_continue"                       },
                { "digits/6-end",           "_6_end"                            },
                { "digits/7-begin",         "_7_begin"                          },
                { "digits/7-continue",      "_7_continue"                       },
                { "digits/7-end",           "_7_end"                            },
                { "digits/8-begin",         "_8_begin"                          },
                { "digits/8-continue",      "_8_continue"                       },
                { "digits/8-end",           "_8_end"                            },
                { "digits/9-begin",         "_9_begin"                          },
                { "digits/9-continue",      "_9_continue"                       },
                { "digits/9-end",           "_9_end"                            },

                // Messages

                { "messages/at destination",    "at_destination"                },
                { "messages/bail out",          "bail_out"                      },
                { "messages/bearing",           "bearing"                       },
                { "messages/bingo fuel",        "bingo_fuel"                    },
                { "messages/bombs away",        "bombs_away"                    },
                { "messages/check six",         "check_six"                     },
                { "messages/contact bearing",   "contact_bearing"               }, //
                { "messages/contact",           "contactx"                      }, // amb
                { "messages/copy rejoin",       "copy_rejoin"                   }, // amb (opy)
                { "messages/ejecting",          "ejecting"                      },
                { "messages/engaged defensive", "engaged_defensive"             },
                { "messages/engaging air defences", "engaging_air_defences"     },
                { "messages/engaging bandit",   "engaging_bandit"               },
                { "messages/engaging primary",  "engaging_primary"              },
                { "messages/engaging target",   "engaging_target"               },
                { "messages/fox 1",             "fox_1"                         },
                { "messages/fox 2",             "fox_2"                         },
                { "messages/fox 3",             "fox_3"                         },
                { "messages/guns",              "guns"                          },
                { "messages/i am hit",          "i_am_hit"                      },
                { "messages/in position to the left", "in_position_to_the_left" },
                { "messages/missile away from", "missile_rifle"                 }, // amb
                { "messages/missile away",      "missile_away"                  }, // amb
                { "messages/missile launch",    "missile_launch"                },
                { "messages/mud spike",         "mud_spike"                     },
                { "messages/music is off",      "music_is_off"                  },
                { "messages/music is on",       "music_is_on"                   },
                { "messages/radar off",         "radar_off"                     },
                { "messages/radar on",          "radar_on"                      },
                { "messages/rejoin",            "rejoin"                        },
                { "messages/request permission to attack", "request_permission_to_attack"   },
                { "messages/rockets away",      "rockets_away"                  },
                { "messages/rolling",           "rollingx"                      }, // amb
                { "messages/rolling_taxi",      "rolling_taxi"                  }, // amb
                { "messages/rtb",               "rtb"                           },
                { "messages/running in",        "running_in"                    },
                { "messages/sam launch",        "sam_launch"                    },
                { "messages/spike",             "spike"                         },
                { "messages/splash one",        "splash_one"                    },
                { "messages/tally bandit",      "tally_bandit"                  },
                { "messages/wheels up",         "wheels_up"                     },
                { "messages/winchester",        "winchester"                    },

                // root

                { "1oclock",                    "_1oclock"                      },
                { "2oclock",                    "_2oclock"                      },
                { "3oclock",                    "_3oclock"                      },
                { "4oclock",                    "_4oclock"                      },
                { "5oclock",                    "_5oclock"                      },
                { "6oclock",                    "_6oclock"                      },
                { "7oclock",                    "_7oclock"                      },
                { "8oclock",                    "_8oclock"                      },
                { "9oclock",                    "_9oclock"                      },
                { "10oclock",                   "_10oclock"                     },
                { "11oclock",                   "_11oclock"                     },
                { "12oclock",                   "_12oclock"                     },

                { "2-bright",                   "_2_bright"                     },
                { "2-calm",                     "_2_calm"                       },
                { "2-loud",                     "_2_loud"                       },
                { "3-bright",                   "_3_bright"                     },
                { "3-calm",                     "_3_calm"                       },
                { "3-loud",                     "_3_loud"                       },
                { "4-bright",                   "_4_bright"                     },
                { "4-calm",                     "_4_calm"                       },
                { "4-loud",                     "_4_loud"                       },

                { "affirm",                     "affirm"                        },
                { "air defence target",         "air_defence_target"            },
                { "armor target",               "armor_target"                  },
                { "copy",                       "copyx"                         }, //amb
                { "delimeter",                  "delimeter"                     },
                { "for",                        "for"                           },
                { "negative",                   "negative"                      },
                { "roger",                      "roger"                         },
                { "rounds on target",           "rounds_on_target"              },
                { "target destroyed",           "trgt_destroyed"                }, //amb
                { "target",                     "target"                        }, //amb
                { "unable",                     "unable"                        },

                // additional fun stuff

                { "10",                         "number_11"                     }, // make TEN
                { "11",                         "number_11"                     },
                { "12",                         "number_12"                     },
                { "13",                         "number_13"                     },
                { "14",                         "number_14"                     },
                { "15",                         "number_15"                     },
                { "16",                         "number_16"                     },
                { "17",                         "number_17"                     },
                { "18",                         "number_18"                     },
                { "19",                         "number_19"                     },
                { "20",                         "number_20"                     },
                { "30",                         "number_30"                     },
                { "40",                         "number_40"                     },
                { "50",                         "number_50"                     },
                { "60",                         "number_60"                     },
                { "70",                         "number_70"                     },
                { "80",                         "number_80"                     },
                { "90",                         "number_90"                     },

                };

            }
        }
    }
}


