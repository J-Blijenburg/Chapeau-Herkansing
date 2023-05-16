using Model;
using Logic;

namespace UI
{
    public partial class OrderOverView : Form
    {
        //algemeen de structuur goed aanpassen met listviews van de menu etc...
        //een plusje bij de menuitems zetten zodat je ze kan toevoegen aan de listview
        //de listview van lunch, dinner en drinks in 1 listview zetten, en dan gwn de titel in het midden zetten
        //de afwerkingen van de rondjes en de kleuren enzo -> design dingetje


        private Form previousForm;
        private OrderService orderService = new OrderService();
        private ReceiptService receiptService = new ReceiptService();
        private Table table;
        private Employee currentEmployee;
        public OrderOverView(Form previousForm, MenuType panelToShow, Table table, Employee employee)
        {
            InitializeComponent();
            ShowCorrectPanel(panelToShow);
            this.previousForm = previousForm;
            this.table = table;
            this.currentEmployee = employee;
            DisplayTextLabel(employee);

            //dit in een aparte method
            ListViewOrderdItems.Columns.Add("Amount", 100);
            ListViewOrderdItems.Columns.Add("Name", 300);
            ListViewOrderdItems.Columns.Add("Comment", 100);
        }

        //verander methode naam naar dislayEmployeeName
        private void DisplayTextLabel(Employee employee)
        {
            LblEmployee.Text = employee.FirstName;
            LblTableNumber.Text = $"Table #{table.Number}";
        }

        private void BtnLunch_Click(object sender, EventArgs e)
        {
            ShowCorrectPanel(MenuType.Lunch);
            GetAllLunches();
        }

        private void BtnDinner_Click(object sender, EventArgs e)
        {
            ShowCorrectPanel(MenuType.Dinner);
            GetAllDinners();
        }

        private void BtnDrinks_Click(object sender, EventArgs e)
        {
            ShowCorrectPanel(MenuType.Drinks);
            GetAllDrinks();

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
  

        private void ShowCorrectPanel(MenuType panelToShow)
        {
            HideAllPanels();

            //TODO: for later
            //button.BackColor = ColorTranslator.FromHtml("#CAEADB");

            switch (panelToShow)
            {
                case MenuType.Drinks:
                    GetAllDrinks();
                    PnlDrinks.Show();
                    BtnDrinks.BackColor = ColorTranslator.FromHtml("#CAEADB");
                    break;
                case MenuType.Dinner:
                    GetAllDinners();
                    PnlDinner.Show();
                    BtnDinner.BackColor = ColorTranslator.FromHtml("#CAEADB");
                    break;
                case MenuType.Lunch:
                    GetAllLunches();
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
        private void GetAllDrinks()
        {
            try
            {
                //als je een methode maakt die een listview en een list<menuitem> verwacht
                //dan kan je deze 3 methodes in 1 methode zetten
                //
                

                //als je een listmenuitem aanmaakt dan hoef je niet constant orderservice aan te roepen

                //van te voren de menuitems inladen en ingelaad laten zodat ze niet constant opnieuw worden ingeladen
                FillListViewMenuItems(ListDrinksSoft, orderService.GetMenuItemsByMenuAndCategory(MenuType.Drinks.ToString(), Category.SoftDrinks.ToString()));

                FillListViewMenuItems(ListDrinksBeers, orderService.GetMenuItemsByMenuAndCategory(MenuType.Drinks.ToString(), Category.Beers.ToString()));

                FillListViewMenuItems(ListDrinksWines, orderService.GetMenuItemsByMenuAndCategory(MenuType.Drinks.ToString(), Category.Wines.ToString()));

                FillListViewMenuItems(ListDrinksSpirits, orderService.GetMenuItemsByMenuAndCategory(MenuType.Drinks.ToString(), Category.Spirits.ToString()));

                FillListViewMenuItems(ListDrinksHot, orderService.GetMenuItemsByMenuAndCategory(MenuType.Drinks.ToString(), Category.HotDrinks.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetAllLunches()
        {
            try
            {
                //zelfde geldt voor hier
                FillListViewMenuItems(ListLunchStarter, orderService.GetMenuItemsByMenuAndCategory(MenuType.Lunch.ToString(), Category.Starters.ToString()));

                FillListViewMenuItems(ListLunchMains, orderService.GetMenuItemsByMenuAndCategory(MenuType.Lunch.ToString(), Category.Mains.ToString()));

                FillListViewMenuItems(ListLunchDesserts, orderService.GetMenuItemsByMenuAndCategory(MenuType.Lunch.ToString(), Category.Desserts.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        
        private void GetAllDinners()
        {
            try
            {
                //zelfde geldt voor hier
                FillListViewMenuItems(ListDinnerStarter, orderService.GetMenuItemsByMenuAndCategory(MenuType.Dinner.ToString(), Category.Starters.ToString()));
                FillListViewMenuItems(ListDinnerEntre, orderService.GetMenuItemsByMenuAndCategory(MenuType.Dinner.ToString(), Category.Entres.ToString()));

                FillListViewMenuItems(ListDinnerMains, orderService.GetMenuItemsByMenuAndCategory(MenuType.Dinner.ToString(), Category.Mains.ToString()));

                FillListViewMenuItems(ListDinnerDesserts, orderService.GetMenuItemsByMenuAndCategory(MenuType.Dinner.ToString(), Category.Desserts.ToString()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //fill the listview with the given menuitems
        private void FillListViewMenuItems(ListView listView, List<MenuItem> menuItems)
        {
            try
            {
                listView.Clear();

                //maak hier een methode van
                listView.Columns.Add("Name", 375);
                listView.Columns.Add("Price", 100);

                foreach (MenuItem menuItem in menuItems)
                {
                    ListViewItem listViewItem = new ListViewItem(menuItem.Name);
                    listViewItem.SubItems.Add($"€ {menuItem.Price.ToString("N2")}");
                    listViewItem.Tag = menuItem;
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
                //het toevoegen van de orderid kan ook in de DAO laag scheelt weer code
                int orderId = orderService.CreateOrder(order);
                order.SetOrderId(orderId);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return order;

        }

        private void ListViewRowClick(object sender, EventArgs e)
        {
            FillListViewOrderdItems((ListView)sender);
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
                        //de update quantity kan gwn met orderitem.quantity++ of --
                        orderItem.UpdateQuantity(orderItem.Quantity + 1);

                        //dit stukje komt vaker voor in de code, misschien een methode van maken
                        lvItem.Text = $"{orderItem.Quantity}x";
                        itemExists = true;
                        break;
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
                orderItem.UpdateQuantity(orderItem.Quantity - 1);
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
