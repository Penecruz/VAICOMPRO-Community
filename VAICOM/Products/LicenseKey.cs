namespace VAICOM
{
    namespace Products
    {

        public partial class LicenseKeys
        {

            public class ProductOrder
            {
                public Order order;
            }

            public class Order
            {
                public string buyer_email;
                public int id;
            }

        }
    }
}
