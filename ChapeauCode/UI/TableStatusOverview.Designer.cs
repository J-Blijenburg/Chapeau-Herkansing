namespace UI
{
    partial class TableStatusOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableStatusOverview));
            employeeNameLbl = new Label();
            pictureBox1 = new PictureBox();
            backBtn = new Button();
            tableNumberLbl = new Label();
            goToTableBtn = new Button();
            reservedBtn = new Button();
            occupiedBtn = new Button();
            freeBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // employeeNameLbl
            // 
            employeeNameLbl.AutoSize = true;
            employeeNameLbl.Location = new Point(367, 22);
            employeeNameLbl.Name = "employeeNameLbl";
            employeeNameLbl.Size = new Size(75, 20);
            employeeNameLbl.TabIndex = 28;
            employeeNameLbl.Text = "Employee";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(255, 179, 71);
            backBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(3, 609);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(93, 36);
            backBtn.TabIndex = 26;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // tableNumberLbl
            // 
            tableNumberLbl.AutoSize = true;
            tableNumberLbl.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            tableNumberLbl.Location = new Point(166, 189);
            tableNumberLbl.Name = "tableNumberLbl";
            tableNumberLbl.Size = new Size(115, 50);
            tableNumberLbl.TabIndex = 25;
            tableNumberLbl.Text = "Table";
            // 
            // goToTableBtn
            // 
            goToTableBtn.BackColor = Color.White;
            goToTableBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            goToTableBtn.Location = new Point(136, 439);
            goToTableBtn.Name = "goToTableBtn";
            goToTableBtn.Size = new Size(198, 53);
            goToTableBtn.TabIndex = 24;
            goToTableBtn.Text = "Go to table";
            goToTableBtn.UseVisualStyleBackColor = false;
            goToTableBtn.Click += goToTableBtn_Click;
            // 
            // reservedBtn
            // 
            reservedBtn.BackColor = Color.FromArgb(196, 196, 196);
            reservedBtn.FlatStyle = FlatStyle.Flat;
            reservedBtn.Location = new Point(317, 334);
            reservedBtn.Name = "reservedBtn";
            reservedBtn.Size = new Size(102, 48);
            reservedBtn.TabIndex = 23;
            reservedBtn.Text = "Reserved";
            reservedBtn.UseVisualStyleBackColor = false;
            // 
            // occupiedBtn
            // 
            occupiedBtn.BackColor = Color.FromArgb(255, 179, 71);
            occupiedBtn.FlatStyle = FlatStyle.Flat;
            occupiedBtn.Location = new Point(179, 334);
            occupiedBtn.Name = "occupiedBtn";
            occupiedBtn.Size = new Size(102, 48);
            occupiedBtn.TabIndex = 22;
            occupiedBtn.Text = "Occupied";
            occupiedBtn.UseVisualStyleBackColor = false;
            // 
            // freeBtn
            // 
            freeBtn.BackColor = Color.FromArgb(138, 210, 176);
            freeBtn.BackgroundImageLayout = ImageLayout.None;
            freeBtn.FlatStyle = FlatStyle.Flat;
            freeBtn.Location = new Point(46, 334);
            freeBtn.Name = "freeBtn";
            freeBtn.Size = new Size(102, 48);
            freeBtn.TabIndex = 21;
            freeBtn.Text = "Free";
            freeBtn.UseVisualStyleBackColor = false;
            // 
            // TableStatusOverview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 929);
            Controls.Add(employeeNameLbl);
            Controls.Add(pictureBox1);
            Controls.Add(backBtn);
            Controls.Add(tableNumberLbl);
            Controls.Add(goToTableBtn);
            Controls.Add(reservedBtn);
            Controls.Add(occupiedBtn);
            Controls.Add(freeBtn);
            MaximizeBox = false;
            Name = "TableStatusOverview";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TableStatus";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label employeeNameLbl;
        private PictureBox pictureBox1;
        private Button backBtn;
        private Label tableNumberLbl;
        private Button goToTableBtn;
        private Button reservedBtn;
        private Button occupiedBtn;
        private Button freeBtn;
    }
}