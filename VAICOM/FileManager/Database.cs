using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using VAICOM.Database;
using VAICOM.Static;

namespace VAICOM
{
    namespace FileManager
    {

        public partial class FileHandler
        {

            public partial class Database
            {

                //Writes a single category database to file (used by import: menus, atcs)
                public static void WriteCategoryToFile(string cat, Dictionary<string, string> table, bool overwrite)
                {
                    Dictionary<string, string> WriteObject = table;
                    try
                    {
                        string filename;

                        if (State.databaseencrypted)
                        { filename = Aliases.scrambleddbfilenames[cat]; }
                        else
                        { filename = cat + ".json"; }

                        string path = State.VA_APPS + "\\" + AppData.RootFolder + "\\" + AppData.SubFolders["database"] + "\\" + filename;
                        string jsonstring;
                        if (State.databaseencrypted)
                        {
                            jsonstring = Helpers.Crypto.Encrypt(JsonConvert.SerializeObject(WriteObject, Formatting.Indented));
                        }
                        else
                        {
                            jsonstring = JsonConvert.SerializeObject(WriteObject, Formatting.Indented);
                        }

                        if (overwrite || !File.Exists(path))
                        {
                            File.WriteAllText(path, jsonstring);
                        }
                    }
                    catch (Exception e)
                    {
                        Log.Write("Exception: " + e.ToString(), Colors.Text);
                    }

                }

                // restores/writes all keyword (alias) database files
                public static void WriteAllCategoriesToFile(bool overwrite)
                {
                    Dictionary<string, string> WriteObject = new Dictionary<string, string>();
                    try
                    {
                        //Log.Write("Updating keywords database...", Colors.Text);
                        foreach (KeyValuePair<string, Dictionary<string, string>> entry in Aliases.categories)
                        {

                            string filename;

                            if (State.databaseencrypted)
                            { filename = Aliases.scrambleddbfilenames[entry.Key]; }
                            else
                            { filename = entry.Key + ".json"; }

                            WriteObject = entry.Value;

                            string path = State.VA_APPS + "\\" + AppData.RootFolder + "\\" + AppData.SubFolders["database"] + "\\" + filename;
                            string jsonstring;
                            if (State.databaseencrypted)
                            {
                                jsonstring = Helpers.Crypto.Encrypt(JsonConvert.SerializeObject(WriteObject, Formatting.Indented));
                            }
                            else
                            {
                                jsonstring = JsonConvert.SerializeObject(WriteObject, Formatting.Indented);
                            }

                            if (overwrite || !File.Exists(path))
                            {
                                File.WriteAllText(path, jsonstring);
                            }
                        }
                        //Log.Write("Success.", Colors.Text);
                    }
                    catch (Exception)
                    {
                        //Log.Write("Exception: " + e.ToString(), colors.Text);
                    }

                }

                // reads entire database into memory
                public static void ReadAllCategoriesFromFile()
                {
                    Log.Write("Loading keywords database...", Colors.Text);

                    // read database into Reference tables 
                    foreach (KeyValuePair<string, Dictionary<string, string>> entry in Aliases.categories)
                    {
                        string filename;
                        if (State.databaseencrypted)
                        { filename = Aliases.scrambleddbfilenames[entry.Key]; }
                        else
                        { filename = entry.Key + ".json"; }
                        try
                        {
                            Dictionary<string, string> ReturnObject = new Dictionary<string, string>();
                            string path = State.VA_APPS + "\\" + AppData.RootFolder + "\\" + AppData.SubFolders["database"] + "\\" + filename;
                            if (State.databaseencrypted)
                            { ReturnObject = JsonConvert.DeserializeObject<Dictionary<string, string>>(Helpers.Crypto.Decrypt(File.ReadAllText(path))); }
                            else { ReturnObject = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(path)); }
                            Dictionary<string, string> newvalue = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                            newvalue = ReturnObject;
                            Aliases.reference[entry.Key] = newvalue;
                            //Log.Write("  " + entry.Key, colors.Text);
                        }
                        catch (Exception)
                        {
                            //Log.Write("Exception: " + e.Message, colors.Text);
                        }

                    }

                    int warncounter = 0;

