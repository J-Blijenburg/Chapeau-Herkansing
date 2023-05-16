

namespace Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public Employee Employee { get; set; }
        public Receipt Receipt { get; set; }
        public DateTime OrderDateTime { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        public Order()
        {

        }

        public Order(Employee employee, Receipt receipt, DateTime orderDateTime, OrderStatus status)
        {
            Employee = employee;
            Receipt = receipt;
            OrderDateTime = orderDateTime;
            Status = status;
            OrderItems = new List<OrderItem>();
        }

        public void SetOrderId(int id)
        {
            this.OrderId = id;
        }


    }
}
