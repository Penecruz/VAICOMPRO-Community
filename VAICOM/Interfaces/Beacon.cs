using VAICOM.Static;
using VAICOM.Client;
using System;
using System.Timers;
using System.Runtime.Versioning;

namespace VAICOM
{
    namespace Interfaces
    {

        [SupportedOSPlatform("windows")]
        public static partial class Beacon
        {

            public static System.Timers.Timer   BeaconTimer         { get; set; }
            public static bool                  Created             { get; set; }
            public static bool                  CurrentPlayStatus   { get; set; }

            public static void Beacon_Initialize()
            {
                try
                {
                    State.beaconlocked = false;
                    State.beaconinterval = 6000;
                    Log.Write("Beacon initialized. ", Colors.Inline);
                    State.beaconinitalized = true;
                }
                catch (Exception e)
                {
                    Log.Write("Beacon init: " + e.Message, Colors.Inline);
                    State.beaconinitalized = false;
                }
            }

            public static void Beacon_PlayToggle()
            {
                try
                {
                    if (!State.beaconinitalized)
                    {
                        Beacon_Initialize();
                    }
                    if (State.beaconactive == false)
                    {
                        Log.Write("Beacon start.", Colors.Inline);
                        Beacon_TimerStart();
                    }
                    else
                    {
                        Log.Write("Beacon stop.", Colors.Inline);
                        Beacon_TimerStop();
                    }

                }
                catch (Exception e)
                {
                    Log.Write("Problems were reported with Beacon toggle. " + e.Message, Colors.Inline);
                }
            }

            public static void Beacon_TimerStart()
            {
                try
                {
                    if (!Created)
                    {
                        BeaconTimer = new System.Timers.Timer(State.beaconinterval);
                    }

                    BeaconTimer.Start();
                    BeaconTimer.Elapsed += Beacon_Timer_Elapsed_Handler;
                    CurrentPlayStatus = true;
                    State.beaconactive = true;
                }
                catch (Exception e)
                {
                    Log.Write("Problems were reported with Beacon timer start. " + e.Message, Colors.Inline);
                }
            }

            public static void Beacon_TimerStop()
            {
                try
                {
                    BeaconTimer.Elapsed -= Beacon_Timer_Elapsed_Handler;
                    BeaconTimer.Stop();
                    CurrentPlayStatus = false;
                    State.beaconactive = false;
                }
                catch (Exception e)
                {
                    Log.Write("Problems were reported with Beacon timer stop. " + e.Message, Colors.Inline);
                }
            }

            private static void Beacon_Timer_Elapsed_Handler(object sender, ElapsedEventArgs e)
            {
                try
                {
                    if (!State.beaconlocked && !State.valistening)
                    {
                        DcsClient.SendUpdateRequest();
                    }
                }
                catch (Exception a)
                {
                    Log.Write("Problems were reported with the Beacon timer handler. " + a.Message, Colors.Inline);
                }
            }
        }
    }
}


