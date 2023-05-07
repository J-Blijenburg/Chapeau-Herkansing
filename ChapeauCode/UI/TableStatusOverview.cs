using Logic;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class TableStatusOverview : Form
    {
        private Table _selectedTable;
        private TableService _tableService;
        private Employee _loggedInEmployee;

        public event EventHandler TableStatusChanged;
        public TableStatusOverview(Table selectedTable, Employee loggedInEmployee)
        {
            InitializeComponent();
            _selectedTable = selectedTable;
            _tableService = new TableService();
            _loggedInEmployee = loggedInEmployee;

            employeeNameLbl.Text = _loggedInEmployee.FirstName;
            tableNumberLbl.Text = $"Table {_selectedTable.Number}";

            freeBtn.Click += ChangeTableStatusButton_Click;
            occupiedBtn.Click += ChangeTableStatusButton_Click;
            reservedBtn.Click += ChangeTableStatusButton_Click;

            UpdateButtonSelection();
        }


        private void UpdateButtonSelection()
        {
            freeBtn.FlatAppearance.BorderSize = _selectedTable.Status == TableStatus.Open ? 2 : 0;
            occupiedBtn.FlatAppearance.BorderSize = _selectedTable.Status == TableStatus.Occupied ? 2 : 0;
            reservedBtn.FlatAppearance.BorderSize = _selectedTable.Status == TableStatus.Reserved ? 2 : 0;
        }
        private void ChangeTableStatusButton_Click(object sender, EventArgs e)
        {
            TableStatus newStatus;
            if (sender == freeBtn)
                newStatus = TableStatus.Open;
            else if (sender == occupiedBtn)
                newStatus = TableStatus.Occupied;
            else
                newStatus = TableStatus.Reserved;

            UpdateTableStatus(newStatus);
        }

        private void UpdateTableStatus(TableStatus newStatus)
        {
            try
            {
                if (_tableService.UpdateTableStatus(_selectedTable.TableId, newStatus))
                {
                    _selectedTable.Status = newStatus;
                    UpdateButtonSelection();

                    TableStatusChanged?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Error updating table status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating table status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            Tables tables = new Tables(_loggedInEmployee);
            this.Close();
            tables.Show();
        }
    }
}
