

namespace Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public Employee Employee { get; set; }
        public Receipt Receipt { get; set; }
        public DateTime OrderDateTime { get; set; }
        public OrderStatus Status { get; set; }
    }
}
