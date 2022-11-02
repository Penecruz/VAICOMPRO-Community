using System.Collections.Generic;
using System.Runtime.Versioning;

namespace VAICOM {

    namespace Framework {


        [SupportedOSPlatform("windows")]
        public static class SpecialFolderInstances {

            private static Dictionary<SpecialFolderTypes, SpecialFolder> _knownFolderInstances;

            #region ---- Typed KnownFolder Instances ----
            /// <summary>
            /// The per-user Account Pictures folder. Introduced in Windows 8.
            /// Defaults to &quot;%APPDATA%\Microsoft\Windows\AccountPictures&quot;.
            /// </summary>
            public static SpecialFolder AccountPictures {
                get { return GetInstance(SpecialFolderTypes.AccountPictures); }
            }

            /// <summary>
            /// The per-user Administrative Tools folder.
            /// Defaults to &quot;%APPDATA%\Microsoft\Windows\Start Menu\Programs\Administrative Tools&quot;.
            /// </summary>
            public static SpecialFolder AdminTools {
                get { return GetInstance(SpecialFolderTypes.AdminTools); }
            }

            /// <summary>
            /// The per-user Application Shortcuts folder. Introduced in Windows 8.
            /// Defaults to &quot;%LOCALAPPDATA%\Microsoft\Windows\Application Shortcuts&quot;.
            /// </summary>
            public static SpecialFolder ApplicationShortcuts {
                get { return GetInstance(SpecialFolderTypes.ApplicationShortcuts); }
            }

            /// <summary>
            /// The per-user Camera Roll folder. Introduced in Windows 8.1.
            /// Defaults to &quot;.%USERPROFILE%\Pictures\Camera Roll&quot;.
            /// </summary>
            public static SpecialFolder CameraRoll {
                get { return GetInstance(SpecialFolderTypes.CameraRoll); }
            }

            /// <summary>
            /// The per-user Temporary Burn Folder.
            /// Defaults to &quot;%LOCALAPPDATA%\Microsoft\Windows\Burn\Burn&quot;.
            /// </summary>
            public static SpecialFolder CDBurning {
                get { return GetInstance(SpecialFolderTypes.CDBurning); }
            }

            /// <summary>
            /// The common Administrative Tools folder.
            /// Defaults to &quot;%ALLUSERSPROFILE%\Microsoft\Windows\Start Menu\Programs\Administrative Tools&quot;.
            /// </summary>
            public static SpecialFolder CommonAdminTools {
                get { return GetInstance(SpecialFolderTypes.CommonAdminTools); }
            }

            /// <summary>
            /// The common OEM Links folder.
            /// Defaults to &quot;%ALLUSERSPROFILE%\OEM Links&quot;.
            /// </summary>
            public static SpecialFolder CommonOemLinks {
                get { return GetInstance(SpecialFolderTypes.CommonOemLinks); }
            }

            /// <summary>
            /// The common Programs folder.
            /// Defaults to &quot;%ALLUSERSPROFILE%\Microsoft\Windows\Start Menu\Programs&quot;.
            /// </summary>
            public static SpecialFolder CommonPrograms {
                get { return GetInstance(SpecialFolderTypes.CommonPrograms); }
            }

            /// <summary>
            /// The common Start Menu folder.
            /// Defaults to &quot;%ALLUSERSPROFILE%\Microsoft\Windows\Start Menu&quot;.
            /// </summary>
            public static SpecialFolder CommonStartMenu {
                get { return GetInstance(SpecialFolderTypes.CommonStartMenu); }
            }

            /// <summary>
            /// The common Startup folder.
            /// Defaults to &quot;%ALLUSERSPROFILE%\Microsoft\Windows\Start Menu\Programs\StartUp&quot;.
            /// </summary>
            public static SpecialFolder CommonStartup {
                get { return GetInstance(SpecialFolderTypes.CommonStartup); }
            }

            /// <summary>
            /// The common Templates folder.
            /// Defaults to &quot;%ALLUSERSPROFILE%\Microsoft\Windows\Templates&quot;.
            /// </summary>
            public static SpecialFolder CommonTemplates {
                get { return GetInstance(SpecialFolderTypes.CommonTemplates); }
            }

