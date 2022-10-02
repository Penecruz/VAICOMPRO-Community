using VAICOM.Static;
using System.Collections.Generic;
using System;

namespace VAICOM
{
    namespace Extensions
    {
        namespace RIO
        {

            public partial class helper
            {

                public static Dictionary<string, DeviceAction> DLstate = new Dictionary<string, DeviceAction>()
                {
                    {"Stennis",    null }, //DeviceActionsLibrary.RIO.Atom_J_VOID  },
                    {"Washington", null }, //DeviceActionsLibrary.RIO.Atom_J_VOID  },
                    {"Roosevelt",  null }, //DeviceActionsLibrary.RIO.Atom_J_VOID  },
                    {"Lincoln",    null }, //DeviceActionsLibrary.RIO.Atom_J_VOID  },
                    {"Truman",     null }, //DeviceActionsLibrary.RIO.Atom_J_VOID  },
                    {"Ticonderoga",null }, //DeviceActionsLibrary.RIO.Atom_J_VOID  },
                    {"Darkstar",   null }, //DeviceActionsLibrary.RIO.Atom_J_VOID  },
                    {"Focus",      null }, //DeviceActionsLibrary.RIO.Atom_J_VOID  },
                    {"Magic",      null }, //DeviceActionsLibrary.RIO.Atom_J_VOID  },
                    {"Overlord",   null }, //DeviceActionsLibrary.RIO.Atom_J_VOID  },
                    {"Wizard",     null }, // DeviceActionsLibrary.RIO.Atom_J_VOID  },

                };

                public static void resetDLstate()
                {
                    DLstate = new Dictionary<string, DeviceAction>();

                    DLstate["Stennis"]      = DeviceActionsLibrary.RIO.Atom_J_VOID;
                    DLstate["Washington"]   = DeviceActionsLibrary.RIO.Atom_J_VOID;
                    DLstate["Roosevelt"]    = DeviceActionsLibrary.RIO.Atom_J_VOID;
                    DLstate["Lincoln"]      = DeviceActionsLibrary.RIO.Atom_J_VOID;
                    DLstate["Truman"]       = DeviceActionsLibrary.RIO.Atom_J_VOID;
                    DLstate["Ticonderoga"]  = DeviceActionsLibrary.RIO.Atom_J_VOID;
                    DLstate["Darkstar"]     = DeviceActionsLibrary.RIO.Atom_J_VOID;
                    DLstate["Focus"]        = DeviceActionsLibrary.RIO.Atom_J_VOID;
                    DLstate["Magic"]        = DeviceActionsLibrary.RIO.Atom_J_VOID;
                    DLstate["Overlord"]     = DeviceActionsLibrary.RIO.Atom_J_VOID;
                    DLstate["Wizard"]       = DeviceActionsLibrary.RIO.Atom_J_VOID;
                }

                public static string extractDLunit(string unitcallsign, string fullname)
                {
                    string result = "";

                    if (unitcallsign.Contains("Stennis")    || fullname.Contains("Stennis"))    { return "Stennis";     }
                    if (unitcallsign.Contains("Washington") || fullname.Contains("Washington")) { return "Washington"; }
                    if (unitcallsign.Contains("Roosevelt")  || fullname.Contains("Roosevelt"))  { return "Roosevelt"; }
                    if (unitcallsign.Contains("Lincoln")    || fullname.Contains("Lincoln"))    { return "Lincoln"; }
                    if (unitcallsign.Contains("Truman")     || fullname.Contains("Truman"))     { return "Truman";  }
                    if (unitcallsign.Contains("Ticonderoga")|| fullname.Contains("Ticonderoga")){ return "Ticonderoga"; }
                    if (unitcallsign.Contains("Darkstar")   || fullname.Contains("Darkstar"))   { return "Darkstar";    }
                    if (unitcallsign.Contains("Focus")      || fullname.Contains("Focus"))      { return "Focus";       }
                    if (unitcallsign.Contains("Magic")      || fullname.Contains("Magic"))      { return "Magic";       }
                    if (unitcallsign.Contains("Overlord")   || fullname.Contains("Overlord"))   { return "Overlord";    }
                    if (unitcallsign.Contains("Wizard")     || fullname.Contains("Wizard"))     { return "Wizard";      }

                    return result;
                }

                public static void getDLstate()
                {
                    try
                    {
                        resetDLstate();
                        int counter = 0;

                        foreach (Servers.Server.DcsUnit unit in State.currentstate.DLunits)
                        {
                            string callsign = extractDLunit(unit.callsign, unit.fullname);                       
                            try
                            {
                                counter += 1;
                                DLstate[callsign] = GetAtom(counter);
                            }
                            catch (Exception e)
                            {
                            }

                        }
                    }
                    catch
                    {
                        Log.Write("could not update DL state.", Colors.Inline);
                    }
                }
            }
        }
    }
}
