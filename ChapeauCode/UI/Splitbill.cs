using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Model;
using System.Reflection.Metadata.Ecma335;

namespace UI
{
    public partial class Splitbill : Form, IFormObserver
    {
        private IPaymentSystem observer;
        private double totalAmount;
        private bool isPaid = false;

        public Splitbill(IPaymentSystem observer, double totalAmount)
        {
            InitializeComponent();
            this.observer = observer;
            this.observer.AddObserver(this);
            this.totalAmount = totalAmount;
            LoadData();
        }

        private void LoadData()
        {
            LblToPayNumber.Text = totalAmount.ToString();
        }

        bool IFormObserver.Update()
        {
            return isPaid;
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
          double? totalAmountPaid  = double.Parse(TbInputAmountPaid.Text);
            if (totalAmountPaid > totalAmount) {
                isPaid = true;
                this.Close();
            }
               
        
        }


    }
}