            /// <summary>
            /// The per-user Contacts folder. Introduced in Windows Vista.
            /// Defaults to &quot;%USERPROFILE%\Contacts&quot;.
            /// </summary>
            public static SpecialFolder Contacts {
                get { return GetInstance(SpecialFolderTypes.Contacts); }
            }

            /// <summary>
            /// The per-user Cookies folder.
            /// Defaults to &quot;%APPDATA%\Microsoft\Windows\Cookies&quot;.
            /// </summary>
            public static SpecialFolder Cookies {
                get { return GetInstance(SpecialFolderTypes.Cookies); }
            }

            /// <summary>
            /// The per-user Desktop folder.
            /// Defaults to &quot;%USERPROFILE%\Desktop&quot;.
            /// </summary>
            public static SpecialFolder Desktop {
                get { return GetInstance(SpecialFolderTypes.Desktop); }
            }

            /// <summary>
            /// The common DeviceMetadataStore folder. Introduced in Windows 7.
            /// Defaults to &quot;%ALLUSERSPROFILE%\Microsoft\Windows\DeviceMetadataStore&quot;.
            /// </summary>
            public static SpecialFolder DeviceMetadataStore {
                get { return GetInstance(SpecialFolderTypes.DeviceMetadataStore); }
            }

            /// <summary>
            /// The per-user Documents folder.
            /// Defaults to &quot;%USERPROFILE%\Documents&quot;.
            /// </summary>
            public static SpecialFolder Documents {
                get { return GetInstance(SpecialFolderTypes.Documents); }
            }

            /// <summary>
            /// The per-user Documents library. Introduced in Windows 7.
            /// Defaults to &quot;%APPDATA%\Microsoft\Windows\Libraries\Documents.library-ms&quot;.
            /// </summary>
            public static SpecialFolder DocumentsLibrary {
                get { return GetInstance(SpecialFolderTypes.DocumentsLibrary); }
            }

            /// <summary>
            /// The per-user Downloads folder.
            /// Defaults to &quot;%USERPROFILE%\Downloads&quot;.
            /// </summary>
            public static SpecialFolder Downloads {
                get { return GetInstance(SpecialFolderTypes.Downloads); }
            }

            /// <summary>
            /// The per-user Favorites folder.
            /// Defaults to &quot;%USERPROFILE%\Favorites&quot;.
            /// </summary>
            public static SpecialFolder Favorites {
                get { return GetInstance(SpecialFolderTypes.Favorites); }
            }

            /// <summary>
            /// The fixed Fonts folder.
            /// Points to &quot;%WINDIR%\Fonts&quot;.
            /// </summary>
            public static SpecialFolder Fonts {
                get { return GetInstance(SpecialFolderTypes.Fonts); }
            }

            /// <summary>
            /// The per-user GameExplorer folder. Introduced in Windows Vista.
            /// Defaults to &quot;%LOCALAPPDATA%\Microsoft\Windows\GameExplorer&quot;.
            /// </summary>
            public static SpecialFolder GameTasks {
                get { return GetInstance(SpecialFolderTypes.GameTasks); }
            }

            /// <summary>
            /// The per-user History folder.
            /// Defaults to &quot;%LOCALAPPDATA%\Microsoft\Windows\History&quot;.
            /// </summary>
            public static SpecialFolder History {
                get { return GetInstance(SpecialFolderTypes.History); }
            }

            /// <summary>
            /// The per-user ImplicitAppShortcuts folder. Introduced in Windows 7.
            /// Defaults to &quot;%APPDATA%\Microsoft\Internet Explorer\Quick Launch\User Pinned\ImplicitAppShortcuts&quot;.
            /// </summary>
            public static SpecialFolder ImplicitAppShortcuts {
                get { return GetInstance(SpecialFolderTypes.ImplicitAppShortcuts); }
            }

            /// <summary>
            /// The per-user Temporary Internet Files folder.
            /// Defaults to &quot;%LOCALAPPDATA%\Microsoft\Windows\Temporary Internet Files&quot;.
            /// </summary>
            public static SpecialFolder InternetCache {
                get { return GetInstance(SpecialFolderTypes.InternetCache); }
            }

