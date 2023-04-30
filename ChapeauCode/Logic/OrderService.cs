using DAL;

namespace Logic
{
    public class OrderService
    {
        OrderDAO orderDAO;

        public OrderService() { 
            this.orderDAO = new OrderDAO();
        }
    }
}
