using Model;
using Logic;

namespace UI
{
    public partial class Tables : Form
    {
        private TableService tableService;
        private Employee loggedInEmployee;
        private Login loginForm;
        public Tables(Employee loggedInEmployee, Login loginForm)
        {
            InitializeComponent();
            tableService = new TableService();
            this.loggedInEmployee = loggedInEmployee;
            Initializer();
            LoadTables();
            this.loginForm = loginForm;
        }
        private void Initializer()
        {
            employeeNameLbl.Text = this.loggedInEmployee.FirstName;
            timeUpdateTimer.Start();
            timeUpdateTimer.Tick += timeUpdateTimer_Tick;
            tableUpdateTimer.Interval = 10000;
            tableUpdateTimer.Tick += tableUpdateTimer_Tick;
            tableUpdateTimer.Start();
        }
        private void LoadTables()
        {
            List<Table> tables = tableService.GetAllTables();
            foreach (Table table in tables)
            {
                Button tableButton = this.Controls.Find($"table{table.Number}Btn", true).FirstOrDefault() as Button;
                if (tableButton != null)
                {
                    tableButton.BackColor = tableService.GetColorForTable(table);
                    tableButton.Tag = table;
                    tableButton.Click -= TableButton_Click;
                    tableButton.Click += TableButton_Click;
                }
            }
        }
        private void TableButton_Click(object sender, EventArgs e)
        {
            Button tableButton = sender as Button;
            Table selectedTable = tableButton.Tag as Table;

            TableStatusOverview tableStatusOverview = new TableStatusOverview(selectedTable, loggedInEmployee, this);
            tableStatusOverview.TableStatusChanged += (s, eventArgs) => LoadTables();
            tableStatusOverview.Show();
            this.Hide();
        }
        private void timeUpdateTimer_Tick(object sender, EventArgs e)
        {
            timeLbl.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void tableUpdateTimer_Tick(object sender, EventArgs e)
        {
            LoadTables();
        }

        private void btnSignOff_Click(object sender, EventArgs e)
        {
            loggedInEmployee = null;
            this.Close();
            loginForm.ShowDialog();
        }
    }
}
