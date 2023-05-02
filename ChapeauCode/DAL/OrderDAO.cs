using Model;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DAL
{
   public class OrderDAO : BaseDao
    {
        public List<MenuItem> GetMenuItemsByMenuAndCategory(string menu, string category)
        {
            string query = "SELECT MI.MenuItemId, MI.Name, MI.Stock, MI.Price, MC.VAT, MC.Name, ME.Name, ME.StartTime, ME.EndTime " +
                "FROM MenuItem AS MI " +
                "JOIN MenuCategory AS MC ON MI.MenuCategoryId = MC.MenuCategoryId " +
                "JOIN Menu AS ME ON MC.MenuId = ME.MenuId " +
                "WHERE ME.Name = @menuName AND MC.Name = @categoryName";
            SqlParameter[] sqlParameters;
            sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@menuName", menu),
                new SqlParameter("@categoryName", category)

            };
            return CreateMenuItems(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<MenuItem> CreateMenuItems(DataTable dataTable)
        {
            List<MenuItem> list = new List<MenuItem>();
            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem menuItem = new MenuItem()
                {
                    MenuItemId = (int)dr["MenuItemId"],
                    Name = (string)dr["Name"],
                    Stock = (int)dr["Stock"],
                    Price = (double)dr["Price"],
                    MenuCategory = new MenuCategory()
                    {
                        VAT = (double)dr["VAT"],
                        Name = (string)dr["Name"],
                        Menu = new Menu()
                        {
                            Name = (string)dr["Name"]
                        }
                    }
                };
                list.Add(menuItem);
            } 
            return list;
        }

        public void SendOrderItems(List<OrderItem> orderItems)
        {
            string query = "INSERT INTO OrderItem (OrderId, Comment, MenuItemId, Quantity) VALUES (@orderId, @comment, @menuItemId, @quantity)";
            foreach (OrderItem orderItem in orderItems)
            {
                SqlParameter[] sqlParameters;
                sqlParameters = new SqlParameter[]
                {
                    new SqlParameter("@orderId", 1),
                    new SqlParameter("@comment", orderItem.Comment),
                    new SqlParameter("@menuItemId", orderItem.MenuItem.MenuItemId),
                    new SqlParameter("@quantity", orderItem.Quantity)
                };
                ExecuteEditQuery(query, sqlParameters);
            }
        }  
        
        public void CreateOrder(Order order)
        {
            string query = "INSERT INTO [Order] (EmployeeId, ReceiptId, OrderDateTime, Status) VALUES (@EmployeeId, @ReceiptId, @OrderDateTime, @Status)";
            SqlParameter[] sqlParameters;
            sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@EmployeeId", order.Employee.EmployeeId),
                new SqlParameter("@ReceiptId", 5),
                new SqlParameter("@OrderDateTime", order.OrderDateTime),
                new SqlParameter("@Status", (int) order.Status)
            };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
