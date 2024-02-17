using System.Collections.Generic;

namespace VAICOM
{
    namespace Products
    {

        public class Product
        {
            public string name;
            public string category;
            public string version;
            public string description;
            public int product_id;
            public bool activated;
            public string rootfoldername;
        }

        public partial class Products
        {

            public class Families
            {

                public class Vaicom
                {
                    public static string RegKeyBase = "Software\\VoiceAttack.com\\Plugins";
                    public static string RegKeyRoot = RegKeyBase + "\\" + "VAICOMPRO";

                    public static Product VaicomProPlugin = new Product { product_id = 0001, category = "VA plugin", version = "2.9", rootfoldername = "VAICOMPRO", name = "VAICOMPRO", description = "PRO license" };
                    public static Product ChatterThemePack = new Product { product_id = 0002, category = "Extension", version = "2.9", rootfoldername = "VAICOMPRO" + "\\" + "Extensions", name = "ChatterThemes", description = "Chatter Theme Pack" };
                    public static Product RIODialog = new Product { product_id = 0003, category = "Extension", version = "2.9", rootfoldername = "VAICOMPRO" + "\\" + "Extensions", name = "RIO Dialog", description = "AI RIO Dialog extension" };
                    public static Product RealATC = new Product { product_id = 0004, category = "Extension", version = "2.9", rootfoldername = "VAICOMPRO" + "\\" + "Extensions", name = "Realistic ATC", description = "Realistic ATC extension" };
                    public static Product InteractiveKneeboard = new Product { product_id = 0005, category = "Extension", version = "2.9", rootfoldername = "VAICOMPRO" + "\\" + "Extensions", name = "Interactive Kneeboard", description = "Interactive Kneeboard" };

                }

                public class DCSWorld
                {
                    public static string RegKeyRoot = "Software\\Eagle Dynamics\\";
                }

            }

            public static Dictionary<string, Product> LookupTable = new Dictionary<string, Product>()
            {
                {"0001",      Products.Families.Vaicom.VaicomProPlugin        },
                {"0002",      Products.Families.Vaicom.ChatterThemePack       },
                {"0003",      Products.Families.Vaicom.RIODialog              },
                {"0004",      Products.Families.Vaicom.RealATC                },
                {"0005",      Products.Families.Vaicom.InteractiveKneeboard   },
            };

        }

    }

}
