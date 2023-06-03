using Model;
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
    public partial class OrderComment : Form
    {
        private OrderItem item;
        private Form previousForm;
        public OrderComment(Form form, OrderItem orderItem)
        {
            InitializeComponent();
            this.item = orderItem;
            this.previousForm = form;
            CheckExistingComment();
        }

        private void CheckExistingComment()
        {
            if (item.Comment != "")
            {
                TxtComment.Text = item.Comment;
            }
        }

        private void BtnAddComment_Click(object sender, EventArgs e)
        {
            item.Comment = TxtComment.Text;
            ShowPreviousForm();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            ShowPreviousForm();
        }

        private void ShowPreviousForm()
        {
            this.Close();
            previousForm.Show();
        }
    }
}
