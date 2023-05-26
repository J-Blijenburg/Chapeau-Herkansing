﻿using Model;
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
        public List<MenuItem> GetMenuItemsByMenuNameAndCategoryName(string menu, string category)
        {
            string query = "SELECT MI.MenuItemId, MI.Name, MI.Stock, MI.Price " +
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
            return CreateListOfMenuItem(ExecuteSelectQuery(query, sqlParameters));
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
            string query = "INSERT INTO OrderItem (OrderId, Comment, MenuItemId, Quantity) VALUES (@orderId, @comment, @menuItemId, @quantity)";
            foreach (OrderItem orderItem in order.GetOrderItems())
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
                new SqlParameter("@stock", orderItem.MenuItem.GetStock() - orderItem.Quantity),
                new SqlParameter("@menuItemId", orderItem.MenuItem.MenuItemId)
            };
            ExecuteEditQuery(query, sqlParameters);
        }
        
        public void CreateOrder(Order order)
        {
            //When a order is added to the database return the ide of the order 
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
            string query = "SELECT MenuId, Name, StartTime, EndTime FROM Menu";
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

        public Menu GetMenuByMenuType(MenuType menuType)
        {
            string query = "SELECT MU.MenuId, MU.Name, MU.StartTime, MU.EndTime " +
                "FROM Menu AS MU " +
                "WHERE MU.Name = @menuType";
            SqlParameter[] sqlParameters;
            sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@menuType", menuType.ToString()),
            };

            return CreateMenu(ExecuteSelectQuery(query, sqlParameters));
        }

        private Menu CreateMenu(DataTable dataTable)
        {
            Menu menu = new Menu();
            foreach (DataRow dr in dataTable.Rows)
            {
                menu.MenuId = (int)dr["MenuId"];
                menu.Name = StringToMenuType((string)dr["Name"]);
                menu.StartTime = new TimeOnly(((TimeSpan)dr["StartTime"]).Ticks);
                menu.EndTime = new TimeOnly(((TimeSpan)dr["EndTime"]).Ticks);

            }

            return menu;
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
                    menuCategoryId = (int)dr["MenuCategoryId"],
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

        public List<OrderItem> GetKitchenOrders()
        {
            string query = "SELECT oi.OrderID, oi.Comment, oi.Quantity, o.Status, m.Name AS 'Dish', c.Name AS 'Type' " + "FROM OrderItem oi " + "JOIN [Order] o ON oi.OrderID = o.OrderID " + "JOIN MenuItem m ON oi.MenuItemID = m.MenuItemID " + "JOIN MenuCategory mc ON m.MenuCategoryID = mc.MenuCategoryID " + "JOIN Menu c ON mc.MenuId = c.MenuId " + "WHERE o.Status <> 3 AND (c.Name = 'Lunch' OR c.Name = 'Dinner');";
            return ReadKitchenAndBarOrders(ExecuteSelectQuery(query));
        }

        public List<OrderItem> GetBarOrders()
        {
            string query = "SELECT oi.OrderID, oi.Comment oi.Quantity, o.Status, m.Name AS 'Dish', c.Name AS 'Type' " + "FROM OrderItem oi " + "JOIN [Order] o ON oi.OrderID = o.OrderID " + "JOIN MenuItem m ON oi.MenuItemID = m.MenuItemID " + "JOIN MenuCategory mc ON m.MenuCategoryID = mc.MenuCategoryID " + "JOIN Menu c ON mc.MenuId = c.MenuId " + "WHERE o.Status <> 3 AND (c.Name = 'Drinks');";
            return ReadKitchenAndBarOrders(ExecuteSelectQuery(query));
        }

        public void UpdateOrderStatus(int orderId, OrderStatus orderStatus)
        {
            string query = "UPDATE [Order] SET Status = @status WHERE OrderId = @orderId";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@status", orderStatus);
            sqlParameters[1] = new SqlParameter("@orderId", orderId);
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
                            Order = new Order()
                            {
                                OrderId = (int)dr["OrderId"],
                                Status = (OrderStatus)(int)dr["Status"],


                            },
                            Quantity = (int)dr["Quantity"],
                            Comment = (string)dr["Comment"],
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
                Console.WriteLine(e.Message);
                return null;
            }


        }
    }
}
