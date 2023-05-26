using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MenuItem
    {
        public int MenuItemId { get; set; }
        public string Name { get; set; }
        private int Stock { get; set; }
        private double Price { get; set; }
        public Menu Menu { get; set; }
        public MenuItem()
        {

        public MenuItem GetMenuItem()
        {
            return this;
        }

        public bool CheckStock()
        {
            if (Stock > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetStock()
        {
            return Stock;
        }

        public string GetPriceFormat()
        {
            return $"€ {Price.ToString("N2")}";
        }

        public void SetStock(int stock)
        {
            Stock = stock;
        }
    }
}
