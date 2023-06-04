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

    //TODO
    //barmedewerkers/keukenmedewerkers zouden inzicht moeten hebben in hoe lang een bestelling al open staat
    //eerdere drank/eet-bestellingen  van dezelfde dag moeten ook oproepbaar zijn (filter ‘bestellingen openstaand’ en ‘bestellingen gereed’);


    public partial class KitchenBar : Form
    {
        private OrderService orderService = new OrderService();
        private Employee loggedInEmployeeType;
        private System.Windows.Forms.Timer timer;

        public KitchenBar(Employee employee)
        {
            InitializeComponent();
            CheckLoginRoleAndFillListView(employee);
            loggedInEmployeeType = employee;
            txtBoxUser.Text = employee.GetFullName();

            //initialize the timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 30000; // 30 seconds
            timer.Tick += Timer_Tick;
            timer.Start();

        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            RefreshListView();
        }

        private void RefreshListView()
        {
            CheckLoginRoleAndFillListView(loggedInEmployeeType);
        }

        private void CheckLoginRoleAndFillListView(Employee employee)
        {

            if (employee.Role == EmployeeRole.Bartender)
            {
                GetOrderedItemsBar();
                txtTypeOfOrder.Text = "Bar orders";
            }
            else if (employee.Role == EmployeeRole.Chefkok)
            {
                GetOrderedItemsKitchen();
                txtTypeOfOrder.Text = "Kitchen orders";
            }


        }

        private void GetOrderedItemsKitchen()
        {
            lstViewOrders.Items.Clear();
            FillListViewOrders(lstViewOrders, orderService.GetKitchenOrders());
        }

        private void GetOrderedItemsBar()
        {
            lstViewOrders.Items.Clear();
            FillListViewOrders(lstViewOrders, orderService.GetBarOrders());
        }


        private void FillListViewOrders(ListView listView, List<OrderItem> orderItems)
        {
            try
            {



                foreach (OrderItem orderItem in orderItems)
                {
                    TimeSpan timeDiff = Subtract(orderItem.Order.OrderDateTime);

                    ListViewItem listViewItem = new ListViewItem(orderItem.OrderItemId.ToString());
                    listViewItem.SubItems.Add(orderItem.Comment.ToString());
                    listViewItem.SubItems.Add(orderItem.Quantity.ToString());
                    listViewItem.SubItems.Add($"{timeDiff.Hours:00}:{timeDiff.Minutes:00}:{timeDiff.Seconds:00}");
                    listViewItem.SubItems.Add(orderItem.MenuItem.Name.ToString());
                    listViewItem.SubItems.Add(orderItem.OrderItemStatus.ToString());
                    listViewItem.SubItems.Add(orderItem.Order.OrderId.ToString());
                    listViewItem.Tag = orderItem;
                    listView.Items.Add(listViewItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstViewOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedItems = lstViewOrders.SelectedItems;

            lstViewSelectedOrder.Items.Clear();

            foreach (ListViewItem selectedItem in selectedItems)
            {
                ListViewItem newItem;
                int columnIntegerOrderItemId = GetColumnIndex(lstViewOrders, "OrderItemID");
                int columnIntegerOrderId = GetColumnIndex(lstViewOrders, "OrderId");
                int columnIntegerStatus = GetColumnIndex(lstViewOrders, "Status");

                newItem = new ListViewItem(selectedItem.SubItems[columnIntegerOrderItemId].Text);
                newItem.SubItems.Add(selectedItem.SubItems[columnIntegerStatus].Text);
                newItem.SubItems.Add(selectedItem.SubItems[columnIntegerOrderId].Text);

                lstViewSelectedOrder.Items.Add(newItem);
            }
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
            if (lstViewSelectedOrder.SelectedItems.Count > 0)
            {
                int columnIntegerOrderId = GetColumnIndex(lstViewSelectedOrder, "OrderId");
                int columnIntegerOrderItemId = GetColumnIndex(lstViewSelectedOrder, "OrderItemId");

                int orderId = Convert.ToInt32(lstViewSelectedOrder.SelectedItems[0].SubItems[columnIntegerOrderId].Text);
                int orderItemId = Convert.ToInt32(lstViewSelectedOrder.SelectedItems[0].SubItems[columnIntegerOrderItemId].Text);

                orderService.UpdateOrderItemStatus(orderId, status, orderItemId);
                lstViewOrders.Items.Clear();
                lstViewSelectedOrder.Items.Clear();
                CheckLoginRoleAndFillListView(loggedInEmployeeType);
            }
            else
            {
                MessageBox.Show("Please select an order");
            }
        }

        private void btnInPrep_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus(Model.OrderItemStatus.Preparing);

        }

        private void btnPrepared_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus(Model.OrderItemStatus.ReadyToBeServed);
        }

        private void btnServed_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus(Model.OrderItemStatus.Delivered);
        }

        private TimeSpan Subtract(DateTime value)
        {
            DateTime dateNow = DateTime.Now;
            TimeSpan diff = dateNow.Subtract(value);
            return diff;
        }
    }
}
