using VAICOM.FileManager;
using System;
using System.Windows;
using System.Windows.Controls;


namespace VAICOM
{
    namespace UI
    {

        public partial class ConfigWindow : Window
        {
            // ------------  EXTENSIONS PAGE -----------------------------

            public void UpdateKneeboard()
            {
                Extensions.Kneeboard.KneeboardUpdater.SendHeartBeatCycle();
            }

            private bool kneeboard_init = false;

            private void SetCurrentValueKneeboardOpacity(object sender, EventArgs e) 
            {
                KneeboardOpacity.IsEnabled = State.kneeboardactivated;
                KneeboardOpacity.Value = State.activeconfig.KneeboardOpacity;
                kneeboard_init = true;
            }
            private void KneeboardOpacity_Change(object sender, RoutedPropertyChangedEventArgs<double> e)
            {
                if (kneeboard_init && !State.activeconfig.KneeboardOpacity.Equals(e.NewValue))
                {
                    State.activeconfig.KneeboardOpacity = e.NewValue;
                    Settings.ConfigFile.WriteConfigToFile(true);
                    UpdateKneeboard();                               
                }
            }

            public void AIRIO_restart_popup()
            {
                RIO_Enable_Box.IsEnabled = false;
                string caption = "AIRIO setting changed";
                string message = "AIRIO setting changed:\nRestart VoiceAttack and DCS.";
                MessageBox.Show(message, caption, MessageBoxButton.OK, MessageBoxImage.Information);
            }

            // Left column:        

            private void SetConfigEnableRIO_Enable(object sender, RoutedEventArgs e) { if (State.allowairioswitching) { if (!State.activeconfig.RIO_Enabled) {  } State.activeconfig.RIO_Enabled = true; FileHandler.Lua.LuaFiles_Install(false, true); } else { RIO_Enable_Box.IsEnabled = false; } } // State.activeconfig.RIO_Enabled = false; 
            private void SetConfigDisableRIO_Enable(object sender, RoutedEventArgs e) { if (State.allowairioswitching) { if (State.activeconfig.RIO_Enabled) {  } State.activeconfig.RIO_Enabled = false; FileHandler.Lua.LuaFiles_Install(false, true); } else { RIO_Enable_Box.IsEnabled = false;  } } // State.activeconfig.RIO_Enabled = false;

            private void SetCurrentValueRIO_Enable(object sender, EventArgs e)
            {
                if (State.jesteractivated && State.dll_installed_rio)
                {
                    RIO_Enable_Box.Visibility = Visibility.Visible;
                }
                else
                {
                    RIO_Enable_Box.Visibility = Visibility.Hidden;
                }
                RIO_Enable_Box.IsEnabled = State.jesteractivated;
                RIO_Enable_Box.IsChecked = State.activeconfig.RIO_Enabled;
            }

            private void SetConfigEnableRIO_Disable_Rose(object sender, RoutedEventArgs e) { State.activeconfig.RIO_Messages = true; }
            private void SetConfigDisableRIO_Disable_Rose(object sender, RoutedEventArgs e) { State.activeconfig.RIO_Messages = false; }
            private void SetCurrentValueRIO_Disable_Rose(object sender, EventArgs e)
            {
                if (State.jesteractivated && State.dll_installed_rio)
                {
                    RIO_Hints.Visibility = Visibility.Visible;
                }
                else
                {
                    RIO_Hints.Visibility = Visibility.Hidden;
                }
                RIO_Hints.IsEnabled = State.jesteractivated;
                RIO_Hints.IsChecked = State.activeconfig.RIO_Messages;
            }

            private void SetConfigEnableRIO_Hints_Only(object sender, RoutedEventArgs e) { State.activeconfig.RIO_Hints_Only = true; }
            private void SetConfigDisableRIO_Hints_Only(object sender, RoutedEventArgs e) { State.activeconfig.RIO_Hints_Only = false; }
            private void SetCurrentValueRIO_Hints_Only(object sender, EventArgs e)
            {
                if (State.jesteractivated && State.dll_installed_rio)
                {
                    RIO_Hints_Only.Visibility = Visibility.Visible;
                }
                else
                {
                    RIO_Hints_Only.Visibility = Visibility.Hidden;
                }
                RIO_Hints_Only.IsEnabled = State.jesteractivated;
                RIO_Hints_Only.IsChecked = State.activeconfig.RIO_Hints_Only;
            }

