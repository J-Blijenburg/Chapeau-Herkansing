using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Menu
    {
        public int MenuId { get; set; }
        public MenuType Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        //toevoegen van de listmenuCategory, ff checken of het goed staat enzo...
        public List<MenuCategory> MenuCategories { get; set; }

    }
}