            /// <summary>
            /// The per-user Libraries folder. Introduced in Windows 7.
            /// Defaults to &quot;%APPDATA%\Microsoft\Windows\Libraries&quot;.
            /// </summary>
            public static SpecialFolder Libraries {
                get { return GetInstance(SpecialFolderTypes.Libraries); }
            }

            /// <summary>
            /// The per-user Links folder.
            /// Defaults to &quot;%USERPROFILE%\Links&quot;.
            /// </summary>
            public static SpecialFolder Links {
                get { return GetInstance(SpecialFolderTypes.Links); }
            }

            /// <summary>
            /// The per-user Local folder.
            /// Defaults to &quot;%LOCALAPPDATA%&quot; (&quot;%USERPROFILE%\AppData\Local&quot;)&quot;.
            /// </summary>
            public static SpecialFolder LocalAppData {
                get { return GetInstance(SpecialFolderTypes.LocalAppData); }
            }

            /// <summary>
            /// The per-user LocalLow folder.
            /// Defaults to &quot;%USERPROFILE%\AppData\LocalLow&quot;.
            /// </summary>
            public static SpecialFolder LocalAppDataLow {
                get { return GetInstance(SpecialFolderTypes.LocalAppDataLow); }
            }

            /// <summary>
            /// The fixed LocalizedResourcesDir folder.
            /// Points to &quot;%WINDIR%\resources\0409&quot; (code page).
            /// </summary>
            public static SpecialFolder LocalizedResourcesDir {
                get { return GetInstance(SpecialFolderTypes.LocalizedResourcesDir); }
            }

            /// <summary>
            /// The per-user Music folder.
            /// Defaults to &quot;%USERPROFILE%\Music&quot;.
            /// </summary>
            public static SpecialFolder Music {
                get { return GetInstance(SpecialFolderTypes.Music); }
            }

            /// <summary>
            /// The per-user Music library. Introduced in Windows 7.
            /// Defaults to &quot;%APPDATA%\Microsoft\Windows\Libraries\Music.library-ms&quot;.
            /// </summary>
            public static SpecialFolder MusicLibrary {
                get { return GetInstance(SpecialFolderTypes.MusicLibrary); }
            }

            /// <summary>
            /// The per-user Network Shortcuts folder.
            /// Defaults to &quot;%APPDATA%\Microsoft\Windows\Network Shortcuts&quot;.
            /// </summary>
            public static SpecialFolder NetHood {
                get { return GetInstance(SpecialFolderTypes.NetHood); }
            }

            /// <summary>
            /// The per-user Original Images folder. Introduced in Windows Vista.
            /// Defaults to &quot;%LOCALAPPDATA%\Microsoft\Windows Photo Gallery\Original Images&quot;.
            /// </summary>
            public static SpecialFolder OriginalImages {
                get { return GetInstance(SpecialFolderTypes.OriginalImages); }
            }

            /// <summary>
            /// The per-user Slide Shows folder. Introduced in Windows Vista.
            /// Defaults to &quot;%USERPROFILE%\Pictures\Slide Shows&quot;.
            /// </summary>
            public static SpecialFolder PhotoAlbums {
                get { return GetInstance(SpecialFolderTypes.PhotoAlbums); }
            }

            /// <summary>
            /// The per-user Pictures library. Introduced in Windows 7.
            /// Defaults to &quot;%APPDATA%\Microsoft\Windows\Libraries\Pictures.library-ms&quot;.
            /// </summary>
            public static SpecialFolder PicturesLibrary {
                get { return GetInstance(SpecialFolderTypes.PicturesLibrary); }
            }

            /// <summary>
            /// The per-user Pictures folder.
            /// Defaults to &quot;%USERPROFILE%\Pictures&quot;.
            /// </summary>
            public static SpecialFolder Pictures {
                get { return GetInstance(SpecialFolderTypes.Pictures); }
            }

            /// <summary>
            /// The per-user Playlists folder.
            /// Defaults to &quot;%USERPROFILE%\Music\Playlists&quot;.
            /// </summary>
            public static SpecialFolder Playlists {
                get { return GetInstance(SpecialFolderTypes.Playlists); }
            }