            private void SetConfigEnableRIO_ICShotmic(object sender, RoutedEventArgs e)
            {
                State.activeconfig.ICShotmic = true;
                if (State.AIRIOactive)
                {     
                    State.Proxy.Command.SetSessionEnabledByCategory("Keyword Collections", true);
                    State.Proxy.Command.SetSessionEnabledByCategory("Extension packs", true);
                    State.Proxy.State.SetListeningEnabled(true);
                }
            }
            private void SetConfigDisableRIO_ICShotmic(object sender, RoutedEventArgs e)
            {
                State.activeconfig.ICShotmic = false;
                if (State.AIRIOactive)
                {                
                    if (State.activeconfig.ReleaseHot)
                    {
                        State.Proxy.Command.SetSessionEnabledByCategory("Keyword Collections", false);
                        State.Proxy.Command.SetSessionEnabledByCategory("Extension packs", false);
                        if (State.Proxy.GetProfileName().ToLower().Contains(State.defProfileName.ToLower()))
                        {
                            State.Proxy.Command.SetSessionEnabled("Chatter", true);
                        }
                        State.Proxy.State.SetListeningEnabled(true);
                    }
                    else
                    {
                        State.Proxy.Command.SetSessionEnabledByCategory("Keyword Collections", true);
                        State.Proxy.Command.SetSessionEnabledByCategory("Extension packs", true);
                        State.Proxy.State.SetListeningEnabled(false);
                    }
                }
            }
            private void SetCurrentValueRIO_ICShotmic(object sender, EventArgs e)
            {
                if (State.jesteractivated && State.dll_installed_rio)
                {
                    RIO_ICShotmic.Visibility = Visibility.Visible;
                }
                else
                {
                    RIO_ICShotmic.Visibility = Visibility.Hidden;
                }
                RIO_ICShotmic.IsEnabled = false; 
                RIO_ICShotmic.IsChecked = State.activeconfig.ICShotmic;
            }

            public void CheckBoxHotMic()
            {
                RIO_ICShotmic.IsChecked = State.activeconfig.ICShotmic;
            }

            private void SetConfigEnableRIO_ICShotmic_useswitch(object sender, RoutedEventArgs e)
            {
            }
            private void SetConfigDisableRIO_ICShotmic_useswitch(object sender, RoutedEventArgs e)
            {
            }
            private void SetCurrentValueRIO_ICShotmic_useswitch(object sender, EventArgs e)
            {
            }

            private void InitRIODllWarning(object sender, EventArgs e)
            {
                if (State.jesteractivated && !State.dll_installed_rio)
                {
                    RIO_Dll_missing.Visibility = Visibility.Visible;
                }
                else
                {
                    RIO_Dll_missing.Visibility = Visibility.Hidden;
                }
            }
            private void Init_RIO_Dll_missing_Pic(object sender, EventArgs e)
            {
                if (State.jesteractivated && !State.dll_installed_rio)
                {
                    RIO_Dll_missing_Pic.Visibility = Visibility.Visible;
                }
                else
                {
                    RIO_Dll_missing_Pic.Visibility = Visibility.Hidden;
                }

            }

            private void CarrierCommsOn(object sender, RoutedEventArgs e) { CarrierComms.IsChecked = State.realatcactivated; }
            private void CarrierCommsOff(object sender, RoutedEventArgs e) { CarrierComms.IsChecked = State.realatcactivated; }
            private void SetCurrentValueCarrierComms(object sender, EventArgs e)
            {
                CarrierComms.IsEnabled = State.realatcactivated;
                CarrierComms.IsChecked = State.realatcactivated;
            }

            private void CarrierSuppressAutoOn(object sender, RoutedEventArgs e) { State.activeconfig.CarrierSuppressAuto = true; }
            private void CarrierSuppressAutoOff(object sender, RoutedEventArgs e) { State.activeconfig.CarrierSuppressAuto = false; }
            private void SetCurrentValueCarrierSuppressAuto(object sender, EventArgs e)
            {
                CarrierSuppressAuto.IsEnabled = State.realatcactivated;
                CarrierSuppressAuto.IsChecked = State.realatcactivated && State.activeconfig.CarrierSuppressAuto;
            }

            // Right column:

