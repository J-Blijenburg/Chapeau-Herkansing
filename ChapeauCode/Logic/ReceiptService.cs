using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ReceiptService
    {
        ReceiptDAO receiptDAO;
        public ReceiptService()
        {
            this.receiptDAO = new ReceiptDAO();
        }

        public int CreateReceipt(Receipt receipt)
        {
           return receiptDAO.CreateReceipt(receipt);
        }
    }
}
