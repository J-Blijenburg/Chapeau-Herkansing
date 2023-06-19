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
        private const string ColorOpen = "#8AD2B0";
        private const string ColorOccupied = "#FFB347";
        private const string ColorReserved = "#C4C4C4";
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
            Table table = tableDAO.GetTable(tableNumber);

            if (table == null)
            {
                throw new Exception($"Table with number {tableNumber} not found");
            }
            if (this.HasUnhandledReceipt(tableNumber) && (table.Status == TableStatus.Occupied || table.Status == TableStatus.Reserved) && newStatus == TableStatus.Open)
            {
                throw new Exception("Can't set table to 'Free' because there are unhandled receipts");
            }

            tableDAO.UpdateTableStatus(tableNumber, newStatus);
        }
        public bool HasUnhandledReceipt(int tableNumber)
        {
            return tableDAO.HasUnhandledReceipt(tableNumber);
        }
        public Color GetColorForTable(Table table)
        {
            //tafel status heeft prioriteit
            if (table.Status == TableStatus.Open)
            {
                return GetColorForStatus(table.Status);
            }
            else if (table.UndeliveredOrdersCount > 0)
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
                    return ColorTranslator.FromHtml(ColorOpen);
                case TableStatus.Occupied:
                    return ColorTranslator.FromHtml(ColorOccupied);
                case TableStatus.Reserved:
                    return ColorTranslator.FromHtml(ColorReserved);
                default:
                    return Color.Gray;
            }
        }
    }
}
