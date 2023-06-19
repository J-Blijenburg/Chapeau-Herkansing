using DAL;
using Model;
using System.ComponentModel.Design;
using System.Drawing.Drawing2D;

namespace Logic
{
    //Code By: Jens Begin *******************************************************

    public class OrderService
    {
        private const decimal VATRate = 0.15M;
        OrderDAO orderDAO;
        private TableService tableService;
        public OrderService() { 
            this.orderDAO = new OrderDAO();
            this.tableService = new TableService();
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

            // If no orders found, return zero timespan
            if (orderItems.Count == 0)
            {
                return TimeSpan.Zero;
            }

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
        public bool AreAllItemsServed(List<OrderItem> orderItems)
        {
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

        //TODO: CONST maken 
        public double CalculateTotalVat(List<OrderItem> orderItems)
        {
            double totalVat = 0; //const maken ?

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
            decimal lowVatRate = 0.06M; //const van maken

            foreach (var item in orderItems)
            {
                if ((decimal)(item.MenuItem.MenuCategory.VAT / 100.0) == lowVatRate)
                    lowVat += (decimal)item.MenuItem.Price * item.Quantity * (decimal)(item.MenuItem.MenuCategory.VAT / 100.0);
            }

            return lowVat;
        }

        public decimal CalculateHighVat(List<OrderItem> orderItems)
        {
            decimal highVat = 0; //const maken
            decimal highVatRate = 0.21M; //const maken

            foreach (var item in orderItems)
            {
                if ((decimal)(item.MenuItem.MenuCategory.VAT / 100.0) == highVatRate)
                    highVat += (decimal)item.MenuItem.Price * item.Quantity * (decimal)(item.MenuItem.MenuCategory.VAT / 100.0);
            }

            return highVat;
        }

        public decimal CalculateTotalPrice(List<OrderItem> orderItems)
        {
            decimal totalPrice = 0; //const maken ? 

            foreach (var item in orderItems)
            {
                totalPrice += (decimal)item.MenuItem.Price * item.Quantity;
            }

            return totalPrice;
        }

    }
}
