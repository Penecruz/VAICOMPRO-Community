using System.Collections.Generic;
using System;
using System.Collections;

namespace VAICOM
{
    namespace Database
    {

        public static class CollectionData
        {

            // data providers: functions used for drop down tables in config window
            public static SortedDictionary<string, string> GetChatterThemes()
            {
                SortedDictionary<string, string> collection = new SortedDictionary<string, string>();

                collection.Add("(AUTO)", "(AUTO)");

                try
                {
                    foreach (string a in State.chatterthemes)
                    {
                        collection.Add(a, a);
                    }
                }
                catch
                {
                }

                return collection;
            }


            public static SortedDictionary<int, string> GetAudioDeviceObjects()
            {
                SortedDictionary<int, string> collection = new SortedDictionary<int, string>();
                try
                {
                    for (int i = 0; i < State.audiodeviceobjects.Count; i++)
                    {
                        collection.Add(State.audiodeviceobjects[i].number, State.audiodeviceobjects[i].name);
                    }
                }
                catch
                {
                }

                return collection;
            }

            public static SortedDictionary<string, string> GetAliases()
            {
                return Aliases.master;
            }

            public class StringFilter : StringComparer
            {
                public override int Compare(string x, string y)
                {
                    return ((new CaseInsensitiveComparer()).Compare(x.Replace("*",""), y.Replace("*", "")));
                }

                public override bool Equals(string x, string y)
                {
                    return (x.ToLower().Replace("*", "").Equals(y.ToLower().Replace("*", "")));
                }

                public override int GetHashCode(string x)
                {
                    return 0;
                }
            }

            public static SortedDictionary<string, string> GetAliasList()
            {
                SortedDictionary<string, string> choices = new SortedDictionary<string, string>();
                choices = Aliases.master;
                return choices;
            }

            public static Dictionary<string, string> GetKeywordsList()
            {
                Dictionary<string, string> choices = new Dictionary<string, string>();
                choices = Labels.master;
                return choices;
            }

            public static Dictionary<string, PushToTalk.PTT.TXNode> GetHotkeyList()
            {
                Dictionary<string, PushToTalk.PTT.TXNode> choices = new Dictionary<string, PushToTalk.PTT.TXNode>();
                choices = PushToTalk.PTT.SelectionMap;
                return choices;
            }

        }
    }

}