            /// <summary>
            /// The per-user Printer Shortcuts folder.
            /// Defaults to &quot;%APPDATA%\Microsoft\Windows\Printer Shortcuts&quot;.
            /// </summary>
            public static SpecialFolder PrintHood {
                get { return GetInstance(SpecialFolderTypes.PrintHood); }
            }

            /// <summary>
            /// The fixed user profile folder.
            /// Defaults to &quot;%USERPROFILE%&quot; (&quot;%SYSTEMDRIVE%\USERS\%USERNAME%&quot;)&quot;.
            /// </summary>
            public static SpecialFolder Profile {
                get { return GetInstance(SpecialFolderTypes.Profile); }
            }

            /// <summary>
            /// The fixed ProgramData folder.
            /// Points to &quot;%ALLUSERSPROFILE%&quot; (&quot;%PROGRAMDATA%&quot;, &quot;%SYSTEMDRIVE%\ProgramData&quot;).
            /// </summary>
            public static SpecialFolder ProgramData {
                get { return GetInstance(SpecialFolderTypes.ProgramData); }
            }

            /// <summary>
            /// The fixed Program Files folder.
            /// This is the same as the <see cref="ProgramFilesX86"/> known folder in 32-bit applications or the
            /// <see cref="ProgramFilesX64"/> known folder in 64-bit applications.
            /// Points to %SYSTEMDRIVE%\Program Files on a 32-bit operating system or in 64-bit applications on a 64-bit
            /// operating system and to %SYSTEMDRIVE%\Program Files (x86) in 32-bit applications on a 64-bit operating
            /// system.
            /// </summary>
            public static SpecialFolder ProgramFiles {
                get { return GetInstance(SpecialFolderTypes.ProgramFiles); }
            }

            /// <summary>
            /// The fixed Program Files folder (64-bit forced).
            /// This known folder is unsupported in 32-bit applications.
            /// Points to %SYSTEMDRIVE%\Program Files.
            /// </summary>
            public static SpecialFolder ProgramFilesX64 {
                get { return GetInstance(SpecialFolderTypes.ProgramFilesX64); }
            }

            /// <summary>
            /// The fixed Program Files folder (32-bit forced).
            /// This is the same as the <see cref="ProgramFiles"/> known folder in 32-bit applications.
            /// Points to &quot;%SYSTEMDRIVE%\Program Files&quot; on a 32-bit operating system and to
            /// &quot;%SYSTEMDRIVE%\Program Files (x86)&quot; on a 64-bit operating system.
            /// </summary>
            public static SpecialFolder ProgramFilesX86 {
                get { return GetInstance(SpecialFolderTypes.ProgramFilesX86); }
            }

            /// <summary>
            /// The fixed Common Files folder.
            /// This is the same as the <see cref="ProgramFilesCommonX86"/> known folder in 32-bit applications or the
            /// <see cref="ProgramFilesCommonX64"/> known folder in 64-bit applications.
            /// Points to&quot; %PROGRAMFILES%\Common Files&quot; on a 32-bit operating system or in 64-bit applications on
            /// a 64-bit operating system and to &quot;%PROGRAMFILES(X86)%\Common Files&quot; in 32-bit applications on a
            /// 64-bit operating system.
            /// </summary>
            public static SpecialFolder ProgramFilesCommon {
                get { return GetInstance(SpecialFolderTypes.ProgramFilesCommon); }
            }

            /// <summary>
            /// The fixed Common Files folder (64-bit forced).
            /// This known folder is unsupported in 32-bit applications.
            /// Points to &quot;%PROGRAMFILES%\Common Files&quot;.
            /// </summary>
            public static SpecialFolder ProgramFilesCommonX64 {
                get { return GetInstance(SpecialFolderTypes.ProgramFilesCommonX64); }
            }

            /// <summary>
            /// The fixed Common Files folder (32-bit forced).
            /// This is the same as the <see cref="ProgramFilesCommon"/> known folder in 32-bit applications.
            /// Points to &quot;%PROGRAMFILES%\Common Files&quot; on a 32-bit operating system and to
            /// &quot;%PROGRAMFILES(X86)%\Common Files&quot; on a 64-bit operating system.
            /// </summary>
            public static SpecialFolder ProgramFilesCommonX86 {
                get { return GetInstance(SpecialFolderTypes.ProgramFilesCommonX86); }
            }

