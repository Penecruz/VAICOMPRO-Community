using VAICOM.Static;
using VAICOM.Servers;
using System.Collections.Generic;
using System;
using System.IO;

namespace VAICOM
{
    namespace FileManager
    {
        public static partial class FileHandler
        {
            public static partial class Lua
            {

                public static void LuaFiles_Remove() // called by reset page
                {

                    try
                    {


                        foreach (KeyValuePair<string, string> set in Server.dcsfolders)
                        {

                            try
                            {
                                string programfolder64 = Environment.GetEnvironmentVariable("ProgramW6432");

                                string dcsinstallfolder1 = Helpers.WinReg.GetDCSInstallFolder(set.Value);
                                string dcsinstallfolder2 = Helpers.Common.TrimmedString(State.activeconfig.DCSfoldername1); //+ set.Value;
                                string dcsinstallfolder3 = Helpers.WinReg.GetSteamFolder().Replace("/", "\\") + "\\steamapps\\common\\" + "DCSWorld";
                                string dcsinstallfolder4 = programfolder64 + "\\" + "Eagle Dynamics" + "\\" + set.Value;

                                bool installfound = false;
                                string folder = "NOT FOUND";

                                // custom folder (overrides others)
                                if (!installfound && State.activeconfig.UseCustomFolders && !dcsinstallfolder2.Equals(set.Value) && Directory.Exists(dcsinstallfolder2)) // custom
                                {
                                    if ((set.Value.Contains("OpenBeta").Equals(State.activeconfig.CustomFoldersOBFlag)))
                                    {
                                        folder = dcsinstallfolder2;
                                        installfound = true;
                                    }
                                }

                                // get from registry (preferred)
                                if (!installfound && dcsinstallfolder1 != null)
                                {
                                    folder = dcsinstallfolder1;
                                    installfound = true;
                                }

                                // steam (standard path)
                                if (!installfound && !set.Key.Contains("OpenBeta") && Directory.Exists(dcsinstallfolder3))
                                {
                                    folder = dcsinstallfolder3;
                                    installfound = true;
                                }

                                // regular install path
                                if (!installfound && Directory.Exists(dcsinstallfolder4))
                                {
                                    folder = dcsinstallfolder4;
                                    installfound = true;
                                }

                                string UserSavedGamesFolder = Framework.SpecialFoldersRetrieve.GetSavedGames();

                                if (installfound)
                                {

                                    foreach (KeyValuePair<string, Server.LuaFile> serverfile in LuaFiles)
                                    {
                                        if (serverfile.Value.canremove) // do this only for files set to canremove
                                        {

                                            Server.LuaFile thisfile = serverfile.Value;
                                            string basepath;
                                            string path;

                                            if (thisfile.root)
                                            {
                                                basepath = folder + "\\" + thisfile.installfolder;
                                                path = basepath + "\\" + thisfile.filename;
                                            }
                                            else
                                            {
                                                basepath = UserSavedGamesFolder + "\\" + Server.dcsversion[set.Key] + "\\" + thisfile.installfolder;
                                                path = basepath + "\\" + thisfile.filename;
                                            }

                                            if (!thisfile.filename.ToLower().Equals("export.lua"))
                                            {
                                                if (State.luahardreset && thisfile.hardreset) 
                                                {
                                                    if (File.Exists(path))
                                                    {
                                                        File.Delete(path);
                                                    }
                                                    if (File.Exists(path + ".old"))
                                                    {
                                                        File.Delete(path + ".old");
                                                    }

                                                    // put back original

                                                    if (thisfile.filename.ToLower().Equals("vaicompro.export.lua"))
                                                    {
                                                        Directory.Delete(basepath,true);
                                                    }
                                                    else
                                                    {

                                                        string writestring = thisfile.orig;
                                                        using (StreamWriter writer = new StreamWriter(path, false)) { writer.Write(writestring); };
                                                    }

                                                }
                                            }
                                            else // export.lua
                                            {
                                                if (File.Exists(path))
                                                {
                                                    string exportfile = File.ReadAllText(path);
                                                    string exportmatch = "";
                                                    int matchoccurences = 0;

                                                    exportmatch = thisfile.source;
                                                    matchoccurences = (exportfile.Length - exportfile.Replace(exportmatch, "").Length) / exportmatch.Length;

                                                    if (matchoccurences >= 1)
                                                    {
                                                        exportfile = exportfile.Replace(exportmatch, ""); // clear
                                                        string writestring = exportfile;
                                                        using (StreamWriter writer = new StreamWriter(path, false)) { writer.Write(writestring); };
                                                    }
                                                    else // big code block not found, try smaller
                                                    {
                                                        exportmatch = Properties.Resources.Exportmatch;
                                                        matchoccurences = (exportfile.Length - exportfile.Replace(exportmatch, "").Length) / exportmatch.Length;

                                                        if (matchoccurences >= 1)
                                                        {
                                                            exportfile = exportfile.Replace(exportmatch, ""); // clear
                                                            string writestring = exportfile;
                                                            using (StreamWriter writer = new StreamWriter(path, false)) { writer.Write(writestring); };

                                                        }
                                                        else
                                                        {
                                                            // no matching content found
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            catch
                            {
                            }
                        }
                    }
                    catch
                    {
                        Log.Write("Problems were reported during removal of lua code.", Colors.Text);
                    }
                }
            }
        }
    }
}

