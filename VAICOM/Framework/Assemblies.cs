using VAICOM.Static;
using System;
using System.Reflection;

namespace VAICOM
{
    namespace Framework
    {
        public partial class Assemblies
        {
            public static void GetAssembliesInfo_Plugin()
            {
                //plugin
                try
                {
                    State.dll_info_plugin = Assembly.GetExecutingAssembly().GetName();
                    State.dll_version_plugin = State.dll_info_plugin.Version.ToString();
                    State.dll_installed_plugin = true;
                }
                catch
                {
                }
            }

            public static void GetAssembliesInfo_Chatter()
            {
                // chatter
                try
                {
                    State.dll_info_chatter = Assembly.GetAssembly(typeof(Themepack.Default)).GetName();
                    State.dll_version_chatter = State.dll_info_chatter.Version.ToString();
                    State.dll_installed_chatter = true;
                }
                catch
                {
                }
            }

            public static void GetAssembliesInfo_Rio()
            {
                // RIO
                try
                {
                    State.dll_info_rio = Assembly.GetAssembly(typeof(Extensions.RIO.DeviceActionsLibrary)).GetName();
                    if (State.dll_info_rio.Version.ToString().Equals("0.0.0.0"))
                    {
                        State.dll_info_rio = new AssemblyName() { Version = Version.Parse("2.8.0.0")};
                        State.dll_version_rio = "(not installed)";
                        State.dll_installed_rio = false;
                    }
                    else
                    {
                        State.dll_version_rio = State.dll_info_rio.Version.ToString();
                        State.dll_installed_rio = true;
                    }
                }
                catch
                {
                }
            }


            public static Assembly AssemblyResolve(object sender, ResolveEventArgs args)
            {

                try
                {

                    string missingassembly = args.Name.ToString().ToLower();

                    if (missingassembly.Equals("sound"))
                    {

                        using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("VAICOM.Embed.Sound.dll"))
                        {
                            byte[] assemblyData = new byte[stream.Length];
                            stream.Read(assemblyData, 0, assemblyData.Length);
                            return Assembly.Load(assemblyData);
                        }
                    }

                    if (missingassembly.StartsWith("newtonsoft.json"))
                    {

                        using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("VAICOM.Embed.Newtonsoft.Json.dll"))
                        {
                            byte[] assemblyData = new byte[stream.Length];
                            stream.Read(assemblyData, 0, assemblyData.Length);
                            return Assembly.Load(assemblyData);
                        }
                    }

                    if (missingassembly.StartsWith("naudio.vorbis"))
                    {

                        using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("VAICOM.Embed.NAudio.Vorbis.dll"))
                        {
                            byte[] assemblyData = new byte[stream.Length];
                            stream.Read(assemblyData, 0, assemblyData.Length);
                            return Assembly.Load(assemblyData);
                        }
                    }

                    if (missingassembly.StartsWith("naudio") && !missingassembly.Contains("vorbis"))
                    {

                        using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("VAICOM.Embed.NAudio.dll"))
                        {
                            byte[] assemblyData = new byte[stream.Length];
                            stream.Read(assemblyData, 0, assemblyData.Length);
                            return Assembly.Load(assemblyData);
                        }
                    }

                    if (missingassembly.StartsWith("nvorbis"))
                    {
  
                        using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("VAICOM.Embed.NVorbis.dll"))
                        {
                            byte[] assemblyData = new byte[stream.Length];
                            stream.Read(assemblyData, 0, assemblyData.Length);
                            return Assembly.Load(assemblyData);
                        }
                    }

                    if (missingassembly.StartsWith("chatter"))
                    {
                        return null;
                    }

                    if (missingassembly.StartsWith("airio"))
                    {
                        using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream("VAICOM.Embed.AIRIO.dll"))
                        {
                            byte[] assemblyData = new byte[stream.Length];
                            stream.Read(assemblyData, 0, assemblyData.Length);
                            return Assembly.Load(assemblyData);
                        }
                    }

                    return null;

                }
                catch (Exception e)
                {
                    State.Proxy.WriteToLog("DLL resolve error: " + e.StackTrace, Colors.Text);
                    return null;
                }
            }
        }
    }
}
