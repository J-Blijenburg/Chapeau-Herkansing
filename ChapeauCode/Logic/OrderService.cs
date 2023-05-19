using DAL;
using Model;

namespace Logic
{
    public class OrderService
    {
        OrderDAO orderDAO;
        public OrderService() { 
            this.orderDAO = new OrderDAO();
        }
        public List<MenuItem> GetMenuItemsByMenuAndCategory(string menu, string category)
        {
            return orderDAO.GetMenuItemsByMenuAndCategory(menu, category);
        }

        public void SendOrderItems(Order order)
        {
            orderDAO.SendOrderItems(order);
        }
        
        public void CreateOrder(Order order)
        {
            orderDAO.CreateOrder(order);
        }

        public List<OrderItem> GetOrderdItems(Table table)
        {
            return orderDAO.GetOrderdItems(table);
        }

        public void DeleteOrder(Order order)
        {
            orderDAO.DeleteOrder(order);
        }
    }
}
