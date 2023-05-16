using System;
using System.Collections.Generic;
using System.Linq;
using Model;
using DAL;
using System.Drawing;
using System.Diagnostics;

namespace Logic
{
    public class TableService
    {
        private TableDAO tableDAO;

        public TableService()
        {
            tableDAO = new TableDAO();
        }

        public List<Table> GetAllTables()
        {
            return tableDAO.GetTables();
        }
        public void UpdateTableStatus(int tableNumber, TableStatus newStatus)
        {
            tableDAO.UpdateTableStatus(tableNumber, newStatus);
        }
        public Color GetColorForTable(Table table)
        {
            if (table.UndeliveredOrdersCount > 0)
            {
                return Color.Red;
            }
            else
            {
                return GetColorForStatus(table.Status);
            }
        }

        public Color GetColorForStatus(TableStatus status)
        {
            switch (status)
            {
                case TableStatus.Open:
                    return ColorTranslator.FromHtml("#8AD2B0");
                case TableStatus.Occupied:
                    return ColorTranslator.FromHtml("#FFB347");
                case TableStatus.Reserved:
                    return ColorTranslator.FromHtml("#C4C4C4");
                default:
                    return Color.Gray;
            }
        }
    }
}
