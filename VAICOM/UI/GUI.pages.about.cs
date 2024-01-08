using System;
using System.Windows;
using System.Windows.Input;


namespace VAICOM
{
    namespace UI
    {

        public partial class ConfigWindow : Window
        {

            // ------------  LICENSE PAGE ---------------------------------


            private void setproductname(object sender, EventArgs e)
            {
                showproductname();
            }

            public void showproductname()
            {
                productname.Text = "Community Edition";

            }

            private void showprolight(object sender, EventArgs e)
            {
                showprolight();
            }

            private void showprolight()
            {
                if (State.currentlicense.Equals("PRO"))
                {
                    pro_light.Visibility = Visibility.Visible;
                }
                else
                {
                    pro_light.Visibility = Visibility.Hidden;
                }
            }

            public void Alternateupdatebug()
            {
                if (!State.updateavailable_plugin)
                {
                    tagline.Visibility = Visibility.Hidden; // visible
                }
                else
                {
                    tagline.Visibility = Visibility.Hidden;
                }
            }

            private void OpenBuyLink(object sender, RoutedEventArgs e)
            {
            }

            private void ValidateLicenseKey(object sender, RoutedEventArgs e)
            {
            }

            public void resetenabledfeatures()
            {
                // preferences

                // left column
                ImportOtherMenu.IsEnabled = State.PRO;
                MP_AOCS.IsEnabled = State.PRO;
                UseSRSMapping.IsEnabled = State.PRO;
                DisableMenus.IsEnabled = true;
                EnforceATCProtocol.IsEnabled = State.PRO;
                EnforceCallsigns.IsEnabled = State.PRO;
                UseInstantSelect.IsEnabled = State.PRO;
                AllowRadioTuning.IsEnabled = State.PRO;
                ForceLanguage.IsEnabled = State.PRO;
                ForcedLanguage.IsEnabled = State.PRO;
                EnforceCallsigns.IsEnabled = State.PRO;
                CallsignsLanguage.IsEnabled = State.PRO;
                EnforceATCProtocol.IsEnabled = State.PRO;
                ATCProtocol.IsEnabled = State.PRO;

                // right column
                UIaddhints.IsEnabled = State.PRO;
                RequireCues.IsEnabled = State.PRO;
                AllowAppendices.IsEnabled = State.PRO;
                AllowOptions.IsEnabled = true;
                AllowAddCommands.IsEnabled = State.PRO;
                DisableSquelch.IsEnabled = State.PRO;
                UIsounds.IsEnabled = State.PRO;
                DisablePlayerVoice.IsEnabled = true;


                // MP page
                MP_UsePluginWithMultiplayer.IsEnabled = State.PRO;
                MP_ShowOnScreenMessages.IsEnabled = State.PRO;
                MP_AOCS.IsEnabled = State.PRO;

                VoIPSwitching.IsEnabled = State.PRO;
                MP_AutoSwitch.IsEnabled = State.PRO;
                MP_WarnHumans.IsEnabled = State.PRO;
                MP_DelayTransmit.IsEnabled = State.PRO;
                MP_IgnoreSelect.IsEnabled = State.PRO;


                MP_UseVoiceChatIntegration.IsEnabled = State.PRO;
                MP_VCHotMic.IsEnabled = State.PRO;

                MP_UseSRSIntegration.IsEnabled = State.PRO;
                UseSRSMapping.IsEnabled = State.PRO;

                // EX extensions page

                RIO_Hints.IsEnabled = State.jesteractivated;
                if (State.jesteractivated && State.dll_installed_rio)
                {
                    RIO_Hints.Visibility = Visibility.Visible;
                }
                else
                {
                    RIO_Hints.Visibility = Visibility.Hidden;
                }

                RIO_Enable_Box.IsEnabled = State.jesteractivated;
                if (State.jesteractivated && State.dll_installed_rio)
                {
                    RIO_Enable_Box.Visibility = Visibility.Visible;
                }
                else
                {
                    RIO_Enable_Box.Visibility = Visibility.Hidden;
                }

                RIO_Hints_Only.IsEnabled = State.jesteractivated;
                if (State.jesteractivated && State.dll_installed_rio)
                {
                    RIO_Hints_Only.Visibility = Visibility.Visible;
                }
                else
                {
                    RIO_Hints_Only.Visibility = Visibility.Hidden;
                }

                RIO_ICShotmic.IsEnabled = State.jesteractivated;
                if (State.jesteractivated && State.dll_installed_rio)
                {
                    RIO_ICShotmic.Visibility = Visibility.Visible;
                }
                else
                {
                    RIO_ICShotmic.Visibility = Visibility.Hidden;
                }
                RIO_ICShotmic_useswitch.IsEnabled = false;
                if (State.jesteractivated && State.dll_installed_rio)
                {
                    RIO_ICShotmic_useswitch.Visibility = Visibility.Hidden;
                }
                else
                {
                    RIO_ICShotmic_useswitch.Visibility = Visibility.Hidden;
                }

                autobrief.IsEnabled = State.PRO;
                briefconcise.IsEnabled = State.PRO;
                deepinterrogate.IsEnabled = State.PRO;
                ChatterAutostart.IsEnabled = State.chatterthemesactivated;
                ChatterSilentOffline.IsEnabled = State.chatterthemesactivated;
                ChatterTheme.IsEnabled = State.chatterthemesactivated;

                CarrierComms.IsEnabled = State.realatcactivated;
                CarrierComms.IsChecked = State.realatcactivated;

                //audio page

                Pan_AOCS.IsEnabled = State.PRO;
                Chatter_Pan.IsEnabled = State.chatterthemesactivated;
                World_Sw_Up.IsEnabled = State.PRO;
                World_Sw_Dn.IsEnabled = State.PRO;
                World_Init_Button.IsEnabled = State.PRO;


                // config page
                RunInDebugMode.IsEnabled = true;
                AutoImportATC.IsEnabled = State.PRO;
                UseCustomFolders.IsEnabled = true;
                SetFolders.IsEnabled = true;
                AutoImportModules.IsEnabled = State.PRO;
                ManualManageServer.IsEnabled = true;
                ExportFiles.IsEnabled = true;

                // PTT page
                ForceMultiHotkey.IsEnabled = State.PRO;
                ForceSingleHotkey.IsEnabled = State.PRO;
                HotkeySelection.IsEnabled = true;
                OperateDial.IsEnabled = true;
                Volume_Knob.IsEnabled = State.chatterthemesactivated;
                Button_Top_TX1.IsEnabled = State.PRO;
                Button_Top_TX2.IsEnabled = State.PRO;
                Button_Top_TX3.IsEnabled = State.PRO;
                Button_Top_TX4.IsEnabled = State.PRO;
                Button_Top_TX5.IsEnabled = State.PRO;
                Button_Top_TX6.IsEnabled = State.PRO;

                // keywords editor
                AliasCycle.IsEnabled = true;
                comboBoxAlias.IsEnabled = true;
                comboBoxAlias.IsEditable = State.PRO;
                Microphone.IsEnabled = State.PRO;
                newalias.IsEnabled = State.PRO;
                deletealias.IsEnabled = State.PRO;
                Revert_Button.IsEnabled = State.PRO;
                Apply_Button.IsEnabled = State.PRO;
                Restore_Button.IsEnabled = State.PRO;
                ExportCSVbutton.IsEnabled = true;
                KeywordsExport.IsEnabled = State.PRO;
                Cancel.IsEnabled = State.PRO;
                ImportCSVbutton_Add.IsEnabled = true;

            }

