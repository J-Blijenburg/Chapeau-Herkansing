using Logic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.CustomTools;

namespace UI
{
    public partial class BillForm : Form
    {
        private Table table;
        private Employee logedinEmployee;
        private OrderService orderService = new OrderService();
        private ReceiptService receiptService = new ReceiptService();
        private PaymentMethod paymentmethod;
        private List<OrderItem> orderItems;
        private Receipt receipt;
        RoundedButton clickedButton;
        public BillForm(Table table, Employee currentEmployee)
        {
            InitializeComponent();
            this.table = table;
            this.logedinEmployee = currentEmployee;
            LoadOrders();
        }

        private void Columns()
        {
            LvBill.Columns.Add("amount", 75);
            LvBill.Columns.Add("name", 200);
            LvBill.Columns.Add("price", 100);
        }
        private void Style()
        {
            LvBill.Font = new Font("Arial", 12, FontStyle.Bold);
            LvBill.View = View.Details;
            BtnProceedToPayment.BackColor = ColorTranslator.FromHtml("#8AD2B0");
            BtnProceedToPayment.Font = new Font("Arial", 12, FontStyle.Bold);
        }
        private void LoadListviewStyle() { Columns(); Style(); }

        public void LoadOrders()
        {
            LoadListviewStyle();
            receipt = receiptService.GetReceipt(table, logedinEmployee);

            //orderItems = orderService.GetOrderdItems(table);
            orderItems = orderService.GetOrderdItemsByReceiptId(receipt.ReceiptId); //haal comments op in Dao

            double totalVat = (double)orderService.CalculateTotalVat(orderItems);
            receipt.TotalVat = totalVat;
            receipt.LowVatPrice = (double)orderService.CalculateLowVat(orderItems);
            receipt.HighVatPrice = (double)orderService.CalculateHighVat(orderItems);

            double totalPrice = (double)orderService.CalculateTotalPrice(orderItems);
            LblTotalNumber.Text = $"€ {totalPrice.ToString("N2")}";
            LblVatNumber.Text = $"€ {totalVat.ToString("N2")}";
            LblOrderPriceNumber.Text = $"€ {totalPrice.ToString("N2")}";


            foreach (OrderItem orderitem in orderItems)
            {
                ListViewItem listViewItem = new ListViewItem(orderitem.Quantity.ToString());
                listViewItem.SubItems.Add(orderitem.MenuItem.GetName());
                listViewItem.SubItems.Add(orderitem.SubTotal.ToString());
                listViewItem.Tag = orderitem;
                LvBill.Items.Add(listViewItem);
                if (!string.IsNullOrEmpty(orderitem.GetComment()))
                {
                    ListViewItem commentItem = new ListViewItem(string.Empty);
                    commentItem.SubItems.Add(orderitem.GetComment());
                    LvBill.Items.Add(commentItem);
                }
            }
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

        private void BtnProceedToPayment_Click(object sender, EventArgs e)
        {
            if (clickedButton == null)
            {
                MessageBox.Show("You need to choose a payment method");
                return;
            }

            receipt.Payment.PaymentMethod = paymentmethod;
            PaymentOverView pov = new PaymentOverView(receipt, orderItems);
            this.Hide();
            pov.ShowDialog();
        }
    }
}
