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

        public Receipt GetReceipt(Table table, Employee employee)
        {
            return receiptDAO.GetReceiptByTable(table, employee); //todo set try catch
        }
        public void UpdateReceipt(Receipt receipt)
        {
            try
            {
                receiptDAO.UpdateReceiptPaid(receipt);
            }
            catch (Exception exception)
            {
                  new Exception(exception.Message);
            }
         
        }

    }
}
