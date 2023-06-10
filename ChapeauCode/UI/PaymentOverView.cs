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
    public partial class PaymentOverView : Form
    {
        private OrderService orderService = new OrderService();
        private List<OrderItem> orderItems;
        private Receipt receipt;
        private double tip;
        private double amount;
        public PaymentOverView(Receipt receipt, List<OrderItem> orderItems
            )
        {
            InitializeComponent();
            this.receipt = receipt;
            this.orderItems = orderItems;
            LoadData();
        }
        
        private void LoadData()
        {
            amount = double.Parse(LblOrderPriceNumber.Text = orderService.CalculateTotalPrice(orderItems).ToString());
            receipt.TotalPrice = amount;
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            this.Close();
            CommentQuestion Comment = new CommentQuestion(receipt);
            Comment.ShowDialog();
        }

        private void BtnSetAmountPaid_Click(object sender, EventArgs e)
        {
            double paidAmount = ConvertValue(TbAmountPaid);
            if (Checkvalue(paidAmount))
            {
                MessageBox.Show($"A negative value {paidAmount} cannot be entered"); return;
            }
            if (paidAmount < amount) { MessageBox.Show("You have not paid enough"); return; }
            LblChangeNumber.Text = (paidAmount - amount).ToString();
        }
        private double ConvertValue(TextBox value)
        {
            return double.Parse(value.Text);
        }
        private bool Checkvalue(double value)
        {
            return value < 0;
        }

        private void BtnAddChangeAsTip_Click(object sender, EventArgs e)
        {
            this.tip = double.Parse(LblChangeNumber.Text);
            receipt.Tip = tip;
            LblChangeNumber.Text = 0.ToString();
        }

        private void BtnSetCustomTip_Click(object sender, EventArgs e)
        {
            double Checktip = ConvertValue(TbAmountPaid);
            if (Checkvalue(Checktip))
            {
                MessageBox.Show($"A negative value {Checktip} cannot be entered"); return;
            }
            this.tip = Checktip;
            receipt.Tip = tip;
            LblChangeNumber.Text = 0.ToString();
        }
    }
}
