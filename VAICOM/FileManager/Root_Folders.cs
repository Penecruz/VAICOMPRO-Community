using System.Collections.Generic;
using System.IO;
using VAICOM.Static;

namespace VAICOM
{
    namespace FileManager
    {

        public partial class FileHandler
        {

            public static partial class Root
            {

                // check if subfolders exist and if not create them (on initialize)
                public static void CheckSubFolders()
                {
                    Log.Write("Checking installation subfolders.", Colors.Text);

                    try
                    {
                        string rootpath = State.Proxy.SessionState["VA_APPS"] + "\\" + Products.Products.Families.Vaicom.VaicomProPlugin.rootfoldername;
                        string path;

                        foreach (KeyValuePair<string, string> entry in AppData.SubFolders)
                        {
                            path = rootpath + "\\" + entry.Value; if (!Directory.Exists(path))
                            {
                                Directory.CreateDirectory(path);
                                Log.Write("Restored folder " + path, Colors.Text);
                            }
                        }
                    }
                    catch
                    {
                    }
                }

                public static void ExtractCompagnionApp()
                {

                    try
                    {
                        string rootpath = State.Proxy.SessionState["VA_APPS"] + "\\" + Products.Products.Families.Vaicom.VaicomProPlugin.rootfoldername;
                        string writefile;

                        byte[] source = Properties.Resources.VAICOMPRO;

                        writefile = rootpath + "\\" + "VAICOMPRO.exe";

                        if (File.Exists(writefile))
                        {
                            File.Delete(writefile);
                        }

                        File.WriteAllBytes(writefile, source);

                    }
                    catch
                    {
                    }
                }

                public static void ExtractNoLoadContext() // add NoLoadContext for VA 2.0 Compatability Pene
                {

                    try
                    {
                        string rootpath = State.Proxy.SessionState["VA_APPS"] + "\\" + Products.Products.Families.Vaicom.VaicomProPlugin.rootfoldername;
                        string writefile;

                        byte[] source = Properties.Resources.NoLoadContext;

                        writefile = rootpath + "\\" + "NoLoadContext";

                        if (File.Exists(writefile))
                        {
                            File.Delete(writefile);
                        }

                        File.WriteAllBytes(writefile, source);

                    }
                    catch
                    {
                    }
                }

                public static void DeleteConfigFolder()
                {

                    try
                    {
                        string rootpath = State.Proxy.SessionState["VA_APPS"] + "\\" + Products.Products.Families.Vaicom.VaicomProPlugin.rootfoldername;
                        string path;

                        foreach (KeyValuePair<string, string> entry in AppData.SubFolders)
                        {
                            path = rootpath + "\\" + entry.Value;
                            if (entry.Key.Equals("config"))
                            {
                                if (Directory.Exists(path))
                                {
                                    Directory.Delete(path, true);
                                    Log.Write("Cleared Config folder." + path, Colors.Text);
                                }
                            }
                        }
                    }
                    catch
                    {
                    }
                }

                public static void DeleteDatabaseFolder()
                {

                    try
                    {
                        string rootpath = State.Proxy.SessionState["VA_APPS"] + "\\" + Products.Products.Families.Vaicom.VaicomProPlugin.rootfoldername;
                        string path;

                        foreach (KeyValuePair<string, string> entry in AppData.SubFolders)
                        {
                            path = rootpath + "\\" + entry.Value;
                            if (entry.Key.Equals("database"))
                            {
                                if (Directory.Exists(path))
                                {
                                    Directory.Delete(path, true);
                                    Log.Write("Cleared Database folder." + path, Colors.Text);
                                }
                            }
                        }
                    }
                    catch
                    {
                    }
                }
            }
        }
    }
}
