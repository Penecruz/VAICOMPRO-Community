namespace VAICOM
{

    namespace PushToTalk
    {

        public partial class PTT
        {

            public static void PTT_ResetConfig()
            {
                PTT_ResetRadios();
                PTT_TXAssignmentVoid();
            }

            public static void PTT_ResetRadios()
            {

                RadioDevices.VOID.name = "VOID";
                RadioDevices.VOID.deviceid = 0;
                RadioDevices.VOID.AM = false;
                RadioDevices.VOID.FM = false;
                RadioDevices.VOID.isavailable = true;
                RadioDevices.VOID.on = true;
                RadioDevices.VOID.intercom = false;
                RadioDevices.VOID.isSRSserver = false;
                RadioDevices.VOID.frequency = "";

                RadioDevices.AUTO.name = "AUTO";
                RadioDevices.AUTO.deviceid = 0;
                RadioDevices.AUTO.AM = true;
                RadioDevices.AUTO.FM = true;
                RadioDevices.AUTO.isavailable = true;
                RadioDevices.AUTO.on = true;
                RadioDevices.AUTO.intercom = true;
                RadioDevices.AUTO.isSRSserver = false;
                RadioDevices.AUTO.frequency = "";

                RadioDevices.Radio1.name = "VHF AM";
                RadioDevices.Radio1.deviceid = 0;
                RadioDevices.Radio1.AM = true;
                RadioDevices.Radio1.FM = false;
                RadioDevices.Radio1.isavailable = true;
                RadioDevices.Radio1.on = true;
                RadioDevices.Radio1.intercom = false;
                RadioDevices.Radio1.isSRSserver = false;
                RadioDevices.Radio1.frequency = "";

                RadioDevices.Radio2.name = "UHF";
                RadioDevices.Radio2.deviceid = 0;
                RadioDevices.Radio2.AM = true;
                RadioDevices.Radio2.FM = false;
                RadioDevices.Radio2.isavailable = true;
                RadioDevices.Radio2.on = true;
                RadioDevices.Radio2.intercom = false;
                RadioDevices.Radio2.isSRSserver = false;
                RadioDevices.Radio2.frequency = "";

                RadioDevices.Radio3.name = "VHF FM";
                RadioDevices.Radio3.deviceid = 0;
                RadioDevices.Radio3.AM = false;
                RadioDevices.Radio3.FM = true;
                RadioDevices.Radio3.isavailable = true;
                RadioDevices.Radio3.on = true;
                RadioDevices.Radio3.intercom = false;
                RadioDevices.Radio3.isSRSserver = false;
                RadioDevices.Radio3.frequency = "";

                RadioDevices.INT.name = "INT";
                RadioDevices.INT.deviceid = 0;
                RadioDevices.INT.AM = false;
                RadioDevices.INT.FM = false;
                RadioDevices.INT.isavailable = true;
                RadioDevices.INT.on = true;
                RadioDevices.INT.intercom = true;
                RadioDevices.INT.isSRSserver = false;
                RadioDevices.INT.frequency = "";

                RadioDevices.AUX.name = "AUX";
                RadioDevices.AUX.deviceid = 0;
                RadioDevices.AUX.AM = true;
                RadioDevices.AUX.FM = true;
                RadioDevices.AUX.isavailable = true;
                RadioDevices.AUX.on = true;
                RadioDevices.AUX.intercom = true;
                RadioDevices.AUX.isSRSserver = false;
                RadioDevices.AUX.frequency = "";

                RadioDevices.SEL.name = "SEL/AUTO";
                RadioDevices.SEL.deviceid = 0;
                RadioDevices.SEL.AM = true;
                RadioDevices.SEL.FM = true;
                RadioDevices.SEL.isavailable = true;
                RadioDevices.SEL.on = true;
                RadioDevices.SEL.intercom = true;
                RadioDevices.SEL.isSRSserver = false;
                RadioDevices.SEL.frequency = "";

            }

            public static void PTT_TXAssignmentVoid()
            {
                TXNodes.TX1.name = "TX1";
                TXNodes.TX1.number = 1;
                TXNodes.TX1.enabled = false;
                TXNodes.TX1.radios = TXConfigs.SNGL_RADIO_VOID;

                TXNodes.TX2.name = "TX2";
                TXNodes.TX2.number = 2;
                TXNodes.TX2.enabled = false;
                TXNodes.TX2.radios = TXConfigs.SNGL_RADIO_VOID;

                TXNodes.TX3.name = "TX3";
                TXNodes.TX3.number = 3;
                TXNodes.TX3.enabled = false;
                TXNodes.TX3.radios = TXConfigs.SNGL_RADIO_VOID;

                TXNodes.TX4.name = "TX4";
                TXNodes.TX4.number = 4;
                TXNodes.TX4.enabled = false;
                TXNodes.TX4.radios = TXConfigs.SNGL_RADIO_VOID;

                TXNodes.TX5.name = "TX5";
                TXNodes.TX5.number = 5;
                TXNodes.TX5.enabled = false;
                TXNodes.TX5.radios = TXConfigs.SNGL_RADIO_VOID;

                TXNodes.TX6.name = "TX6";
                TXNodes.TX6.number = 6;
                TXNodes.TX6.enabled = false;
                TXNodes.TX6.radios = TXConfigs.SNGL_RADIO_VOID;

            }

            public static void PTT_TXAssignmentDefault()
            {

                TXNodes.TX1.name = "TX1";
                TXNodes.TX1.number = 1;
                TXNodes.TX1.enabled = !State.activeconfig.ForceSingleHotkey;
                TXNodes.TX1.radios = TXConfigs.SNGL_RADIO_Radio1;

                TXNodes.TX2.name = "TX2";
                TXNodes.TX2.number = 2;
                TXNodes.TX2.enabled = !State.activeconfig.ForceSingleHotkey;
                TXNodes.TX2.radios = TXConfigs.SNGL_RADIO_Radio2;

                TXNodes.TX3.name = "TX3";
                TXNodes.TX3.number = 3;
                TXNodes.TX3.enabled = !State.activeconfig.ForceSingleHotkey;
                TXNodes.TX3.radios = TXConfigs.SNGL_RADIO_Radio3;

                TXNodes.TX4.name = "TX4";
                TXNodes.TX4.number = 4;
                TXNodes.TX4.enabled = !State.activeconfig.ForceSingleHotkey && State.currentstate.easycomms;
                TXNodes.TX4.radios = TXConfigs.ALL_RADIOS_AUTO;

                TXNodes.TX5.name = "TX5";
                TXNodes.TX5.number = 5;
                TXNodes.TX5.enabled = !State.activeconfig.ForceSingleHotkey;
                TXNodes.TX5.radios = TXConfigs.SNGL_RADIO_INT;

                TXNodes.TX6.name = "TX6";
                TXNodes.TX6.number = 6;
                TXNodes.TX6.enabled = !State.activeconfig.ForceSingleHotkey;
                TXNodes.TX6.radios = TXConfigs.SNGL_RADIO_AUX;

            }

        }
    }
}
