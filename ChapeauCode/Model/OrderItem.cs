using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Model
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public OrderStatus OrderItemStatus { get; set; }
        //doordat er nu een list is in order is dit niet meer nodig de order order zegmaar
        public Order Order { get; set; }
        public string Comment { get; set; }
        public MenuItem MenuItem { get; set; }
        public int Quantity { get; set; }

        public OrderItem() { }

        public OrderItem CreateOrderItem(string comment, MenuItem menuItem, int quantity, OrderStatus status)
        {
            Comment = comment;
            MenuItem = menuItem;
            Quantity = quantity;
            OrderItemStatus = status;
            return this;
        }

        public string DisplayQuantityFormat()
        {
            return $"{Quantity}x";
        }

        public string GetComment()
        {
            return Comment;
        }   

        public int GetQuantity()
        {
            return Quantity;
        }

        public int AddQuantity(int quantity)
        {
            Quantity += quantity;
            return Quantity;
        }

        public MenuItem GetMenuItem()
        {
            return MenuItem;
        }
        

    }
}
