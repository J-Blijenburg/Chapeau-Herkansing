using Model;
using Logic;
using System.Drawing;

namespace UI
{
    //Code By: Jens Begin *******************************************************
    public partial class OrderOverView : Form
    {
        private Form previousForm;
        private OrderService orderService = new OrderService();
        private ReceiptService receiptService = new ReceiptService();
        private Table table;
        private Employee currentEmployee;
        public OrderOverView(Form previousForm, MenuType panelToShow, Table table, Employee employee)
        {
            InitializeComponent();
            DisplayAllMenuItems();
            ShowCorrectPanel(panelToShow);
            this.previousForm = previousForm;
            this.table = table;
            this.currentEmployee = employee;
            DisplayEmployeeAndTable(employee, table);
            AddColumnsToListView();
            DisableMenuButtons();
        }

        private void DisableMenuButtons()
        {
            List<Menu> menus = orderService.GetListOfMenu();
            Button button = new Button();   

            foreach (Menu menu in menus)
            {
                switch (menu.GetMenuType())
                {
                    case MenuType.Lunch:
                        button = BtnLunch;
                        break;
                    case MenuType.Dinner:
                        button = BtnDinner;
                        break;
                    case MenuType.Drinks:
                        button = BtnDrinks;
                        break;
                }
                       
                if (!menu.CheckMenuTime())
                {
                    button.Enabled = false;
                    button.BackColor = Color.LightGray;
                    button.Text += "\n(Not Available)";
                }
            }
        }

        

        //Every menu item there is from the database will be displayed instantly
        //Instead of loading them in the listview when the user clicks on the menu button
        private void DisplayAllMenuItems()
        {
            try
            {
                //https://stackoverflow.com/questions/105372/how-to-enumerate-an-enum
                //Since we place all the items in the right list, we can loop through the menu types and categories
                foreach (MenuType menuType in (MenuType[])Enum.GetValues(typeof(MenuType)))
                {
                   
                    Menu menu = orderService.GetMenuByMenuType(menuType);
                    menu.SetMenuCategories(orderService.GetMenuCategoriesByMenu(menu));
                    
                    
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

                    foreach (MenuCategory menuCategory in menu.GetMenuCategories())
                    {
                        GetMenuItems(listView, menuType, menuCategory.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetMenuItems(ListView listView, MenuType menuType, Category category)
        {
            FillListViewMenuItems(listView, orderService.GetMenuItemsByMenuAndCategory(menuType.ToString(), category.ToString()), category);
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
        //The given user and table will be displayed in the top right corner
        private void DisplayEmployeeAndTable(Employee employee, Table table)
        {
            LblEmployee.Text = employee.FirstName;
            LblTableNumber.Text = $"Table #{table.Number}";
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
                BtnLunch.BackColor = color;
            }
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

        //This form will be disposed and the previousform will be displayed again.
        //This will make sure that there is only 1 form active
        private void BtnAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                SendOrderItems(this.currentEmployee);
                this.Dispose();
                previousForm.Show();
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
                    Receipt receipt = receiptService.GetReceipt(table);
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
            Order createdOrder =  new Order().CreateOrder(employee, receipt, OrderStatus.Ordered);
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

        //This method will be called when the user clicks on a menuitem
        private void ListViewRowClick(object sender, EventArgs e)
        {
            //check if the item has a color otherwise it is a title category
            ListView listView = (ListView)sender;
            if (!listView.SelectedItems[0].BackColor.IsKnownColor)
            {
                FillListViewOrderdItems((ListView)sender);
            }
        }

        //receive the selected menuitem and add it to the listview of ListViewOrderdItems
        private void FillListViewOrderdItems(ListView listView)
        {
            try
            {
                bool itemExists = false;
                MenuItem menuItem = (MenuItem)listView.SelectedItems[0].Tag;
                foreach (ListViewItem lvItem in ListViewOrderdItems.Items)
                {
                    OrderItem orderItem = (OrderItem)lvItem.Tag;
                    if (menuItem.MenuItemId == orderItem.MenuItem.MenuItemId)
                    {
                        //TODO: What if multiple employees are working on the same order?
                        if (menuItem.GetStock() > orderItem.Quantity)
                        {
                            orderItem.Quantity++;
                            lvItem.Text = orderItem.DisplayQuantityFormat();
                            itemExists = true;
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Not enough stock");
                            itemExists = true;
                            break;
                        }
                    }
                }
                if (!itemExists)
                {
                    AddOrderItemToListView(menuItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //every menuitem will be added as a orderitem to the listview
        private void AddOrderItemToListView(MenuItem menuItem)
        {
            OrderItem orderItem = new OrderItem();
            orderItem.CreateOrderItem("", menuItem, 1);


            ListViewItem listViewItem = new ListViewItem(orderItem.DisplayQuantityFormat());
            listViewItem.SubItems.Add(orderItem.MenuItem.Name);
            listViewItem.SubItems.Add(orderItem.Comment);
            listViewItem.Tag = orderItem;
            ListViewOrderdItems.Items.Add(listViewItem);
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
                        ListViewOrderdItems.Items.Remove(ListViewOrderdItems.SelectedItems[0]);
                    }
                    else
                    {
                        ListViewOrderdItems.SelectedItems[0].Text = orderItem.DisplayQuantityFormat();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnAddOrderItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckOrderdItems())
                {
                    OrderItem selectedOrderItem = (OrderItem)ListViewOrderdItems.SelectedItems[0].Tag;

                    MenuItem menuItem = selectedOrderItem.MenuItem;

                    if (selectedOrderItem.Quantity < menuItem.GetStock())
                    {
                        selectedOrderItem.Quantity++;
                        ListViewOrderdItems.SelectedItems[0].Text = selectedOrderItem.DisplayQuantityFormat();
                    }
                    else
                    {
                        MessageBox.Show("Not enough stock");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    ListViewOrderdItems.Refresh();
                    ShowComment(orderItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void ShowComment(OrderItem orderItem)
        {
            ListViewItem selectedItem = ListViewOrderdItems.SelectedItems[0];
            selectedItem.SubItems[GetColumnIndex(ListViewOrderdItems, "Comment")].Text = orderItem.Comment;
        }

        //To know the right index of a column, the column name will be compared with the column names of the listview
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
        
    }
    //Code By: Jens End *******************************************************
}

