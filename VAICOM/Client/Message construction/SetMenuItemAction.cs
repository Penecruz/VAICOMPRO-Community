namespace VAICOM
{

    namespace Client
    {

        public partial class DcsClient
        {
            public static partial class Message
            {
                public static void SetMenuItemAction()
                {
                    State.currentmessage.actionsequence.Add(State.currentcommand.actionIndex);
                }
            }
        }
    }
}



