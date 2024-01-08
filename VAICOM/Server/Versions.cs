using System.Collections.Generic;


namespace VAICOM
{
    namespace Servers
    {

        public static partial class Server
        {

            // Program Files:
            public static Dictionary<string, string> dcsfolders = new Dictionary<string, string>()
            {
                {"2.8",             "DCS World"             },
                {"2.8 OpenBeta",    "DCS World OpenBeta"    },
                {"STEAM",           "DCSWorld"              },
            };

            // Saved Games:
            public static Dictionary<string, string> dcsversion = new Dictionary<string, string>()
            {
                {"2.8",             "DCS"           },
                {"2.8 OpenBeta",    "DCS.openbeta"  },
                {"STEAM",           "DCS"           },
            };

            public class LuaFile
            {
                public string source;
                public string source_legacy;
                public string installfolder;
                public string installfolder_legacy;
                public string filename;
                public string version;
                public string fileid;
                public bool append;
                public bool canremove;
                public bool hardreset;
                public string orig;
                public string orig_legacy;
                public bool reset;
                public bool root;
                public bool autoremove;
                public bool export;
                public bool install;
                public bool quiet;
                public bool AIRIO;
                public bool kneeboard;
                public bool binary;
                public byte[] binarysource;
                public bool stringreplace;
                public string stringorig;
                public string stringsource;

            }
        }
    }
}