                    foreach (KeyValuePair<string, Dictionary<string, string>> entry in Aliases.categories)
                    {
                        //Log.Write("Reading reference from database: " + entry.Key, colors.Text);          

                        foreach (KeyValuePair<string, string> alias in entry.Value)
                        {
                            try
                            {
                                //Log.Write(" db value: " + Aliases.database[entry.Key][alias.Key], colors.Text);

                                // add aliases for keywords that don't have any yet 
                                string keyword = alias.Value;
                                bool diskhasaliasforkeyword = Aliases.reference[entry.Key].ContainsValue(keyword);
                                if (!diskhasaliasforkeyword)
                                {
                                    warncounter = warncounter + 1;
                                    //Log.Write("  Adding new aliases to reference table for " + keyword + " :", Colors.Text);

                                    foreach (KeyValuePair<string, string> newalias in entry.Value)
                                    {
                                        if (newalias.Value.Equals(keyword))
                                        {
                                            Aliases.reference[entry.Key].Add(newalias.Key, newalias.Value);
                                            Log.Write("   -> " + newalias.Key, Colors.Text);
                                        }
                                    }
                                }
                                // for VSPX: fix aliases that should have asterisk in the new model (but not on disk yet) 
                                if (State.activeconfig.UseNewRecognitionModel)
                                {
                                    bool diskhasaliaswithoutasterisk = alias.Key.Contains("*") && Aliases.reference[entry.Key].ContainsKey(alias.Key.Replace("*", ""));
                                    if (diskhasaliaswithoutasterisk)
                                    {
                                        string keywordstr = Aliases.reference[entry.Key][alias.Key.Replace("*", "")]; // get its value
                                        Aliases.reference[entry.Key].Remove(alias.Key.Replace("*", ""));
                                        Aliases.reference[entry.Key].Add(alias.Key, keywordstr);
                                    }
                                }
                            }
                            catch (Exception e)
                            {
                                //Log.Write("There was a problem adding references for " + alias.Key + ": " + e.Message, Colors.Text);
                            }
                        }

                    }

                    //Log.Write(" warning counter: " + warncounter, colors.Warning);

                    Aliases.appendiceswpn = Aliases.reference["aiappendiceswpn"];
                    Aliases.appendicesdir = Aliases.reference["aiappendicesdir"];
                    Aliases.aicues = Aliases.reference["aicues"];
                    Aliases.aicommands = Aliases.reference["aicommands"];
                    Aliases.airecipients = Aliases.reference["airecipients"];
                    Aliases.cockpitcontrol = Aliases.reference["cockpitcontrol"];
                    Aliases.importedatcs = Aliases.reference["importedatcs"];
                    Aliases.importedmenus = Aliases.reference["importedmenus"];
                    Aliases.playercallsigns = Aliases.reference["playercallsigns"];
                    Aliases.simcontrol = Aliases.reference["simcontrol"];

                    Aliases.categories["aiappendiceswpn"] = Aliases.reference["aiappendiceswpn"];
                    Aliases.categories["aiappendicesdir"] = Aliases.reference["aiappendicesdir"];
                    Aliases.categories["aicues"] = Aliases.reference["aicues"];
                    Aliases.categories["aicommands"] = Aliases.reference["aicommands"];
                    Aliases.categories["airecipients"] = Aliases.reference["airecipients"];
                    Aliases.categories["cockpitcontrol"] = Aliases.reference["cockpitcontrol"];
                    Aliases.categories["importedatcs"] = Aliases.reference["importedatcs"];
                    Aliases.categories["importedmenus"] = Aliases.reference["importedmenus"];
                    Aliases.categories["playercallsigns"] = Aliases.reference["playercallsigns"];
                    Aliases.categories["simcontrol"] = Aliases.reference["simcontrol"];

                    Aliases.inputscancats["recipient"] = Aliases.reference["airecipients"];
                    Aliases.inputscancats["importedatcs"] = Aliases.reference["importedatcs"];
                    Aliases.inputscancats["importemenus"] = Aliases.reference["importedmenus"];
                    Aliases.inputscancats["sender"] = Aliases.reference["playercallsigns"];
                    Aliases.inputscancats["cue"] = Aliases.reference["aicues"];
                    Aliases.inputscancats["command"] = Aliases.reference["aicommands"];
                    Aliases.inputscancats["apxwpn"] = Aliases.reference["aiappendiceswpn"];
                    Aliases.inputscancats["apxdir"] = Aliases.reference["aiappendicesdir"];

                    if (warncounter > 0)
                    {
                        Log.Write("Writing updates.", Colors.Text);
                        FileHandler.Database.WriteAllCategoriesToFile(true);
                    }

                    Log.Write("Success.", Colors.Text);

                }
            }
        }
    }
}