            /// <summary>
            /// The per-user Programs folder.
            /// Defaults to &quot;%APPDATA%\Microsoft\Windows\Start Menu\Programs&quot;.
            /// </summary>
            public static SpecialFolder Programs {
                get { return GetInstance(SpecialFolderTypes.Programs); }
            }

            /// <summary>
            /// The fixed Public folder. Introduced in Windows Vista.
            /// Defaults to &quot;%PUBLIC%&quot; (&quot;%SYSTEMDRIVE%\Users\Public)&quot;.
            /// </summary>
            public static SpecialFolder Public {
                get { return GetInstance(SpecialFolderTypes.Public); }
            }

            /// <summary>
            /// The common Public Desktop folder.
            /// Defaults to &quot;%PUBLIC%\Desktop&quot;.
            /// </summary>
            public static SpecialFolder PublicDesktop {
                get { return GetInstance(SpecialFolderTypes.PublicDesktop); }
            }

            /// <summary>
            /// The common Public Documents folder.
            /// Defaults to &quot;%PUBLIC%\Documents&quot;.
            /// </summary>
            public static SpecialFolder PublicDocuments {
                get { return GetInstance(SpecialFolderTypes.PublicDocuments); }
            }

            /// <summary>
            /// The common Public Downloads folder. Introduced in Windows Vista.
            /// Defaults to &quot;%PUBLIC%\Downloads&quot;.
            /// </summary>
            public static SpecialFolder PublicDownloads {
                get { return GetInstance(SpecialFolderTypes.PublicDownloads); }
            }

            /// <summary>
            /// The common GameExplorer folder. Introduced in Windows Vista.
            /// Defaults to &quot;%ALLUSERSPROFILE%\Microsoft\Windows\GameExplorer&quot;.
            /// </summary>
            public static SpecialFolder PublicGameTasks {
                get { return GetInstance(SpecialFolderTypes.PublicGameTasks); }
            }

            /// <summary>
            /// The common Libraries folder. Introduced in Windows 7.
            /// Defaults to &quot;%ALLUSERSPROFILE%\Microsoft\Windows\Libraries&quot;.
            /// </summary>
            public static SpecialFolder PublicLibraries {
                get { return GetInstance(SpecialFolderTypes.PublicLibraries); }
            }

            /// <summary>
            /// The common Public Music folder.
            /// Defaults to &quot;%PUBLIC%\Music&quot;.
            /// </summary>
            public static SpecialFolder PublicMusic {
                get { return GetInstance(SpecialFolderTypes.PublicMusic); }
            }

            /// <summary>
            /// The common Public Pictures folder.
            /// Defaults to &quot;%PUBLIC%\Pictures&quot;.
            /// </summary>
            public static SpecialFolder PublicPictures {
                get { return GetInstance(SpecialFolderTypes.PublicPictures); }
            }

            /// <summary>
            /// The common Ringtones folder. Introduced in Windows 7.
            /// Defaults to &quot;%ALLUSERSPROFILE%\Microsoft\Windows\Ringtones&quot;.
            /// </summary>
            public static SpecialFolder PublicRingtones {
                get { return GetInstance(SpecialFolderTypes.PublicRingtones); }
            }

            /// <summary>
            /// The common Public Account Pictures folder. Introduced in Windows 8.
            /// Defaults to &quot;%PUBLIC%\AccountPictures&quot;.
            /// </summary>
            public static SpecialFolder PublicUserTiles {
                get { return GetInstance(SpecialFolderTypes.PublicUserTiles); }
            }

            /// <summary>
            /// The common Public Videos folder.
            /// Defaults to &quot;%PUBLIC%\Videos&quot;.
            /// </summary>
            public static SpecialFolder PublicVideos {
                get { return GetInstance(SpecialFolderTypes.PublicVideos); }
            }

            /// <summary>
            /// The per-user Quick Launch folder.
            /// Defaults to &quot;%APPDATA%\Microsoft\Internet Explorer\Quick Launch&quot;.
            /// </summary>
            public static SpecialFolder QuickLaunch {
                get { return GetInstance(SpecialFolderTypes.QuickLaunch); }
            }

