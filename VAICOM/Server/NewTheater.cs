using VAICOM.Static;
using VAICOM.Database;
using VAICOM.FileManager;
using System.Collections.Generic;

namespace VAICOM
{

    namespace Servers
    {

        public static partial class Server
        {

            public static void ScanNewTheater()
            {
                if (State.activeconfig.Checkfornewatcs)
                {
                    int newatccounter = 0;

                    Log.Write("Scanning for new theater.", Colors.Text);

                    foreach (Server.DcsUnit ATC in State.currentstate.availablerecipients["ATC"])
                    {
                        if (!Aliases.airecipients.ContainsValue(ATC.fullname) & !Aliases.importedatcs.ContainsValue(ATC.fullname))
                        {
                            if (!Aliases.importedatcs.ContainsKey(ATC.fullname))
                            {
                                Log.Write("Importing new ATC: " + ATC.fullname, Colors.Text);
                                Aliases.importedatcs.Add(ATC.fullname, ATC.fullname);
                                if (!Aliases.importedatcs.ContainsKey(ATC.callsign))
                                {
                                    Aliases.importedatcs.Add(ATC.callsign, ATC.fullname);
                                    Log.Write("Alias: " + ATC.callsign, Colors.Text);
                                }

                                newatccounter = newatccounter + 1;
                            }
                        }
                    }

                    if (newatccounter > 0) // new atcs imported
                    {
                     
                        FileHandler.Database.WriteCategoryToFile("importedatcs", Aliases.importedatcs, true);
                        FileHandler.Database.WriteCategoryToFile("airecipients", Aliases.airecipients, true);

                        FileHandler.Database.ReadAllCategoriesFromFile(); 
                        SetImportedATCsAsRecipients();
                        Aliases.BuildNewMasterTable(); 

                        State.activeconfig.Editorrequiresreload = true;
                        Settings.ConfigFile.WriteConfigToFile(true);

                        Log.Write("New theater ATCs were found: the database was updated.", Colors.Warning);
                        Log.Write("In Keywords Editor select RELOAD.", Colors.Warning);
                    }
                    else
                    {
                        Log.Write("No new ATCs were found.", Colors.Text);
                    }
                }
            }

            public static void SetImportedATCsAsRecipients()
            {

                Aliases.UpdateScanCats();

                if (Aliases.importedatcs != null)
                {
                    int id = 15800;
                    Log.Write("Adding " + Aliases.importedatcs.Count.ToString() + " imported ATC aliases.", Colors.Text);
                    foreach (KeyValuePair<string, string> ATC in Aliases.importedatcs)
                    {
                        if (id < 15997) { id = id + 1; }
                        if (!Recipients.Table.ContainsKey(ATC.Value))
                        {
                            Labels.importedatcs.Add(ATC.Value, ATC.Value);
                            Recipients.Table.Add(ATC.Value, new Recipient { uniqueid = id, name = ATC.Value, displayname = ATC.Value });
                            Log.Write("Setting ATC " + ATC.Key + " as recipient " + ATC.Value + " " + id.ToString(), Colors.Text);
                        }
                    }
                }
            }

        }
    }
}
