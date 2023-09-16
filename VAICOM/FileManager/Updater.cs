using VAICOM.Static;
using System.Collections.Generic;
using System;
using System.Windows;
using System.Net;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;
using Newtonsoft.Json;
using System.Threading;


namespace VAICOM
{
    namespace FileManager
    {
        public static partial class FileHandler
        {

            public static partial class Updater
            {

                public static void GetPluginUpdates()
                {
                    try
                    {

                        string basefolder = State.Proxy.SessionState["VA_APPS"] + "\\" + Products.Products.Families.Vaicom.VaicomProPlugin.rootfoldername + "\\";
                        string localfolder = basefolder + "Updates" + "\\";
                        string filename;

                        if (State.versionbeta)
                        {
                            filename = "updatesbeta.json";
                        }
                        else
                        {
                            filename = "updates.json";
                        }

                        if (!GetWebUpdateFile(basefolder, filename))
                        {
                            Log.Write("Updater: JSON could not be downloaded. ", Colors.Inline);
                            return;
                        }

                        UpdateDescriptions newdescr = new UpdateDescriptions();

                        try
                        {
                            newdescr = JsonConvert.DeserializeObject<UpdateDescriptions>(File.ReadAllText(basefolder + filename));
                            foreach (UpdateData componentupdate in newdescr.updates)
                            {
                                if (AcceptUpdate(componentupdate))
                                {
                                    GetUpdate(localfolder, componentupdate);
                                    File.Delete(basefolder + filename);
                                    PerformUpdate(basefolder, componentupdate);
                                    FinishUpdate();
                                }
                            }

                            if (File.Exists(basefolder + filename))
                            {

                                File.Delete(basefolder + filename);
                            }

                        }
                        catch (Exception ex)
                        {
                            Log.Write("failed to read update JSON: " + ex.Message, Colors.Inline);
                            File.Delete(basefolder + filename);
                        }

                    }
                    catch (Exception ex)
                    {
                        UI.Playsound.Error();
                        Log.Write("There was an updater problem." + ex.Message, Colors.Inline);
                    }

                }

                public static void FinishUpdate()
                {
                    
                    int timeout = 10;
                    for (int i = 0; i < timeout; i++)
                    {
                        Thread.Sleep(1000);
                        UI.Playsound.Proceed();
                    }

                    UI.Playsound.Commandcomplete();
                    State.activeconfig.AutomaticUpdateFinished = true;
                    Settings.ConfigFile.WriteConfigToFile(true);

                    Log.Write("Update finished. Restart VoiceAttack.", Colors.Warning);

                    startloop:
                    goto startloop;

                }

                public static void PerformUpdate(string basefolder, UpdateData componentupdate)
                {
                    if (componentupdate.productid.Equals(Products.Products.Families.Vaicom.VaicomProPlugin.product_id)) // plugin
                    {
                        RunBatchFile(basefolder, Properties.Resources.Updater_Plugin);
                    }

                    if (componentupdate.productid.Equals(Products.Products.Families.Vaicom.ChatterThemePack.product_id)) // rio
                    {
                        RunBatchFile(basefolder, Properties.Resources.Updater_Chatter);
                    }

                    if (componentupdate.productid.Equals(Products.Products.Families.Vaicom.RIODialog.product_id)) // rio
                    {
                        RunBatchFile(basefolder, Properties.Resources.Updater_RIO);
                    }
                }

