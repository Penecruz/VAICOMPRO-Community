using System;
using System.Collections.Generic;
using VAICOM.Database;
using VAICOM.PushToTalk;
using VAICOM.Servers;
using VAICOM.Static;

namespace VAICOM
{
    namespace Client
    {

        public partial class DcsClient
        {
            public static partial class Message
            {

                public static int getunitsincat(PTT.TXNode TX)
                {

                    List<Server.DcsUnit> tunedforcurrentTX = DcsClient.GetTunedUnitsForTX(TX, true);
                    List<Server.DcsUnit> catunits = State.currentstate.availablerecipients[State.currentcommand.RecipientClass().Name];

                    int counter = 0;

                    foreach (Server.DcsUnit tunedunit in tunedforcurrentTX)
                    {
                        if (catunits.Contains(tunedunit) && !tunedunit.id_.Equals(-1))
                        {
                            State.currentmessageunit = tunedunit;
                            counter += 1;
                        }
                    }

                    return counter;

                }

                public static bool SetRecipientByFreq()
                {

                    if (State.currentstate.easycomms || (State.currentstate.radios.Count.Equals(0)))
                    {
                        return false;
                    }

                    try
                    {
                        if (!State.currentrecipientclass.Equals(Recipientclasses.Flight))
                        {
                            return getunitsincat(State.currentTXnode).Equals(1);    // >1 ; resolve by call contents not by freq. messageunit already set.  
                        }
                        else
                        {
                            return false; // flight: do not resolve unit by freq
                        }
                    }
                    catch (Exception e)
                    {
                        Log.Write("Error setting recipient by frequency: " + e.StackTrace, Colors.Inline);
                        return false;
                    }
                }

            }
        }
    }
}

