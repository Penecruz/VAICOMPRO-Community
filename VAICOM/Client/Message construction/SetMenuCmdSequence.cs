
namespace VAICOM
{
    namespace Client
    {

        public partial class DcsClient
        {

            public static partial class Message
            {

                public static void SetMenuCmdSequence()
                {

                    switch (State.currentkey["command"])
                    {
                        case "menu01":
                            State.currentmessage.cmdsequence.AddRange(iCommandsequences.doAction1);
                            break;
                        case "menu02":
                            State.currentmessage.cmdsequence.AddRange(iCommandsequences.doAction2);
                            break;
                        case "menu03":
                            State.currentmessage.cmdsequence.AddRange(iCommandsequences.doAction3);
                            break;
                        case "menu04":
                            State.currentmessage.cmdsequence.AddRange(iCommandsequences.doAction4);
                            break;
                        case "menu05":
                            State.currentmessage.cmdsequence.AddRange(iCommandsequences.doAction5);
                            break;
                        case "menu06":
                            State.currentmessage.cmdsequence.AddRange(iCommandsequences.doAction6);
                            break;
                        case "menu07":
                            State.currentmessage.cmdsequence.AddRange(iCommandsequences.doAction7);
                            break;
                        case "menu08":
                            State.currentmessage.cmdsequence.AddRange(iCommandsequences.doAction8);
                            break;
                        case "menu09":
                            State.currentmessage.cmdsequence.AddRange(iCommandsequences.doAction9);
                            break;
                        case "menu10":
                            State.currentmessage.cmdsequence.AddRange(iCommandsequences.doAction10);
                            break;
                        case "menu11":
                            State.currentmessage.cmdsequence.AddRange(iCommandsequences.doAction11);
                            break;
                        case "menu12":
                            State.currentmessage.cmdsequence.AddRange(iCommandsequences.doAction12);
                            break;
                    }

                }


                // command sequence for Options
                public static void setoptionscmdsequence()
                {
                    State.currentmessage.showmenu = true;
                    State.currentmessage.cmdsequence.AddRange(iCommandsequences.homemenu);

                    switch (State.currentrecipientclass.Name)
                    {
                        case "Flight":
                            State.currentmessage.cmdsequence.AddRange(State.currentmodule.Flightmenu);
                            break;
                        case "JTAC":
                            State.currentmessage.cmdsequence.AddRange(iCommandsequences.showJTAC);
                            State.currentmessage.cmdsequence.AddRange(iCommandsequences.menuindex());
                            break;
                        case "ATC":
                            State.currentmessage.cmdsequence.AddRange(iCommandsequences.showATC);
                            State.currentmessage.cmdsequence.AddRange(iCommandsequences.menuindex());
                            break;
                        case "AWACS":
                            State.currentmessage.cmdsequence.AddRange(iCommandsequences.showAWACS);
                            State.currentmessage.cmdsequence.AddRange(iCommandsequences.menuindex());
                            break;
                        case "Tanker":
                            State.currentmessage.cmdsequence.AddRange(iCommandsequences.showTanker);
                            State.currentmessage.cmdsequence.AddRange(iCommandsequences.menuindex());
                            break;
                        case "Crew":
                            State.currentmessage.cmdsequence.AddRange(iCommandsequences.showCrew);
                            break;
                        case "Aux":
                            State.currentmessage.cmdsequence.AddRange(iCommandsequences.showAux);
                            break;
                        case "Moose":
                            State.currentmessage.cmdsequence.AddRange(iCommandsequences.showMoose); // Add Moose
                            break;
                        case "Cargo":
                            State.currentmessage.cmdsequence.AddRange(iCommandsequences.showCargo);
                            break;
                        case "Descent":
                            State.currentmessage.cmdsequence.AddRange(iCommandsequences.showDescent);
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}



