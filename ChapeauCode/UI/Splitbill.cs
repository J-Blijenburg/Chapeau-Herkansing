using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Model;
using System.Reflection.Metadata.Ecma335;

namespace UI
{
    public partial class Splitbill : Form, ISplittDisplay
    {
        private IPaymentSystem observer;
        private static double totalAmountPaid;
        private static double totalAmountReceipt;

        public Splitbill(IPaymentSystem observer, double totalAmount)
        {
            InitializeComponent();
            this.observer = observer;
            this.observer.AddObserver(this);
            totalAmountReceipt = totalAmount;
            LoadData();
        }
        private void LoadData()
        {
            LblToPayNumber.Text = totalAmountReceipt.ToString();
        }
        public void Update(Receipt receipt)
        {
         
            receipt.TotalPriceExclVat -= totalAmountPaid;
            if (receipt.TotalPriceExclVat < 0)
                receipt.Payments.First().IsPaid = true;
            totalAmountPaid = 0;
        }
        private void BtnPay_Click(object sender, EventArgs e)
        {
            totalAmountPaid = double.Parse(TbInputAmountPaid.Text);
            if (totalAmountPaid > 0)
            {
                this.Close();
            }
        }
    }
}
