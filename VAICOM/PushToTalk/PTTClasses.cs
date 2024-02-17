using System.Collections.Generic;
using VAICOM.Database;

namespace VAICOM
{

    namespace PushToTalk
    {

        public partial class PTT
        {

            public class RadioDevice
            {
                public string name;
                public int deviceid;
                public bool isavailable;
                public int number;
                public bool on;
                public string frequency = "";
                public string modulation;
                public bool AM;
                public bool FM;
                public bool intercom;
                public bool isSRSserver;
            }

            public class TXNode
            {
                public string name;
                public int number;
                public bool enabled;
                public List<RadioDevice> radios;
                public int tunecounter;
                public bool tunedforai;
                public bool tunedforhuman;
                public string displaytunedunit;
                public string humanplayers;
                public bool relay;
            }

            public static class TXNodes
            {
                public static TXNode TX1 = new TXNode();
                public static TXNode TX2 = new TXNode();
                public static TXNode TX3 = new TXNode();
                public static TXNode TX4 = new TXNode();
                public static TXNode TX5 = new TXNode();
                public static TXNode TX6 = new TXNode();
            }

            public static class RadioDevices
            {
                public static RadioDevice VOID = new RadioDevice() { name = "VOID", deviceid = 0, AM = false, FM = false, isavailable = true, on = true, intercom = false, isSRSserver = false };
                public static RadioDevice AUTO = new RadioDevice() { name = "AUTO", deviceid = 0, AM = true, FM = true, isavailable = true, on = true, intercom = true, isSRSserver = false };
                public static RadioDevice Radio1 = new RadioDevice() { name = "VHF AM", deviceid = 0, AM = true, FM = false, isavailable = true, on = true, intercom = false, isSRSserver = false };
                public static RadioDevice Radio2 = new RadioDevice() { name = "UHF", deviceid = 0, AM = true, FM = false, isavailable = true, on = true, intercom = false, isSRSserver = false };
                public static RadioDevice Radio3 = new RadioDevice() { name = "VHF FM", deviceid = 0, AM = false, FM = true, isavailable = true, on = true, intercom = false, isSRSserver = false };
                public static RadioDevice INT = new RadioDevice() { name = "INT", deviceid = 0, AM = false, FM = false, isavailable = true, on = true, intercom = true, isSRSserver = false };
                public static RadioDevice AUX = new RadioDevice() { name = "AUX", deviceid = 0, AM = true, FM = true, isavailable = true, on = true, intercom = true, isSRSserver = false };
                public static RadioDevice SEL = new RadioDevice() { name = "SEL/AUTO", deviceid = 0, AM = true, FM = true, isavailable = true, on = true, intercom = true, isSRSserver = false };
            }

            public static Dictionary<string, TXNode> SelectionMap = new Dictionary<string, TXNode>()
            {
                { "TX1",   TXNodes.TX1 },
                { "TX2",   TXNodes.TX2 },
                { "TX3",   TXNodes.TX3 },
                { "TX4",   TXNodes.TX4 },
                { "TX5",   TXNodes.TX5 },
                { "TX6",   TXNodes.TX6 },
            };

            public static Dictionary<Recipientclass, RadioDevice> DefaultRadio = new Dictionary<Recipientclass, RadioDevice>()
            {
                { Recipientclasses.Undefined,   RadioDevices.VOID   },
                { Recipientclasses.Flight,      RadioDevices.Radio2 },
                { Recipientclasses.JTAC,        RadioDevices.Radio3 },
                { Recipientclasses.ATC,         RadioDevices.Radio1 },
                { Recipientclasses.AWACS,       RadioDevices.Radio1 },
                { Recipientclasses.Tanker,      RadioDevices.Radio1 },
                { Recipientclasses.Crew,        RadioDevices.INT    },
                { Recipientclasses.Aux,         RadioDevices.Radio3 },
                { Recipientclasses.Cockpit,     RadioDevices.AUX    },
            };

            public static Dictionary<Recipientclass, RadioDevice> AlternativeRadio = new Dictionary<Recipientclass, RadioDevice>()
            {
                { Recipientclasses.Undefined,   RadioDevices.VOID   },
                { Recipientclasses.Flight,      RadioDevices.VOID   },
                { Recipientclasses.JTAC,        RadioDevices.Radio1 },
                { Recipientclasses.ATC,         RadioDevices.VOID   },
                { Recipientclasses.AWACS,       RadioDevices.VOID   },
                { Recipientclasses.Tanker,      RadioDevices.VOID   },
                { Recipientclasses.Crew,        RadioDevices.VOID   },
                { Recipientclasses.Aux,         RadioDevices.Radio1 },
                { Recipientclasses.Cockpit,     RadioDevices.VOID   },
            };

            public static class TXConfigs
            {
                public static List<RadioDevice> NO_RADIO = new List<RadioDevice>();
                public static List<RadioDevice> SNGL_RADIO_VOID = new List<RadioDevice>() { RadioDevices.VOID };
                public static List<RadioDevice> SNGL_RADIO_Radio1 = new List<RadioDevice>() { RadioDevices.Radio1 };
                public static List<RadioDevice> SNGL_RADIO_Radio2 = new List<RadioDevice>() { RadioDevices.Radio2 };
                public static List<RadioDevice> SNGL_RADIO_Radio3 = new List<RadioDevice>() { RadioDevices.Radio3 };
                public static List<RadioDevice> ALL_RADIOS_SEL = new List<RadioDevice>() { RadioDevices.SEL, RadioDevices.VOID, RadioDevices.Radio1, RadioDevices.Radio2, RadioDevices.Radio3, RadioDevices.INT, RadioDevices.AUX };
                public static List<RadioDevice> ALL_RADIOS_AUTO = new List<RadioDevice>() { RadioDevices.AUTO, RadioDevices.VOID, RadioDevices.Radio1, RadioDevices.Radio2, RadioDevices.Radio3, RadioDevices.INT, RadioDevices.AUX };
                public static List<RadioDevice> SNGL_RADIO_INT = new List<RadioDevice>() { RadioDevices.INT };
                public static List<RadioDevice> SNGL_RADIO_AUX = new List<RadioDevice>() { RadioDevices.AUX };
            }
        }
    }
}