                public static bool AcceptUpdate(UpdateData componentupdate)
                {
                    bool accept = false;

                    if (componentupdate.productid.Equals(Products.Products.Families.Vaicom.VaicomProPlugin.product_id))
                    {
                        Version currentversionplugin = State.dll_info_plugin.Version;

                        Version onlineversionplugin = new Version();
                        if (Version.TryParse(componentupdate.versionstring, out onlineversionplugin))
                        {
                            State.updateavailable_plugin = componentupdate.isrelease && (onlineversionplugin > currentversionplugin); // sets update bug
                        }
                        else
                        {
                            State.updateavailable_plugin = false;
                        }

                        if (State.activeconfig.DisableAutomaticUpdates || (componentupdate.isbeta && !State.activeconfig.BetaTester))
                        {
                            State.updateavailable_plugin = false;
                        }

                        if (State.updateavailable_plugin &&!State.activeconfig.DisableAutomaticUpdates)
                        {
                            Log.Write("New update available!", Colors.Warning);

                            string caption = componentupdate.title;
                            string message = "New update available: \n\n" + componentupdate.releasenotes + "\n\nDo you want to update now?\n";
                            MessageBoxResult selectedchoice = MessageBox.Show(message, caption, MessageBoxButton.YesNo, MessageBoxImage.Information);
                            accept = selectedchoice.Equals(MessageBoxResult.Yes);
                            return accept;
                        }
                        else
                        {
                            return false;
                        }

                    }

                    if (componentupdate.productid.Equals(Products.Products.Families.Vaicom.ChatterThemePack.product_id))
                    {                        
                        Version currentversionchatter = State.dll_info_chatter.Version;

                        Version onlineversionchatter = new Version();
                        if (Version.TryParse(componentupdate.versionstring, out onlineversionchatter))
                        {
                            State.updateavailable_chatter = componentupdate.isrelease && (onlineversionchatter > currentversionchatter); // sets update bug
                        }
                        else
                        {
                            State.updateavailable_chatter = false;
                        }

                        if (!State.chatterthemesactivated || State.activeconfig.DisableAutomaticUpdates || (componentupdate.isbeta && !State.activeconfig.BetaTester))
                        {
                            State.updateavailable_chatter = false;
                        }

                        if (State.updateavailable_chatter && !State.activeconfig.DisableAutomaticUpdates)
                        {

                            Log.Write("New update available!", Colors.Warning);

                            string caption = componentupdate.title;
                            string message = "New update available: \n\n" + componentupdate.releasenotes + "\n\nDo you want to update now?\n";
                            MessageBoxResult selectedchoice = MessageBox.Show(message, caption, MessageBoxButton.YesNo, MessageBoxImage.Information);
                            accept = selectedchoice.Equals(MessageBoxResult.Yes);
                            return accept;
                        }
                        else
                        {
                            return false;
                        }

                    }

                    if (componentupdate.productid.Equals(Products.Products.Families.Vaicom.RIODialog.product_id))
                    {
                        Version currentversionrio = State.dll_info_rio.Version;

                        Version onlineversionrio = new Version();
                        if (Version.TryParse(componentupdate.versionstring, out onlineversionrio))
                        {
                            State.updateavailable_rio = componentupdate.isrelease && (onlineversionrio > currentversionrio); // sets update bug
                        }
                        else
                        {
                            State.updateavailable_rio = false;
                        }

                        if (!State.jesteractivated || State.activeconfig.DisableAutomaticUpdates || (componentupdate.isbeta && !State.activeconfig.BetaTester))
                        {
                            State.updateavailable_rio = false;
                        }

                        if (State.updateavailable_rio && !State.activeconfig.DisableAutomaticUpdates)
                        {
                            Log.Write("New update available!", Colors.Warning);
                            string caption = componentupdate.title;
                            string message = "New update available: \n\n" + componentupdate.releasenotes + "\n\nDo you want to update now?\n";
                            MessageBoxResult selectedchoice = MessageBox.Show(message, caption, MessageBoxButton.YesNo, MessageBoxImage.Information);
                            accept = selectedchoice.Equals(MessageBoxResult.Yes);
                            return accept;
                        }
                        else
                        {
                            return false;
                        }

                    }

                    return false;
                }

