using System.Collections.Generic;

namespace VAICOM
{
    namespace Client
    {
        public partial class DcsClient
        {

            public static class iCommandsequences
            {

                public static List<int> voidmessage = new List<int>() { iCommands.iCommandNull };

                public static List<int> homemenu = new List<int>() { iCommands.ICommandMenuItem11, iCommands.ICommandMenuItem11, iCommands.ICommandMenuItem11 };

                public static List<int> showFlight = new List<int>() { iCommands.ICommandMenuItem2 };
                public static List<int> showJTAC = new List<int>() { iCommands.ICommandMenuItem4 };
                public static List<int> showATC = new List<int>() { iCommands.ICommandMenuItem5 };
                public static List<int> showCargo = new List<int>() { iCommands.ICommandMenuItem6 };
                public static List<int> showDescent = new List<int>() { iCommands.ICommandMenuItem7 };
                public static List<int> showAWACS = new List<int>() { iCommands.ICommandMenuItem7 };
                public static List<int> showTanker = new List<int>() { iCommands.ICommandMenuItem6, iCommands.ICommandMenuItem9 };
                public static List<int> showCrew = new List<int>() { iCommands.ICommandMenuItem8 };
                public static List<int> showAux = new List<int>() { iCommands.ICommandMenuItem10 };
                public static List<int> showMoose = new List<int>() { iCommands.ICommandMenuItem10 }; // Add Moose

                public static List<int> doAction1 = new List<int>() { iCommands.ICommandMenuItem1 };
                public static List<int> doAction2 = new List<int>() { iCommands.ICommandMenuItem2 };
                public static List<int> doAction3 = new List<int>() { iCommands.ICommandMenuItem3 };
                public static List<int> doAction4 = new List<int>() { iCommands.ICommandMenuItem4 };
                public static List<int> doAction5 = new List<int>() { iCommands.ICommandMenuItem5 };
                public static List<int> doAction6 = new List<int>() { iCommands.ICommandMenuItem6 };
                public static List<int> doAction7 = new List<int>() { iCommands.ICommandMenuItem7 };
                public static List<int> doAction8 = new List<int>() { iCommands.ICommandMenuItem8 };
                public static List<int> doAction9 = new List<int>() { iCommands.ICommandMenuItem9 };
                public static List<int> doAction10 = new List<int>() { iCommands.ICommandMenuItem10 };
                public static List<int> doAction11 = new List<int>() { iCommands.ICommandMenuItem11 };
                public static List<int> doAction12 = new List<int>() { iCommands.ICommandMenuItem12 };

                public static List<int> closemenu = new List<int>() { iCommands.ICommandMenuItem12 };

                public static List<int> showflight1 = new List<int>() { iCommands.ICommandMenuItem1 };
                public static List<int> showflight2 = new List<int>() { iCommands.ICommandMenuItem2 };

                public static List<int> iCommandPushToTalkEnableVoice = new List<int>() { iCommands.iCommandPushToTalkEnableVoice };
                public static List<int> iCommandPushToTalkDisableVoice = new List<int>() { iCommands.iCommandPushToTalkDisableVoice };

                public static List<int> menuindex()
                {

                    List<int> retindex = new List<int>();

                    try
                    {
                        int calledatcindex = State.currentmessageunit.index;

                        bool haspages = false;

                        bool morethanoneunit = (State.currentstate.availablerecipients[State.currentrecipientclass.Name].Count > 1);
                        bool calledgenericclass = State.currentkey["recipient"].ToLower().Equals(State.currentrecipientclass.Name.ToLower());

                        if (morethanoneunit & !calledgenericclass)
                        {
                            haspages = true;
                        }

                        if (haspages & (calledatcindex < 11)) // if fits on page
                        {
                            int menunumber = 965 + calledatcindex;
                            retindex.Add(menunumber);
                        }
                        else
                        {
                            //retindex.Add(0); 
                        }

                    }
                    catch
                    {
                    }

                    return retindex;
                }

            }

            public static class iCommands
            {
                public static int iCommandNull = 0;

                public static int ICommandToggleCommandMenu = 179;

                public static int ICommandMenuItem1 = 966;
                public static int ICommandMenuItem2 = 967;
                public static int ICommandMenuItem3 = 968;
                public static int ICommandMenuItem4 = 969;
                public static int ICommandMenuItem5 = 970;
                public static int ICommandMenuItem6 = 971;
                public static int ICommandMenuItem7 = 972;
                public static int ICommandMenuItem8 = 973;
                public static int ICommandMenuItem9 = 974;
                public static int ICommandMenuItem10 = 975;
                public static int ICommandMenuItem11 = 976;
                public static int ICommandMenuItem12 = 977;

                public static int ICommandMenuExit = 978;
                public static int ICommandSwitchDialog = 979;
                public static int ICommandSwitchToCommonDialog = 980;

                public static int iCommandPushToTalkEnableVoice = 1695;
                public static int iCommandPushToTalkDisableVoice = 1696;


            }
        }
    }
}
