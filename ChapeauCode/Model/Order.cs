

namespace Model
{
    public class Order
    {
        public int OrderId { get; set; }
        private Employee Employee { get; set; }
        private Receipt Receipt { get; set; }
        public DateTime OrderDateTime { get; set; }
        public OrderStatus Status { get; set; }
    }
}
