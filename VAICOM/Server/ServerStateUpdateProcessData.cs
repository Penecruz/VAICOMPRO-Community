using VAICOM.Static;
using VAICOM.Extensions.RIO;
using VAICOM.PushToTalk;
using VAICOM.Extensions.AOCS;
using System.Collections.Generic;
using System;
using System.Windows.Forms;
using System.Linq;



namespace VAICOM
{
    namespace Servers
    {

        public static partial class Server
        {

            public static bool InvalidUnitForTuning(Server.DcsUnit unit)
            {
                bool invalid = false;

                bool ticonderoga = unit.fullname.ToLower().Contains("ticonderoga") || unit.callsign.ToLower().Contains("ticonderoga");
                bool tarawa = unit.fullname.ToLower().Contains("tarawa") || unit.callsign.ToLower().Contains("tarawa");
                bool burke = unit.fullname.ToLower().Contains("burke") || unit.callsign.ToLower().Contains("burke");
                bool perry = unit.fullname.ToLower().Contains("perry") || unit.callsign.ToLower().Contains("perry");

                bool fixedwing = State.currentstate.playerunitcat.ToLower().Equals("planes") & !State.currentstate.id.Equals("AV8BNA");

                invalid = fixedwing && (ticonderoga || tarawa || burke || perry);

                return invalid;
            }


            public static void FixBadNamingAndRemove()
            {
                try
                {
                    foreach (DcsUnit unit in State.currentstate.availablerecipients["ATC"])
                    {
                        if (unit.callsign.Equals("unknown"))
                        {
                            unit.callsign = unit.fullname;
                        }
                    }
                }
                catch
                {
                }

                //remove
                try
                {
                    List<DcsUnit> ATCs = new List<DcsUnit>();
                    ATCs = State.currentstate.availablerecipients["ATC"];

                    foreach (DcsUnit unit in ATCs.ToArray())
                    {
                        if (InvalidUnitForTuning(unit))
                        {
                            unit.allowtuning = false;
                            State.currentstate.availablerecipients["ATC"].Remove(unit);
                        }
                    }
                }
                catch (Exception e)
                {
                    Log.Write("Could not remove unit " + e.Message, Colors.Inline);
                }

            }

        public static void CreateListTACAN()
            {
                try
                {
                    List<DcsUnit> TACANunits = new List<DcsUnit>();

                    foreach (DcsUnit unit in State.currentstate.availablerecipients["Tanker"])
                    {
                        if (unit.callsign.Contains("Arco") || unit.fullname.Contains("Arco"))
                        {
                            TACANunits.Add(unit);
                        }
                        if (unit.callsign.Contains("Shell") || unit.fullname.Contains("Shell"))
                        {
                            TACANunits.Add(unit);
                        }
                        if (unit.callsign.Contains("Texaco") || unit.fullname.Contains("Texaco"))
                        {
                            TACANunits.Add(unit);
                        }
                    }
                    foreach (DcsUnit unit in State.currentstate.availablerecipients["ATC"])
                    {

                        if (CheckSuperCarrier(unit.callsign + unit.fullname) && !(unit.callsign + unit.fullname).ToLower().Contains("kuznetsov") && !(unit.callsign + unit.fullname).ToLower().Contains("vinson"))
                        {
                            TACANunits.Add(unit);
                        }

                        if (unit.callsign.Contains("Tarawa") || unit.fullname.Contains("Tarawa"))
                        {
                            TACANunits.Add(unit);
                        }

                    }
                    State.currentstate.TACANunits = TACANunits.OrderBy(o => o.range).ToList();
                    helper.getTACANstate();
                }
                catch
                {
                    Log.Write("Could not update TACAN state", Colors.Inline);
                }
            }

