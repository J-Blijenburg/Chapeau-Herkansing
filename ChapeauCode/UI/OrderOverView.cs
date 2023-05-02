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
        private Order order;
        public OrderOverView(Form previousForm, string panelToShow)
        {
            InitializeComponent();
            ShowCorrectPanel(panelToShow);
            this.previousForm = previousForm;
            this.order = new Order();
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
            Receipt receipt = CreateReceipt();



            SendOrderItems();


            //This form will be disposed and the previousform will be displayed again.
            //This will make sure that there is only 1 form active
            this.Dispose();
            previousForm.Show();
        }


        private Receipt CreateReceipt()
        {
            //de employee moet nog worden aangepast aan de gebruiker die is ingelogd
            Employee employee = new Employee();
            employee.EmployeeId = 1;

            //de table moet nog worden aangepast aan de tafel waar de gebruiker aan zit
            Table table = new Table();
            table.TableId = 1;

            //de payment moet nog worden aangepast aan de betaalmethode die de gebruiker heeft gekozen
            Payment payment = new Payment();
            payment.PaymentId = 1;

            //LET OP: Deze methode is nog niet af. moet nog worden aangepast aan gebruikers etc...
            Receipt receipt = new Receipt();
            receipt.ReceiptDateTime = DateTime.Now;
            receipt.Feedback = "";
            receipt.Employee = employee;
            receipt.Table = table;
            receipt.LowVatPrice = 0;
            receipt.HighVatPrice = 0;
            receipt.TotalPrice = 0;
            receipt.Tip = 0;
            receipt.IsHandled = false;
            receipt.Payment = payment;

            orderService.CreateReceipt(receipt);

            return receipt;
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
        private void FillListViewMenuItems(System.Windows.Forms.ListView listView, List<MenuItem> menuItems)
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
            List<OrderItem> orderItems = new List<OrderItem>();

            foreach (ListViewItem item in ListViewOrderdItems.Items)
            {
                orderItems.Add((OrderItem)item.Tag);
                
            }
            orderService.SendOrderItems(orderItems);
            
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
            orderItem.Order = order;
            orderItem.Comment = "";
            orderItem.MenuItem = menuItem;
            orderItem.Quantity = 1;
            return orderItem;
        }
    }
}
