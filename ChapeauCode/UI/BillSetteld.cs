using DAL;
using Logic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class BillSetteld : Form
    {
        private Receipt receipt;
        private ReceiptService receiptService = new ReceiptService();
        public BillSetteld(Receipt receipt)
        {
            InitializeComponent();
            this.receipt = receipt;
            LoadData();
            UpdateReceipt();
        }

        private void LoadData()
        {
            LblAmontPaidNummer.Text = (receipt.TotalPrice + receipt.Tip).ToString();
            LblOrderPriceNummer.Text = receipt.TotalPrice.ToString();
            LblVatNummer.Text = receipt.TotalVat.ToString();
            LblTipAmountNummer.Text = receipt.Tip.ToString();
            receipt.Payment.IsPaid = true;
        }
        //update the receid in tha database
        private void UpdateReceipt() {
            receiptService.UpdateReceipt(receipt.Table);
        }
    }
}
