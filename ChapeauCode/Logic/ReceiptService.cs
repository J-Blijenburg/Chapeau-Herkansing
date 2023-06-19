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
        OrderDAO orderDAO;  
        public ReceiptService()
        {
            this.receiptDAO = new ReceiptDAO();
            this.orderDAO = new OrderDAO();
        }

        public Receipt GetReceiptByTable(Table table)
        {
            return receiptDAO.GetReceiptByTable(table); //todo set try catch
        }
        public Receipt GetReceiptByTableAndEmployee(Table table, Employee employee)
        {
            return receiptDAO.GetReceiptByTableAndEmployee(table, employee); //todo set try catch
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
  

        public List<OrderItem> GetOrderedItemsByReceiptId(int receiptId)
        {
            return orderDAO.GetOrderedItemsByReceiptId(receiptId);
        }

    }
}
