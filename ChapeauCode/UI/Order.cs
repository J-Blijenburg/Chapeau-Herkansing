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

namespace UI
{
    public partial class Order : Form
    {
        private Form previousForm;
        private OrderService orderService = new OrderService();
        public Order(Form previousForm, string panelToShow)
        {
            InitializeComponent();
            ShowCorrectPanel(panelToShow);
            this.previousForm = previousForm;
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
            //This form will be disposed and the previousform will be displayed again.
            //This will make sure that there is only 1 form active
            this.Dispose();
            previousForm.Show();
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

        private void FillListViewMenuItems(ListView listView, List<MenuItem> menuItems)
        {
            listView.Clear();

            listView.Columns.Add("Name", 375);
            listView.Columns.Add("Price", 100);

            foreach (MenuItem menuItem in menuItems)
            {
                ListViewItem listViewItem = new ListViewItem(menuItem.Name);
                listViewItem.SubItems.Add($"€ {menuItem.Price.ToString("N2")}");
                listView.Items.Add(listViewItem);
            }
        }

    }
}
