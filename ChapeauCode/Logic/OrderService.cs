using DAL;
using Model;

namespace Logic
{
    public class OrderService
    {
        OrderDAO orderDAO;

        public OrderService() { 
            this.orderDAO = new OrderDAO();
        }

        public List<MenuItem> GetMenuItemsByMenuAndCategory(string menu, string category)
        {
            return orderDAO.GetMenuItemsByMenuAndCategory(menu, category);
        }
    }
}
