using Model;
using Logic;

namespace UI
{
    public partial class Tables : Form
    {
        private TableService tableService;
        private Employee loggedInEmployee;
        private Login loginForm;
        private const string TableButtonNameFormat = "table{0}Btn";

        public Tables(Employee loggedInEmployee, Login loginForm)
        {
            InitializeComponent();
            tableService = new TableService();
            this.loggedInEmployee = loggedInEmployee;
            this.loginForm = loginForm;

            Initializer();
            LoadTables();
        }
        private void Initializer()
        {
            employeeNameLbl.Text = this.loggedInEmployee.FirstName;

            timeUpdateTimer.Tick += timeUpdateTimer_Tick;
            timeUpdateTimer.Start();
            tableUpdateTimer.Interval = 10000; //10 seconden
            tableUpdateTimer.Tick += tableUpdateTimer_Tick;
            tableUpdateTimer.Start();
        }
        private void LoadTables()
        {
            List<Table> tables = tableService.GetAllTables();
            foreach (Table table in tables)
            {
                //string format replaced values die in curly braces staan {} met de value na de komma
                Button tableButton = this.Controls.Find(string.Format(TableButtonNameFormat, table.Number), true).FirstOrDefault() as Button;

                if (tableButton != null)
                {
                    tableButton.BackColor = tableService.GetColorForTable(table);
                    tableButton.Tag = table;
                    //eerst unsubscriben, preventief om te voorkomen dat de eventhandler meerdere keren wordt toegevoegd aan dezelfde
                    
                    tableButton.Click -= TableButton_Click;
                    //geeft de object ook meteen door
                    tableButton.Click += TableButton_Click;
                }
            }
        }
        private void ReloadTables(object sender, EventArgs e)
        {
            LoadTables();
        }
        private void TableButton_Click(object sender, EventArgs e)
        {
            //sender is een object en krijgt mee van subscriber
            Button tableButton = sender as Button;
            Table selectedTable = tableButton.Tag as Table;
            this.Hide();

            TableStatusOverview tableStatusOverview = new TableStatusOverview(selectedTable, loggedInEmployee, this);
            tableStatusOverview.TableStatusChanged += ReloadTables;
            tableStatusOverview.Show();
            
            
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
            this.Dispose();
            loginForm.Show();
        }

    }
}
