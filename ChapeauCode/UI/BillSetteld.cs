using DAL;
using Logic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private Employee loggedInEmployee;
        public BillSetteld(Receipt receipt, Employee employee)
        {
            InitializeComponent();
            this.receipt = receipt;
            this.loggedInEmployee = employee;   
            LoadData();
            UpdateReceipt();
        }

        private void LoadData()
        {
            LblOrderPriceNummer.Text = receipt.TotalPriceExclVat.ToString("N2");
            LblAmontPaidNummer.Text = (receipt.TotalPriceExclVat + receipt.Tip + receipt.TotalVat).ToString("N2");
            LblTipAmountNummer.Text = receipt.Tip.ToString("N2");
            LblVatNummer.Text = receipt.TotalVat.ToString("N2");
            receipt.Payments.First().IsPaid = true;
            receipt.IsHandled = true;   
        }
        //update the receipt in the database
        private void UpdateReceipt()
        {
            receiptService.UpdateReceipt(receipt);
        }

        private void BtnBackTableOverView_Click(object sender, EventArgs e)
        {
            Tables tables = new Tables(loggedInEmployee, new Login());
            this.Close();
            tables.Show();

        }
    }
}
