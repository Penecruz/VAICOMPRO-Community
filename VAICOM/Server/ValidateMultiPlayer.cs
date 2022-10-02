using VAICOM.Static;

namespace VAICOM
{
    namespace Servers
    {
        public static partial class Server
        {
            public static void ValidateMultiPlayer()
            {
                if (!State.PRO & State.currentstate.multiplayer)
                {
                    Log.Write("Multiplayer is available only with PRO license.", Colors.Warning);
                    State.tempblockedcommands = true;
                    UI.Playsound.Error();
                }
                else
                {
                    State.tempblockedcommands = false;
                }
            }
        }

    }
}
