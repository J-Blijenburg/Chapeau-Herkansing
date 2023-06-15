using Model;
using Logic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace UI
{
    //Code By: Jens Begin *******************************************************
    public partial class OrderOverView : Form
    {
        private Form previousForm;
        private OrderService orderService;
        private ReceiptService receiptService;
        private Table table;
        private Employee currentEmployee;
        private List<OrderItem> listOfOrderItems;
        public OrderOverView(Form previousForm, MenuType panelToShow, Table table, Employee employee)
        {
            InitializeComponent();
            orderService = new OrderService();
            receiptService = new ReceiptService();
            listOfOrderItems = new List<OrderItem>();
            List<Menu> menus = orderService.GetListOfMenu();

            DisplayEmployeeAndTable(employee, table);
            AddColumnsToListView();

            DisplayAllMenuItems(menus);
            ShowCorrectPanel(panelToShow);
            EnableMenuButtons(menus);

            this.previousForm = previousForm;
            this.table = table;
            this.currentEmployee = employee;
        }

        //****The following code is mostly focused on displaying the right items*****

        //The given user and table will be displayed in the top right corner
        private void DisplayEmployeeAndTable(Employee employee, Table table)
        {
            LblEmployee.Text = employee.GetFirstName();
            LblTableNumber.Text = $"Table #{table.Number}";
        }

        //when loading the orderviewform it will add all the columns to the listviews
        private void AddColumnsToListView()
        {
            //Add columns to the orderd items listview
            AddColumn(ListViewOrderdItems, "Amount", 100);
            AddColumn(ListViewOrderdItems, "Name", 300);
            AddColumn(ListViewOrderdItems, "Comment", 100);

            //Add columns to the menu listviews
            AddColumn(ListDinner, "", 375);
            AddColumn(ListDinner, "", 100);
            AddColumn(ListDrinks, "", 375);
            AddColumn(ListDrinks, "", 100);
            AddColumn(ListLunch, "", 375);
            AddColumn(ListLunch, "", 100);
        }

        private void AddColumn(ListView listView, string name, int width)
        {
            listView.Columns.Add(name, width);
        }


        //check which Menu button is imported and enable the button
        private void EnableMenuButtons(List<Menu> menus)
        {
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
        }

        //Every menu item there is from the database will be displayed instantly
        //Instead of loading them in the listview when the user clicks on the menu button
        private void DisplayAllMenuItems(List<Menu> menus)
        {
            try
            {
                foreach (Menu menu in menus)
                {
                    menu.SetMenuCategories(orderService.GetMenuCategoriesByMenu(menu));
                    ListView listView = GetListViewByMenuType(menu.GetMenuType());
                    foreach (MenuCategory menuCategory in menu.GetMenuCategories())
                    {
                        FillListViewMenuItems(listView, orderService.GetMenuItemsByMenuAndCategory(menu, menuCategory), menuCategory.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private ListView GetListViewByMenuType(MenuType menuType)
        {
            ListView listView = new ListView();
            switch (menuType)
            {
                case MenuType.Drinks:
                    listView = ListDrinks;
                    break;
                case MenuType.Dinner:
                    listView = ListDinner;
                    break;
                case MenuType.Lunch:
                    listView = ListLunch;
                    break;
            }
            return listView;
        }

        //every time a list of menuitems is added it will place the name of the category above the menuitems
        private void FillListViewMenuItems(ListView listView, List<MenuItem> menuItems, Category menuCategory)
        {
            try
            {
                ListViewItem list = new ListViewItem();
                list.Text = menuCategory.ToString();
                list.Font = new Font("Arial", 12, FontStyle.Bold);
                listView.Items.Add(list);

                foreach (MenuItem menuItem in menuItems)
                {
                    ListViewItem listViewItem = new ListViewItem(menuItem.Name);
                    listViewItem.SubItems.Add(menuItem.GetPriceFormat());
                    listViewItem.SubItems.Add(menuItem.GetStock().ToString());
                    listViewItem.Tag = menuItem;
                    listViewItem.BackColor = ColorTranslator.FromHtml("#C4C4C4");
                    listView.Items.Add(listViewItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        //When the user changes the category it will show the right panel
        private void BtnLunch_Click(object sender, EventArgs e)
        {
            ShowCorrectPanel(MenuType.Lunch);
        }

        private void BtnDinner_Click(object sender, EventArgs e)
        {
            ShowCorrectPanel(MenuType.Dinner);
        }

        private void BtnDrinks_Click(object sender, EventArgs e)
        {
            ShowCorrectPanel(MenuType.Drinks);
        }

        //When the user clicks on a category button it will display the right panel
        private void ShowCorrectPanel(MenuType panelToShow)
        {
            HideAllPanels();
            Button button = new Button();
            switch (panelToShow)
            {
                case MenuType.Drinks:
                    PnlDrinks.Show();
                    button = BtnDrinks;
                    break;
                case MenuType.Dinner:
                    PnlDinner.Show();
                    button = BtnDinner;
                    break;
                case MenuType.Lunch:
                    PnlLunch.Show();
                    button = BtnLunch;
                    break;
            }
            //By changing the backcolor of the button the user will know which panel is active
            button.BackColor = ColorTranslator.FromHtml("#CAEADB");
        }

        //To make sure the panels don't overlap each other, It will hide all the panels before showing the right one
        private void HideAllPanels()
        {
            PnlDrinks.Hide();
            PnlLunch.Hide();
            PnlDinner.Hide();

            Color color = ColorTranslator.FromHtml("#8AD2B0");

            CheckEnabledButton(BtnLunch, color);
            CheckEnabledButton(BtnDinner, color);
            CheckEnabledButton(BtnDrinks, color);
        }

        private void CheckEnabledButton(Button button, Color color)
        {
            if (button.Enabled)
            {
                button.BackColor = color;
            }
        }

        //*****The following is for add/update/remove orderd items *****

        //This method will be called when the user clicks on a menuitem
        private void ListViewRowClick(object sender, EventArgs e)
        {
            //check if the item has a color otherwise it is a title category
            ListView listView = (ListView)sender;

            if (!listView.SelectedItems[0].BackColor.IsKnownColor)
            {
                MenuItem menuItem = (MenuItem)listView.SelectedItems[0].Tag;

                UpdateOrderItem(menuItem);
                LoadOrderItemsIntoListView();
            }
        }

        private void UpdateOrderItem(MenuItem menuItem)
        {
            //Goes through every selected order items and adjust the quantity when item is already in the List<OrderItem>
            //else it creates and add that item
            bool itemExists = false;
    
            foreach (OrderItem orderItem in listOfOrderItems)
            {
                if (menuItem.MenuItemId == orderItem.MenuItem.MenuItemId)
                {
                    CheckAndUpdateQuantity(menuItem, orderItem);
                    itemExists = true;  
                }
            }

            if (!itemExists)
            {
                CreateOrderItem(menuItem);
            }
        }

        private void CreateOrderItem(MenuItem menuItem)
        {
            OrderItem orderItem = new OrderItem();
            orderItem.CreateOrderItem("", menuItem, 1, OrderItemStatus.Ordered);

            //also add it to the list of orderitems
            listOfOrderItems.Add(orderItem);
        }

        private void BtnRemoveOrderItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckOrderdItems())
                {
                    OrderItem orderItem = (OrderItem)ListViewOrderdItems.SelectedItems[0].Tag;
                    orderItem.Quantity--;
                    if (orderItem.Quantity == 0)
                    {
                        listOfOrderItems.Remove(orderItem);
                    }
                    LoadOrderItemsIntoListView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void BtnAddQuantity_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckOrderdItems())
                {
                    //Update the quantity in the List<OrderItem> and reload the listview
                    OrderItem selectedOrderItem = (OrderItem)ListViewOrderdItems.SelectedItems[0].Tag;
                    MenuItem menuItem = selectedOrderItem.GetMenuItem();

                    CheckAndUpdateQuantity(menuItem, selectedOrderItem);
                    LoadOrderItemsIntoListView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckAndUpdateQuantity(MenuItem menuItem, OrderItem orderItem)
        {
            if (menuItem.GetStock() > orderItem.Quantity)
            {
                orderItem.AddQuantity(1);
            }
            else
            {
                MessageBox.Show("Not enough stock");
            }
        }

        private void BtnAddCommentOrderItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckOrderdItems())
                {
                    OrderItem orderItem = (OrderItem)ListViewOrderdItems.SelectedItems[0].Tag;
                    OrderComment orderComment = new OrderComment(this, orderItem);
                    this.Hide();
                    orderComment.ShowDialog();

                    LoadOrderItemsIntoListView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Every orderd item that has been placed into the List<OrderItem>, will be shown in a ListView
        private void LoadOrderItemsIntoListView()
        {
            ListViewOrderdItems.Items.Clear();

            foreach (OrderItem orderItem in listOfOrderItems)
            {
                AddListViewItem(ListViewOrderdItems, orderItem);
            }
        }

        private void AddListViewItem(ListView listView, OrderItem orderItem)
        {
            ListViewItem listViewItem = new ListViewItem(orderItem.DisplayQuantityFormat());
            listViewItem.SubItems.Add(orderItem.MenuItem.GetName());
            listViewItem.SubItems.Add(orderItem.GetComment());
            listViewItem.Tag = orderItem;
            listView.Items.Add(listViewItem);
        }

        //When the user doesn't have any items selected it will show a message
        private bool CheckOrderdItems()
        {
            if (ListViewOrderdItems.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please, select an item!");
                return true;
            }
            return false;
        }

        //******The following code is focused on placing a order *********

        //This form will be disposed and the previousform will be displayed again.
        //This will make sure that there is only 1 form active
        private void BtnAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                SendOrderItems(this.currentEmployee);
                ShowPreviousForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //When the user doesn't have any items selected it will go back to the previous form
        //without adding an order
        private void SendOrderItems(Employee employee)
        {
            try
            {
                if (ListViewOrderdItems.Items.Count != 0)
                {
                    Receipt receipt = receiptService.GetReceipt(table, currentEmployee);
                    Order order = CreateOrder(receipt, employee);

                    foreach (ListViewItem item in ListViewOrderdItems.Items)
                    {
                        OrderItem orderItem = (OrderItem)item.Tag;
                        orderItem.Order = order;

                        order.AddOrderItemToOrder(orderItem);
                    }
                    orderService.SendOrderItems(order);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //First a order will be created and then it will be send to the database
        //If it is added to the database it will return an id and add it to the order
        private Order CreateOrder(Receipt receipt, Employee employee)
        {
            Order createdOrder = new Order().CreateOrder(employee, receipt, OrderStatus.InProgress);
            try
            {
                orderService.CreateOrder(createdOrder);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return createdOrder;
        }

        //The user has an option to cancel the entire order but it will ask for confirmation
        private void BtnCancelOrder_Click(object sender, EventArgs e)
        {
            //https://stackoverflow.com/questions/3036829/how-do-i-create-a-message-box-with-yes-no-choices-and-a-dialogresult
            //Apparantly MessageboxButtons will be displayed in dutch instead of english
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel the order?", "Cancel Order", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ShowPreviousForm();
            }
        }

        private void ShowPreviousForm()
        {
            this.Dispose();
            previousForm.Show();
        }
    }
    //Code By: Jens End *******************************************************
}

