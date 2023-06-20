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
        private List<ISplittDisplay> observers = new List<ISplittDisplay>();
        private Employee loggedInEmployee;
        private Receipt updatedReceipt = new Receipt();

        public PaymentOverView(Receipt receipt, Employee employee)
        {
            InitializeComponent();
            this.receipt = receipt;
            this.loggedInEmployee = employee;
            this.updatedReceipt = new Receipt
            {
                TotalVat = receipt.TotalVat,
                Tip = receipt.Tip,
                TotalPriceExclVat = receipt.TotalPriceExclVat,
                HighVatPrice = receipt.HighVatPrice,
                LowVatPrice = receipt.LowVatPrice,
                Feedback = receipt.Feedback,
                ReceiptDateTime = receipt.ReceiptDateTime,
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
            LblTotalPriceNumber.Text = receipt.TotalPrice.ToString("N2");
        }
        private void NonCashPayment()
        {
            if (!(receipt.Payments.Last().PaymentMethod == PaymentMethod.Cash))
            {
                LblChangeTekst.Hide();
                LblChangeNumber.Hide();
                BtnAddChangeAsTip.Hide();
                LblChangeNumber.Visible = false;
            }
        }
        private void BtnPay_Click(object sender, EventArgs e)
        {
            ShowNextPayWindow();
        }

        private void CheckPayment()
        {
            if (receipt.Payments.First().IsPaid)
            {
                this.Hide();
                CommentQuestionForm Comment = new CommentQuestionForm(updatedReceipt, loggedInEmployee);
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
            updatedReceipt.Payments = receipt.Payments;
        }

        private void BtnSetAmountPaid_Click(object sender, EventArgs e)
        {
            double paidAmount = ConvertValue(TbAmountPaid);
            if (CheckIfNegativeValue(paidAmount))
            {
                MessageBox.Show($"A negative value {paidAmount.ToString("N2")} cannot be entered"); return;
            }
            if (paidAmount > 0 && receipt.TotalPrice > 0)
            {
                receipt.TotalPrice -= paidAmount;
            }
            if (receipt.TotalPrice < 0)
            {
                LblChangeNumber.Text = ( Math.Abs(receipt.TotalPrice)).ToString("N2");
             
                Payment payment = new Payment();
                payment.PaymentId = receipt.Payments.First().PaymentId;
                payment.PaymentMethod = receipt.Payments.Last().PaymentMethod;
                if (payment.PaymentMethod == PaymentMethod.Cash)
                    MessageBox.Show($"You have paid {paidAmount} in total, you will receive {LblChangeNumber.Text} in  change.");
                receipt.Payments.Clear();
                receipt.Payments.Add(payment);
                receipt.Payments.First().IsPaid = true;
            }


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
                updatedReceipt.Tip = tip;
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
            receipt.Tip = Checktip;
            LblChangeNumber.Text = 0.ToString();
            MessageBox.Show($"The tip has been set");
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
