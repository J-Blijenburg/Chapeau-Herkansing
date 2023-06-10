using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class CommentQuestion : Form
    {
        private Receipt receipt;
        public CommentQuestion(Receipt receipt)
        {
            InitializeComponent();
            this.receipt = receipt;
        }

        private void BtnAddComment_Click(object sender, EventArgs e)
        {
            this.Close();
            CommentInput commandinput = new CommentInput(receipt);
            commandinput.ShowDialog();
        }

        private void BtContinueWithPayment_Click(object sender, EventArgs e)
        {
            this.Close();
            BillSetteld commandinput = new BillSetteld(receipt);
            commandinput.ShowDialog();

        }
    }
}
