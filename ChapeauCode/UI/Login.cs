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
                ShowLoginError();
            }
        }
        private bool IsUserInputValid()
        {
            return !string.IsNullOrWhiteSpace(userNameTextBox.Text) && !string.IsNullOrWhiteSpace(passwordTextbox.Text);
        }
        private void ProcessSuccessfulLogin(Employee loggedInEmployee)
        {
            this.Hide();
            OpenFormBasedOnRole(loggedInEmployee);
        }
        private void ShowLoginError()
        {
            loginErrorMsgLbl.Text = "Invalid login credentials";
        }

        private void OpenFormBasedOnRole(Employee loggedInEmployee)
        {
            switch (loggedInEmployee.Role)
            {
                case EmployeeRole.Chefkok:
                case EmployeeRole.Bartender:
                    using (KitchenBar chefForm = new KitchenBar())
                    {
                        chefForm.ShowDialog();
                    }
                    break;

                case EmployeeRole.Waiter:
                case EmployeeRole.Manager:
                    using (Tables waiterForm = new Tables(loggedInEmployee))
                    {
                        waiterForm.ShowDialog();
                    }
                    break;

                default:
                    throw new ArgumentException("Invalid employee role");
            }
        }
        private void showHidePasswordBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (passwordTextbox.UseSystemPasswordChar)
                {
                    passwordTextbox.UseSystemPasswordChar = false;
                    showHidePasswordBtn.Text = "Hide";
                }
                else
                {
                    passwordTextbox.UseSystemPasswordChar = true;
                    showHidePasswordBtn.Text = "Show";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private void UpdateLoginButton()
        {
            try
            {
                loginBtn.Enabled = IsUserInputValid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }


        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateLoginButton();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateLoginButton();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void forgotPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                managerContactMsgLbl.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
