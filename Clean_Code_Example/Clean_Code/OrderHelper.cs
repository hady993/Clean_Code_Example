namespace Clean_Code_Example.Clean_Code
{
    public class OrderHelper
    {
        private const int orderPriceLimit = 1000;

        public int CalculateTotal(decimal price, int quantity)
        {
            return (int)(price * quantity);
        }

        public string GetOrderType(decimal total)
        {
            return total > orderPriceLimit ? "Big order" : "Small order";
        }
    }
}