            /// <summary>
            /// The per-user Recent Items folder.
            /// Defaults to &quot;%APPDATA%\Microsoft\Windows\Recent&quot;.
            /// </summary>
            public static SpecialFolder Recent {
                get { return GetInstance(SpecialFolderTypes.Recent); }
            }

            /// <summary>
            /// The common Recorded TV library. Introduced in Windows 7.
            /// Defaults to &quot;%PUBLIC%\RecordedTV.library-ms&quot;.
            /// </summary>
            public static SpecialFolder RecordedTVLibrary {
                get { return GetInstance(SpecialFolderTypes.RecordedTVLibrary); }
            }

            /// <summary>
            /// The fixed Resources folder.
            /// Points to &quot;%WINDIR%\Resources&quot;.
            /// </summary>
            public static SpecialFolder ResourceDir {
                get { return GetInstance(SpecialFolderTypes.ResourceDir); }
            }

            /// <summary>
            /// The per-user Ringtones folder. Introduced in Windows 7.
            /// Defaults to &quot;%LOCALAPPDATA%\Microsoft\Windows\Ringtones&quot;.
            /// </summary>
            public static SpecialFolder Ringtones {
                get { return GetInstance(SpecialFolderTypes.Ringtones); }
            }

            /// <summary>
            /// The per-user Roaming folder.
            /// Defaults to &quot;%APPDATA%&quot; (&quot;%USERPROFILE%\AppData\Roaming&quot;).
            /// </summary>
            public static SpecialFolder RoamingAppData {
                get { return GetInstance(SpecialFolderTypes.RoamingAppData); }
            }

            /// <summary>
            /// The per-user RoamedTileImages folder. Introduced in Windows 8.
            /// Defaults to &quot;%LOCALAPPDATA%\Microsoft\Windows\RoamedTileImages&quot;.
            /// </summary>
            public static SpecialFolder RoamedTileImages {
                get { return GetInstance(SpecialFolderTypes.RoamedTileImages); }
            }

            /// <summary>
            /// The per-user RoamingTiles folder. Introduced in Windows 8.
            /// Defaults to &quot;%LOCALAPPDATA%\Microsoft\Windows\RoamingTiles&quot;.
            /// </summary>
            public static SpecialFolder RoamingTiles {
                get { return GetInstance(SpecialFolderTypes.RoamingTiles); }
            }

            /// <summary>
            /// The common Sample Music folder.
            /// Defaults to &quot;%PUBLIC%\Music\Sample Music&quot;.
            /// </summary>
            public static SpecialFolder SampleMusic {
                get { return GetInstance(SpecialFolderTypes.SampleMusic); }
            }

            /// <summary>
            /// The common Sample Pictures folder.
            /// Defaults to &quot;%PUBLIC%\Pictures\Sample Pictures&quot;.
            /// </summary>
            public static SpecialFolder SamplePictures {
                get { return GetInstance(SpecialFolderTypes.SamplePictures); }
            }

            /// <summary>
            /// The common Sample Playlists folder. Introduced in Windows Vista.
            /// Defaults to &quot;%PUBLIC%\Music\Sample Playlists&quot;.
            /// </summary>
            public static SpecialFolder SamplePlaylists {
                get { return GetInstance(SpecialFolderTypes.SamplePlaylists); }
            }

            /// <summary>
            /// The common Sample Videos folder.
            /// Defaults to &quot;%PUBLIC%\Videos\Sample Videos&quot;.
            /// </summary>
            public static SpecialFolder SampleVideos {
                get { return GetInstance(SpecialFolderTypes.SampleVideos); }
            }

            /// <summary>
            /// The per-user Saved Games folder. Introduced in Windows Vista.
            /// Defaults to &quot;%USERPROFILE%\Saved Games&quot;.
            /// </summary>
            public static SpecialFolder SavedGames {
                get { return GetInstance(SpecialFolderTypes.SavedGames); }
            }

            /// <summary>
            /// The per-user Searches folder.
            /// Defaults to &quot;%USERPROFILE%\Searches&quot;.
            /// </summary>
            public static SpecialFolder SavedSearches {
                get { return GetInstance(SpecialFolderTypes.SavedSearches); }
            }

