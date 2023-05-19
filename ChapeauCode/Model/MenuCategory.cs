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
        public List<MenuItem> MenuItems { get; set; }
    }
}
