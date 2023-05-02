using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class TableOverview : Form
    {
        public TableOverview()
        {
            InitializeComponent();
        }

        private void BtnLunch_Click(object sender, EventArgs e)
        {
            OpenOrderForm("Lunch");
        }

        private void BtnDinner_Click(object sender, EventArgs e)
        {
            OpenOrderForm("Dinner");
        }

        private void BtnDrinks_Click(object sender, EventArgs e)
        {
            OpenOrderForm("Drinks");
        }

        private void OpenOrderForm(string panelToShow)
        {
            //When creating a new orderForm this form will hide and will be used again after the orderform is disposed
            OrderView order = new OrderView(this, panelToShow);
            this.Hide();

            //Since there is no need of using both the forms at the same time, the orderform will be shown as a dialog preventing the user from using the tableoverview form
            order.ShowDialog();

            //This messagebox can be used to check how many Forms there are currently running
            //MessageBox.Show(Application.OpenForms.Count.ToString());
        }
    }
}
