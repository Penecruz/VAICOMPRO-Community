using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VAICOM.Extensions.RIO
{

    public class AuxData 
    {
  
    }

    public class RecipientInfo
    {
        public int      uniqueid;
        public string   name;
        public string   displayname;
        public bool     requiresJester;
        public bool     enabled;
        public bool     blockedforFree;

        public RecipientInfo()
        {
            requiresJester  = true;
            enabled         = false;
            blockedforFree  = true;
        }
    }

    public class CommandInfo
    {
        public int      uniqueid;
        public string   name;
        public string   displayname;
        public int      eventnumber;
        public bool     requiresJester;
        public bool     enabled;
        public bool     blockedforFree;

        public CommandInfo()
        {
            eventnumber     = 4000;
            requiresJester  = true;
            enabled         = false;
            blockedforFree  = true;
        }
    }

    // get added to recipients.all
    public static partial class Recipients
    {
        public static Dictionary<string, RecipientInfo> aicomms = new Dictionary<string, RecipientInfo>(StringComparer.OrdinalIgnoreCase)
        {
            { "RIO",    new RecipientInfo { uniqueid = 19301, name = "wAIUnitFlightCrewMembersRIO",     displayname = Labels.airecipients["RIO"], requiresJester = true, enabled = true } },
            { "Iceman", new RecipientInfo { uniqueid = 19302, name = "wAIUnitFlightCrewMembersIceman",  displayname = Labels.airecipients["Iceman"], requiresJester = true, enabled = true } },
        };
    }

  



}
