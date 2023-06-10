

namespace Model
{
    public class Order : Receipt
    {
        public int OrderId { get; set; }
        public Employee Employee { get; set; }
        public Receipt Receipt { get; set; }
        public DateTime OrderDateTime { get; set; }
        public OrderStatus Status { get; set; }
        private List<OrderItem> OrderItems { get; set; }

        public Order()
        {

        }
        public Order CreateOrder(Employee employee, Receipt receipt, OrderStatus status) {
            Employee = employee;
            Receipt = receipt;
            OrderDateTime = DateTime.Now;
            Status = status;
            OrderItems = new List<OrderItem>();
            
            return this;
        }
        public void AddOrderItemToOrder(OrderItem orderItem)
        {
            if (orderItem is not null)
            {
                OrderItems.Add(orderItem);
            }
        }
        public List<OrderItem> GetOrderItems()
        {
              return OrderItems;
        }
    }
}
