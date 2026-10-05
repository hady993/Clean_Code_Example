using Clean_Code_Example.Core;

namespace Clean_Code_Example.Clean_Code
{
    public class OrderValidator
    {
        public void ValidateOrder(Order order)
        {
            if (order.CustomerName == null)
                throw new ArgumentNullException(nameof(order.CustomerName), "Customer name cannot be null.");
        }
    }
}
