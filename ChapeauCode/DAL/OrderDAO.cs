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
                };
                list.Add(menuItem);
            } 
            return list;
        }

        public void SendOrderItems(Order order)
        {
            string query = "INSERT INTO OrderItem (OrderId, Comment, MenuItemId, Quantity) VALUES (@orderId, @comment, @menuItemId, @quantity)";
            foreach (OrderItem orderItem in order.OrderItems)
            {
                SqlParameter[] sqlParameters;
                sqlParameters = new SqlParameter[]
                {
                    new SqlParameter("@orderId", orderItem.Order.OrderId),
                    new SqlParameter("@comment", orderItem.Comment),
                    new SqlParameter("@menuItemId", orderItem.MenuItem.MenuItemId),
                    new SqlParameter("@quantity", orderItem.Quantity)
                };
                UpdateQuantity(orderItem);
                ExecuteEditQuery(query, sqlParameters);
            }
        }  

        private void UpdateQuantity(OrderItem orderItem)
        {
            string query = "UPDATE MenuItem SET Stock = @stock WHERE MenuItemId = @menuItemId";
            SqlParameter[] sqlParameters;
            sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@stock", orderItem.MenuItem.Stock - orderItem.Quantity),
                new SqlParameter("@menuItemId", orderItem.MenuItem.MenuItemId)
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        
        public void CreateOrder(Order order)
        {
            string query = "INSERT INTO [Order] (EmployeeId, ReceiptId, OrderDateTime, Status) VALUES (@EmployeeId, @ReceiptId, @OrderDateTime, @Status); SELECT CAST(scope_identity() AS int)";
            SqlParameter[] sqlParameters;
            sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@EmployeeId", order.Employee.EmployeeId),
                new SqlParameter("@ReceiptId", order.Receipt.ReceiptId),
                new SqlParameter("@OrderDateTime", order.OrderDateTime),
                new SqlParameter("@Status", (int) order.Status)
            };
            order.OrderId = ExecuteInsertQueryAndReturnId(query, sqlParameters);
        }

        public List<OrderItem> GetOrderdItems(Table table){
            string query = "SELECT OI.OrderItemId, OD.OrderId, EM.EmployeeId , EM.FirstName, EM.LastName, EM.EmployeeNumber, EM.Password, EM.IsActive, EM.RegistrationDate, ER.Role,RT.ReceiptId, RT.ReceiptDateTime, RT.Feedback, EmployeeReceipt.EmployeeId, EmployeeReceipt.FirstName, EmployeeReceipt.LastName, EmployeeReceipt.EmployeeNumber, EmployeeReceipt.Password, EmployeeReceipt.IsActive, EmployeeReceipt.RegistrationDate, RoleReceipt.Role,TE.TableId,  TE.Number, TS.Status, RT.LowVatPrice, RT.HighVatPrice, RT.TotalPrice, RT.Tip, RT.IsHandled,PM.PaymentId, PM.IsPaid, OD.OrderDateTime, OS.Status, OI.Comment, MI.MenuItemId, MI.Name, MI.Stock, MI.Price, MC.MenuCategoryId, MC.VAT, MC.Name, MU.MenuId, MU.Name, MU.StartTime, MU.EndTime, OI.Quantity " +
                "FROM [OrderItem] AS OI JOIN [Order] AS OD ON OI.OrderId = OD.OrderId " +
                "JOIN [OrderStatus] AS OS ON OD.Status = OS.OrderStatusId " +
                "JOIN [Employee] AS EM ON OD.EmployeeId = EM.EmployeeId " +
                "JOIN [EmployeeRole] AS ER ON EM.Role = ER.EmployeeRoleId " +
                "JOIN [Receipt] AS RT ON OD.ReceiptId = RT.ReceiptId " +
                "JOIN [Employee] AS EmployeeReceipt ON RT.EmployeeId = EmployeeReceipt.EmployeeId " +
                "JOIN [EmployeeRole] AS RoleReceipt ON EmployeeReceipt.Role = RoleReceipt.EmployeeRoleId " +
                "JOIN [Table] AS TE ON RT.TableId = TE.TableId JOIN [TableStatus] AS TS ON TE.Status = TS.TableStatusId " +
                "JOIN [Payment] AS PM ON RT.PaymentId = PM.PaymentId " +
                "JOIN [MenuItem] AS MI ON OI.MenuItemId = MI.MenuItemId " +
                "JOIN [MenuCategory] AS MC ON MI.MenuCategoryId = MC.MenuCategoryId " +
                "JOIN [Menu] AS MU ON MC.MenuId = MU.MenuId " +
                "WHERE TE.Number = @TableNumber AND RT.IsHandled = 0";
            SqlParameter[] sqlParameters;
            sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@TableNumber", table.Number)
            };
            
            return CreateOrderItems(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<OrderItem> CreateOrderItems(DataTable dataTable)
        {
            List<OrderItem> orderItems = new List<OrderItem>();

            foreach (DataRow dataRow in dataTable.Rows)
            {
                OrderItem orderItem = new OrderItem()
                {
                    OrderItemId = (int)dataRow["OrderItemId"],
                    Order = new Order()
                    {
                        OrderId = (int)dataRow["OrderId"],
                        Employee = new Employee()
                        {
                            EmployeeId = (int)dataRow["EmployeeId"],
                            FirstName = (string)dataRow["FirstName"],
                            LastName = (string)dataRow["LastName"],
                            EmployeeNumber = (int)dataRow["EmployeeNumber"],
                            Password = (string)dataRow["Password"],
                            IsActive = (bool)dataRow["IsActive"],
                            RegistrationDate = DateTime.Now,
                            Role = StringToEmployeeRole((string)dataRow["Role"])
                        },
                        Receipt = new Receipt()
                        {
                            ReceiptId = (int)dataRow["ReceiptId"],
                            ReceiptDateTime = DateTime.Now,
                            Feedback = (string)dataRow["Feedback"],
                            Employee = new Employee()
                            {
                                EmployeeId = (int)dataRow["EmployeeId"],
                                FirstName = (string)dataRow["FirstName"],
                                LastName = (string)dataRow["LastName"],
                                EmployeeNumber = (int)dataRow["EmployeeNumber"],
                                Password = (string)dataRow["Password"],
                                IsActive = (bool)dataRow["IsActive"],
                                RegistrationDate = DateTime.Now,
                                Role =  StringToEmployeeRole((string)dataRow["Role"])
                            },
                            Table = new Table()
                            {
                                TableId = (int)dataRow["TableId"],
                                Number = (int)dataRow["Number"],
                                Status = StringToTableStatus((string)dataRow["Status"])
                            },
                            LowVatPrice = (double)dataRow["LowVatPrice"],
                            HighVatPrice = (double)dataRow["HighVatPrice"],
                            TotalPrice = (double)dataRow["TotalPrice"],
                            Tip = (double)dataRow["Tip"],
                            IsHandled = (bool)dataRow["IsHandled"],
                            Payment = new Payment()
                            {
                                PaymentId = (int)dataRow["PaymentId"],
                                IsPaid = (bool)dataRow["IsPaid"]
                            }
                        },
                        OrderDateTime = DateTime.Now,
                        Status = StringToOrderStatus((string)dataRow["Status"])

                    },
                    Comment = (string)dataRow["Comment"],
                    MenuItem = new MenuItem()
                    {
                        MenuItemId = (int)dataRow["MenuItemId"],
                        Name = (string)dataRow["Name"],
                        Stock = (int)dataRow["Stock"],
                        Price = (double)dataRow["Price"],
                    },
                    Quantity = (int)dataRow["Quantity"]
                };
                orderItems.Add(orderItem);
            }

            return orderItems;
        }

        private Category StringtoCategory(string categoryName)
        {
            switch (categoryName)
            {
                case "Starters":
                    return Category.Starters;
                case "Mains":
                    return Category.Mains;
                case "Desserts":
                    return Category.Desserts;
                case "Entres":
                    return Category.Entres;
                case "SoftDrinks":
                    return Category.SoftDrinks;
                case "Beers":
                    return Category.Beers;
                case "Wines":
                    return Category.Wines;
                case "Spirits":
                    return Category.Spirits;
                case "HotDrinks":
                    return Category.HotDrinks;
                default:
                    return Category.Starters;
            }
        }

        private MenuType StringToMenuType(string name)
        {
            switch (name)
            {
                case "Lunch":
                return MenuType.Lunch;
                case "Dinner":
                return MenuType.Dinner;
                case "Drinks":
                return MenuType.Drinks;
                default:
                return MenuType.Lunch;
            }
        }

        private EmployeeRole StringToEmployeeRole(string role)
        {
            switch (role)
            {
                case "Manager":
                    return EmployeeRole.Manager;
                case "Waiter":
                    return EmployeeRole.Waiter;
                case "Chefkok":
                    return EmployeeRole.Chefkok;
                case "Bartender":
                    return EmployeeRole.Bartender;
                    default:
                      return EmployeeRole.Waiter;
            }
        }

        private TableStatus StringToTableStatus(string tableStatus)
        {
            switch (tableStatus)
            {
                case "Open":
                    return TableStatus.Open;
                case "Reserved":
                    return TableStatus.Reserved;
                case "Occupied":
                    return TableStatus.Occupied;
                default:
                    return TableStatus.Open;
            }
        }

        private OrderStatus StringToOrderStatus(string orderStatus)
        {
            switch (orderStatus)
            {
                case "Ordered":
                    return OrderStatus.Ordered;
                case "Preparing":
                    return OrderStatus.Preparing;
                case "Delivered":
                    return OrderStatus.Delivered;
                case "ReadyToBeServed":
                    return OrderStatus.ReadyToBeServed;
                default:
                    return OrderStatus.Ordered;
      
            }
        }

        public void DeleteOrder(Order order)
        {
            string query = "DELETE FROM [Order] WHERE OrderId = @OrderId";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@OrderId", order.OrderId)
            };
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
