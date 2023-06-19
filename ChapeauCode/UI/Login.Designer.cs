namespace UI
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            userNameTextBox = new TextBox();
            passwordTextbox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            showHidePasswordBtn = new Button();
            loginBtn = new Button();
            forgotPasswordLink = new LinkLabel();
            managerContactMsgLbl = new Label();
            loginErrorMsgLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(180, 325);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(184, 27);
            userNameTextBox.TabIndex = 5;
            userNameTextBox.TextChanged += userNameTextBox_TextChanged;
            // 
            // passwordTextbox
            // 
            passwordTextbox.Location = new Point(180, 396);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.Size = new Size(184, 27);
            passwordTextbox.TabIndex = 6;
            passwordTextbox.TextChanged += passwordTextbox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(45, 390);
            label2.Name = "label2";
            label2.Size = new Size(129, 32);
            label2.TabIndex = 8;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(39, 319);
            label3.Name = "label3";
            label3.Size = new Size(135, 32);
            label3.TabIndex = 9;
            label3.Text = "Username:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(101, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 163);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // showHidePasswordBtn
            // 
            showHidePasswordBtn.Location = new Point(382, 396);
            showHidePasswordBtn.Name = "showHidePasswordBtn";
            showHidePasswordBtn.Size = new Size(61, 27);
            showHidePasswordBtn.TabIndex = 12;
            showHidePasswordBtn.Text = "Show";
            showHidePasswordBtn.UseVisualStyleBackColor = true;
            showHidePasswordBtn.Click += showHidePasswordBtn_Click;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = SystemColors.ActiveBorder;
            loginBtn.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            loginBtn.Location = new Point(159, 570);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(158, 73);
            loginBtn.TabIndex = 13;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // forgotPasswordLink
            // 
            forgotPasswordLink.AutoSize = true;
            forgotPasswordLink.BackColor = Color.Transparent;
            forgotPasswordLink.Cursor = Cursors.WaitCursor;
            forgotPasswordLink.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            forgotPasswordLink.LinkColor = SystemColors.ActiveCaptionText;
            forgotPasswordLink.Location = new Point(180, 675);
            forgotPasswordLink.Name = "forgotPasswordLink";
            forgotPasswordLink.Size = new Size(106, 17);
            forgotPasswordLink.TabIndex = 14;
            forgotPasswordLink.TabStop = true;
            forgotPasswordLink.Text = "Forgot password";
            forgotPasswordLink.UseWaitCursor = true;
            forgotPasswordLink.LinkClicked += forgotPasswordLink_LinkClicked;
            // 
            // managerContactMsgLbl
            // 
            managerContactMsgLbl.AutoSize = true;
            managerContactMsgLbl.ForeColor = Color.FromArgb(216, 0, 0);
            managerContactMsgLbl.Location = new Point(137, 707);
            managerContactMsgLbl.Name = "managerContactMsgLbl";
            managerContactMsgLbl.Size = new Size(196, 20);
            managerContactMsgLbl.TabIndex = 15;
            managerContactMsgLbl.Text = "Please contact the manager!";
            managerContactMsgLbl.Visible = false;
            // 
            // loginErrorMsgLbl
            // 
            loginErrorMsgLbl.AutoSize = true;
            loginErrorMsgLbl.ForeColor = Color.FromArgb(216, 0, 0);
            loginErrorMsgLbl.Location = new Point(159, 488);
            loginErrorMsgLbl.Name = "loginErrorMsgLbl";
            loginErrorMsgLbl.Size = new Size(0, 20);
            loginErrorMsgLbl.TabIndex = 16;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(455, 929);
            Controls.Add(loginErrorMsgLbl);
            Controls.Add(managerContactMsgLbl);
            Controls.Add(forgotPasswordLink);
            Controls.Add(loginBtn);
            Controls.Add(showHidePasswordBtn);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(passwordTextbox);
            Controls.Add(userNameTextBox);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox userNameTextBox;
        private TextBox passwordTextbox;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
        private Button showHidePasswordBtn;
        private Button loginBtn;
        private LinkLabel forgotPasswordLink;
        private Label managerContactMsgLbl;
        private Label loginErrorMsgLbl;
    }
}