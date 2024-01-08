using System;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace VAICOM
{

    namespace Framework
    {

        public sealed class SpecialFolder
        {

            public SpecialFolder(SpecialFolderTypes type)
                : this(type, WindowsIdentity.GetCurrent())
            {
            }

            public SpecialFolder(SpecialFolderTypes type, WindowsIdentity identity)
            {
                Type = type;
                Identity = identity;
            }


            public SpecialFolderTypes Type
            {
                get;
                private set;
            }

            public WindowsIdentity Identity
            {
                get;
                private set;
            }

            public string DefaultPath
            {
                get
                {
                    return GetPath(KnownFolderFlags.DontVerify | KnownFolderFlags.DefaultPath);
                }
                set
                {
                }
            }

            public string Path
            {
                get
                {
                    return GetPath(KnownFolderFlags.DontVerify);
                }
                set
                {
                    SetPath(KnownFolderFlags.None, value);
                }
            }

            public string ExpandedPath
            {
                get
                {
                    return GetPath(KnownFolderFlags.DontVerify | KnownFolderFlags.NoAlias);
                }
                set
                {
                    SetPath(KnownFolderFlags.DontUnexpand, value);
                }
            }

            public void Create()
            {
                GetPath(KnownFolderFlags.Init | KnownFolderFlags.Create);
            }

            private string GetPath(KnownFolderFlags flags)
            {
                IntPtr outPath;
                int result = SHGetKnownFolderPath(Type.GetGuid(), (uint)flags, Identity.Token, out outPath);
                if (result >= 0)
                {
                    return Marshal.PtrToStringUni(outPath);
                }
                else
                {
                    throw new ExternalException("Cannot get the known folder path. It may not be available on this system.",
                        result);
                }
            }

            private void SetPath(KnownFolderFlags flags, string path)
            {
                int result = SHSetKnownFolderPath(Type.GetGuid(), (uint)flags, Identity.Token, path);
                if (result < 0)
                {
                    throw new ExternalException("Cannot set the known folder path. It may not be available on this system.",
                        result);
                }
            }

            [DllImport("Shell32.dll")]
            private static extern int SHGetKnownFolderPath([MarshalAs(UnmanagedType.LPStruct)] Guid rfid, uint dwFlags,
                IntPtr hToken, out IntPtr ppszPath);

            [DllImport("Shell32.dll")]
            private static extern int SHSetKnownFolderPath([MarshalAs(UnmanagedType.LPStruct)] Guid rfid, uint dwFlags,
                IntPtr hToken, [MarshalAs(UnmanagedType.LPWStr)] string pszPath);

            [Flags]
            private enum KnownFolderFlags : uint
            {
                None = 0x00000000,
                SimpleIDList = 0x00000100,
                NotParentRelative = 0x00000200,
                DefaultPath = 0x00000400,
                Init = 0x00000800,
                NoAlias = 0x00001000,
                DontUnexpand = 0x00002000,
                DontVerify = 0x00004000,
                Create = 0x00008000,
                NoAppcontainerRedirection = 0x00010000,
                AliasOnly = 0x80000000
            }
        }
    }
}
