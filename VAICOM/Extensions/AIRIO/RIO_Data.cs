using VAICOM.Static;
using System.Collections.Generic;


namespace VAICOM
{
    namespace Extensions
    {
        namespace RIO
        {

            public class tables
            {

                public static void resetriomenustate()
                {
                    try
                    {
                        tables.menustate[tables.menucats.RDR_BVR]       = tables.menustates.Radar_Active;
                        tables.menustate[tables.menucats.RDR_STT]       = tables.menustates.Not_STT_Locked;
                        tables.menustate[tables.menucats.WPN_AG]        = tables.menustates.AG_Computer_Pilot;
                        tables.menustate[tables.menucats.CREW]          = tables.menustates.Crew_Awake;
                        tables.menustate[tables.menucats.STARTUP]       = tables.menustates.Starting_Up;
                        tables.menustate[tables.menucats.PLAYERSEAT]    = tables.menustates.Pilot;
                        tables.menustate[tables.menucats.CONTR_TALK]    = tables.menustates.Talk;
                        tables.menustate[tables.menucats.CONTR_EJECT]   = tables.menustates.Eject_Single;
                        tables.menustate[tables.menucats.CALLOUTS]      = tables.menustates.Call;
                    }
                    catch
                    {
                        Log.Write("Problems reported with resetting RIO state.", Colors.Text);
                    }
                }

                public static Dictionary<menucats, menustates> menustate = new Dictionary<menucats, menustates>()
                {
                    {menucats.RDR_BVR,      menustates.Radar_Active         },
                    {menucats.RDR_STT,      menustates.Not_STT_Locked       },
                    {menucats.WPN_AG,       menustates.AG_Computer_Pilot    },
                    {menucats.CREW,         menustates.Crew_Awake           },
                    {menucats.STARTUP,      menustates.Starting_Up          },
                    {menucats.PLAYERSEAT,   menustates.Pilot                },
                    {menucats.CONTR_TALK,   menustates.Talk                 },
                    {menucats.CONTR_EJECT,  menustates.Eject_Single         },
                    {menucats.CALLOUTS,     menustates.Talk                 },

                };

                public enum menucats
                {
                    RADIO,
                    RDR_BVR,
                    RDR_STT,
                    RDR_WVR,
                    WPN_AG,
                    UTIL_NAV,
                    DEFENSIVE,
                    RADIO_DL,
                    UTIL_CREW,
                    CREW,
                    STARTUP,
                    PLAYERSEAT,
                    CONTR_TALK,
                    CONTR_EJECT,
                    CALLOUTS
                }

                public enum menustates
                {
                    Radar_Active,
                    Radar_Passive,
                    STT_locked,
                    Not_STT_Locked,
                    AG_Computer_Pilot,
                    AG_Computer_Target,
                    WPN_Single,
                    WPN_Pairs,
                    Crew_Awake,
                    Crew_Asleep,
                    Starting_Up,
                    Not_Starting,
                    Pilot,
                    RIO,
                    Talk,
                    No_Talk,
                    Eject_Both,
                    Eject_Single,
                    Call,
                    No_Call

                }


            }

        }
    }
}
