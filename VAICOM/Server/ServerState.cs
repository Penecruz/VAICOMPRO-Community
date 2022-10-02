using System.Collections.Generic;

namespace VAICOM
{
    namespace Servers
    {

        public static partial class Server
        {

            public static bool receivedupdatecomplete;
            public static bool processingchunks;
            public static Dictionary<string, string> catdescriptions = new Dictionary<string, string>()
            {
                { "Carrier","Supercarrier unit" },
                { "ATC","ATC unit" },
                { "Player","player" },
                { "Flight","wingman" },
                { "JTAC","tactical operator" },
                { "AWACS","AWACS unit" },
                { "Tanker","AAR unit" },
                { "Crew","ground crew" },
                { "Aux","auxiliary unit" },
                { "Cargo","cargo unit" },
                { "Allies","allied flight unit" },
            };

        }
    }
}

