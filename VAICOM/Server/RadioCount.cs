using System;

namespace VAICOM
{
    namespace Servers
    {

        public static partial class Server
        {

            public static bool AtLeastOneRadioCount()
            {
                bool result = false;

                try
                {

                    if ((State.currentstate.radios.Count == 0)) 
                    {
                        result = true;
                    }
                    else
                    {
                        foreach (RadioDevice device in State.currentstate.radios)
                        {
                            if (!device.intercom & device.on)
                            {
                                result = true;
                            }
                        }
                    }
                }
                catch (Exception)
                {
                }

                return result;
            }
        }
    }
}