                public static void GetUpdate(string localfolder, UpdateData componentupdate)
                {

                    State.activeconfig.AutomaticUpdateFinished = false;
                    Settings.ConfigFile.WriteConfigToFile(true);

                    Log.Write("Executing automatic update.", Colors.Warning);

                    if (!Directory.Exists(localfolder))
                    {
                        Directory.CreateDirectory(localfolder); 
                    }

                    // get the zip from URL specified in the updates.json/updatesbeta.json/updatesdev.json

                    string packageurl = componentupdate.downloadurl;
                    Log.Write("Downloading package..... ", Colors.Warning);
                    string packagefile = "download"; // local name of file when done

                    try
                    {
                        WebClient myWebClient = new WebClient();
                        myWebClient.DownloadFile(packageurl, localfolder + "\\" + packagefile);
                    }
                    catch
                    {
                        UI.Playsound.Error();
                        Log.Write("There was a problem downloading the update package. Please try again later.", Colors.Warning);
                        Thread.Sleep(1000);
                        return;
                    }

                    Log.Write("Package download complete.", Colors.Warning);
                    Log.Write("Installing...", Colors.Warning);

                    // unzip

                    string extractpath = localfolder + "Package\\";

                    if (Directory.Exists(extractpath))
                    {
                        Directory.Delete(extractpath, true);
                    }

                    ZipFile.ExtractToDirectory(localfolder + packagefile, extractpath);
                    File.Delete(localfolder + packagefile);


                    // now execute batch file to install 

                }

                public static void CleanUpdateFolder()
                {

                    try
                    {

                        string basefolder = State.Proxy.SessionState["VA_APPS"] + "\\" + Products.Products.Families.Vaicom.VaicomProPlugin.rootfoldername + "\\";
                        string localfolder = basefolder + "Updates" + "\\";

                        if (File.Exists(basefolder + "updater.cmd"))
                        {
                            File.Delete(basefolder + "updater.cmd");
                        }

                        if (Directory.Exists(localfolder))
                        {
                            Directory.Delete(localfolder, true);
                        }

                    }
                    catch (Exception e)
                    {
                        Log.Write("Cleanup: " + e.Message, Colors.Text);
                    }

                }

                public static void RunBatchFile(string basefolder, string batchcontentsraw)
                {

                    string batchfile = basefolder + "updater.cmd";
                    string VApath = State.VA_DIR;
     
                    string insertcontent1 = "\"" + VApath + "\\VoiceAttack.exe\"\n";
                    string batchcontents = batchcontentsraw.Replace("XXXXXX", insertcontent1);

                    File.WriteAllText(batchfile, batchcontents);

                    System.Diagnostics.Process proc = new System.Diagnostics.Process();
                    proc.StartInfo.FileName = batchfile;
                    proc.StartInfo.WorkingDirectory = basefolder;
                    proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    
                    State.activeconfig.AutomaticUpdateFinished = true;
                    Settings.ConfigFile.WriteConfigToFile(true);
                    
                    UI.Playsound.Proceed();

                    Thread.Sleep(1500);

                    proc.Start(); // this will terminate the process from here.

                }

                public static bool GetWebUpdateFile(string basefolder, string filename)
                {

                    bool success;

                    try
                    {

                        string URL = "https://raw.githubusercontent.com/Penecruz/VAICOMPRO-Community/Development/VAICOM_Installer/Resources/"; // <-- web URL of the hosted updates.json files
                        string downloadfile = null;
                        Log.Write("Checking for updates... ", Colors.Inline);
                        WebClient myWebClient = new WebClient();
                        downloadfile = URL + filename;
                        myWebClient.DownloadFile(downloadfile, basefolder + filename);

                        success = true;
                    }
                    catch
                    {
                        success = false;
                    }

                    return success;
                }

                public class UpdateData
                {
                    public string   title;
                    public bool     isrelease;
                    public bool     isbeta;
                    public bool     isdev;
                    public Int64    productid;
                    public Int64    releasedate;
                    public Int64    version; // for backwards compatibility
                    public string   versionstring;
                    public string   downloadurl;
                    public string   releasenotes;

                    public UpdateData()
                    {
                        title       = "";
                        isrelease   = false;
                        isbeta      = false;
                        isdev       = false;
                        productid   = 0;
                        releasedate = 0;
                        version     = 0;
                        versionstring = "";
                        downloadurl = "";
                        releasenotes= "";
                    }
                }

                public class UpdateDescriptions
                {
                    public List<UpdateData> updates;
                }

            }
        }
    }
}
