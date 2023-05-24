﻿using System;
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
        //doordat er nu een list is in order is dit niet meer nodig de order order zegmaar
        public Order Order { get; set; }
        public string Comment { get; set; }
        public MenuItem MenuItem { get; set; }
        public int Quantity { get; set; }

        public OrderItem() { }

        public OrderItem(string comment, MenuItem menuItem, int quantity)
        {
            Comment = comment;
            MenuItem = menuItem;
            Quantity = quantity;
        }

        public string DisplayQuantityFormat()
        {
            return $"{Quantity}x";
        }

        public string toStringForKitchenAndBar()
        {
            return $"{Order.OrderId}, {Comment}, {Quantity} {MenuItem.Name}";
        }
    }
}
