using Clean_Code_Example.Core;

namespace Clean_Code_Example.Bad_Code
{
    public class OrderMan
    {
        private List<Order> orders = new();

        public int DoIt(string n, decimal p, int q, bool save)
        {
            // check and manage order process
            if (n == null)
                return -1;

            Order x = new Order(n, p, q);
            orders.Add(x);

            decimal t = p * q;

            if (t > 1000)
                Console.WriteLine("Big order");
            else
                Console.WriteLine("Small order");

            if (save)
            {
                try
                {
                    Console.WriteLine("Saving " + n);
                }
                catch
                {
                    return -2;
                }
            }

            return 1;
        }
    }
}
