using Model;
using Logic;

namespace UI
{
    public partial class Tables : Form
    {
        private TableService tableService;
        private List<Table> tables;
        private Employee loggedInEmployee;

        public Tables(Employee loggedInEmployee)
        {
            InitializeComponent();
            tableService = new TableService();
            this.loggedInEmployee = loggedInEmployee;
            employeeNameLbl.Text = this.loggedInEmployee.FirstName;

            LoadTables();
            timeUpdateTimer.Start();
            timeUpdateTimer.Tick += TimeUpdateTimer_Tick;
        }
        private void LoadTables()
        {
            tables = tableService.GetAllTables();

            foreach (Table table in tables)
            {
                Button tableButton = this.Controls.Find($"table{table.Number}Btn", true).FirstOrDefault() as Button;
                if (tableButton != null)
                {
                    tableButton.BackColor = tableService.GetColorForStatus(table.Status);
                    tableButton.Tag = table;
                    tableButton.Click += TableButton_Click;
                }
            }
        }
        private void TableButton_Click(object sender, EventArgs e)
        {
            Button tableButton = sender as Button;
            Table selectedTable = tableButton.Tag as Table;

            TableStatusOverview tableStatusOverview = new TableStatusOverview(selectedTable, loggedInEmployee);
            tableStatusOverview.TableStatusChanged += (s, ev) =>
            {
                LoadTables();
            };
            tableStatusOverview.Show();
            this.Hide();
        }


        private void TableStatusUserControl_TableStatusChanged(object sender, EventArgs e)
        {
            LoadTables();
        }

        private void TimeUpdateTimer_Tick(object sender, EventArgs e)
        {
            timeLbl.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
