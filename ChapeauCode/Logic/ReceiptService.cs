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

        public Receipt GetReceipt(Table table)
        {
            return receiptDAO.GetReceiptByTable(table);
        }
        public Receipt UpdateReceipt(Table table)
        {
            return receiptDAO.UpdateReceipt(table);
        }



    }
}
