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
        private Table table;
        public TableOverview(Table table)
        {
            InitializeComponent();
            this.orderService = new OrderService();
            this.table = table;

            
            FillListViewOrderdItems(ListViewOrderdItems, GetOrderdItems(table));
        }

        private void BtnLunch_Click(object sender, EventArgs e)
        {
            OpenOrderForm(MenuType.Lunch);
        }

        private void BtnDinner_Click(object sender, EventArgs e)
        {
            OpenOrderForm(MenuType.Dinner);
        }

        private void BtnDrinks_Click(object sender, EventArgs e)
        {
            OpenOrderForm(MenuType.Drinks);
        }

        private void OpenOrderForm(MenuType panelToShow)
        {
            //When creating a new orderForm this form will hide and will be used again after the orderform is disposed
            Employee employee = new Employee();
            employee.FirstName = "Jens";
            employee.EmployeeId = 1;
            
            OrderOverView order = new OrderOverView(this, panelToShow, table, employee);
            this.Hide();

            //Since there is no need of using both the forms at the same time, the orderform will be shown as a dialog preventing the user from using the tableoverview form
            order.ShowDialog();

            FillListViewOrderdItems(ListViewOrderdItems, GetOrderdItems(table));
            

            //This messagebox can be used to check how many Forms there are currently running
            //MessageBox.Show(Application.OpenForms.Count.ToString());
        }

        private List<OrderItem> GetOrderdItems(Table table)
        {
            return orderService.GetOrderdItems(table);
        }

        private void FillListViewOrderdItems(ListView listView, List<OrderItem> orderItems)
        {
            listView.Clear();

            listView.Columns.Add("Name", 375);

            foreach (OrderItem orderItem in orderItems)
            {
                ListViewItem listViewItem = new ListViewItem(orderItem.MenuItem.Name);
                listViewItem.Tag = orderItem;
                listView.Items.Add(listViewItem);
            }
        }
    }
}
