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

        }

        private void BtnDinner_Click(object sender, EventArgs e)
        {
            ShowCorrectPanel("Dinner");
        }

        private void BtnDrinks_Click(object sender, EventArgs e)
        {
            ShowCorrectPanel("Drinks");
            List<MenuItem> listOfMenuItems = orderService.GetMenuItemsByMenuAndCategory("Drinks", "SoftDrinks");

            ListDrinksSoft.Clear();

            ListDrinksSoft.Columns.Add("Name", 380);
            ListDrinksSoft.Columns.Add("Price", 100);

            foreach (MenuItem menuItem in listOfMenuItems)
            {
                ListViewItem drinksSoft = new ListViewItem(menuItem.Name);
                drinksSoft.SubItems.Add($"€ {menuItem.Price.ToString("N2")}");
                ListDrinksSoft.Items.Add(drinksSoft);
            }



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
                    break;
                case "Dinner":
                    PnlDinner.Show();
                    BtnDinner.BackColor = ColorTranslator.FromHtml("#CAEADB");
                    break;
                case "Lunch":
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

    }
}
