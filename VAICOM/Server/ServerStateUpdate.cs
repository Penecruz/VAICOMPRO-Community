using VAICOM.Static;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;

namespace VAICOM
{
    namespace Servers
    {

        public static partial class Server
        {

            public static void UpdateServerState() // gets all chuncks
            {
                ExtractAll(State.receivedchunk.cid);

                if (receivedupdatecomplete)
                {
                    if (!processingchunks)
                    {
                        ProcessServerData();
                    }
                }

            }

            public static void DumpStateToLog()
            {
                Log.Reset();
                string state = JsonConvert.SerializeObject(State.currentstate, Formatting.Indented).ToString();
                Log.Write("STATE: " + state, Colors.Critical);
            }

            public static int chunkcount = 12;

            public static void ExtractAll(int id)
            {
                switch (id)
                {
                    case 1:
                        ExtractChunk1();
                        break;
                    case 2:
                        ExtractChunk2();
                        break;
                    case 3:
                        ExtractChunk3();
                        break;
                    case 4:
                        ExtractChunk4();
                        break;
                    case 5:
                        ExtractChunk5();
                        break;
                    case 6:
                        ExtractChunk6();
                        break;
                    case 7:
                        ExtractChunk7();
                        break;
                    case 8:
                        ExtractChunk8();
                        break;
                    case 9:
                        ExtractChunk9();
                        break;
                    case 10:
                        ExtractChunk10();
                        break;
                    case 11:
                        ExtractChunk11();
                        break;
                    case 12:
                        ExtractChunk12();
                        break;
                }
            }

            public static void ExtractChunk1()
            {

                processingchunks = true;

                State.previousstate = State.currentstate;
                State.currentstate = new ServerState();

                try
                {
                    State.currentstate.client           = State.receivedchunk.client;
                    State.currentstate.clientversion    = State.receivedchunk.clientversion;
                    State.currentstate.mode             = State.receivedchunk.mode;
                    State.currentstate.type             = State.receivedchunk.type;
                    State.currentstate.dcsversion       = State.receivedchunk.dcsversion.Length > 5 ? State.receivedchunk.dcsversion.Substring(0, 5) : State.receivedchunk.dcsversion;
                    State.currentstate.root             = State.receivedchunk.root;
                    State.currentstate.multiplayer      = State.receivedchunk.multiplayer;
                    State.currentstate.vrmode           = State.receivedchunk.vrmode;
                    State.currentstate.easycomms        = State.receivedchunk.easycomms;
                    State.currentstate.pausebasestate   = State.receivedchunk.pausebasestate;
                    State.currentstate.theatre          = State.receivedchunk.theatre;
                    State.currentstate.sortie           = State.receivedchunk.sortie;
                    State.currentstate.task             = State.receivedchunk.task;
                    State.currentstate.country          = State.receivedchunk.country;
                    State.currentstate.options          = State.receivedchunk.options;
                }
                catch (Exception e)
                {
                    Log.Write("ERROR 1/" + chunkcount + " :" + e.StackTrace, Colors.Inline);

                }
                receivedupdatecomplete = false;
            }
            public static void ExtractChunk2()
            {
                processingchunks = true;
                try
                {
                    State.currentstate.timer                = State.receivedchunk.timer;
                    State.currentstate.tod                  = State.receivedchunk.tod;
                    State.currentstate.id                   = State.receivedchunk.id;
                    State.currentstate.playerusername       = State.receivedchunk.playerusername;
                    State.currentstate.playercallsign       = State.receivedchunk.playercallsign;
                    State.currentstate.playercoalition      = State.receivedchunk.playercoalition;
                    State.currentstate.playerunitid         = State.receivedchunk.playerunitid;
                    State.currentstate.playerunitcat        = State.receivedchunk.playerunitcat;
                    State.currentstate.airborne             = State.receivedchunk.airborne;
                    State.currentstate.intercom             = State.receivedchunk.intercom;
                    State.currentstate.fsmstate             = State.receivedchunk.fsmstate;
                    State.currentstate.radios               = State.receivedchunk.radios;
                }
                catch (Exception e)
                {
                    Log.Write("ERROR 2/" + chunkcount + " :" + e.StackTrace, Colors.Inline);
                }
                receivedupdatecomplete = false;
            }
            public static void ExtractChunk3()
            {

                processingchunks = true;
                try
                {
                    State.currentstate.missiontitle     = State.receivedchunk.missiontitle;
                    State.currentstate.missionbriefing  = State.receivedchunk.missionbriefing;
                    State.currentstate.missiondetails   = State.receivedchunk.missiondetails;
                }
                catch (Exception e)
                {
                    Log.Write("ERROR 3/" + chunkcount + " :" + e.StackTrace, Colors.Inline);
                }
                receivedupdatecomplete = false;
            }

            public static bool CheckSuperCarrier(string checkstr)
            {
                return checkstr.ToLower().Contains("kuznetsov") || checkstr.ToLower().Contains("stennis") || checkstr.ToLower().Contains("roosevelt") || checkstr.ToLower().Contains("lincoln") || checkstr.ToLower().Contains("washington") || checkstr.ToLower().Contains("truman");
            }

