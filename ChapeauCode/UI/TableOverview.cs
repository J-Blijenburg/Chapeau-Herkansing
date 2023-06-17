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
        private ReceiptService receiptService;
        private Table table;
        private Employee currentEmployee;
        private TableStatusOverview tableStatusOverview;
        private Receipt currentReceipt;
        private TimeSpan orderStartDateTime;
        public TableOverview(Table table, Employee currentEmployee, TableStatusOverview tableStatusOverview)
        {
            this.InitializeComponent();
            orderService = new OrderService();
            receiptService = new ReceiptService();
            this.table = table;
            this.currentEmployee = currentEmployee;
            this.tableStatusOverview = tableStatusOverview;

            this.EnableMenuButtons();
            this.UpdateOrderItemsListView();

            Initializer();
        }
        private void Initializer()
        {
            try
            {
                orderStartDateTime = orderService.GetOrderElapsedTime(this.currentReceipt.ReceiptId);
                timeUpdateTimer.Start();
                timeUpdateTimer.Tick += timeUpdateTimer_Tick;
                timeUpdateTimer.Interval = 1000;
                tableUpdateTimer.Interval = 10000;
                tableUpdateTimer.Tick += tableUpdateTimer_Tick;
                tableUpdateTimer.Start();
                SetLabels();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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
            OrderOverView orderForm = new(this, panelToShow, this.table, currentEmployee);
            this.Hide();
            orderForm.ShowDialog();
            UpdateOrderItemsListView();
        }
        private void UpdateOrderItemsListView()
        {
            try
            {
                currentReceipt = receiptService.GetReceipt(this.table, currentEmployee);
                List<OrderItem> orderItems = orderService.GetOrderedItemsByReceiptId(currentReceipt.ReceiptId);
                FillListViewOrderedItems(ListViewOrderdItems, orderItems);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);

            }

        }

        private void FillListViewOrderedItems(ListView listView, List<OrderItem> orderItems)
        {
            ClearListView(listView);
            AddColumnsToListView(listView);
            AddItemsToListView(listView, orderItems);
            UpdateTotalVatAndPriceLabels(orderItems);
        }
        private void ClearListView(ListView listView)
        {
            listView.Clear();
        }
        private void AddColumnsToListView(ListView listView)
        {
            listView.Columns.Add("Name", 150);
            listView.Columns.Add("Price", 60);
            listView.Columns.Add("Qty", 40);
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
                    orderItem.SubTotal.ToString("N2"),
                    orderItem.OrderItemStatus.ToString()
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
        private void UpdateOrderStatus(OrderItemStatus status)
        {
            if (ListViewOrderdItems.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = ListViewOrderdItems.SelectedItems[0];
                OrderItem orderItem = selectedItem.Tag as OrderItem;

                if (orderItem != null)
                {
                    try
                    {
                        orderService.UpdateOrderItemStatusByWaiter(orderItem.OrderItemId, status);
                    }
                    catch (InvalidOperationException e)
                    {
                        // Display the error message to the user
                        MessageBox.Show(e.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid item selected");
                }
            }
            else
            {
                MessageBox.Show("Please select an order item");
            }
        }

        private void tableUpdateTimer_Tick(object sender, EventArgs e)
        {
            UpdateOrderItemsListView();
        }
        private void timeUpdateTimer_Tick(object sender, EventArgs e)
        {
            // Refresh the receipt
            currentReceipt = receiptService.GetReceipt(this.table, currentEmployee);

            TimeSpan elapsedTime = orderService.GetOrderElapsedTime(currentReceipt.ReceiptId);
            orderWaitTimeLbl.Text = $"Order running for: {elapsedTime.Hours:D2}:{elapsedTime.Minutes:D2}:{elapsedTime.Seconds:D2}";
        }


    }
}
