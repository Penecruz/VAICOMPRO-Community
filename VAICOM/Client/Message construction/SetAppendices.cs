using VAICOM.Database;

namespace VAICOM
{
    namespace Client
    {

        public partial class DcsClient
    {
            public static partial class Message
            {
                public static void SetAppendices()
                {

                    State.apxwpnallowed = State.activeconfig.AllowAppendices & State.currentmodule.ApxWpn;
                    State.apxdirallowed = State.activeconfig.AllowAppendices & State.currentmodule.ApxDir;

                    bool useweapon = false;
                    bool usedirection = false;
                    int weaponnumber = 0;
                    double direction = 0;

                    if (State.have["apxwpn"] & State.apxwpnallowed)
                    {
                        useweapon = true;
                        weaponnumber = Appendices.Weapon[State.currentkey["apxwpn"]].weapon;
                    }

                    if (State.have["apxdir"] & State.apxdirallowed)
                    {
                        usedirection = true;
                        direction = Appendices.Direction[State.currentkey["apxdir"]].direction;
                    }

                    State.currentmessage.parameters.Add(useweapon);
                    State.currentmessage.parameters.Add(usedirection);
                    State.currentmessage.parameters.Add(weaponnumber);
                    State.currentmessage.parameters.Add(direction);

                }
            }
        }
    }
}



