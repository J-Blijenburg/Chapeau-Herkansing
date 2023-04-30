

namespace Model
{
    public class Order
    {
        public int OrderId { get; set; }
        private int EmployeeId { get; set; }
        private int ReceiptId { get; set; }
        public DateTime OrderDateTime { get; set; }
        public OrderStatus Status { get; set; }
    }
}
