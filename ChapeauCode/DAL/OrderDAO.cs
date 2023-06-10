using Model;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;

namespace DAL
{
   public class OrderDAO : BaseDao
    {
        //Code By: Jens Begin *******************************************************
        public List<MenuItem> GetMenuItemsByMenuNameAndCategoryName(string menuName, string categoryName)
        {
            string query = "SELECT MI.MenuItemId, MI.Name, MI.Stock, MI.Price " +
                "FROM MenuItem AS MI " +
                "JOIN MenuCategory AS MC ON MI.MenuCategoryId = MC.MenuCategoryId " +
                "JOIN Menu AS ME ON MC.MenuId = ME.MenuId " +
                "WHERE ME.Name = @menuName AND MC.Name = @categoryName";
            SqlParameter[] sqlParameters;
            sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@menuName", menuName),
                new SqlParameter("@categoryName", categoryName)

            };
            return CreateListOfMenuItem(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<OrderItem> GetOrderedItemsByReceiptId(int receiptId)
        {
            string query = @"SELECT OD.ReceiptId, OI.MenuItemId, MI.Name, MI.Price, MC.VAT, MC.MenuCategoryId, MC.Name AS MenuCategoryName, SUM(OI.Quantity) as TotalQuantity FROM [OrderItem] AS OI JOIN [Order] AS OD ON OI.OrderId = OD.OrderId JOIN [Receipt] AS RT ON OD.ReceiptId = RT.ReceiptId JOIN [Table] AS TE ON RT.TableNumber = TE.Number JOIN [MenuItem] AS MI ON OI.MenuItemId = MI.MenuItemId JOIN [MenuCategory] AS MC ON MI.MenuCategoryId = MC.MenuCategoryId WHERE OD.ReceiptId = @ReceiptId AND RT.IsHandled = 0 GROUP BY OD.ReceiptId, OI.MenuItemId, MI.Name, MI.Price, MC.VAT, MC.MenuCategoryId, MC.Name";

            SqlParameter[] sqlParameters = { new SqlParameter("@ReceiptId", receiptId) };

            return CreateListOfOrderItems(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<OrderItem> CreateListOfOrderItems(DataTable dataTable)
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            foreach (DataRow row in dataTable.Rows)
            {
                OrderItem orderItem = new OrderItem
                {
                    Order = new Order { Receipt = new Receipt { ReceiptId = (int)row["ReceiptId"] } },
                    MenuItem = new MenuItem {
                        MenuItemId = (int)row["MenuItemId"],
                        Name = row["Name"].ToString(),
                        Price = (double)row["Price"],
                    MenuCategory = new MenuCategory()
                    {
                        MenuCategoryId = (int)row["MenuCategoryId"],
                        VAT = (double)row["VAT"],
                        Name = (Category)Enum.Parse(typeof(Category), row["MenuCategoryName"].ToString())
                    }
                    },

                    Quantity = (int)row["TotalQuantity"]

                };


                orderItems.Add(orderItem);
            }

            return orderItems;
        }

        private List<MenuItem> CreateListOfMenuItem(DataTable dataTable)
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
            //After the order is created, the orderitems are added to the database
            string query = "INSERT INTO OrderItem (OrderId, Comment, MenuItemId, Quantity, OrderItemStatus) VALUES (@orderId, @comment, @menuItemId, @quantity, @orderItemStatus)";
            foreach (OrderItem orderItem in order.GetOrderItems())
            {
                SqlParameter[] sqlParameters;
                sqlParameters = new SqlParameter[]
                {
                    new SqlParameter("@orderId", orderItem.Order.OrderId),
                    new SqlParameter("@comment", orderItem.Comment),
                    new SqlParameter("@menuItemId", orderItem.MenuItem.MenuItemId),
                    new SqlParameter("@quantity", orderItem.Quantity),
                    new SqlParameter("@orderItemStatus", orderItem.OrderItemStatus)
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
                new SqlParameter("@stock", orderItem.CalculateTotalStock()),
                new SqlParameter("@menuItemId", orderItem.GetMenuItemId())
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        
        public void CreateOrder(Order order)
        {
            //When a order is added to the database return the id of the order 
            //And place it in the order object
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

        public List<Menu> GetListOfMenu()
        {
            //https://azureops.org/articles/get-local-date-in-azure-sql-database/
            //Get every menu from the database where the current time is between the start and end time of the menu
            string query = "SELECT MenuId, Name, StartTime, EndTime " +
                "FROM Menu " +
                "WHERE StartTime < CAST(SYSDATETIMEOFFSET() AT TIME ZONE 'W. Europe Standard Time' AS TIME) AND EndTime > CAST(SYSDATETIMEOFFSET() AT TIME ZONE 'W. Europe Standard Time' AS TIME)";
            SqlParameter[] sqlParameters;
            sqlParameters = new SqlParameter[]
            {
            };
            return CreateListOfMenu(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Menu> CreateListOfMenu(DataTable dataTable)
        {
            List<Menu> listOfMenus = new List<Menu>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Menu menu = new Menu()
                {
                    MenuId = (int)dr["MenuId"],
                    Name = StringToMenuType((string)dr["Name"]),
                    StartTime = new TimeOnly(((TimeSpan)dr["StartTime"]).Ticks),
                    EndTime = new TimeOnly(((TimeSpan)dr["EndTime"]).Ticks)
                };
                listOfMenus.Add(menu);
            }
            return listOfMenus;
        }

        private MenuType StringToMenuType(string menuName)
        {
            MenuType menuType = new MenuType();
            switch (menuName)
            {
                case "Lunch":
                    menuType = MenuType.Lunch;
                    break;
                case "Dinner":
                    menuType = MenuType.Dinner;
                    break;
                case "Drinks":
                    menuType = MenuType.Drinks;
                    break;
            }
            return menuType;
        }

        public List<MenuCategory> GetMenuCategoriesByMenu(Menu menu)
        {
            string query = "SELECT MC.MenuCategoryId, MC.VAT, MC.Name " +
                "FROM MenuCategory AS MC " +
                "JOIN MENU AS MU ON MC.MenuId = MU.MenuId " +
                "WHERE MU.Name = @menu";
            SqlParameter[] sqlParameters;
            sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@menu", menu.Name.ToString())
            };
            return CreateListOfMenuCategory(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<MenuCategory> CreateListOfMenuCategory(DataTable dataTable)
        {
            List<MenuCategory> listOfMenuCategories = new List<MenuCategory>();
            foreach (DataRow dr in dataTable.Rows)
            {
                MenuCategory menuCategory = new MenuCategory()
                {
                    MenuCategoryId = (int)dr["MenuCategoryId"],
                    VAT = (double)dr["VAT"],
                    Name = StringToCategory((string)dr["Name"])
                };
                listOfMenuCategories.Add(menuCategory);
            }
            return listOfMenuCategories;
        }

        private Category StringToCategory(string categoryName)
        {
            Category category = new Category();

            if (Enum.TryParse(categoryName, out Category categoryType))
            {
                category =  categoryType;
            }
             
            return category;
        }

        //Code By: Jens End *******************************************************


        public List<OrderItem> GetOrderItemsByReceiptId(int receiptId)
        {
            string query = @"SELECT OD.ReceiptId, OI.MenuItemId, MI.Name, MI.Price, MC.VAT, MC.MenuCategoryId, MC.Name AS MenuCategoryName, SUM(OI.Quantity) as TotalQuantity FROM [OrderItem] AS OI JOIN [Order] AS OD ON OI.OrderId = OD.OrderId JOIN [Receipt] AS RT ON OD.ReceiptId = RT.ReceiptId JOIN [Table] AS TE ON RT.TableNumber = TE.Number JOIN [MenuItem] AS MI ON OI.MenuItemId = MI.MenuItemId JOIN [MenuCategory] AS MC ON MI.MenuCategoryId = MC.MenuCategoryId WHERE OD.ReceiptId = @ReceiptId AND RT.IsHandled = 0 GROUP BY OD.ReceiptId, OI.MenuItemId, MI.Name, MI.Price, MC.VAT, MC.MenuCategoryId, MC.Name";

            SqlParameter[] sqlParameters = { new SqlParameter("@ReceiptId", receiptId) };

            return CreateListOfOrderItems(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<OrderItem> CreateListOfOrderItems(DataTable dataTable)
        {
            List<OrderItem> orderItems = new List<OrderItem>();
            foreach (DataRow row in dataTable.Rows)
            {
                OrderItem orderItem = new OrderItem
                {
                    Order = new Order { Receipt = new Receipt { ReceiptId = (int)row["ReceiptId"] } },
                    MenuItem = new MenuItem
                    {
                        MenuItemId = (int)row["MenuItemId"],
                        Name = row["Name"].ToString(),
                        Price = (double)row["Price"],
                        MenuCategory = new MenuCategory()
                        {
                            MenuCategoryId = (int)row["MenuCategoryId"],
                            VAT = (double)row["VAT"],
                            Name = (Category)Enum.Parse(typeof(Category), row["MenuCategoryName"].ToString())
                        }
                    },

                    Quantity = (int)row["TotalQuantity"]

                };


                orderItems.Add(orderItem);
            }

            return orderItems;
        }

        public List<OrderItem> GetOrderedItems(Table table)
        {
            string query = "SELECT OI.OrderItemId, OD.OrderId, EM.FirstName, EM.LastName, OD.OrderDateTime, OS.Status, OI.Comment, MI.MenuItemId, MI.Name AS MenuItemName, MI.Stock, MI.Price, MC.MenuCategoryId, MC.VAT, MC.Name AS MenuCategoryName, OI.Quantity " +
              "FROM [OrderItem] AS OI " +
              "JOIN [Order] AS OD ON OI.OrderId = OD.OrderId " +
              "JOIN [OrderStatus] AS OS ON OD.Status = OS.OrderStatusId " +
              "JOIN [Employee] AS EM ON OD.EmployeeId = EM.EmployeeId " +
              "JOIN [Receipt] AS RT ON OD.ReceiptId = RT.ReceiptId " +
              "JOIN [Table] AS TE ON RT.TableNumber = TE.Number " +
              "JOIN [MenuItem] AS MI ON OI.MenuItemId = MI.MenuItemId " +
              "JOIN [MenuCategory] AS MC ON MI.MenuCategoryId = MC.MenuCategoryId " +
              "WHERE TE.Number = @TableNumber AND RT.IsHandled = 0";

            SqlParameter[] sqlParameters = new SqlParameter[] {
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
                            FirstName = (string)dataRow["FirstName"],
                            LastName = (string)dataRow["LastName"],
                        },
                        OrderDateTime = DateTime.Now,
                        Status = StringToOrderStatus((string)dataRow["Status"])
                    },
                    Comment = (string)dataRow["Comment"],
                    MenuItem = new MenuItem()
                    {
                        MenuItemId = (int)dataRow["MenuItemId"],
                        Name = (string)dataRow["MenuItemName"],
                        Stock = (int)dataRow["Stock"],
                        Price = (double)dataRow["Price"],
                        MenuCategory = new MenuCategory()
                        {
                            MenuCategoryId = (int)dataRow["MenuCategoryId"],
                            VAT = (double)dataRow["VAT"],
                            Name = (Category)Enum.Parse(typeof(Category), dataRow["MenuCategoryName"].ToString())
                        }
                    },

                    Quantity = (int)dataRow["Quantity"]
                };
                orderItems.Add(orderItem);
            }

            return orderItems;
        }
        private OrderStatus StringToOrderStatus(string orderStatus)
        {
            switch (orderStatus)
            {
                case "InProgress":
                    return OrderStatus.InProgress;
                case "Finished":
                    return OrderStatus.Finished;
                default:
                    return OrderStatus.InProgress;
      
            }
        }

        

        public List<OrderItem> GetRunningOrderItems(MenuType type)
        {
            string queryString = GetTypeOfOrderForQuery(type);

            string query = "SELECT oi.OrderID, oi.OrderItemId, oi.OrderItemStatus, oi.Comment, oi.Quantity, o.Status, o.OrderDateTime, m.Name AS 'Dish', c.Name AS 'Type' " +
                           "FROM OrderItem oi " +
                           "JOIN [Order] o ON oi.OrderID = o.OrderID " +
                           "JOIN MenuItem m ON oi.MenuItemID = m.MenuItemID " +
                           "JOIN MenuCategory mc ON m.MenuCategoryID = mc.MenuCategoryID " +
                           "JOIN Menu c ON mc.MenuId = c.MenuId " +
                           "WHERE oi.OrderItemStatus <> 3 AND (" + queryString + ")";
            return ReadKitchenAndBarOrders(ExecuteSelectQuery(query));
        }

        public List<OrderItem> GetFinshedOrderItems(MenuType type)
        {
            string queryString = GetTypeOfOrderForQuery(type);

            string query = "SELECT oi.OrderID, oi.OrderItemId, oi.OrderItemStatus, oi.Comment, oi.Quantity, o.Status, o.OrderDateTime, m.Name AS 'Dish', c.Name AS 'Type' " +
                           "FROM OrderItem oi " +
                           "JOIN [Order] o ON oi.OrderID = o.OrderID " +
                           "JOIN MenuItem m ON oi.MenuItemID = m.MenuItemID " +
                           "JOIN MenuCategory mc ON m.MenuCategoryID = mc.MenuCategoryID " +
                           "JOIN Menu c ON mc.MenuId = c.MenuId " +
                           "WHERE o.Status = 2 AND (" + queryString + ")" +
                           "AND CONVERT(date, o.OrderDateTime) = CONVERT(date, GETDATE())";
            return ReadKitchenAndBarOrders(ExecuteSelectQuery(query));
        }



        private static string GetTypeOfOrderForQuery(MenuType type)
        {
            string query = "";
            switch (type)
            {
                case MenuType.Dinner:
                case MenuType.Lunch:
                    {
                        query = "c.Name = 'Lunch' OR c.Name = 'Dinner'";
                        break;
                    }
                case MenuType.Drinks:
                    {
                        query = "c.Name = 'Drinks'";
                        break;
                    }
                default:
                    {  
                        break;
                    }
            }

            return query;
        }

        public void UpdateOrderStatus(int orderId, OrderItemStatus orderStatus, int orderItemId)
        {
            string query = @"UPDATE [OrderItem]
                     SET [OrderItemStatus] = @status
                     WHERE [OrderItemId] = @OrderItemId;

                     IF NOT EXISTS (
                         SELECT 1
                         FROM [OrderItem]
                         WHERE OrderId = @orderId AND OrderItemStatus <> 3
                     )
                     BEGIN
                         UPDATE [Order]
                         SET Status = 2
                         WHERE OrderId = @OrderId;
                     END";

            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@status", orderStatus);
            sqlParameters[1] = new SqlParameter("@OrderItemId", orderItemId);
            sqlParameters[2] = new SqlParameter("@orderId", orderId);

            ExecuteEditQuery(query, sqlParameters);
        }


        private List<OrderItem> ReadKitchenAndBarOrders(DataTable dataTable)
        {
            List<OrderItem> list = new List<OrderItem>();
            try
            {
                if (dataTable != null)
                {
                    foreach (DataRow dr in dataTable.Rows)
                    {
                        OrderItem orderItem = new OrderItem()
                        {
                            Quantity = (int)dr["Quantity"],
                            Comment = (string)dr["Comment"],
                            OrderItemId = (int)dr["OrderItemId"],
                            OrderItemStatus = (OrderItemStatus)(int)dr["OrderItemStatus"],
                            Order = new Order()
                            {
                                OrderId = (int)dr["OrderId"],
                                Status = (OrderStatus)(int)dr["Status"],
                                OrderDateTime = (DateTime)dr["OrderDateTime"]

                            },
                    
                            MenuItem = new MenuItem()
                            {
                                Name = (string)dr["Dish"],
                                Menu = new Menu()
                                {
                                    Name = Enum.TryParse((string)dr["Type"], out MenuType menuType) ? menuType : MenuType.Lunch
                                }

                            },
                        };
                        list.Add(orderItem);
                    }
                }
                return list;
            }
            catch (Exception e)
            {
                
                return null;
            }


        }
    }
}
