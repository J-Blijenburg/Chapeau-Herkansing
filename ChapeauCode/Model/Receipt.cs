using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Receipt
    {
        private const double HundredPercent = 100.0;
        private const double LowVatRate = 0.06;
        private const double HighVatRate = 0.21;
        public int ReceiptId { get; set; }
        public DateTime ReceiptDateTime { get; set; }
        public string Feedback { get; set; }
        public Employee Employee { get; set; }
        public Table Table { get; set; }
        public double LowVatPrice { get; set; }
        public double HighVatPrice { get; set; }
        public double TotalVat { get; set; }
        public double TotalPriceExclVat { get; set; }
        private double totalPrice;
        public double TotalPrice { get { return TotalVat + TotalPriceExclVat; } set { totalPrice = value; TotalPriceExclVat = totalPrice - TotalVat;  } }
        public double Tip { get; set; }

        public bool IsHandled { get; set; }
        //public Payment Payment { get; set; }

        public List<Payment> Payments { get; set; } = new List<Payment>();
        private List<Order> Orders { get; set; }

        public double CalculateTotalVat(List<OrderItem> orderItems)
        {
            double totalVat = 0;

            foreach (var item in orderItems)
            {
                if (item.MenuItem.MenuCategory != null)
                {
                    double vatRate = item.MenuItem.MenuCategory.VAT / HundredPercent;
                    double itemVat = item.MenuItem.Price * item.Quantity * vatRate;
                    totalVat += itemVat;
                }
            }

            return totalVat;
        }
        public double CalculateLowVat(List<OrderItem> orderItems)
        {
            double lowVat = 0;

            foreach (var item in orderItems)
            {
                if ((double)(item.MenuItem.MenuCategory.VAT / HundredPercent) == LowVatRate)
                    lowVat += (double)item.MenuItem.Price * item.Quantity * (double)(item.MenuItem.MenuCategory.VAT / HundredPercent);
            }

            return lowVat;
        }

        public double CalculateHighVat(List<OrderItem> orderItems)
        {
            double highVat = 0;

            foreach (var item in orderItems)
            {
                if ((double)(item.MenuItem.MenuCategory.VAT / HundredPercent) == HighVatRate)
                    highVat += (double)item.MenuItem.Price * item.Quantity * (double)(item.MenuItem.MenuCategory.VAT / HundredPercent);
            }

            return highVat;
        }

        public double CalculateTotalPrice(List<OrderItem> orderItems)
        {
            double totalPrice = 0;

            foreach (var item in orderItems)
            {
                totalPrice += (double)item.MenuItem.Price * item.Quantity;
            }

            return totalPrice;
        }

    }
}
