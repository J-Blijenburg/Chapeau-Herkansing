using Model;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
   public class OrderDAO : BaseDao
    {
        public List<MenuItem> GetMenuItemsByMenuAndCategory(string menu, string category)
        {
            string query = "SELECT MI.Name, MI.Stock, MI.Price, MC.VAT, MC.Name, ME.Name, ME.StartTime, ME.EndTime " +
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
    }
}
