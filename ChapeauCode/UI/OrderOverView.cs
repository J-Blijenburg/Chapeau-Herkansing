using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Logic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ListView = System.Windows.Forms.ListView;

namespace UI
{
    public partial class OrderOverView : Form
    {
        private Form previousForm;
        private OrderService orderService = new OrderService();
        private ReceiptService receiptService = new ReceiptService();
        private Table table;
        public OrderOverView(Form previousForm, string panelToShow, Table table)
        {
            InitializeComponent();
            ShowCorrectPanel(panelToShow);
            this.previousForm = previousForm;
            this.table = table;
            


            ListViewOrderdItems.Columns.Add("Amount", 100);
            ListViewOrderdItems.Columns.Add("Name", 375);
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
            SendOrderItems();
            

            //This form will be disposed and the previousform will be displayed again.
            //This will make sure that there is only 1 form active
            this.Dispose();
            previousForm.Show();
        }


        

        private Order CreateOrder(Receipt receipt)
        {
            //de employee moet nog worden aangepast aan de gebruiker die is ingelogd
            Employee employee = new Employee();
            employee.EmployeeId = 1;

            //LET OP: Deze methode is nog niet af. moet nog worden aangepast aan gebruikers etc...
            Order order = new Order();
            order.Employee = employee;
            order.Receipt = receipt;
            order.OrderDateTime = DateTime.Now;
            order.Status = OrderStatus.Ordered;

            order.OrderId = new OrderService().CreateOrder(order);

            return order;
        }

        private void ShowCorrectPanel(string panelToShow)
        {
            HideAllPanels();

            switch (panelToShow)
            {
                case "Drinks":
                    PnlDrinks.Show();
                    BtnDrinks.BackColor = ColorTranslator.FromHtml("#CAEADB");
                    GetAllDrinks();
                    break;
                case "Dinner":
                    PnlDinner.Show();
                    BtnDinner.BackColor = ColorTranslator.FromHtml("#CAEADB");
                    GetAllDinners();
                    break;
                case "Lunch":
                    PnlLunch.Show();
                    BtnLunch.BackColor = ColorTranslator.FromHtml("#CAEADB");
                    GetAllLunches();
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
            FillListViewMenuItems(ListDrinksSoft, orderService.GetMenuItemsByMenuAndCategory("Drinks", "SoftDrinks"));

            FillListViewMenuItems(ListDrinksBeers, orderService.GetMenuItemsByMenuAndCategory("Drinks", "Beers"));

            FillListViewMenuItems(ListDrinksWines, orderService.GetMenuItemsByMenuAndCategory("Drinks", "Wines"));

            FillListViewMenuItems(ListDrinksSpirits, orderService.GetMenuItemsByMenuAndCategory("Drinks", "Spirits"));

            FillListViewMenuItems(ListDrinksHot, orderService.GetMenuItemsByMenuAndCategory("Drinks", "HotDrinks"));

        }

        private void GetAllLunches()
        {
            FillListViewMenuItems(ListLunchStarter, orderService.GetMenuItemsByMenuAndCategory("Lunch", "Starters"));

            FillListViewMenuItems(ListLunchMains, orderService.GetMenuItemsByMenuAndCategory("Lunch", "Mains"));

            FillListViewMenuItems(ListLunchDesserts, orderService.GetMenuItemsByMenuAndCategory("Lunch", "Desserts"));
        }

        private void GetAllDinners()
        {
            FillListViewMenuItems(ListDinnerStarter, orderService.GetMenuItemsByMenuAndCategory("Diner", "Starters"));
            FillListViewMenuItems(ListDinnerEntre, orderService.GetMenuItemsByMenuAndCategory("Diner", "Entres"));

            FillListViewMenuItems(ListDinnerMains, orderService.GetMenuItemsByMenuAndCategory("Diner", "Mains"));

            FillListViewMenuItems(ListDinnerDesserts, orderService.GetMenuItemsByMenuAndCategory("Diner", "Desserts"));
        }

        //fill the listview with the given menuitems
        private void FillListViewMenuItems(ListView listView, List<MenuItem> menuItems)
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

        private void SendOrderItems()
        {
            if (ListViewOrderdItems.Items.Count != 0)
            {
                List<OrderItem> orderItems = new List<OrderItem>();

                Receipt receipt = receiptService.GetReceipt(table);
                Order order = CreateOrder(receipt);

                foreach (ListViewItem item in ListViewOrderdItems.Items)
                {
                    OrderItem orderItem = (OrderItem)item.Tag;
                    orderItem.Order = order;
                    orderItems.Add(orderItem);

                }

                


                orderService.SendOrderItems(orderItems);
            }
        }

        private void ListViewRowClick(object sender, EventArgs e)
        {
            FillListViewOrderdItems((ListView)sender);

        }

        //receive the selected menuitem and add it to the listview of ListViewOrderdItems
        private void FillListViewOrderdItems(ListView listView)
        {
            bool itemExists = false;
            MenuItem menuItem = (MenuItem)listView.SelectedItems[0].Tag;

            //TODO: Dit moet een menuitem zijn, niet een orderitem
            foreach (ListViewItem orderItems in ListViewOrderdItems.Items)
            {
                if (menuItem.Name == orderItems.SubItems[1].Text)
                {
                    OrderItem chosenOrderItem = (OrderItem)orderItems.Tag;
                    chosenOrderItem.Quantity++;
                    orderItems.Text = $"{chosenOrderItem.Quantity}x";
                    itemExists = true;
                    break;
                }
            }
            if (!itemExists)
            {
                OrderItem orderItem = CreateOrderItem(menuItem);
                ListViewItem listViewItem = new ListViewItem($"{orderItem.Quantity}x");
                listViewItem.SubItems.Add(orderItem.MenuItem.Name);
                listViewItem.Tag = orderItem;
                ListViewOrderdItems.Items.Add(listViewItem);
            }
        }

        private OrderItem CreateOrderItem(MenuItem menuItem)
        {
            OrderItem orderItem = new OrderItem();
            orderItem.Comment = "";
            orderItem.MenuItem = menuItem;
            orderItem.Quantity = 1;
            return orderItem;
        }
    }
}
