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
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public List<MenuCategory> MenuCategories { get; set; }

        public bool CheckMenuTime()
        {
            if (TimeOnly.FromDateTime(DateTime.Now) > StartTime && TimeOnly.FromDateTime(DateTime.Now) < EndTime)
            {
                return true;
            }
            return false;
        }
    }
}