            public static void CreateListDL()
            {
                try
                {
                    List<DcsUnit> DLunits = new List<DcsUnit>();

                    foreach (DcsUnit unit in State.currentstate.availablerecipients["AWACS"])
                    {
                        if (unit.callsign.Contains("Darkstar") || unit.fullname.Contains("Darkstar"))
                        {
                            DLunits.Add(unit);
                        }
                        if (unit.callsign.Contains("Focus") || unit.fullname.Contains("Focus"))
                        {
                            DLunits.Add(unit);
                        }
                        if (unit.callsign.Contains("Magic") || unit.fullname.Contains("Magic"))
                        {
                            DLunits.Add(unit);
                        }
                        if (unit.callsign.Contains("Overlord") || unit.fullname.Contains("Overlord"))
                        {
                            DLunits.Add(unit);
                        }
                        if (unit.callsign.Contains("Wizard") || unit.fullname.Contains("Wizard"))
                        {
                            DLunits.Add(unit);
                        }
                    }
                    foreach (DcsUnit unit in State.currentstate.availablerecipients["ATC"])
                    {
                        if ( unit.fullname.ToLower().Contains("ticonderoga") || unit.callsign.ToLower().Contains("ticonderoga") ||( CheckSuperCarrier(unit.callsign+unit.fullname) && !(unit.callsign + unit.fullname).ToLower().Contains("kuznetsov") && !(unit.callsign + unit.fullname).ToLower().Contains("vinson")))
                        {
                            DLunits.Add(unit);
                        }

                    }
                    State.currentstate.DLunits = DLunits.OrderBy(o => o.range).ToList();
                    helper.getDLstate();
                }
                catch
                {
                    Log.Write("Could not update DL state", Colors.Inline);
                }
            }

            public static void GetAuxMenu()
            {
                if (State.currentstate.menuaux != null)
                {
                    if (!State.activeconfig.ImportOtherMenu || State.menuauximported)
                    {
                    }
                    else
                    {
                        try
                        {
                            ImportAuxMenu();
                        }
                        catch
                        {
                            Log.Write("There was a problem importing F10 menu items.", Colors.Text);
                            State.menuauximported = false;
                        }
                    }
                }
            }

            public static void GUI_Update()
            {
                try
                {
                    if (State.configwindowopen && (State.configurationwindow != null))
                    {
                        State.configurationwindow.Dispatcher.BeginInvoke((MethodInvoker)delegate
                        {
                            State.configurationwindow.UpdateAllbugs();
                        });
                    }
                }
                catch
                {
                }
            }

            public static bool tunedforAOCS;

            public static void ProcessServerData()
            {

                // first set deep debug mode if special user:
                State.deepdebugmode = State.clientmode.Equals(ClientModes.Debug) || State.currentstate.playerusername.Equals(State.debuguser);

                // received something;
                State.dcsrunning = true;

                // set new beacon state
                State.oneradioactive = AtLeastOneRadioCount();
                State.beaconlocked = State.oneradioactive;

                // always check module first
                ValidateDcsModule(true); // true = silent
                PTT.PTT_ApplyNewConfig();
                State.AIRIOactive = State.jesteractivated && State.dll_installed_rio && State.activeconfig.RIO_Enabled && State.currentmodule.Equals(Products.DCSmodules.LookupTable[State.riomod]);

                // new mission?
                if (DetectNewMission())
                {
                    InitNewMission();
                }

                // insert AOCS
                AOCSProvider.AddAOCSUnit();

                // for AIRIO: update state
                if (State.AIRIOactive)
                {
                    try
                    {
                        Client.DcsClient.UpdateRIOState();
                        CreateListTACAN();  
                        CreateListDL();
                    }
                    catch
                    {
                    }
                }

                FixBadNamingAndRemove();

                Client.DcsClient.Assign_Tuned_Units_to_Radios();

                State.Stopwatch.Restart();

                if (State.transmitting)
                {
                    List<Server.DcsUnit> tunedunits = Client.DcsClient.GetTunedUnitsForTX(State.currentTXnode, false);
                    Client.DcsClient.ShowTunedUnitsForTX(State.currentTXnode);
                    tunedforAOCS = State.currentstate.easycomms || State.currentmodule.IsFC || tunedunits.Contains(State.currentstate.availablerecipients["Aux"].Find(Client.DcsClient.Message.IsAOCS));
                    PTT.PTT_GUI_Update(State.currentTXnode, true);
                    PTT.PTT_Manage_Listen_States_OnUpdate(State.currentTXnode);
                }
                else
                {                 
                    PTT.PTT_Manage_Listen_States_OnPressRelease(false,false);
                }

                GetAuxMenu();

                VAICOM.Interfaces.VA_Plugin.VA_ExposeVariables(State.Proxy);

                State.Stopwatch.Stop();

                Log.Write("Server update processed.", Colors.Inline);


            }

        }
    }
}

