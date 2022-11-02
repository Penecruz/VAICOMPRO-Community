using VAICOM.Static;
using Microsoft.Win32;
using System;
using System.Security.AccessControl;
using System.Runtime.Versioning;

namespace VAICOM
{

    namespace Helpers
    {

        [SupportedOSPlatform("windows")]
        public static class WinReg
        {
            // looks for reg entry for dcs version
            public static string GetDCSInstallFolder(string DCSversionname)
            {
                string keystring = "";
                try
                {
                    RegistryKey getkey = Registry.CurrentUser.OpenSubKey(Products.Products.Families.DCSWorld.RegKeyRoot + "\\" + DCSversionname);
                    keystring = getkey.GetValue("Path").ToString();
                    return keystring;
                }
                catch
                {
                    keystring = null;
                }
                return keystring;
            }


            public static string GetSteamFolder()
            {
                string keystring = "";
                try
                {
                    RegistryKey getkey = Registry.CurrentUser.OpenSubKey("Software\\Valve\\Steam");
                    keystring = getkey.GetValue("SteamPath").ToString();
                    return keystring;
                }
                catch
                {
                    keystring = "";
                }
                return keystring;
            }

            public static string GetDeepSteamFolder()
            {
                string keystring = "";

                try
                {
                    string user = Environment.UserDomainName + "\\" + "Administrators";

                    Log.Write("USER: " + user, Colors.Critical);

                    RegistrySecurity rs = new RegistrySecurity();
                    string keystr = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\Steam App 223750";
                    RegistryKey rk2;

                    // Attempt to change permissions for the key.
                    try
                    {
                        rs = new RegistrySecurity();
                        rs.AddAccessRule(new RegistryAccessRule(user,
                            RegistryRights.ReadKey,
                            InheritanceFlags.None,
                            PropagationFlags.None,
                            AccessControlType.Allow));
;
                        rk2 = Registry.LocalMachine.OpenSubKey(keystr);
                        rk2.SetAccessControl(rs);

                        keystring = rk2.GetValue("InstallLocation").ToString();

                    }
                    catch (UnauthorizedAccessException)
                    {
                        Log.Write("ACCED DENIED", Colors.Critical);

                    }

                    return keystring;
                }
                catch(Exception e)
                {
                    keystring = e.InnerException.Message;
                }

                return keystring;
            }
        }
    }
}