            private void ShowLicenses(object sender, MouseButtonEventArgs e)
            {

                string caption = "VAICOM PRO Community Edition";
                string message = "THE SOFTWARE IS PROVIDED \"AS IS\", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.";

                MessageBox.Show(message, caption, MessageBoxButton.OK, MessageBoxImage.Information);

            }


            // ------------------------------------------------------------


            // --- FREE / PRO WARNINGS ------------------------------------

            public void refreshwarnings()
            {
                if (!State.PRO)
                { prowarning0.Visibility = Visibility.Visible; }
                else { prowarning0.Visibility = Visibility.Hidden; }

                if (!State.PRO)
                { prowarnpic0.Visibility = Visibility.Visible; }
                else { prowarnpic0.Visibility = Visibility.Hidden; }

                if (!State.PRO)
                { prowarning1.Visibility = Visibility.Visible; }
                else { prowarning1.Visibility = Visibility.Hidden; }

                if (!State.PRO)
                { prowarnpic1.Visibility = Visibility.Visible; }
                else { prowarnpic1.Visibility = Visibility.Hidden; }

                if (!State.PRO)
                { prowarning2.Visibility = Visibility.Visible; }
                else { prowarning2.Visibility = Visibility.Hidden; }

                if (!State.PRO)
                { prowarnpic2.Visibility = Visibility.Visible; }
                else { prowarnpic2.Visibility = Visibility.Hidden; }

                if (!State.PRO)
                { prowarning3.Visibility = Visibility.Visible; }
                else { prowarning3.Visibility = Visibility.Hidden; }

                if (!State.PRO)
                { prowarnpic3.Visibility = Visibility.Visible; }
                else { prowarnpic3.Visibility = Visibility.Hidden; }

                if (!State.PRO)
                { prowarning4.Visibility = Visibility.Visible; }
                else { prowarning4.Visibility = Visibility.Hidden; }

                if (!State.PRO)
                { prowarnpic4.Visibility = Visibility.Visible; }
                else { prowarnpic4.Visibility = Visibility.Hidden; }

                if (!State.PRO)
                { prowarning5.Visibility = Visibility.Visible; }
                else { prowarning5.Visibility = Visibility.Hidden; }

                if (!State.PRO)
                { prowarnpic5.Visibility = Visibility.Visible; }
                else { prowarnpic5.Visibility = Visibility.Hidden; }

                if (!State.PRO)
                { prowarning6.Visibility = Visibility.Visible; }
                else { prowarning6.Visibility = Visibility.Hidden; }

                if (!State.PRO)
                { prowarnpic6.Visibility = Visibility.Visible; }
                else { prowarnpic6.Visibility = Visibility.Hidden; }

                if (!State.PRO)
                { prowarning10.Visibility = Visibility.Visible; }
                else { prowarning10.Visibility = Visibility.Hidden; }

                if (!State.PRO)
                { prowarnpic10.Visibility = Visibility.Visible; }
                else { prowarnpic10.Visibility = Visibility.Hidden; }
            }

