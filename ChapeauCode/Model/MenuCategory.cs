using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MenuCategory
    {
        public int menuCategoryId { get; set; }
        public double VAT { get; set; }
        public Category Name { get; set; }


        //toevoegen van de listmenutitem, ff checken of het goed staat enzo...
        //public List<MenuItem> MenuItems { get; set; }

        //doordat er een list is en je weet welk menu erbij hoort hoef je niet de menu meetegeven
        public Menu Menu { get; set; }
    }
}
