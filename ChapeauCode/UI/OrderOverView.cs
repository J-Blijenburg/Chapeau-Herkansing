using Model;
using Logic;

namespace UI
{
    public partial class OrderOverView : Form
    {
        //een plusje bij de menuitems zetten zodat je ze kan toevoegen aan de listview
        //de afwerkingen van de rondjes en de kleuren enzo -> design dingetje
        private Form previousForm;
        private OrderService orderService = new OrderService();
        private ReceiptService receiptService = new ReceiptService();
        private Table table;
        private Employee currentEmployee;
        public OrderOverView(Form previousForm, MenuType panelToShow, Table table, Employee employee)
        {
            InitializeComponent();
            GetAllMenuItemsDisplayed();
            ShowCorrectPanel(panelToShow);
            this.previousForm = previousForm;
            this.table = table;
            this.currentEmployee = employee;
            DisplayEmployeeAndTable(employee, table);
            AddColumnsToListView();
        }

        private void GetAllMenuItemsDisplayed()
        {
            try
            {
                //als je een methode maakt die een listview en een list<menuitem> verwacht
                //dan kan je deze 3 methodes in 1 methode zetten

                //als je een listmenuitem aanmaakt dan hoef je niet constant orderservice aan te roepen

                FillListViewMenuItems(ListDrinks, orderService.GetMenuItemsByMenuAndCategory(MenuType.Drinks.ToString(), Category.SoftDrinks.ToString()), Category.SoftDrinks);
                FillListViewMenuItems(ListDrinks, orderService.GetMenuItemsByMenuAndCategory(MenuType.Drinks.ToString(), Category.Beers.ToString()), Category.Beers);
                FillListViewMenuItems(ListDrinks, orderService.GetMenuItemsByMenuAndCategory(MenuType.Drinks.ToString(), Category.Wines.ToString()), Category.Wines);
                FillListViewMenuItems(ListDrinks, orderService.GetMenuItemsByMenuAndCategory(MenuType.Drinks.ToString(), Category.Spirits.ToString()), Category.Spirits);
                FillListViewMenuItems(ListDrinks, orderService.GetMenuItemsByMenuAndCategory(MenuType.Drinks.ToString(), Category.HotDrinks.ToString()), Category.HotDrinks);

                FillListViewMenuItems(ListLunch, orderService.GetMenuItemsByMenuAndCategory(MenuType.Lunch.ToString(), Category.Starters.ToString()), Category.Starters);
                FillListViewMenuItems(ListLunch, orderService.GetMenuItemsByMenuAndCategory(MenuType.Lunch.ToString(), Category.Mains.ToString()), Category.Mains);
                FillListViewMenuItems(ListLunch, orderService.GetMenuItemsByMenuAndCategory(MenuType.Lunch.ToString(), Category.Desserts.ToString()), Category.Desserts);

                FillListViewMenuItems(ListDinner, orderService.GetMenuItemsByMenuAndCategory(MenuType.Dinner.ToString(), Category.Starters.ToString()), Category.Starters);
                FillListViewMenuItems(ListDinner, orderService.GetMenuItemsByMenuAndCategory(MenuType.Dinner.ToString(), Category.Entres.ToString()), Category.Entres);
                FillListViewMenuItems(ListDinner, orderService.GetMenuItemsByMenuAndCategory(MenuType.Dinner.ToString(), Category.Mains.ToString()), Category.Mains);
                FillListViewMenuItems(ListDinner, orderService.GetMenuItemsByMenuAndCategory(MenuType.Dinner.ToString(), Category.Desserts.ToString()), Category.Desserts);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowCorrectPanel(MenuType panelToShow)
        {
            HideAllPanels();
            //TODO: for later
            //button.BackColor = ColorTranslator.FromHtml("#CAEADB");

            switch (panelToShow)
            {
                case MenuType.Drinks:
                    PnlDrinks.Show();
                    BtnDrinks.BackColor = ColorTranslator.FromHtml("#CAEADB");
                    break;
                case MenuType.Dinner:
                    PnlDinner.Show();
                    BtnDinner.BackColor = ColorTranslator.FromHtml("#CAEADB");
                    break;
                case MenuType.Lunch:
                    PnlLunch.Show();
                    BtnLunch.BackColor = ColorTranslator.FromHtml("#CAEADB");
                    break;
            }
        }

        private void HideAllPanels()
        {
            PnlDrinks.Hide();
            PnlLunch.Hide();
            PnlDinner.Hide();

            BtnLunch.BackColor = ColorTranslator.FromHtml("#8AD2B0");
            BtnDinner.BackColor = ColorTranslator.FromHtml("#8AD2B0");
            BtnDrinks.BackColor = ColorTranslator.FromHtml("#8AD2B0");
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
                SendOrderItems(this.currentEmployee);

                //This form will be disposed and the previousform will be displayed again.
                //This will make sure that there is only 1 form active
                this.Dispose();
                previousForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void SendOrderItems(Employee employee)
        {
            try
            {
                if (ListViewOrderdItems.Items.Count != 0)
                {
                    //Had eerst de class zo gemaakt dat de order al in de constructor werdt aangemaakt
                    //Maar op het moment dat de order wordt gecanceld, moet je het weer verwijderen uit de database

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

            ListView listView = (ListView)sender;
            //check if the item has a color otherwise it is a title category
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
                        if (menuItem.Stock >= orderItem.Quantity)
                        {
                            orderItem.Quantity++;

                            //dit stukje komt vaker voor in de code, misschien een methode van maken
                            lvItem.Text = $"{orderItem.Quantity}x";
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
                    OrderItem orderItem = new OrderItem("", menuItem, 1);
                    ListViewItem listViewItem = new ListViewItem($"{orderItem.Quantity}x");
                    listViewItem.SubItems.Add(orderItem.MenuItem.Name);
                    listViewItem.SubItems.Add(orderItem.Comment);
                    listViewItem.Tag = orderItem;
                    ListViewOrderdItems.Items.Add(listViewItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnRemoveOrderItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Omdat het niet onverwachts is kan je beter iets anders dan een exception gooien
                CheckOrderdItems();

                OrderItem orderItem = (OrderItem)ListViewOrderdItems.SelectedItems[0].Tag;
                orderItem.Quantity--;
                if (orderItem.Quantity == 0)
                {
                    ListViewOrderdItems.Items.Remove(ListViewOrderdItems.SelectedItems[0]);
                }
                else
                {
                    //dit stukje komt vaker voor in de code, misschien een methode van maken
                    ListViewOrderdItems.SelectedItems[0].Text = $"{orderItem.Quantity}x";
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
                //Omdat het niet onverwachts is kan je beter iets anders dan een exception gooien

                CheckOrderdItems();

                OrderItem orderItem = (OrderItem)ListViewOrderdItems.SelectedItems[0].Tag;

                OrderComment orderComment = new OrderComment(this, orderItem);
                this.Hide();
                orderComment.ShowDialog();

                ShowComment(orderItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CheckOrderdItems()
        {
            //Omdat het niet onverwachts is kan je beter iets anders dan een exception gooien

            if (ListViewOrderdItems.SelectedItems.Count == 0)
            {
                throw new Exception("Please, select an item!");
            }
        }

        private void ShowComment(OrderItem orderItem)
        {

            ListViewItem selectedItem = ListViewOrderdItems.SelectedItems[0];
            //dit ziet er niet heel netjes uit. Je wilt voorkomen dat je de index van de subitems moet weten
            selectedItem.SubItems[2].Text = orderItem.Comment;
        }
    }
}
