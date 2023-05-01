namespace VAICOM
{
    namespace Products
    {

        public partial class Products
        {

            public static bool CheckActiveLicenses()
            {

                // ALL LICENSES UNLOCKED:

                State.PRO = true; 
                State.chatterthemesactivated = true; 
                State.jesteractivated = true; 
                State.kneeboardactivated = true; // try deactivating kneeboard with false
                State.realatcactivated = true; 

                UpdateClientLicense();

                return true;
 
            }

            public static void UpdateClientLicense()
            {
                State.currentlicense = State.PRO ? "PRO" : "FREE";
            }
        
        }
    }
}
