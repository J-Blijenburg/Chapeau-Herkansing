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
using UI.CustomTools;

namespace UI
{
    public partial class Splitbill : Form, ISplittDisplay
    {
        private IPaymentSystem observer;
        private static double totalAmountPaid;
        private static double totalAmountReceipt;
        private RoundedButton clickedButton;
        private PaymentMethod paymentmethod;
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
            Payment payment = new Payment();
            payment.PaymentMethod = paymentmethod;
            receipt.Payments.Add(payment);
            receipt.TotalPrice -= totalAmountPaid;
            if (receipt.TotalPrice < 0)
                receipt.Payments.First().IsPaid = true;
            totalAmountPaid = 0;
            if (receipt.TotalPrice < 0) { receipt.TotalPrice = 0; }
        }

        private void BtnPay1_Click(object sender, EventArgs e)
        {
            if (TbInputAmountPaid.Text == string.Empty)
            {
                MessageBox.Show("There was no value entered");
                return;
            }
            if (clickedButton == null)
            {
                MessageBox.Show("You need to choose a payment method");
                return;
            }

            totalAmountPaid = double.Parse(TbInputAmountPaid.Text);
            if (totalAmountPaid > 0)
                this.Close();


        }
        private void Button_Click(object sender, EventArgs e)
        {
            // Identify which button triggered the event
            clickedButton = (RoundedButton)sender;

            // Perform the desired action based on the clicked button
            if (clickedButton == BtnCash)
            {
                paymentmethod = PaymentMethod.Cash;
            }
            else if (clickedButton == BtnDebit)
            {
                paymentmethod = PaymentMethod.Pin;
            }
            else
            {
                paymentmethod = PaymentMethod.CreditCard;
                clickedButton = BtnVisa;
            }
            SetSelectedButtonColor(clickedButton);
        }
        private void SetSelectedButtonColor(RoundedButton button)
        {
            BtnCash.BackColor = Color.LightGray;
            BtnDebit.BackColor = Color.LightGray;
            BtnVisa.BackColor = Color.LightGray;
            button.BackColor = ColorTranslator.FromHtml("#ffb347");

        }
    }
}
