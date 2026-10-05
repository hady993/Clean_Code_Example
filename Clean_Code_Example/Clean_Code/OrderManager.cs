using Clean_Code_Example.Core;

namespace Clean_Code_Example.Clean_Code
{
    public class OrderManager
    {
        private readonly OrderHelper _orderHelper;
        private readonly OrderValidator _orderValidator;
        private readonly OrderService _orderService;
        private readonly OrderFactory _orderFactory;

        public OrderManager(OrderHelper orderHelper, OrderValidator orderValidator, OrderService orderService, OrderFactory orderFactory)
        {
            _orderHelper = orderHelper;
            _orderValidator = orderValidator;
            _orderService = orderService;
            _orderFactory = orderFactory;
        }

        public void ProcessOrder(string customerName, decimal price, int quantity)
        {
            Order order = _orderFactory.CreateOrder(customerName, price, quantity);
            _orderValidator.ValidateOrder(order);
            decimal total = _orderHelper.CalculateTotal(order.Price, order.Quantity);
            Console.WriteLine(_orderHelper.GetOrderType(total));
            _orderService.SaveOrder(order);
        }
    }
}
