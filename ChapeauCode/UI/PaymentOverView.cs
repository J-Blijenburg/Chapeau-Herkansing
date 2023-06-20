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
    public partial class PaymentOverView : Form, IPaymentSystem
    {
        private Receipt receipt;
        private double tip;
        private double remaningBalance;
        private List<ISplittDisplay> observers = new List<ISplittDisplay>();
        private Employee loggedInEmployee;
        private Receipt placeholder = new Receipt();

        public PaymentOverView(Receipt receipt, Employee employee)
        {
            InitializeComponent();
            this.receipt = receipt;
            this.loggedInEmployee = employee;
            this.placeholder = new Receipt
            {
                TotalVat = receipt.TotalVat,
                Tip = receipt.Tip,
                TotalPriceExclVat = receipt.TotalPriceExclVat,
                HighVatPrice = receipt.HighVatPrice,
                LowVatPrice = receipt.LowVatPrice,
                Feedback =  receipt.Feedback,
                ReceiptDateTime =  receipt.ReceiptDateTime, 
                Payments = receipt.Payments,
                Employee = receipt.Employee,                
                Table = receipt.Table,      
                ReceiptId = receipt.ReceiptId,
            };

            NonCashPayment();
            LoadData();
        }
        private void LoadData()
        {
            this.Refresh();
            receipt.Payments.Clear();
            LblTotalPriceNumber.Text = receipt.TotalPrice.ToString();
        }
        private void NonCashPayment()
        {
            if (!(receipt.Payments.First().PaymentMethod == PaymentMethod.Cash))
            {
                LblChangeTekst.Hide();
                LblChangeNumber.Hide();
                BtnAddChangeAsTip.Hide();
            }
        }
        private void BtnPay_Click(object sender, EventArgs e)
        {
            ShowNextPayWindow();
        }

        private void CheckPayment()
        {
            if (receipt.TotalPrice > 0)
            {
                MessageBox.Show($"The remaining balance is €{remaningBalance}");
            }

            if (receipt.Payments.First().IsPaid)
            {
                this.Hide();
                CommentQuestionForm Comment = new CommentQuestionForm(placeholder, loggedInEmployee);
                Comment.ShowDialog();
            }

        }
        // show the next payment screen based on the split amount that has been chosen by the user
        private void ShowNextPayWindow()
        {
            observers.Clear();
            for (int i = 0; i < (int)AmountOfPeopleNr.Value; i++)
            {
                Splitbill splitbill = new Splitbill(this, receipt.TotalPrice);
                splitbill.Text = "Payment Form " + (i + 1);
                splitbill.ShowDialog();
                NotifyObservers();
            }
            CheckPayment();
        }
        // add display to the screen of observers
        public void AddObserver(ISplittDisplay observer)
        {
            observers.Add(observer);
        }
        // update the display after person x has paid an certain amount of the total price
        private void NotifyObservers()
        {
            ISplittDisplay observer = observers.LastOrDefault();
            observer?.Update(receipt);
            placeholder.Payments = receipt.Payments;
        }

        private void BtnSetAmountPaid_Click(object sender, EventArgs e)
        {
            double paidAmount = ConvertValue(TbAmountPaid);

            if (CheckIfNegativeValue(paidAmount))
            {
                MessageBox.Show($"A negative value {paidAmount} cannot be entered"); return;
            }

            if (paidAmount < receipt.TotalPrice)
            {
                remaningBalance = receipt.TotalPrice - paidAmount;
                MessageBox.Show($"The remaining balance is €{remaningBalance.ToString("N2")}"); return;
            }
            LblChangeNumber.Text = (paidAmount - receipt.TotalPrice).ToString("N2");
        }
        private double ConvertValue(Control value)
        {
            return double.Parse(value.Text);
        }

        private bool CheckIfNegativeValue(double value)
        {
            return value < 0;
        }

        private void BtnAddChangeAsTip_Click(object sender, EventArgs e)
        {
            if (CheckStringToDouble(LblChangeNumber.Text))
            {
                this.tip = ConvertValue(LblChangeNumber);
                receipt.Tip = tip;
                LblChangeNumber.Text = 0.ToString();
                LblCustomTip.Visible = false;
                TbCustomTip.Visible = false;
                BtnSetCustomTip.Visible = false;
                LblEnterCustomTip.Visible = false;
                LblhasBeenAdded.Visible = true;
            }
        }

        private bool CheckStringToDouble(String toCheck)
        {
            if (!String.IsNullOrEmpty(toCheck) && double.TryParse(toCheck, out double CheckIfNumber))
            {
                if (!CheckIfNegativeValue(double.Parse(toCheck)))
                {
                    return true;
                }
            }
            return false;
        }

        private void BtnSetCustomTip_Click(object sender, EventArgs e)
        {
            double Checktip = ConvertValue(TbAmountPaid);
            if (CheckIfNegativeValue(Checktip))
            {
                MessageBox.Show($"A negative value {Checktip} cannot be entered"); return;
            }
            this.tip = Checktip;
            receipt.Tip = tip;
            LblChangeNumber.Text = 0.ToString();
        }

        private void CbSplitTheBill_CheckedChanged(object sender, EventArgs e)
        {
            AmountOfPeopleNr.Visible = LblAmountOfPeople.Visible = CbSplitTheBill.Checked;
            BtnSetAmountPaid.Enabled = !CbSplitTheBill.Checked;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            BillForm bill = new BillForm(receipt.Table, loggedInEmployee);
            this.Close();
            bill.Show();
        }
    }
}
