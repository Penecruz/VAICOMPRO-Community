using VAICOM.Static;
using System.Collections.Generic;
using System;
using System.Runtime.Versioning;

namespace VAICOM
{
    namespace Extensions
    {
        namespace RIO
        {

            [SupportedOSPlatform("windows")]
            public partial class helper
            {

                public static Dictionary<string, DeviceAction> TACANstate = new Dictionary<string, DeviceAction>()
                {
                    {"Stennis",     null }, // DeviceActionsLibrary.RIO.Atom_J_VOID  },
                    {"Washington",  null }, // DeviceActionsLibrary.RIO.Atom_J_VOID  },
                    {"Roosevelt",   null }, // DeviceActionsLibrary.RIO.Atom_J_VOID  },
                    {"Lincoln",     null }, // DeviceActionsLibrary.RIO.Atom_J_VOID  },
                    {"Truman",      null }, // DeviceActionsLibrary.RIO.Atom_J_VOID  },
                    {"Tarawa",      null }, // DeviceActionsLibrary.RIO.Atom_J_VOID  },
                    {"Arco",        null }, // DeviceActionsLibrary.RIO.Atom_J_VOID  },
                    {"Shell",       null }, // DeviceActionsLibrary.RIO.Atom_J_VOID  },
                    {"Texaco",      null }, // DeviceActionsLibrary.RIO.Atom_J_VOID  },

                };

                public static void resetTACANstate()
                {
                    TACANstate = new Dictionary<string, DeviceAction>();

                    TACANstate["Stennis"]   = DeviceActionsLibrary.RIO.Atom_J_VOID;
                    TACANstate["Washington"]= DeviceActionsLibrary.RIO.Atom_J_VOID;
                    TACANstate["Roosevelt"] = DeviceActionsLibrary.RIO.Atom_J_VOID;
                    TACANstate["Lincoln"]   = DeviceActionsLibrary.RIO.Atom_J_VOID;
                    TACANstate["Truman"]    = DeviceActionsLibrary.RIO.Atom_J_VOID;
                    TACANstate["Tarawa"]    = DeviceActionsLibrary.RIO.Atom_J_VOID;
                    TACANstate["Arco"]      = DeviceActionsLibrary.RIO.Atom_J_VOID;
                    TACANstate["Shell"]     = DeviceActionsLibrary.RIO.Atom_J_VOID;
                    TACANstate["Texaco"]    = DeviceActionsLibrary.RIO.Atom_J_VOID;
                }

                public static string extractTACANunit(string unitcallsign, string fullname)
                {
                    string result = "";

                    if (unitcallsign.Contains("Stennis")    || fullname.Contains("Stennis"))    { return "Stennis"; }
                    if (unitcallsign.Contains("Washington") || fullname.Contains("Washington")) { return "Washington"; }
                    if (unitcallsign.Contains("Roosevelt")  || fullname.Contains("Roosevelt"))  { return "Roosevelt"; }
                    if (unitcallsign.Contains("Lincoln")    || fullname.Contains("Lincoln"))    { return "Lincoln"; }
                    if (unitcallsign.Contains("Truman")     || fullname.Contains("Truman"))     { return "Truman"; }
                    if (unitcallsign.Contains("Tarawa")     || fullname.Contains("Tarawa"))     { return "Tarawa";  }
                    if (unitcallsign.Contains("Arco")       || fullname.Contains("Arco"))       { return "Arco";    }
                    if (unitcallsign.Contains("Shell")      || fullname.Contains("Shell"))      { return "Shell";   }
                    if (unitcallsign.Contains("Texaco")     || fullname.Contains("Texaco"))     { return "Texaco";  }

                    return result;
                }

                public static void getTACANstate()
                {
                    try
                    {

                        resetTACANstate();
                        int counter = 0;
                
                        foreach (Servers.Server.DcsUnit unit in State.currentstate.TACANunits)
                        {
                            string callsign = extractTACANunit(unit.callsign, unit.fullname);
                            counter += 1;
                            try
                            {
                                TACANstate[callsign] = GetAtom(counter);
                            }
                            catch 
                            {
                            }

                        }

                    }
                    catch
                    {
                        Log.Write("could not update TACAN state.", Colors.Inline);
                    }

                }
            }
        }
    }
}
