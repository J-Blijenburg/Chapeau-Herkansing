﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class MenuCategory
    {
        public int MenuCategoryId { get; set; }
        public double VAT { get; set; }
        public Category Name { get; set; }
        private List<MenuItem> MenuItems { get; set; }

        public Category GetName()
        {
            return Name;
        }

        public void SetMenuItems(List<MenuItem> menuItems)
        {
            this.MenuItems = menuItems;
        }

        public List<MenuItem> GetMenuItems()
        {
            return MenuItems;
        }
    }
}
