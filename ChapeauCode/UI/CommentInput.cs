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
    public partial class CommentInput : Form
    {
        private Receipt receipt;
        public CommentInput(Receipt receipt)
        {
            InitializeComponent();
            this.receipt = receipt;
            lblSuccesMessage.Hide();
        }

        private void BtConfirm_Click(object sender, EventArgs e)
        {
            receipt.Feedback = TbComment.Text;
            lblSuccesMessage.Show();

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            CommentQuestion commandQuestion = new CommentQuestion(receipt);
            commandQuestion.ShowDialog();

        }
    }
}
