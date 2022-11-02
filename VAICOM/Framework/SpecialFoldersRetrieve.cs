using VAICOM.Static;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace VAICOM
{
    namespace Framework
    {

        [SupportedOSPlatform("windows")]
        public class SpecialFoldersRetrieve
        {

            public static string GetSavedGames()
            {
                SpecialFolder SavedGamesFolder = new SpecialFolder(SpecialFolderTypes.SavedGames);
                try
                {
                    return SavedGamesFolder.Path;
                }
                catch (ExternalException ex)
                {
                    // revert to default
                    Log.Write("There was problem with locating the Saved Games folder: " + ex, Colors.Text);
                    string SavedGames = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Saved Games\\";
                    Log.Write("Default path is used for Saved Games: " + SavedGames, Colors.Text);
                    return SavedGames;
                }
            }
        }
    }
}
