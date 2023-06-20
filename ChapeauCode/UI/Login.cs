using System;
using System.Windows.Forms;
using DAL;
using Logic;
using Model;

namespace UI
{
    public partial class Login : Form
    {
        //readonly omdat je alleen dingen terug krijgt
        private readonly EmployeeService employeeService;
        public Login()
        {
            InitializeComponent();
            employeeService = new EmployeeService();
            UpdateLoginButton();
            passwordTextbox.UseSystemPasswordChar = true;
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string employeeNumber = userNameTextBox.Text;
            string password = passwordTextbox.Text;

            try
            {
                Employee loggedInEmployee = employeeService.ValidateEmployeeLogin(employeeNumber, password);
                ProcessSuccessfulLogin(loggedInEmployee);
            }
            catch (Exception ex)
            {
                ShowLoginError(ex.Message);
            }
        }
        private void ProcessSuccessfulLogin(Employee loggedInEmployee)
        {
            ClearFields();
            this.Hide();
            OpenFormBasedOnRole(loggedInEmployee);
        }
        private void ClearFields()
        {
            userNameTextBox.Text = "";
            passwordTextbox.Text = "";
            loginErrorMsgLbl.Text = "";
            managerContactMsgLbl.Visible = false;
        }
        private void ShowLoginError(string errorMessage)
        {
            loginErrorMsgLbl.Text = errorMessage;
        }
        private void OpenFormBasedOnRole(Employee loggedInEmployee)
        {
            Form employeeForm = null;
            switch (loggedInEmployee.Role)
            {
                case EmployeeRole.Chefkok:
                case EmployeeRole.Bartender:
                    employeeForm = new KitchenBarView(loggedInEmployee, this);
                    break;
                case EmployeeRole.Waiter:
                case EmployeeRole.Manager:
                    employeeForm = new Tables(loggedInEmployee, this);
                    break;
                default:
                    MessageBox.Show("Invalid employee role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            if (employeeForm != null)
            {
                employeeForm.ShowDialog();
            }
        }

        private void showHidePasswordBtn_Click(object sender, EventArgs e)
        {
            //bepalen of de huidige boolean value op true of false staat, standaard staat ie op true
            //als er op geklikt wordt wordt het false
            passwordTextbox.UseSystemPasswordChar = !passwordTextbox.UseSystemPasswordChar;
            //tekst veranderen op basis van de value, true of false, true is show false is hide
            showHidePasswordBtn.Text = passwordTextbox.UseSystemPasswordChar ? "Show" : "Hide";
        }
        private void UpdateLoginButton()
        {
            loginBtn.Enabled = employeeService.IsUserInputValid(userNameTextBox.Text, passwordTextbox.Text);
        }
        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateLoginButton();
        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {
            UpdateLoginButton();
        }

        private void forgotPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   
            managerContactMsgLbl.Visible = true;
        }
    }
}
