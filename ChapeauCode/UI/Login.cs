using System;
using System.Windows.Forms;
using DAL;
using Logic;
using Model;

namespace UI
{
    public partial class Login : Form
    {
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

            Employee loggedInEmployee = employeeService.ValidateEmployeeLogin(employeeNumber, password);

            if (loggedInEmployee != null)
            {
                ProcessSuccessfulLogin(loggedInEmployee);
            }
            else
            {
                ShowLoginError("Invalid login credentials");
            }
        }
        private void ProcessSuccessfulLogin(Employee loggedInEmployee)
        {
            this.Hide();
            OpenFormBasedOnRole(loggedInEmployee);
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
                    employeeForm = new KitchenBarView(loggedInEmployee);
                    employeeForm.ShowDialog();
                    break;
                case EmployeeRole.Bartender:
                    employeeForm = new KitchenBarView(loggedInEmployee);
                    employeeForm.ShowDialog();
                    break;
                case EmployeeRole.Waiter:
                case EmployeeRole.Manager:
                    employeeForm = new Tables(loggedInEmployee);
                    employeeForm.ShowDialog();
                    break;
                default:
                    throw new ArgumentException("Invalid employee role");
            }
        }
        private void showHidePasswordBtn_Click(object sender, EventArgs e)
        {
            passwordTextbox.UseSystemPasswordChar = !passwordTextbox.UseSystemPasswordChar;
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
