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
            this.login = login;
            //initialize the timer
            InitializeTimer(login);
        }

        private void InitializeTimer(Login login)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 30000; // 30 seconds
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
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

        //gets the running order items based on the employee role
        private void GetRunningOrderItems(EmployeeRole employeeRole)
        {
            lstViewOrders.Items.Clear();

            try
            {
                if (employeeRole == EmployeeRole.Bartender)
                {
                    FillListViewOrders(lstViewOrders, orderService.GetRunningOrderItems(MenuType.Drinks));
                }
                else
                {
                    FillListViewOrders(lstViewOrders, orderService.GetRunningOrderItems(MenuType.Dinner));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There was an error gathering the order items, please contact support, \n {ex.Message}");
            }
        }

        //gets the finished order items based on the employee role
        private void GetFinishedItems(EmployeeRole employeeRole)
        {
            lstViewOrders.Items.Clear();

            try
            {
                if (employeeRole == EmployeeRole.Bartender)
                {
                    FillListViewOrders(lstViewOrders, orderService.GetFinishedOrderItems(MenuType.Drinks));
                }
                else
                {
                    FillListViewOrders(lstViewOrders, orderService.GetFinishedOrderItems(MenuType.Dinner));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There was an error gathering the order items, please contact support, \n {ex.Message}");
            }
        }


        private void FillListViewOrders(ListView listView, List<OrderItem> orderItems)
        {

            //filling the listview with the order items
            foreach (OrderItem orderItem in orderItems)
            {


                ListViewItem listViewItem = new ListViewItem(orderItem.OrderItemId.ToString());
                listViewItem.SubItems.Add(orderItem.Order.Receipt.Table.GetNumber().ToString());
                listViewItem.SubItems.Add(orderItem.Comment.ToString());
                listViewItem.SubItems.Add(orderItem.Quantity.ToString());
                listViewItem.SubItems.Add(orderItem.Order.GetOrderItemWaitTime());
                listViewItem.SubItems.Add(orderItem.Order.OrderDateTime.ToString("H:mm:ss"));
                listViewItem.SubItems.Add(orderItem.MenuItem.Name.ToString());
                listViewItem.SubItems.Add(orderItem.OrderItemStatus.ToString());
                listViewItem.SubItems.Add(orderItem.Order.OrderId.ToString());
                listViewItem.Tag = orderItem;
                listView.Items.Add(listViewItem);
            }


        }

        
        private void lstViewOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstViewSelectedOrder.Items.Clear();
            foreach (ListViewItem selectedItem in lstViewOrders.SelectedItems)
            {
                if (selectedItem.Tag is OrderItem orderItem)
                {
                    ListViewItem listViewItem = new ListViewItem(orderItem.OrderItemId.ToString());
                    listViewItem.SubItems.Add(orderItem.OrderItemStatus.ToString());
                    listViewItem.SubItems.Add(orderItem.Order.OrderId.ToString());

                    lstViewSelectedOrder.Items.Add(listViewItem);
                    
                }
            }
        }

        private void UpdateOrderStatus(OrderItemStatus status)
        {
            //checks if an order is selected and updates the status of the order item(s) to the selected status 
            if (lstViewSelectedOrder.SelectedItems.Count > 0)
            {
                foreach(ListViewItem selectedItem in lstViewOrders.SelectedItems)
                {
                    OrderItem orderItem = (OrderItem)selectedItem.Tag;
                    orderService.UpdateOrderItemStatus(orderItem.Order.OrderId, status, orderItem.OrderItemId);
                }

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
            timer.Stop();
            loggedInEmployee = null;
            this.Close();
            login.Show();
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
    }
}
