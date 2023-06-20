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
        private Table selectedTable;
        private TableService tableService;
        private Employee loggedInEmployee;
        private Tables tablesForm;
        public event EventHandler TableStatusChanged;
        private bool isFormClosing = false;

        public TableStatusOverview(Table selectedTable, Employee loggedInEmployee, Tables tablesForm)
        {
            InitializeComponent();
            tableService = new TableService();
            this.selectedTable = selectedTable;
            this.loggedInEmployee = loggedInEmployee;
            this.tablesForm = tablesForm;

            SetLabels();
            SubscribeToEvents();
            UpdateFreeButtonState();
        }
        private void SetLabels()
        {
            employeeNameLbl.Text = this.loggedInEmployee.FirstName;
            tableNumberLbl.Text = $"Table {this.selectedTable.Number}";
            UpdateButtonSelection();
        }

        private void SubscribeToEvents()
        {
            freeBtn.Click += ChangeTableStatusButton_Click;
            occupiedBtn.Click += ChangeTableStatusButton_Click;
            reservedBtn.Click += ChangeTableStatusButton_Click;
            this.FormClosing += TableStatusOverview_FormClosing;
        }
        private void ReloadTables(object sender, EventArgs e)
        {
            UpdateTableStatus((TableStatus)sender);
        }
        private void TableStatusOverview_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isFormClosing)
            {
                isFormClosing = true;
                TableStatusChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        private void UpdateButtonSelection()
        {
            freeBtn.FlatAppearance.BorderSize = selectedTable.Status == TableStatus.Open ? 2 : 0;
            occupiedBtn.FlatAppearance.BorderSize = selectedTable.Status == TableStatus.Occupied ? 2 : 0;
            reservedBtn.FlatAppearance.BorderSize = selectedTable.Status == TableStatus.Reserved ? 2 : 0;
            goToTableBtn.Enabled = selectedTable.Status == TableStatus.Occupied || selectedTable.Status == TableStatus.Reserved;
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
                tableService.UpdateTableStatus(selectedTable.Number, newStatus);
                selectedTable.Status = newStatus;
                UpdateButtonSelection();
                UpdateFreeButtonState();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating table status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateFreeButtonState()
        {
            try
            {
                freeBtn.Enabled = !tableService.HasUnhandledReceipt(selectedTable.Number);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            tablesForm.Show();
        }

        private void goToTableBtn_Click(object sender, EventArgs e)
        {
            TableOverview tableOverview = new TableOverview(selectedTable, loggedInEmployee, this);
            this.Hide();
            tableOverview.Show();

        }
    }
}
