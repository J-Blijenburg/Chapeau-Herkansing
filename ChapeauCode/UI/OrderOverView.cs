using Model;
using Logic;

namespace UI
{
    public partial class OrderOverView : Form
    {
        private Form previousForm;
        private OrderService orderService = new OrderService();
        private ReceiptService receiptService = new ReceiptService();
        private Table table;
        private Employee currentEmployee;
        public OrderOverView(Form previousForm, string panelToShow, Table table, Employee employee)
        {
            InitializeComponent();
            ShowCorrectPanel(panelToShow);
            this.previousForm = previousForm;
            this.table = table;
            this.currentEmployee = employee;
            DisplayTextLabel(employee);

            ListViewOrderdItems.Columns.Add("Amount", 100);
            ListViewOrderdItems.Columns.Add("Name", 300);
            ListViewOrderdItems.Columns.Add("Comment", 100);
        }

        private void DisplayTextLabel(Employee employee)
        {
            LblEmployee.Text = employee.FirstName;
            LblTableNumber.Text = $"Table #{table.Number}";
        }

        private void BtnLunch_Click(object sender, EventArgs e)
        {
            ShowCorrectPanel("Lunch");
            GetAllLunches();
        }

        private void BtnDinner_Click(object sender, EventArgs e)
        {
            ShowCorrectPanel("Dinner");
            GetAllDinners();
        }

        private void BtnDrinks_Click(object sender, EventArgs e)
        {
            ShowCorrectPanel("Drinks");
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
  

        private void ShowCorrectPanel(string panelToShow)
        {
            HideAllPanels();

            //TODO: for later
            //button.BackColor = ColorTranslator.FromHtml("#CAEADB");

            switch (panelToShow)
            {
                case "Drinks":
                    GetAllDrinks();
                    PnlDrinks.Show();
                    BtnDrinks.BackColor = ColorTranslator.FromHtml("#CAEADB");
                    break;
                case "Dinner":
                    GetAllDinners();
                    PnlDinner.Show();
                    BtnDinner.BackColor = ColorTranslator.FromHtml("#CAEADB");
                    break;
                case "Lunch":
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
                FillListViewMenuItems(ListDrinksSoft, orderService.GetMenuItemsByMenuAndCategory("Drinks", "SoftDrinks"));

                FillListViewMenuItems(ListDrinksBeers, orderService.GetMenuItemsByMenuAndCategory("Drinks", "Beers"));

                FillListViewMenuItems(ListDrinksWines, orderService.GetMenuItemsByMenuAndCategory("Drinks", "Wines"));

                FillListViewMenuItems(ListDrinksSpirits, orderService.GetMenuItemsByMenuAndCategory("Drinks", "Spirits"));

                FillListViewMenuItems(ListDrinksHot, orderService.GetMenuItemsByMenuAndCategory("Drinks", "HotDrinks"));
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
                FillListViewMenuItems(ListLunchStarter, orderService.GetMenuItemsByMenuAndCategory("Lunch", "Starters"));

                FillListViewMenuItems(ListLunchMains, orderService.GetMenuItemsByMenuAndCategory("Lunch", "Mains"));

                FillListViewMenuItems(ListLunchDesserts, orderService.GetMenuItemsByMenuAndCategory("Lunch", "Desserts"));
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
                FillListViewMenuItems(ListDinnerStarter, orderService.GetMenuItemsByMenuAndCategory("Diner", "Starters"));
                FillListViewMenuItems(ListDinnerEntre, orderService.GetMenuItemsByMenuAndCategory("Diner", "Entres"));

                FillListViewMenuItems(ListDinnerMains, orderService.GetMenuItemsByMenuAndCategory("Diner", "Mains"));

                FillListViewMenuItems(ListDinnerDesserts, orderService.GetMenuItemsByMenuAndCategory("Diner", "Desserts"));
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
                    //Maar op het moment dat de order wordt gecanceld moet je het weer verwijderen uit de database

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

                foreach (ListViewItem orderItem in ListViewOrderdItems.Items)
                {
                    if (menuItem.Name == orderItem.SubItems[1].Text)
                    {
                        OrderItem chosenOrderItem = (OrderItem)orderItem.Tag;
                        
                        chosenOrderItem.UpdateQuantity(chosenOrderItem.Quantity + 1);

                        orderItem.Text = $"{chosenOrderItem.Quantity}x";
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

                if (ListViewOrderdItems.SelectedItems.Count == 0)
                {
                    throw new Exception("Selecteer een item!");
                }

                OrderItem orderItem = (OrderItem)ListViewOrderdItems.SelectedItems[0].Tag;
                orderItem.Quantity--;
                if (orderItem.Quantity == 0)
                {
                    ListViewOrderdItems.Items.Remove(ListViewOrderdItems.SelectedItems[0]);
                }
                else
                {
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
                if (ListViewOrderdItems.SelectedItems.Count == 0)
                {
                    throw new Exception("Selecteer een item!");
                }

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

        private void ShowComment(OrderItem orderItem)
        {
            ListViewItem selectedItem = ListViewOrderdItems.SelectedItems[0];
            selectedItem.SubItems[2].Text = orderItem.Comment;
        }
    }
}