            /// <summary>
            /// The per-user Screenshots folder. Introduced in Windows 8.
            /// Defaults to &quot;%USERPROFILE%\Pictures\Screenshots&quot;.
            /// </summary>
            public static SpecialFolder Screenshots {
                get { return GetInstance(SpecialFolderTypes.Screenshots); }
            }

            /// <summary>
            /// The per-user History folder. Introduced in Windows 8.1.
            /// Defaults to &quot;%LOCALAPPDATA%\Microsoft\Windows\ConnectedSearch\History&quot;.
            /// </summary>
            public static SpecialFolder SearchHistory {
                get { return GetInstance(SpecialFolderTypes.SearchHistory); }
            }

            /// <summary>
            /// The per-user Templates folder. Introduced in Windows 8.1.
            /// Defaults to &quot;%LOCALAPPDATA%\Microsoft\Windows\ConnectedSearch\Templates&quot;.
            /// </summary>
            public static SpecialFolder SearchTemplates {
                get { return GetInstance(SpecialFolderTypes.SearchTemplates); }
            }

            /// <summary>
            /// The per-user SendTo folder.
            /// Defaults to &quot;%APPDATA%\Microsoft\Windows\SendTo&quot;.
            /// </summary>
            public static SpecialFolder SendTo {
                get { return GetInstance(SpecialFolderTypes.SendTo); }
            }

            /// <summary>
            /// The common Gadgets folder. Introduced in Windows 7.
            /// Defaults to &quot;%ProgramFiles%\Windows Sidebar\Gadgets&quot;.
            /// </summary>
            public static SpecialFolder SidebarDefaultParts {
                get { return GetInstance(SpecialFolderTypes.SidebarDefaultParts); }
            }

            /// <summary>
            /// The per-user Gadgets folder. Introduced in Windows 7.
            /// Defaults to &quot;%LOCALAPPDATA%\Microsoft\Windows Sidebar\Gadgets&quot;.
            /// </summary>
            public static SpecialFolder SidebarParts {
                get { return GetInstance(SpecialFolderTypes.SidebarParts); }
            }

            /// <summary>
            /// The per-user OneDrive folder. Introduced in Windows 8.1.
            /// Defaults to &quot;%USERPROFILE%\OneDrive&quot;.
            /// </summary>
            public static SpecialFolder SkyDrive {
                get { return GetInstance(SpecialFolderTypes.SkyDrive); }
            }

            /// <summary>
            /// The per-user OneDrive Camera Roll folder. Introduced in Windows 8.1.
            /// Defaults to &quot;%USERPROFILE%\OneDrive\Pictures\Camera Roll&quot;.
            /// </summary>
            public static SpecialFolder SkyDriveCameraRoll {
                get { return GetInstance(SpecialFolderTypes.SkyDriveCameraRoll); }
            }

            /// <summary>
            /// The per-user OneDrive Documents folder. Introduced in Windows 8.1.
            /// Defaults to &quot;%USERPROFILE%\OneDrive\Documents&quot;.
            /// </summary>
            public static SpecialFolder SkyDriveDocuments {
                get { return GetInstance(SpecialFolderTypes.SkyDriveDocuments); }
            }

            /// <summary>
            /// The per-user OneDrive Pictures folder. Introduced in Windows 8.1.
            /// Defaults to &quot;%USERPROFILE%\OneDrive\Pictures&quot;.
            /// </summary>
            public static SpecialFolder SkyDrivePictures {
                get { return GetInstance(SpecialFolderTypes.SkyDrivePictures); }
            }

            /// <summary>
            /// The per-user Start Menu folder.
            /// Defaults to &quot;%APPDATA%\Microsoft\Windows\Start Menu&quot;.
            /// </summary>
            public static SpecialFolder StartMenu {
                get { return GetInstance(SpecialFolderTypes.StartMenu); }
            }

            /// <summary>
            /// The per-user Startup folder.
            /// Defaults to &quot;%APPDATA%\Microsoft\Windows\Start Menu\Programs\StartUp&quot;.
            /// </summary>
            public static SpecialFolder Startup {
                get { return GetInstance(SpecialFolderTypes.Startup); }
            }

