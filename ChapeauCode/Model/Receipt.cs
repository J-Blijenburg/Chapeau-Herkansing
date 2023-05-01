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
        private DateTime ReceiptDateTime { get; set; }
        private string Feedback { get; set; }
        private Employee Employee { get; set; }
        public Table Table { get; set; }
        public double LowVatPrice { get; set; }
        public double HighVatPrice { get; set; }
        public double TotalPrice { get; set; }
        public double Tip { get; set; }
        public bool IsHandled { get; set; }
        public Payment Payment { get; set; }
    }
}
