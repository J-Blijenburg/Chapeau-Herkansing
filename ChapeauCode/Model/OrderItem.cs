using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Model
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public Order Order { get; set; }
        public string Comment { get; set; }
        public MenuItem MenuItem { get; set; }
        public int Quantity { get; set; }
    }
}
