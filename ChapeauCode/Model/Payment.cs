namespace Model
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public bool IsPaid { get; set; }

        public PaymentMethod PaymentMethod { get; set; }
    }
}
