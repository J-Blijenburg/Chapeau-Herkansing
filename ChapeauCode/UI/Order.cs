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
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
            PnlDrinks.Hide();
            PnlLunch.Hide();
            PnlDinner.Hide();
        }

        private void BtnLunch_Click(object sender, EventArgs e)
        {
            PnlDrinks.Hide();
            PnlLunch.Show();
            PnlDinner.Hide();

            BtnLunch.BackColor = ColorTranslator.FromHtml("#CAEADB");
            BtnDinner.BackColor = ColorTranslator.FromHtml("#8AD2B0");
            BtnDrinks.BackColor = ColorTranslator.FromHtml("#8AD2B0");

        }

        private void BtnDinner_Click(object sender, EventArgs e)
        {
            PnlDrinks.Hide();
            PnlLunch.Hide();
            PnlDinner.Show();

            BtnLunch.BackColor = ColorTranslator.FromHtml("#8AD2B0");
            BtnDinner.BackColor = ColorTranslator.FromHtml("#CAEADB");
            BtnDrinks.BackColor = ColorTranslator.FromHtml("#8AD2B0");
        }

        private void BtnDrinks_Click(object sender, EventArgs e)
        {
            PnlDrinks.Show();
            PnlLunch.Hide();
            PnlDinner.Hide();

            BtnLunch.BackColor = ColorTranslator.FromHtml("#8AD2B0");
            BtnDinner.BackColor = ColorTranslator.FromHtml("#8AD2B0");
            BtnDrinks.BackColor = ColorTranslator.FromHtml("#CAEADB");

        }


    }
}
