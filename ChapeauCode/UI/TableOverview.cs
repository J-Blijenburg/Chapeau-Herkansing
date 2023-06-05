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
        private OrderService orderService = new OrderService();
        private Table table;
        private Employee currentEmployee;
        public TableOverview(Table table, Employee currentEmployee)
        {
            InitializeComponent();
            EnableMenuButtons();
            this.table = table;

            FillListViewOrderdItems(ListViewOrderdItems, GetOrderdItems(table));
            this.currentEmployee = currentEmployee;
            LblEmployee.Text = currentEmployee.FirstName;
            LblTableNumber.Text = $"Table {table.Number.ToString()}";
        }

        private void EnableMenuButtons()
        {
            List<Menu> menus = orderService.GetListOfMenu();
            foreach (Menu menu in menus)
            {
                switch (menu.GetMenuType())
                {
                    case MenuType.Lunch:
                        EnableButton(BtnLunch, menu);
                        break;
                    case MenuType.Dinner:
                        EnableButton(BtnDinner, menu);
                        break;
                    case MenuType.Drinks:
                        EnableButton(BtnDrinks, menu);
                        break;
                }
            }
        }

        private void EnableButton(Button button, Menu menu)
        {
            button.Enabled = true;
            button.BackColor = ColorTranslator.FromHtml("#8AD2B0");
            button.Font = new Font(button.Font, FontStyle.Regular);
            button.Text = menu.GetMenuType().ToString();
            button.Click += MenuButton_Click;   
        }
        private void MenuButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            switch (clickedButton.Name)
            {
                case "BtnLunch":
                    OpenOrderForm(MenuType.Lunch);
                    break;
                case "BtnDinner":
                    OpenOrderForm(MenuType.Dinner);
                    break;
                case "BtnDrinks":
                    OpenOrderForm(MenuType.Drinks);
                    break;
            }
        }
        private void OpenOrderForm(MenuType panelToShow)
        {
            OrderOverView order = new OrderOverView(this, panelToShow, table, currentEmployee);

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

            listView.Columns.Add("Name", 150);
            listView.Columns.Add("Price", 100);
            listView.Columns.Add("Quantity", 75);
            listView.Columns.Add("Subtotal", 75);

            foreach (OrderItem orderItem in orderItems)
            {
                ListViewItem listViewItem = new ListViewItem(new[]
        {
            orderItem.MenuItem.Name,
            orderItem.MenuItem.Price.ToString("N2"),
            orderItem.Quantity.ToString(),
            orderItem.SubTotal.ToString("N2")
        })
                { Tag = orderItem };

                listView.Items.Add(listViewItem);
            }
            double totalVat = (double)orderService.CalculateTotalVat(orderItems);
            double totalPrice = (double)orderService.CalculateTotalPrice(orderItems);
            LblVatPrice.Text = $"€ {totalVat.ToString("N2")}";
            LblTotalPrice.Text = $"€ {totalPrice.ToString("N2")}";
        }
    }
}