            private void ShowProWarning0(object sender, EventArgs e)
            {
                if (!State.PRO)
                { prowarning0.Visibility = Visibility.Visible; }
                else { prowarning0.Visibility = Visibility.Hidden; }
            }
            private void ShowProWarnPic0(object sender, EventArgs e)
            {
                if (!State.PRO)
                { prowarnpic0.Visibility = Visibility.Visible; }
                else { prowarnpic0.Visibility = Visibility.Hidden; }
            }
            private void ShowProWarning1(object sender, EventArgs e)
            {
                if (!State.PRO)
                { prowarning1.Visibility = Visibility.Visible; }
                else { prowarning1.Visibility = Visibility.Hidden; }
            }
            private void ShowProWarnPic1(object sender, EventArgs e)
            {
                if (!State.PRO)
                { prowarnpic1.Visibility = Visibility.Visible; }
                else { prowarnpic1.Visibility = Visibility.Hidden; }
            }
            private void ShowProWarning2(object sender, EventArgs e)
            {
                if (!State.PRO)
                { prowarning2.Visibility = Visibility.Visible; }
                else { prowarning2.Visibility = Visibility.Hidden; }
            }
            private void ShowProWarnPic2(object sender, EventArgs e)
            {
                if (!State.PRO)
                { prowarnpic2.Visibility = Visibility.Visible; }
                else { prowarnpic2.Visibility = Visibility.Hidden; }
            }
            private void ShowProWarning3(object sender, EventArgs e)
            {
                if (!State.PRO)
                { prowarning3.Visibility = Visibility.Visible; }
                else { prowarning3.Visibility = Visibility.Hidden; }
            }
            private void ShowProWarnPic3(object sender, EventArgs e)
            {
                if (!State.PRO)
                { prowarnpic3.Visibility = Visibility.Visible; }
                else { prowarnpic3.Visibility = Visibility.Hidden; }
            }
            private void ShowProWarning4(object sender, EventArgs e)
            {
                if (!State.PRO)
                { prowarning4.Visibility = Visibility.Visible; }
                else { prowarning4.Visibility = Visibility.Hidden; }
            }
            private void ShowProWarnPic4(object sender, EventArgs e)
            {
                if (!State.PRO)
                { prowarnpic4.Visibility = Visibility.Visible; }
                else { prowarnpic4.Visibility = Visibility.Hidden; }
            }
            private void ShowProWarning5(object sender, EventArgs e)
            {
                if (!State.PRO)
                { prowarning5.Visibility = Visibility.Visible; }
                else { prowarning5.Visibility = Visibility.Hidden; }
            }
            private void ShowProWarnPic5(object sender, EventArgs e)
            {
                if (!State.PRO)
                { prowarnpic5.Visibility = Visibility.Visible; }
                else { prowarnpic5.Visibility = Visibility.Hidden; }
            }
            private void ShowProWarning6(object sender, EventArgs e)
            {
                if (!State.PRO)
                { prowarning6.Visibility = Visibility.Visible; }
                else { prowarning6.Visibility = Visibility.Hidden; }
            }
            private void ShowProWarnPic6(object sender, EventArgs e)
            {
                if (!State.PRO)
                { prowarnpic6.Visibility = Visibility.Visible; }
                else { prowarnpic6.Visibility = Visibility.Hidden; }
            }
            private void ShowProWarning7(object sender, EventArgs e)
            {
                if (!State.PRO)
                { prowarning7.Visibility = Visibility.Visible; }
                else { prowarning7.Visibility = Visibility.Hidden; }
            }
            private void ShowProWarnPic7(object sender, EventArgs e)
            {
                if (!State.PRO)
                { prowarnpic7.Visibility = Visibility.Visible; }
                else { prowarnpic7.Visibility = Visibility.Hidden; }
            }
            private void ShowProWarning10(object sender, EventArgs e)
            {
                if (!State.PRO)
                { prowarning10.Visibility = Visibility.Visible; }
                else { prowarning10.Visibility = Visibility.Hidden; }
            }
            private void ShowProWarnPic10(object sender, EventArgs e)
            {
                if (!State.PRO)
                { prowarnpic10.Visibility = Visibility.Visible; }
                else { prowarnpic10.Visibility = Visibility.Hidden; }
            }

            // ------------------------------------------------------------
        }
    }
}



