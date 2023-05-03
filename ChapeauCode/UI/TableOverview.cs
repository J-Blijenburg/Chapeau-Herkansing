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
    public partial class TableOverview : Form
    {
        private OrderService orderService;
        public TableOverview(Table table)
        {
            InitializeComponent();
            this.orderService = new OrderService();
            GetOrderdItems(table);
        }

        private void BtnLunch_Click(object sender, EventArgs e)
        {
            OpenOrderForm("Lunch");
        }

        private void BtnDinner_Click(object sender, EventArgs e)
        {
            OpenOrderForm("Dinner");
        }

        private void BtnDrinks_Click(object sender, EventArgs e)
        {
            OpenOrderForm("Drinks");
        }

        private void OpenOrderForm(string panelToShow)
        {
            //When creating a new orderForm this form will hide and will be used again after the orderform is disposed
            OrderOverView order = new OrderOverView(this, panelToShow);
            this.Hide();

            //Since there is no need of using both the forms at the same time, the orderform will be shown as a dialog preventing the user from using the tableoverview form
            order.ShowDialog();

            //This messagebox can be used to check how many Forms there are currently running
            //MessageBox.Show(Application.OpenForms.Count.ToString());
        }

        private List<OrderItem> GetOrderdItems(Table table)
        {
            List<OrderItem> orderItems = new List<OrderItem>();

            orderService.GetOrderdItems(table);

            return orderItems;
        }

        private void FillListViewOrderdItems(ListView listView, List<MenuItem> menuItems)
        {
            listView.Clear();

            listView.Columns.Add("Name", 375);
            listView.Columns.Add("Price", 100);

            foreach (MenuItem menuItem in menuItems)
            {
                ListViewItem listViewItem = new ListViewItem(menuItem.Name);
                listViewItem.SubItems.Add($"€ {menuItem.Price.ToString("N2")}");
                listViewItem.Tag = menuItem;
                listView.Items.Add(listViewItem);
            }
        }
    }
}
