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
        private List<MenuCategory> MenuCategories { get; set; }

        public Menu CreateMenu(MenuType menuType, TimeOnly StartTime, TimeOnly EndTime)
        {
            this.Name = menuType;
            this.StartTime = StartTime;
            this.EndTime = EndTime;
            this.MenuCategories = new List<MenuCategory>();
            return this;
        }

        public bool CheckMenuTime()
        {
            return (TimeOnly.FromDateTime(DateTime.Now) > StartTime && TimeOnly.FromDateTime(DateTime.Now) < EndTime);
        }

        public MenuType GetMenuType()
        {
            return Name;
        }

        public List<MenuCategory> GetMenuCategories()
        {
            return MenuCategories;
        }

        public void SetMenuCategories(List<MenuCategory> menuCategories)
        {
            this.MenuCategories = menuCategories;
        }
    }
}
