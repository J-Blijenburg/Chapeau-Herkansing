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
        
        public void CreateReceipt(Receipt receipt)
        {
            string query = "INSERT INTO Receipt (ReceiptDateTime, Feedback, EmployeeId, TableId, LowVatPrice, HighVatPrice, TotalPrice, Tip, IsHandled, PaymentId) VALUES (@ReceiptDateTime, @Feedback, @EmployeeId, @TableId, @LowVatPrice, @HighVatPrice, @TotalPrice, @Tip, @IsHandled, @PaymentId)";
            SqlParameter[] sqlParameters;
            sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@ReceiptDateTime", receipt.ReceiptDateTime),
                new SqlParameter("@Feedback", receipt.Feedback),
                new SqlParameter("@EmployeeId", receipt.Employee.EmployeeId),
                new SqlParameter("@TableId", receipt.Table.TableId),
                new SqlParameter("@LowVatPrice", receipt.LowVatPrice),
                new SqlParameter("@HighVatPrice", receipt.HighVatPrice),
                new SqlParameter("@TotalPrice", receipt.TotalPrice),
                new SqlParameter("@Tip", receipt.Tip),
                new SqlParameter("@IsHandled", receipt.IsHandled),
                new SqlParameter("@PaymentId", receipt.Payment.PaymentId),
            };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
