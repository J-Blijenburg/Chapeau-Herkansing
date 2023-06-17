using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Receipt
    {
        public int ReceiptId { get; set; }
        public DateTime ReceiptDateTime { get; set; }
        public string Feedback { get; set; }
        public Employee Employee { get; set; }
        public Table Table { get; set; }
        public double LowVatPrice { get; set; }
        public double HighVatPrice { get; set; }
        public double TotalVat { get; set; }
        public double TotalPrice { get; set; }
        public double Tip { get; set; }

        public bool IsHandled { get; set; }
        public Payment Payment { get; set; }
        private List<Order> Orders { get; set; }
        
    }
}
