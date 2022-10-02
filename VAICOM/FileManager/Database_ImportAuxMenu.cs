using VAICOM.Static;
using VAICOM.Servers;
using VAICOM.Database;
using System.Collections.Generic;
using System;
using System.IO;
using Newtonsoft.Json; 

namespace VAICOM
{
    namespace FileManager
    {

        public partial class FileHandler
        {

            public partial class Database
            {

                // adds database file with imported F10 menu items
                public static void WriteAuxMenuItemsToFile(bool overwrite)
                {
                    Dictionary<string, Server.MenuItem> WriteObject = Server.auxmenuitems;

                    try
                    {
                        string filename;

                        if (State.databaseencrypted)
                        { filename = Aliases.scrambleddbfilenames["menuitems"]; }
                        else
                        { filename = "menuitems" + ".json"; }

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

                // reads items from db file (on init)
                public static void ReadAuxMenuItemsFromFile()
                {

                    Log.Write("Loading F10 menu items...", Colors.Text);

                    string filename;

                    if (State.databaseencrypted)
                    {
                        filename = Aliases.scrambleddbfilenames["menuitems"];
                    }
                    else
                    {
                        filename = "menuitems" + ".json";
                    }

                    try
                    {
                        Dictionary<string, Server.MenuItem> ReturnObject = new Dictionary<string, Server.MenuItem>();
                        string path = State.VA_APPS + "\\" + AppData.RootFolder + "\\" + AppData.SubFolders["database"] + "\\" + filename;

                        if (State.databaseencrypted)
                        {
                            ReturnObject = JsonConvert.DeserializeObject<Dictionary<string, Server.MenuItem>>(Helpers.Crypto.Decrypt(File.ReadAllText(path)));
                        }
                        else { ReturnObject = JsonConvert.DeserializeObject<Dictionary<string, Server.MenuItem>>(File.ReadAllText(path)); }

                        Dictionary<string, Server.MenuItem> newvalue = new Dictionary<string, Server.MenuItem>(StringComparer.OrdinalIgnoreCase);
                        newvalue = ReturnObject;
                        Server.auxmenuitems = newvalue;
                        Log.Write("Success.", Colors.Text);
                    }
                    catch
                    {
                    }
                }
            }
        }
    }
}
