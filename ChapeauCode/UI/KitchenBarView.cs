using Logic;
using Model;

namespace UI
{

    public partial class KitchenBarView : Form
    {
        private OrderService orderService = new OrderService();
        private Employee loggedInEmployee;
        private System.Windows.Forms.Timer timer;
        private Login login;

        public KitchenBarView(Employee employee, Login login)
        {
            InitializeComponent();
            loggedInEmployee = employee;
            txtBoxUser.Text = employee.FullName;
            CheckRoleAndSetLabels(employee.Role);

            //initialize the timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 30000; // 30 seconds
            timer.Tick += Timer_Tick;
            timer.Start();
            this.login = login;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            RefreshListView();
        }

        private void RefreshListView()
        {
            CheckWhichTypeOfOrdersToGet();
        }

        //gets the items based on the selected radio button
        private void CheckWhichTypeOfOrdersToGet()
        {
            if (rdbRunningOrders.Checked)
            {
                GetRunningOrderItems(loggedInEmployee.Role);
            }
            else if (rdbFinishedOrders.Checked)
            {
                GetFinishedItems(loggedInEmployee.Role);
            }
        }

        //checks the role of the logged in employee and sets the labels accordingly
        private void CheckRoleAndSetLabels(EmployeeRole employeeRole)
        {

            if (employeeRole == EmployeeRole.Bartender)
            {
                txtTypeOfOrder.Text = "Bar orders";
            }
            else
            {
                txtTypeOfOrder.Text = "Kitchen orders";
            }
        }

        //gets the running order items based on the employee role
        private void GetRunningOrderItems(EmployeeRole employeeRole)
        {
            lstViewOrders.Items.Clear();

            if (employeeRole == EmployeeRole.Bartender)
            {
                FillListViewOrders(lstViewOrders, orderService.GetRunningOrderItems(MenuType.Drinks));
            }
            else
            {
                FillListViewOrders(lstViewOrders, orderService.GetRunningOrderItems(MenuType.Dinner));
            }
        }

        //gets the finished order items based on the employee role
        private void GetFinishedItems(EmployeeRole employeeRole)
        {
            lstViewOrders.Items.Clear();

            if (employeeRole == EmployeeRole.Bartender)
            {
                FillListViewOrders(lstViewOrders, orderService.GetFinishedOrderItems(MenuType.Drinks));
            }
            else
            {
                FillListViewOrders(lstViewOrders, orderService.GetFinishedOrderItems(MenuType.Dinner));
            }
        }


        private void FillListViewOrders(ListView listView, List<OrderItem> orderItems)
        {

            //filling the listview with the order items
            foreach (OrderItem orderItem in orderItems)
            {
                

                ListViewItem listViewItem = new ListViewItem(orderItem.OrderItemId.ToString());
                listViewItem.SubItems.Add(orderItem.Comment.ToString());
                listViewItem.SubItems.Add(orderItem.Quantity.ToString());
                listViewItem.SubItems.Add(orderItem.Order.GetOrderItemWaitTime());
                listViewItem.SubItems.Add(orderItem.MenuItem.Name.ToString());
                listViewItem.SubItems.Add(orderItem.OrderItemStatus.ToString());
                listViewItem.SubItems.Add(orderItem.Order.OrderId.ToString());
                listViewItem.Tag = orderItem;
                listView.Items.Add(listViewItem);
            }


        }

        private void lstViewOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedItems = lstViewOrders.SelectedItems;

            lstViewSelectedOrder.Items.Clear();

            //filling the listview with the selected order item from the listview with all order items
            foreach (ListViewItem selectedItem in selectedItems)
            {
                ListViewItem listViewItem;
                int columnIntegerOrderItemId = GetColumnIndex(lstViewOrders, "OrderItemID");
                int columnIntegerOrderId = GetColumnIndex(lstViewOrders, "OrderId");
                int columnIntegerStatus = GetColumnIndex(lstViewOrders, "Status");

                listViewItem = new ListViewItem(selectedItem.SubItems[columnIntegerOrderItemId].Text);
                listViewItem.SubItems.Add(selectedItem.SubItems[columnIntegerStatus].Text);
                listViewItem.SubItems.Add(selectedItem.SubItems[columnIntegerOrderId].Text);

                lstViewSelectedOrder.Items.Add(listViewItem);
            }
        }

        //method by jens
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
            if (lstViewSelectedOrder.SelectedItems.Count > 0)
            {
                int columnIntegerOrderId = GetColumnIndex(lstViewSelectedOrder, "OrderId");
                int columnIntegerOrderItemId = GetColumnIndex(lstViewSelectedOrder, "OrderItemId");

                int orderId = Convert.ToInt32(lstViewSelectedOrder.SelectedItems[0].SubItems[columnIntegerOrderId].Text);
                int orderItemId = Convert.ToInt32(lstViewSelectedOrder.SelectedItems[0].SubItems[columnIntegerOrderItemId].Text);

                orderService.UpdateOrderItemStatus(orderId, status, orderItemId);
                lstViewOrders.Items.Clear();
                lstViewSelectedOrder.Items.Clear();
                CheckWhichTypeOfOrdersToGet();
            }
            else
            {
                MessageBox.Show("Please select an order");
            }
        }

        //buttons for updating the status of the order item
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

        private void rdbFinishedOrders_CheckedChanged(object sender, EventArgs e)
        {
            ToggleButtons(false);
            GetFinishedItems(loggedInEmployee.Role);
        }


        private void rdbRunningOrders_CheckedChanged(object sender, EventArgs e)
        {
            ToggleButtons(true);
            GetRunningOrderItems(loggedInEmployee.Role);
        }

        // turn buttons on or off based on the selected radio button
        private void ToggleButtons(bool enabled)
        {
            btnInPrep.Enabled = enabled;
            btnPrepared.Enabled = enabled;
            btnServed.Enabled = enabled;
        }


        private void btnSignOff_Click(object sender, EventArgs e)
        {
            //signs off the logged in employee and closes the current form before opening the login form
            loggedInEmployee = null;
            Login loginForm = new Login();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
