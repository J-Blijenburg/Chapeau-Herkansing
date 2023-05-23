using Model;
using Logic;
using System.Collections.Generic;

namespace UI
{
    public partial class OrderOverView : Form
    {
        //een plusje bij de menuitems zetten zodat je ze kan toevoegen aan de listview
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
        }

        private void DisplayAllMenuItems()
        {
            try
            {
                //https://stackoverflow.com/questions/105372/how-to-enumerate-an-enum

                //place all the categories in a list depending on the menu type
                List<Category> drinks = new List<Category>() { Category.SoftDrinks, Category.Beers, Category.Wines, Category.Spirits, Category.HotDrinks };
                List<Category> lunch = new List<Category>() { Category.Starters, Category.Mains, Category.Desserts };
                List<Category> dinner = new List<Category>() { Category.Starters, Category.Entres, Category.Mains, Category.Desserts };

                foreach (MenuType menuType in (MenuType[]) Enum.GetValues(typeof(MenuType)))
                {
                    ListView listView = new ListView();
                    List<Category> categories = new List<Category>();

                    switch (menuType)
                    {
                            case MenuType.Drinks:
                                listView = ListDrinks;
                                categories.AddRange(drinks);
                                break;
                            case MenuType.Dinner:
                                listView = ListDinner;
                                categories.AddRange(dinner);
                                break;
                            case MenuType.Lunch:
                                listView = ListLunch;
                                categories.AddRange(lunch);
                                break;
                    }

                    foreach (Category category in categories)
                    {
                        GetMenuItems(listView, menuType, category);
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

        //fill the listview with the given menuitems
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
                    listViewItem.SubItems.Add($"€ {menuItem.Price.ToString("N2")}");
                    listViewItem.SubItems.Add(menuItem.Stock.ToString());
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
            button.BackColor = ColorTranslator.FromHtml("#CAEADB");
        }
        private void HideAllPanels()
        {
            PnlDrinks.Hide();
            PnlLunch.Hide();
            PnlDinner.Hide();

            Color color = ColorTranslator.FromHtml("#8AD2B0");

            BtnLunch.BackColor = color;
            BtnDinner.BackColor = color;
            BtnDrinks.BackColor = color;
        }

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
        private void DisplayEmployeeAndTable(Employee employee, Table table)
        {
            LblEmployee.Text = employee.FirstName;
            LblTableNumber.Text = $"Table #{table.Number}";
        }
        private void BtnPay_Click(object sender, EventArgs e)
        {
            try
            {
                //This form will be disposed and the previousform will be displayed again.
                //This will make sure that there is only 1 form active

                SendOrderItems(this.currentEmployee);
                this.Dispose();
                previousForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

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

                        order.OrderItems.Add(orderItem);
                    }
                    orderService.SendOrderItems(order);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private Order CreateOrder(Receipt receipt, Employee employee)
        {

            Order order = new Order(employee, receipt, DateTime.Now, OrderStatus.Ordered);
            try
            {
                orderService.CreateOrder(order);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return order;
        }

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
                        if (menuItem.Stock > orderItem.Quantity)
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

        private void AddOrderItemToListView(MenuItem menuItem)
        {
            OrderItem orderItem = new OrderItem("", menuItem, 1);
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
}

