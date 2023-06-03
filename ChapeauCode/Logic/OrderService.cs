using DAL;
using Model;
using System.Drawing.Drawing2D;

namespace Logic
{
    //Code By: Jens Begin *******************************************************

    public class OrderService
    {
        OrderDAO orderDAO;
        public OrderService() { 
            this.orderDAO = new OrderDAO();
        }
        public List<MenuItem> GetMenuItemsByMenuAndCategory(string menu, string category)
        {
            return orderDAO.GetMenuItemsByMenuNameAndCategoryName(menu, category);
        }

        public void SendOrderItems(Order order)
        {
            orderDAO.SendOrderItems(order);
        }
        
        public void CreateOrder(Order order)
        {
            orderDAO.CreateOrder(order);
        }

        public List<Menu> GetListOfMenu()
        {
            return orderDAO.GetListOfMenu();
        }

        public List<MenuCategory> GetMenuCategoriesByMenu(Menu menu)
        {
            return orderDAO.GetMenuCategoriesByMenu(menu);
        }

        //Code By: Jens End *********************************************************

        public List<OrderItem> GetOrderdItems(Table table)
        {
            return orderDAO.GetOrderdItems(table);
        }

        public List<OrderItem> GetKitchenOrders()
        {
           return orderDAO.GetKitchenOrders();
        }

        public List<OrderItem> GetBarOrders()
        {
           return orderDAO.GetBarOrders();
        }

        public void UpdateOrderItemStatus(int orderId, OrderStatus orderStatus)
        {
            orderDAO.UpdateOrderStatus(orderId, orderStatus);
        }
    }
}
