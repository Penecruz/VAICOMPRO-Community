using VAICOM.Database;
using System.Collections.Generic;


namespace VAICOM
{
    namespace Languages
    {
        public enum language
        {
            ENG,
            GER,
            ESP,
            FR,
            CHN,
            JAP,
            RUS
        }

        public class localization
        {
            // not used yet
            public static Dictionary<language, Dictionary<string, string>> translatedversion = new Dictionary<language, Dictionary<string, string>>()
            {
                { language.ENG, Aliases.airecipients    },                 

            };

            public static Dictionary<int, string> languages = new Dictionary<int, string>()
            {
                {    0, "ENG" },
                {    1, "RUS" },

            };

        }

    }

}