            /// <summary>
            /// The fixed System32 folder.
            /// This is the same as the <see cref="SystemX86"/> known folder in 32-bit applications.
            /// Points to &quot;%WINDIR%\system32&quot; on 32-bit operating systems or in 64-bit applications on a 64-bit
            /// operating system and to &quot;%WINDIR%\syswow64&quot; in 32-bit applications on a 64-bit operating system.
            /// </summary>
            public static SpecialFolder System {
                get { return GetInstance(SpecialFolderTypes.System); }
            }

            /// <summary>
            /// The fixed System32 folder (32-bit forced).
            /// This is the same as the <see cref="System"/> known folder in 32-bit applications.
            /// Points to &quot;%WINDIR%\syswow64&quot; in 64-bit applications or in 32-bit applications on a 64-bit
            /// operating system and to &quot;%WINDIR%\system32&quot; on 32-bit operating systems.
            /// </summary>
            public static SpecialFolder SystemX86 {
                get { return GetInstance(SpecialFolderTypes.SystemX86); }
            }

            /// <summary>
            /// The per-user Templates folder.
            /// Defaults to &quot;%APPDATA%\Microsoft\Windows\Templates&quot;.
            /// </summary>
            public static SpecialFolder Templates {
                get { return GetInstance(SpecialFolderTypes.Templates); }
            }

            /// <summary>
            /// The per-user User Pinned folder. Introduced in Windows 7.
            /// Defaults to &quot;%APPDATA%\Microsoft\Internet Explorer\Quick Launch\User Pinned&quot;.
            /// </summary>
            public static SpecialFolder UserPinned {
                get { return GetInstance(SpecialFolderTypes.UserPinned); }
            }

            /// <summary>
            /// The fixed Users folder. Introduced in Windows Vista.
            /// Points to &quot;%SYSTEMDRIVE%\Users&quot;.
            /// </summary>
            public static SpecialFolder UserProfiles {
                get { return GetInstance(SpecialFolderTypes.UserProfiles); }
            }

            /// <summary>
            /// The per-user Programs folder. Introduced in Windows 7.
            /// Defaults to &quot;%LOCALAPPDATA%\Programs.&quot;.
            /// </summary>
            public static SpecialFolder UserProgramFiles {
                get { return GetInstance(SpecialFolderTypes.UserProgramFiles); }
            }

            /// <summary>
            /// The per-user common Programs folder. INtroduced in Windows 7.
            /// Defaults to &quot;%LOCALAPPDATA%\Programs\Common&quot;.
            /// </summary>
            public static SpecialFolder UserProgramFilesCommon {
                get { return GetInstance(SpecialFolderTypes.UserProgramFilesCommon); }
            }

            /// <summary>
            /// The per-user Videos folder.
            /// Defaults to &quot;%USERPROFILE%\Videos&quot;.
            /// </summary>
            public static SpecialFolder Videos {
                get { return GetInstance(SpecialFolderTypes.Videos); }
            }

            /// <summary>
            /// The per-user Videos library. Introduced in Windows 7.
            /// Defaults to &quot;%APPDATA%\Microsoft\Windows\Libraries\Videos.library-ms&quot;.
            /// </summary>
            public static SpecialFolder VideosLibrary {
                get { return GetInstance(SpecialFolderTypes.VideosLibrary); }
            }

            /// <summary>
            /// The fixed Windows folder.
            /// Points to &quot;%WINDIR%&quot;.
            /// </summary>
            public static SpecialFolder Windows {
                get { return GetInstance(SpecialFolderTypes.Windows); }
            }
            #endregion

            private static SpecialFolder GetInstance(SpecialFolderTypes type) {

                if (_knownFolderInstances == null) {
                    _knownFolderInstances = new Dictionary<SpecialFolderTypes, SpecialFolder>();
                }

                SpecialFolder knownFolder;
                if (!_knownFolderInstances.TryGetValue(type, out knownFolder)) {
                    knownFolder = new SpecialFolder(type);
                    _knownFolderInstances.Add(type, knownFolder);
                }
                return knownFolder;
            }
        }
    }
}