            public static void ExtractChunk4()
            {

                processingchunks = true;
                try
                {
                    List<string> cats = new List<string>() { "Player", "Flight", "JTAC", "AWACS", "Tanker", "Crew", "Aux", "Cargo" };
                    foreach (string catstr in cats)
                    {
                        try
                        {
                            foreach (DcsUnit a in State.receivedchunk.availablerecipients[catstr])
                            {
                                a.reccat = catstr;
                                a.descr = catdescriptions[catstr];
                                State.currentstate.availablerecipients[catstr].Add(a);
                            }
                        }
                        catch
                        {
                        }
                    }
                }
                catch (Exception e)
                {
                    Log.Write("ERROR 4/" + chunkcount + " :" + e.StackTrace, Colors.Inline);
                }
                receivedupdatecomplete = false;
            }
            public static void ExtractChunk5()
            {
                processingchunks = true;
                try
                {
                    string cat = "ATC";
                    foreach (DcsUnit a in State.receivedchunk.availablerecipients[cat])
                    {
                        a.reccat = cat;
                        a.descr = catdescriptions[cat];
                        if (CheckSuperCarrier(a.callsign + a.fullname))
                        {
                            a.descr = catdescriptions["Carrier"];
                        }
                        State.currentstate.availablerecipients[cat].Add(a);
                    }
                }
                catch (Exception e)
                {
                    Log.Write("ERROR 5/" + chunkcount + " :" + e.StackTrace, Colors.Inline);
                }
                receivedupdatecomplete = false;
            }
            public static void ExtractChunk6()
            {

                processingchunks = true;
                try
                {
                    string cat = "ATC";
                    foreach (DcsUnit a in State.receivedchunk.availablerecipients[cat])
                    {
                        a.reccat = cat;
                        a.descr = catdescriptions[cat];
                        if (CheckSuperCarrier(a.callsign + a.fullname))
                        {
                            a.descr = catdescriptions["Carrier"];
                        }
                        State.currentstate.availablerecipients[cat].Add(a);
                    }
                }
                catch (Exception e)
                {
                    Log.Write("ERROR 6/" + chunkcount + " :" + e.StackTrace, Colors.Inline);
                }
                receivedupdatecomplete = false;
            }

            public static void ExtractChunk7()
            {
                processingchunks = true;
                try
                {
                    string cat = "Allies";
                    foreach (DcsUnit a in State.receivedchunk.availablerecipients[cat])
                    {
                        if (!a.id_.Equals(State.currentstate.availablerecipients["Player"][0].id_))
                        {
                            a.reccat = cat;
                            a.descr = catdescriptions[cat];
                            State.currentstate.availablerecipients[cat].Add(a);
                        }
                    }
                }
                catch (Exception e)
                {
                    Log.Write("ERROR 7/" + chunkcount + " :" + e.Data, Colors.Inline);
                }
                receivedupdatecomplete = false;
            }
            public static void ExtractChunk8()
            {
                processingchunks = true;
                try
                {
                    string cat = "Allies";
                    foreach (DcsUnit a in State.receivedchunk.availablerecipients[cat])
                    {
                        if (!a.id_.Equals(State.currentstate.availablerecipients["Player"][0].id_))
                        {
                            a.reccat = cat;
                            a.descr = catdescriptions[cat];
                            State.currentstate.availablerecipients[cat].Add(a);
                        }
                    }
                }
                catch (Exception e)
                {
                    Log.Write("ERROR 8/" + chunkcount + " :" + e.StackTrace, Colors.Inline);
                }
                receivedupdatecomplete = false;
            }
            public static void ExtractChunk9()
            {
                processingchunks = true;
                try
                {
                    if (State.receivedchunk.menuaux != null)
                    {
                        State.currentstate.menuaux = State.receivedchunk.menuaux;
                        State.currentstate.menucargo = State.receivedchunk.menucargo;
                    }
                }
                catch (Exception e)
                {
                    Log.Write("ERROR 9/" + chunkcount + " :" + e.StackTrace, Colors.Inline);                 
                }
                receivedupdatecomplete = false;
            }
            public static void ExtractChunk10()
            {
                processingchunks = true;
                try
                {
                    State.currentstate.riostate             = State.receivedchunk.riostate;
                    State.currentstate.bpos                 = State.receivedchunk.bpos;
                    State.currentstate.cpos                 = State.receivedchunk.cpos;
                    State.currentstate.viewexternal         = !State.currentstate.cpos.type.Equals(0);
                    State.currentstate.soundsallowexternal  = State.currentstate.options.sound.headphones_on_external_views;

                }
                catch (Exception e)
                {
                    Log.Write("ERROR 10/" + chunkcount + " :" + e.StackTrace + " " +e.Message, Colors.Inline);
                }
                receivedupdatecomplete = false;
            }
            public static void ExtractChunk11()
            {
                processingchunks = true;
                try
                {
                    State.currentstate.payload = State.receivedchunk.payload;
                }
                catch (Exception e)
                {
                    Log.Write("ERROR 11/" + chunkcount + " :" + e.StackTrace, Colors.Inline);        
                }
                receivedupdatecomplete = true;
                processingchunks = false;

            }

            public static void ExtractChunk12()
            {
                try
                {

                }
                catch (Exception e)
                {
                    Log.Write("ERROR 12/" + chunkcount + " :" + e.StackTrace, Colors.Inline);
                }
            }



        }
    }
}

