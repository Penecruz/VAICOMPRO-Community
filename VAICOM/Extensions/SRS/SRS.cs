namespace VAICOM
{
    namespace Extensions
    {

        namespace SRS
        {

            public static partial class SRSclient
            {

                public class SRS_PTT_Message
                {
                    public int MessageType;
                    public bool InhibitTX;

                    public SRS_PTT_Message()
                    {
                        MessageType = 1;
                    }
                }
            }
        }
    }
}