            // auto brief
            private void AutoBriefOn(object sender, RoutedEventArgs e) { State.activeconfig.AutoBrief = true; }
            private void AutoBriefOff(object sender, RoutedEventArgs e) { State.activeconfig.AutoBrief = false; }
            private void SetCurrentValueAutoBrief(object sender, EventArgs e) { autobrief.IsEnabled = State.PRO; autobrief.IsChecked = State.activeconfig.AutoBrief; }

            // concise
            private void BriefConciseOn(object sender, RoutedEventArgs e) { State.activeconfig.BriefConcise = true; }
            private void BriefConciseOff(object sender, RoutedEventArgs e) { State.activeconfig.BriefConcise = false; }
            private void SetCurrentValueBriefConcise(object sender, EventArgs e) { briefconcise.IsEnabled = State.PRO; briefconcise.IsChecked = State.activeconfig.BriefConcise; }

            // deepinterrogate
            private void DeepInterrogateOn(object sender, RoutedEventArgs e) { State.activeconfig.DeepInterrogate = true; }
            private void DeepInterrogateOff(object sender, RoutedEventArgs e) { State.activeconfig.DeepInterrogate = false; }
            private void SetCurrentValueDeepInterrogate(object sender, EventArgs e) { deepinterrogate.IsEnabled = State.PRO; deepinterrogate.IsChecked = State.activeconfig.DeepInterrogate; }

            // chatter

            private void ChatterSilentOfflineOn(object sender, RoutedEventArgs e) { State.activeconfig.ChatterSilentOffline = true; }
            private void ChatterSilentOfflineOff(object sender, RoutedEventArgs e) { State.activeconfig.ChatterSilentOffline = false; }
            private void SetCurrentValueChatterSilentOffline(object sender, EventArgs e)
            {
                ChatterSilentOffline.IsEnabled = State.chatterthemesactivated && State.dll_installed_chatter;
                ChatterSilentOffline.IsChecked = State.activeconfig.ChatterSilentOffline;
            }

            private void KneeboardlinkPTTOn(object sender, RoutedEventArgs e) { State.activeconfig.KneeboardlinkPTT = true;   }
            private void KneeboardlinkPTTOff(object sender, RoutedEventArgs e) { State.activeconfig.KneeboardlinkPTT = false; }
            private void SetCurrentValueKneeboardlinkPTT(object sender, EventArgs e)
            {
                KneeboardlinkPTT.IsEnabled = State.kneeboardactivated;
                KneeboardlinkPTT.IsChecked = State.activeconfig.KneeboardlinkPTT;
            }


            private void ChatterAutostartOn(object sender, RoutedEventArgs e) { State.activeconfig.ChatterAutostart = true; }
            private void ChatterAutostartOff(object sender, RoutedEventArgs e) { State.activeconfig.ChatterAutostart = false; }
            private void SetCurrentValueChatterAutostart(object sender, EventArgs e)
            {
                ChatterAutostart.IsEnabled = State.chatterthemesactivated && State.dll_installed_chatter;
                ChatterAutostart.IsChecked = State.activeconfig.ChatterAutostart;
            }

            private void ChatterFolderInitialValue(object sender, EventArgs e)
            {
                ChatterTheme.IsEnabled = State.chatterthemesactivated && State.dll_installed_chatter;
                string displaytext = "---";
                try
                {
                    displaytext = State.activeconfig.ChatterFolder;
                }
                catch
                {
                }
                ChatterTheme.Text = displaytext;
            }
            private void UpdateChatterFolder(object sender, SelectionChangedEventArgs e)
            {
                try
                {
                    bool chatterchanged;
                    string currenttheme = State.activeconfig.ChatterFolder;

                    State.activeconfig.ChatterFolder = ChatterTheme.SelectedValue.ToString();
                    Settings.ConfigFile.WriteConfigToFile(true);

                    chatterchanged = !(State.activeconfig.ChatterFolder.Equals(currenttheme));

                    if (chatterchanged)
                    {
                        Log.Write("Theme changed: restarting chatter.", Static.Colors.Text);
                        Extensions.Chatter.AudioTimer.Chatter_TimerPlayToggle();
                        Extensions.Chatter.AudioTimer.Chatter_Initialize();
                        Extensions.Chatter.AudioTimer.Chatter_TimerPlayToggle();
                    }
                }
                catch
                {
                }
            }

            // ------------------------------------------------------------
        }
    }
}



