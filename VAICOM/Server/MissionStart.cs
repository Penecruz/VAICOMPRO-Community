using VAICOM.Static;
using VAICOM.PushToTalk;
using VAICOM.Extensions.RIO;
using System;
using VAICOM.Extensions.Kneeboard;
using System.Windows.Forms;


namespace VAICOM
{
    namespace Servers
    {

        public static partial class Server
        {

            public static bool   newmissionflag;
            public static Vector homebaselocation;

            public static bool DetectNewMission()
            {

                bool newmissiondetect = ((State.previousstate.id != State.currentstate.id) || (State.previousstate.playerunitid != State.currentstate.playerunitid) || (State.previousstate.missiontitle != State.currentstate.missiontitle) || (State.previousstate.easycomms != State.currentstate.easycomms));
                if (!newmissionflag && newmissiondetect)
                {
                    Log.Write("------------------------------------------", Colors.Message);
                    Log.Write("DCS mission | " + State.currentstate.missiontitle, Colors.Message);
                    State.dcsrunning = true;
                    newmissionflag = true;
                    return true;
                }
                else
                {
                    newmissionflag = false;
                    return false;
                }

            }

            public static void GUI_InitNewMission()
            {
                if (State.configwindowopen && (State.configurationwindow != null))
                {
                    State.configurationwindow.Dispatcher.BeginInvoke((MethodInvoker)delegate
                    {
                        State.configurationwindow.RIO_Enable_Box.IsEnabled = false;
                        State.configurationwindow.Dictate_set_relhot_Light(State.activeconfig.ReleaseHot);
                    });
                }
            }

            public static void InitNewMission()
            {

                State.allowairioswitching = false;
                State.beaconlocked = State.oneradioactive;
                State.ResetSelectedUnits();
                State.menuauximported = false;
                Extensions.RIO.helper.showingjestermenu = false;

                ValidateMultiPlayer();
                DisplayCurrentModule();
                ScanNewTheater();

                State.messagelog = "";
                State.lastmessagelog = "";
                State.nineline = "";

                tables.resetriomenustate();
                helper.getAGweaponsstate(); 

                // set homebase pos for AOCS
                homebaselocation = new Vector();
                try
                {
                    homebaselocation = State.currentstate.availablerecipients["ATC"][0].pos;
                }
                catch
                {
                }

                // reset listen states
                PTT.PTT_Manage_Listen_States_OnPressRelease(false,false);

                // Chatter Init
                try
                {
                    Extensions.Chatter.AudioTimer.Chatter_Initialize();
                }
                catch
                {
                    Log.Write("Chatter theme could not be initialized.", Colors.Text);
                }

                // AOCS auto brief
                try
                {
                    if (State.PRO && State.activeconfig.AutoBrief)
                    {
                        Extensions.AOCS.AOCSProvider.AOCS_ReadBriefing(true);
                    }
                }
                catch
                {
                    Log.Write("Briefing readout could not be initialized.", Colors.Text);
                }

                // GUI update
                GUI_InitNewMission();

                try
                {
                    Client.DcsClient.UpdateRIOState();
                }
                catch
                {
                }

                // reset kneeboard contents
                try
                {
                    State.KneeboardState = new KneeboardState();
                    State.kneeboardcurrentbuffer = "";
                    State.Proxy.Dictation.ClearBuffer(false, out String Message2);
                }
                catch
                {

                }
            }
        }
    }
}
