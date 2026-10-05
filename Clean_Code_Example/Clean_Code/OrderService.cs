using Clean_Code_Example.Core;

namespace Clean_Code_Example.Clean_Code
{
    public class OrderService
    {
        public void SaveOrder(Order order)
        {
            try
            {
                Console.WriteLine("Saving " + order.CustomerName);
            }
            catch
            {
                throw new Exception("Failed to save order for " + order.CustomerName);
            }
        }
    }
}
