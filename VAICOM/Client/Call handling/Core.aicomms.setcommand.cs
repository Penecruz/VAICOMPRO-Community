using VAICOM.Static;
using VAICOM.Database;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Collections.Generic;

using Newtonsoft.Json;

using System.Media;

namespace VAICOM
{
    namespace Client
    {

        public partial class DcsClient
        {
            public static partial class Message
            {

                public static bool setcommand()
                {
                    bool result;

                    if (!State.have["command"])
                    {      
                        return false;
                    }
                    else
                    {
                        // set State.currentcommand:
                        if (!Commands.Table.ContainsKey(State.currentkey["command"])) // some internal error, default to void command
                        {
                            State.currentkey["command"] = "wMsgNull";
                        }

                        State.currentcommand = Commands.Table[State.currentkey["command"]]; // normal, have command
                        result = true;

                        // catch exceptional cases:
                        if (State.currentcommand.blockedforFree)
                        {
                            if (!State.PRO)
                            {
                                Log.Write("(this command is available only with PRO license)", Colors.Warning);
                                UI.Playsound.Sorry();
                                return false;
                            }
                            if (!State.activeconfig.AllowAddCommands)
                            {
                                Log.Write("Extended command set is currently disabled in preferences.", Colors.Warning);
                                return false;
                            }
                        }

                        // Options
                        if (State.currentcommand.isOptions() && !State.activeconfig.AllowOptions)
                        {
                            Log.Write("Options command is currently disabled in preferences.", Colors.Warning);
                            UI.Playsound.Recipientna();
                            return false;
                        }

                        // RIO LICENSE CHECK:
                        if (State.currentcommand.requiresJester & !State.jesteractivated)
                        {
                            Log.Write("Activate your RIO Dialog extension license to use RIO commands.", Colors.Warning);
                            UI.Playsound.Sorry();
                            return false;
                        }

                        // reject if AIRIO but not in F14.
                        if (State.currentcommand.isRIO() && !State.AIRIOactive)
                        {
                            Log.Write("AIRIO commands are not available.", Colors.Warning);
                            UI.Playsound.Recipientna();
                            return false;
                        }

                        // CARRIER COMMS CHECK:
                        if (State.currentcommand.requiresrealatc & !State.realatcactivated)
                        {
                            Log.Write("To use this command, activate your Realistic ATC extension license.", Colors.Warning);
                            UI.Playsound.Sorry();
                            return false;
                        }

                        // FC3
                        if (State.currentcommand.blockedforFCnonPro & State.currentmodule.IsFC)
                        {
                            if (!State.PRO)
                            {
                                Log.Write("(for " + State.currentmodule.Name + " module this command is available only with PRO license)", Colors.Warning);
                                UI.Playsound.Sorry();
                                return false;
                            }
                            if (!State.activeconfig.AllowAddCommands)
                            {
                                Log.Write("Extended command set is currently disabled in preferences.", Colors.Warning);
                                UI.Playsound.Sorry();
                                return false;
                            }
                        }

                        // FC3
                        if (State.currentcommand.blockedforFC & State.currentmodule.IsFC)
                        {
                            Log.Write("(this command is not available for " + State.currentmodule.Name + " module)", Colors.Warning);
                            UI.Playsound.Sorry();
                            return false;
                        }

                        // Multiplayer check
                        if (State.currentstate.multiplayer & !State.activeconfig.MP_UsePluginWithMultiplayer)
                        {
                            Log.Write("Use with multiplayer is currently disabled in preferences.", Colors.Warning);
                            return false;
                        }

                        // Cue
                        if (State.currentcommand.isEngage() & State.activeconfig.Engagecuerequired & !State.have["cue"])
                        {
                            return false;
                        }

                        // Select command using Flight
                        if (State.currentcommand.isSelect() & !State.have["recipient"])
                        {
                            if (State.have["sender"]) // addressing flight i.e. 'enfield' 
                            {
                                State.currentkey["recipient"] = "flight";
                                State.usedalias["recipient"] = State.usedalias["sender"];
                                State.have["recipient"] = true;
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                    }

                    return result;

                }
            }
        }
    }
}



