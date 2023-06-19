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
    public partial class CommentQuestionForm : Form
    {
        private Receipt receipt;
        private Employee loggedInEmployee;
        public CommentQuestionForm(Receipt receipt, Employee employee)
        {
            InitializeComponent();
            this.receipt = receipt;
            this.loggedInEmployee = employee;
        }

        private void BtnAddComment_Click(object sender, EventArgs e)
        {
            this.Hide();
            CommentInputForm commentinput = new CommentInputForm(receipt, this);
            commentinput.Show();
        }

        private void BtContinueWithPayment_Click(object sender, EventArgs e)
        {
            this.Hide();
            BillSetteld commandinput = new BillSetteld(receipt, loggedInEmployee);
            commandinput.Show();

        }
    }
}
