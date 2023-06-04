using DAL;
using Model;
using System.Drawing.Drawing2D;

namespace Logic
{
    //Code By: Jens Begin *******************************************************

    public class OrderService
    {
        private const decimal VATRate = 0.15M;
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
            return orderDAO.GetOrderedItems(table);
        }

        public List<OrderItem> GetKitchenOrders()
        {
           return orderDAO.GetKitchenOrders();
        }

        public List<OrderItem> GetBarOrders()
        {
           return orderDAO.GetBarOrders();
        }

        public List<OrderItem> GetFinishedKitchenOrders()
        {
            return orderDAO.GetFinishedKitchenOrders();
        }

        public List<OrderItem> GetFinishedBarOrders()
        {
            return orderDAO.GetFinishedBarOrders();
        }

        public void UpdateOrderItemStatus(int orderId, OrderItemStatus orderStatus, int orderItemId)
        {
            orderDAO.UpdateOrderStatus(orderId, orderStatus, orderItemId);
        }
        public double CalculateTotalVat(List<OrderItem> orderItems)
        {
            double totalVat = 0;

            foreach (var item in orderItems)
            {
                if (item.MenuItem.MenuCategory != null)
                {
                    double vatRate = item.MenuItem.MenuCategory.VAT / 100.0;
                    double itemVat = item.MenuItem.Price * item.Quantity * vatRate;
                    totalVat += itemVat;
                }
            }

            return totalVat;
        }
        public decimal CalculateLowVat(List<OrderItem> orderItems)
        {
            decimal lowVat = 0;
            decimal lowVatRate = 0.06M;

            foreach (var item in orderItems)
            {
                if ((decimal)(item.MenuItem.MenuCategory.VAT / 100.0) == lowVatRate)
                    lowVat += (decimal)item.MenuItem.Price * item.Quantity * (decimal)(item.MenuItem.MenuCategory.VAT / 100.0);
            }

            return lowVat;
        }

        public decimal CalculateHighVat(List<OrderItem> orderItems)
        {
            decimal highVat = 0;
            decimal highVatRate = 0.21M;

            foreach (var item in orderItems)
            {
                if ((decimal)(item.MenuItem.MenuCategory.VAT / 100.0) == highVatRate)
                    highVat += (decimal)item.MenuItem.Price * item.Quantity * (decimal)(item.MenuItem.MenuCategory.VAT / 100.0);
            }

            return highVat;
        }

        public decimal CalculateTotalPrice(List<OrderItem> orderItems)
        {
            decimal totalPrice = 0;

            foreach (var item in orderItems)
            {
                totalPrice += (decimal)item.MenuItem.Price * item.Quantity;
            }

            return totalPrice;
        }
    }
}
