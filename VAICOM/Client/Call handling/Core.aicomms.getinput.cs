using VAICOM.Static;

namespace VAICOM
{
    namespace Client
    {

        public partial class DcsClient
        {
            public static partial class Message
            {

                public static bool requirescorrection(string input)
                {
                    if (input.StartsWith("to "))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }


                public static void getinputsentence()
                {
                    State.currentfullsentence = Helpers.Common.StringNormalize(State.Proxy.ParseTokens("{CMD}"));

                    if (requirescorrection(State.currentfullsentence))
                    {
                        State.currentfullsentence = State.currentfullsentence.Replace("to ", "two ");
                    }

                    Log.Write("Captured sentence: " + State.currentfullsentence, Colors.Text);

                }
            }
        }
    }
}



