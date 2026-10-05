using Clean_Code_Example.Core;

namespace Clean_Code_Example.Clean_Code
{
    public class OrderFactory
    {
        public Order CreateOrder(string customerName, decimal price, int quantity)
        {
            return new Order(customerName, price, quantity);
        }
    }
}
