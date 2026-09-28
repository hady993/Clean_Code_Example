namespace Clean_Code_Example.Core
{
    public class Order
    {
        public string CustomerName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Order(string customerName, decimal price, int quantity)
        {
            CustomerName = customerName;
            Price = price;
            Quantity = quantity;
        }
    }
}
