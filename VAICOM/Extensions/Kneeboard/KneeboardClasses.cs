using VAICOM.Static;
using System.Collections.Generic;
using System;
using VAICOM.Servers;
using System.Text.RegularExpressions;
using System.Linq;

namespace VAICOM
{
    namespace Extensions
    {
        namespace Kneeboard
        {

            // core class for kneeboard messages

            public class KneeboardMessage
            {
                public int      eventid;
                public bool?    dictmode;
                public double   opacity;
                public bool?    autoswitch;
                public bool?    switchpage;

                // payload:

                public KneeboardServerData  serverdata;
                public KneeboardUnitsData   unitsdata;
                public KneeboardUnitsDetails unitsdetails;
                public LogData              logdata;
                public AliasData            aliasdata;

                public KneeboardMessage()
                {
                    eventid = 4000; // default
                    opacity = State.activeconfig.KneeboardOpacity;
                    dictmode = State.Proxy.Dictation.IsOn();
                    autoswitch = State.activeconfig.KneeboardlinkPTT;
                    switchpage = false; // only when explicitly set true 
                }
            }

            public class AliasData
            {
                public string category;
                public SortedDictionary<string, List<string>> content;
                public int chunk;

                public AliasData(string cat, SortedDictionary<string,List<string>> cont)
                {
                    category = cat;
                    content = cont;
                    chunk = 0;
                }
            }

            public class LogData
            {
                public string category;
                public string content;
                public int    timer;

                public LogData(string cat, string cont)
                {
                    category = cat;
                    content = cont;
                }
            }

            public class KneeboardServerData
            {
                public string theater;
                public string dcsversion;
                public string aircraft;
                public int    flightsize;
                public string playerusername;
                public string playercallsign;
                public string coalition;
                public string sortie;
                public string task;
                public string country;
                public string missiontitle;
                public string missionbriefing;
                public string missiondetails;
                public bool   multiplayer;

                public KneeboardServerData()
                {
                    theater = State.currentstate.theatre;
                    dcsversion = State.currentstate.dcsversion;
                    aircraft = State.currentstate.id;
                    flightsize = State.currentstate.availablerecipients["Flight"].Count;
                    playerusername = State.currentstate.playerusername;
                    playercallsign = State.currentstate.playercallsign;
                    coalition = State.currentstate.playercoalition.ToUpper();
                    Int32.TryParse(State.currentstate.sortie, out int daytimeinsecs);
                    int hr = (daytimeinsecs / 3600);
                    int min = (daytimeinsecs - hr * 3600) / 60;
                    sortie = "TO "+ KneeboardHelper.theatercode(State.currentstate.theatre) + " MST " + hr.ToString().PadLeft(2, '0') + ":" + min.ToString().PadRight(2,'0') + " "+ KneeboardHelper.theatertimezonestring(State.currentstate.theatre);
                    task = State.currentstate.task;
                    country = State.currentstate.country;
                    missiontitle = State.currentstate.missiontitle;
                    missionbriefing = State.currentstate.missionbriefing;
                    missiondetails = State.currentstate.missiondetails;
                    multiplayer = State.currentstate.multiplayer;
                }

            }

            public class KneeboardUnitSummary
            {
                public string cat;
                public string code;
                public string callsign;
                public string alias;
                public string range;
                public string bearing;
                public string alt;
                public string frq;
                public string istuned;
                public string humanname;
                public List<string> altfreq;

            }

            public class KneeboardUnitsDetails
            {
                public string category;
                public List<string> unitsummary;
                public int timer;

                public KneeboardUnitsDetails(string recipientcat, List<string> contents, bool AOCS)
                {
                    string cat;

                    if (recipientcat.Equals("AOCS"))
                    {
                        cat = "Aux";
                    }
                    else
                    {
                        cat = recipientcat;
                    }

                    category = cat.ToUpper();
                    unitsummary = contents;
                }
            }

            public class KneeboardUnitsData
            {
                public string category;
                public List<string> unitslist;
                public int timer;

                public KneeboardUnitsData(string recipientcat, bool AOCS)
                {


                    category = recipientcat.ToUpper();

                    string cat;

                    if (recipientcat.Equals("AOCS"))
                    {
                        cat = "Aux";
                    }
                    else
                    {
                        cat = recipientcat;
                    }

                    //string header = String.Format("{0,-3} {1,-12} {2,-5} {3,-4} {4,-5}  {5,-10} {6,-10}\n\n", "   ", "UNIT", "BRAA", "RNG", "ALT", "MOD FRQ", "(FRQ)");
                    //sb.Append(header);

                    unitslist = new List<string>();

                    List<KneeboardUnitSummary> units = new List<KneeboardUnitSummary>();

                    foreach (Server.DcsUnit unit in State.currentstate.availablerecipients[cat])
                    {
                        try
                        {
                            string altfreqs = "";

                            KneeboardUnitSummary descr = new KneeboardUnitSummary();

                            descr.cat = cat;
                            descr.code = "XXX";
                            descr.callsign = unit.callsign; //+ " (" +unit.fullname + ")";

                            string searchcallsign = Regex.Replace(unit.callsign.Replace("-", ""), "[0-9]", "");

                            var FoundKey = Database.Aliases.airecipients.FirstOrDefault(x => (x.Value.Equals(searchcallsign) || x.Value.Equals(searchcallsign.ToLower()) || x.Value.Equals(unit.fullname) || x.Value.Equals(unit.fullname.ToLower()))).Key;
                            if (!FoundKey.Equals(null))
                            {
                                // Alias (retrieved from alias table)
                                descr.alias = FoundKey;
                            }
                            else
                            {
                                // Alias (pragmatic)
                                string substract = Regex.Replace(unit.callsign.Replace("-", ""), "[0-9]", "");
                                if (substract.Equals(""))
                                {
                                    descr.alias = unit.callsign; // for pure numeric callsins
                                }
                                else
                                {
                                    descr.alias = substract; // for now, not the actual recovered alias
                                }
                            }

                            descr.istuned = unit.isunittuned();
                            
                            if (!State.currentmodule.Theme.Equals("WWII") && unit.altfreq.Count >= 1) // there are 1 alts minimum
                            {
                                descr.frq = unit.getmodstr() + " " + Helpers.Common.NormalizeFreqString(unit.altfreq[0]);
                            }
                            else
                            {
                                descr.frq = unit.getmodstr() + " " + unit.getfreqstr();
                            }

                            if (AOCS) // supply details
                            {
                                descr.bearing = unit.getbearingstr(); //.PadRight(3)
                                descr.range = unit.getrangestr();
                                descr.alt = unit.getaltstr();


                                descr.humanname = unit.gethumanname();

                                descr.altfreq = unit.altfreq;
                                foreach (string alt in descr.altfreq)
                                {
                                    altfreqs += Helpers.Common.NormalizeFreqString(alt) + " ";
                                }
                            }

                            units.Add(descr);

                            string lineitem = descr.frq + " " + "[" + descr.alias  + "]" + descr.istuned + " "  + descr.callsign + " " + descr.bearing + " " + descr.range + " " + descr.alt + " "+ " " + altfreqs;

                            unitslist.Add(lineitem);

                        }
                        catch (Exception x)
                        {
                            Log.Write(x.Message, Colors.Inline);
                        }

                    }
                }

            }

        }
    }
}
