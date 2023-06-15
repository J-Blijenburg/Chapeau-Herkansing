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
        private const string orderIdColumnName = "OrderId";
        private const string orderItemIdColumnName = "OrderItemId";
        private OrderService orderService;
        private ReceiptService receiptService;
        private Table table;
        private Employee currentEmployee;
        private TableStatusOverview tableStatusOverview;
        public TableOverview(Table table, Employee currentEmployee, TableStatusOverview tableStatusOverview)
        {
            InitializeComponent();
            this.table = table;
            this.currentEmployee = currentEmployee;
            orderService = new OrderService();
            receiptService = new ReceiptService();

            this.SetLabels();
            EnableMenuButtons();
            UpdateOrderItemsListView();
            this.tableStatusOverview = tableStatusOverview;
        }
        private void SetLabels()
        {
            LblEmployee.Text = this.currentEmployee.FirstName;
            LblTableNumber.Text = $"Table {this.table.Number}";
        }
        private void EnableMenuButtons()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while enabling the menu buttons: {ex.Message}");
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
            OrderOverView orderForm = CreateOrderForm(panelToShow);
            orderForm.ShowDialog();
            UpdateOrderItemsListView();
        }
        private OrderOverView CreateOrderForm(MenuType panelToShow)
        {
            return new OrderOverView(this, panelToShow, this.table, currentEmployee);
        }
        private void UpdateOrderItemsListView()
        {
            Receipt receipt = receiptService.GetReceipt(this.table, currentEmployee);
            var orderItems = orderService.GetOrderedItemsByReceiptId(receipt.ReceiptId);
            FillListViewOrderedItems(ListViewOrderdItems, orderItems);
        }
        private void FillListViewOrderedItems(ListView listView, List<OrderItem> orderItems)
        {
            try
            {
                ClearListView(listView);
                AddColumnsToListView(listView);
                AddItemsToListView(listView, orderItems);
                UpdateTotalVatAndPriceLabels(orderItems);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void ClearListView(ListView listView)
        {
            listView.Clear();
        }
        private void AddColumnsToListView(ListView listView)
        {
            listView.Columns.Add("Name", 150);
            listView.Columns.Add("Price", 60);
            listView.Columns.Add("Quantity", 40);
            listView.Columns.Add("Subtotal", 60);
            listView.Columns.Add("Status", 100);
        }

        private void AddItemsToListView(ListView listView, List<OrderItem> orderItems)
        {
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
        }
        private void UpdateTotalVatAndPriceLabels(List<OrderItem> orderItems)
        {
            double totalVat = (double)orderService.CalculateTotalVat(orderItems);
            double totalPrice = (double)orderService.CalculateTotalPrice(orderItems);
            LblVatPrice.Text = $"€ {totalVat.ToString("N2")}";
            LblTotalPrice.Text = $"€ {totalPrice.ToString("N2")}";
        }

        private void BtnPayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            BillForm bill = new BillForm(table, currentEmployee);
            bill.ShowDialog();

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            tableStatusOverview.Show();
        }

        private void btnServed_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus(OrderItemStatus.Delivered);
        }

        private int GetColumnIndex(ListView listView, string columnName)
        {
            int index = 0;
            foreach (ColumnHeader column in listView.Columns)
            {
                if (column.Text == columnName)
                {
                    return index;
                }
                index++;
            }
            return -1;
        }
        private void UpdateOrderStatus(OrderItemStatus status)
        {
            //checks if an order is selected and updates the status of the order item to the selected status 
            if (ListViewOrderdItems.SelectedItems.Count > 0)
            {
                int columnIntegerOrderId = GetColumnIndex(ListViewOrderdItems, orderIdColumnName);
                int columnIntegerOrderItemId = GetColumnIndex(ListViewOrderdItems, orderItemIdColumnName);

                int orderId = Convert.ToInt32(ListViewOrderdItems.SelectedItems[0].SubItems[columnIntegerOrderId].Text);
                int orderItemId = Convert.ToInt32(ListViewOrderdItems.SelectedItems[0].SubItems[columnIntegerOrderItemId].Text);

                orderService.UpdateOrderItemStatus(orderId, status, orderItemId);
                ListViewOrderdItems.Items.Clear();
            }
            else
            {
                MessageBox.Show("Please select an order");
            }
        }
    }
}
