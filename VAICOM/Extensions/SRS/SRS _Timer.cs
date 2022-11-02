using VAICOM.Static;
using System;
using System.Timers;
using System.Runtime.Versioning;

namespace VAICOM
{
    namespace Extensions
    {

        [SupportedOSPlatform("windows")]
        public static partial class SRSclient
        {

            public static System.Timers.Timer   SRS_Timer           { get; set; }
            public static bool                  Created             { get; set; }
            public static bool                  SRSTimerActive   { get; set; }

            public static void SRS_Timer_Initialize()
            {
                try
                {
                    SRS_Timer = new System.Timers.Timer(2000);
                    Log.Write("SRS Timer initialized. ", Colors.Inline);
                    Created = true;
                }
                catch (Exception e)
                {
                    Created = false;
                    Log.Write("SRS Timer init: " + e.Message, Colors.Inline);
                }
            }

            public static void SRS_Timer_PlayToggle()
            {
                try
                {
                    if (!SRSTimerActive)
                    {
                        Log.Write("SRS Timer start.", Colors.Inline);
                        SRS_Timer_Start();

                    }
                    else
                    {
                        Log.Write("SRS Timer stop.", Colors.Inline);
                        SRS_Timer_Stop();
                    }
                }
                catch (Exception e)
                {
                    Log.Write("Problems were reported with SRS toggle. " + e.Message, Colors.Inline);
                }
            }

            // start beacon playback timer

            public static void SRS_Timer_Start()
            {
                try
                {
                    if (!Created)
                    {
                        SRS_Timer = new System.Timers.Timer(2000);
                    }

                    SRS_Timer.Start();
                    SRS_Timer.Elapsed += SRS_Timer_Elapsed_Handler;
                    SRSTimerActive = true;
                }
                catch (Exception e)
                {
                    Log.Write("Problems were reported with SRS timer start. " + e.Message, Colors.Inline);
                }
            }

            // stop chatter playback timer

            public static void SRS_Timer_Stop()
            {
                try
                {
                    SRS_Timer.Elapsed -= SRS_Timer_Elapsed_Handler;
                    SRS_Timer.Stop();
                    SRSTimerActive = false;
                }
                catch (Exception e)
                {
                    Log.Write("Problems were reported with SRS timer stop. " + e.Message, Colors.Inline);
                }
            }

            private static void SRS_Timer_Elapsed_Handler(object sender, ElapsedEventArgs e)
            {
                try
                {
                    PushToTalk.PTT.PTT_Manage_Listen_SRS(false); // stop listen i.e. inhibit
                }
                catch (Exception a)
                {
                    Log.Write("Problems were reported with the SRS timer handler. " + a.Message, Colors.Inline);
                }
            }
        }
    }
}


