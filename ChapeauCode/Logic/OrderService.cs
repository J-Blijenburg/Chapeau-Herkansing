using DAL;
using Model;
using System.ComponentModel.Design;
using System.Drawing.Drawing2D;

namespace Logic
{
    //Code By: Jens Begin *******************************************************

    public class OrderService
    {
        private const double HundredPercent = 100.0;
        private const double LowVatRate = 0.06;
        private const double HighVatRate = 0.21;
        
        OrderDAO orderDAO;
        
        public OrderService() { 
            this.orderDAO = new OrderDAO();
        }
        public List<MenuItem> GetMenuItemsByMenuAndCategory(Menu menu, MenuCategory category)
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
        public List<OrderItem> GetOrderedItemsByReceiptId(int receiptId)
        {
            return orderDAO.GetOrderedItemsByReceiptId(receiptId);
        }

        public TimeSpan GetOrderElapsedTime(int receiptId)
        {
            var orderItems = orderDAO.GetOrderedItemsByReceiptId(receiptId);

            //als er geen orders zijn gevonden, return timespan zero
            if (orderItems.Count == 0)
            {
                return TimeSpan.Zero;
            }
            //return de minimum resulting value
            //return de eerste order item die is geplaatst in de bestelling
            DateTime earliestOrderTime = orderItems.Min(item => item.Order.OrderDateTime);

            return DateTime.Now - earliestOrderTime;
        }


        public List<OrderItem> GetRunningOrderItems(MenuType type)
        {
            return orderDAO.GetRunningOrderItems(type);
        }

        public List<OrderItem> GetFinishedOrderItems(MenuType type)
        {
            return orderDAO.GetFinshedOrderItems(type);
        }

        public void UpdateOrderItemStatus(int orderId, OrderItemStatus orderStatus, int orderItemId)
        {
            orderDAO.UpdateOrderStatus(orderId, orderStatus, orderItemId);
        }
        public void UpdateOrderItemStatusByWaiter(int orderItemId, OrderItemStatus orderStatus)
        {
            OrderItem orderItem = orderDAO.GetOrderItemById(orderItemId);
            if (orderItem == null)
            {
                throw new ArgumentException("Invalid order item");
            }
            if (orderStatus == OrderItemStatus.Delivered && orderItem.OrderItemStatus != OrderItemStatus.ReadyToBeServed)
            {
                throw new InvalidOperationException("Cannot mark as served. The order item is not ready to be served or has been served already");
            }

            orderDAO.UpdateOrderItemStatusByWaiter(orderItemId, orderStatus);
        }
        public bool AllItemsServed(List<OrderItem> orderItems)
        {
            if (!orderItems.Any())
            {
                //return false if there are no order items
                return false;
            }
            foreach (var item in orderItems)
            {
                if (item.OrderItemStatus != OrderItemStatus.Delivered)
                {
                    //if an item is found that isnt delivered, then not all items have been served
                    return false;
                }
            }
            //all items are delivered
            return true;
        }

        public double CalculateTotalVat(List<OrderItem> orderItems)
        {
            double totalVat = 0;

            foreach (var item in orderItems)
            {
                if (item.MenuItem.MenuCategory != null)
                {
                    double vatRate = item.MenuItem.MenuCategory.VAT / HundredPercent;
                    double itemVat = item.MenuItem.Price * item.Quantity * vatRate;
                    totalVat += itemVat;
                }
            }

            return totalVat;
        }
        public double CalculateLowVat(List<OrderItem> orderItems)
        {
            double lowVat = 0;

            foreach (var item in orderItems)
            {
                if ((double)(item.MenuItem.MenuCategory.VAT / HundredPercent) == LowVatRate)
                    lowVat += (double)item.MenuItem.Price * item.Quantity * (double)(item.MenuItem.MenuCategory.VAT / HundredPercent);
            }

            return lowVat;
        }

        public double CalculateHighVat(List<OrderItem> orderItems)
        {
            double highVat = 0;

            foreach (var item in orderItems)
            {
                if ((double)(item.MenuItem.MenuCategory.VAT / HundredPercent) == HighVatRate)
                    highVat += (double)item.MenuItem.Price * item.Quantity * (double)(item.MenuItem.MenuCategory.VAT / HundredPercent);
            }

            return highVat;
        }

        public double CalculateTotalPrice(List<OrderItem> orderItems)
        {
            double totalPrice = 0;

            foreach (var item in orderItems)
            {
                totalPrice += (double)item.MenuItem.Price * item.Quantity;
            }

            return totalPrice;
        }

    }
}
