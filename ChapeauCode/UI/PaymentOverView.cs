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
        private OrderService orderService = new OrderService();
        private List<OrderItem> orderItems;
        private Receipt receipt;
        private double tip;
        private double totalPrice;
        private double remaningBalance;
        private List<IFormObserver> observers = new List<IFormObserver>();

        public PaymentOverView(Receipt receipt, List<OrderItem> orderItems
            )
        {
            InitializeComponent();
            this.receipt = receipt;
            this.orderItems = orderItems;
            NonCashPayment();
            LoadData();
        }

        private void LoadData()
        {
            totalPrice = (double)orderService.CalculateTotalPrice(orderItems);
            LblOrderPriceNumber.Text = totalPrice.ToString();
            receipt.TotalPrice = totalPrice;
        }
        private void NonCashPayment()
        {
            if (!(receipt.Payment.PaymentMethod == PaymentMethod.Cash))
            {
                LblChangeTekst.Hide();
                LblChangeNumber.Hide();
                BtnAddChangeAsTip.Hide();
            }
        }
        private void BtnPay_Click(object sender, EventArgs e)
        {
            if (CbSplitTheBill.Checked)
            {
                ShowNextPayWindow();
            }
            CommentQuestion Comment = new CommentQuestion(receipt);
            this.Hide();
            Comment.ShowDialog();

        }

        private void CheckPayment()
        {
            foreach (IFormObserver observer in observers)
            {
                bool allPaid = false;

                if (observer.Update())
                {
                    allPaid = true;
                }
                if (allPaid)
                {
                    this.Hide();
                    CommentQuestion Comment = new CommentQuestion(receipt);
                    Comment.ShowDialog();
                }
                else
                    MessageBox.Show("Not everything is paid");
            }
        }
        private void ShowNextPayWindow()
        {

            observers.Clear();
            for (int i = 0; i < (int)AmountOfPeopleNr.Value; i++)
            {
                Splitbill splitbill = new Splitbill(this, SplittTotalAmount());
                splitbill.ShowDialog();
            }
            CheckPayment();
        }
        private double SplittTotalAmount()
        {

            return receipt.TotalPrice / (int)AmountOfPeopleNr.Value;
        }


        public void AddObserver(IFormObserver observer)
        {
            for (int i = 1; i <= (int)AmountOfPeopleNr.Value; i++)
            {
                observers.Add(observer);
            }
        }

        public void RemoveObserver(IFormObserver observer)
        {
            observers.Remove(observer);
        }

        private void BtnSetAmountPaid_Click(object sender, EventArgs e)
        {
            double paidAmount = ConvertValue(TbAmountPaid);


            if (CheckNegativeValue(paidAmount))
            {
                MessageBox.Show($"A negative value {paidAmount} cannot be entered"); return;
            }

            if (paidAmount < totalPrice)
            {
                remaningBalance = totalPrice - paidAmount;
                MessageBox.Show($"The remaining balance is €{remaningBalance}"); return;

            }
            LblChangeNumber.Text = (paidAmount - totalPrice).ToString();
        }
        private double ConvertValue(Control value)
        {
            return double.Parse(value.Text);
        }

        private bool CheckNegativeValue(double value)
        {
            return value < 0;
        }

        private void BtnAddChangeAsTip_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(LblChangeNumber.Text))
            {
                this.tip = ConvertValue(LblChangeNumber);
                receipt.Tip = tip;
                LblChangeNumber.Text = 0.ToString();
            }
        }

        private void BtnSetCustomTip_Click(object sender, EventArgs e)
        {
            double Checktip = ConvertValue(TbAmountPaid);
            if (CheckNegativeValue(Checktip))
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
    }
}
