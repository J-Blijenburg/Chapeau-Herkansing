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
            employeeNameLbl.Location = new Point(292, 14);
            employeeNameLbl.Name = "employeeNameLbl";
            employeeNameLbl.Size = new Size(38, 15);
            employeeNameLbl.TabIndex = 28;
            employeeNameLbl.Text = "label5";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(255, 179, 71);
            backBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(3, 457);
            backBtn.Margin = new Padding(3, 2, 3, 2);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(81, 27);
            backBtn.TabIndex = 26;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // tableNumberLbl
            // 
            tableNumberLbl.AutoSize = true;
            tableNumberLbl.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            tableNumberLbl.Location = new Point(126, 142);
            tableNumberLbl.Name = "tableNumberLbl";
            tableNumberLbl.Size = new Size(104, 41);
            tableNumberLbl.TabIndex = 25;
            tableNumberLbl.Text = "label1";
            // 
            // goToTableBtn
            // 
            goToTableBtn.BackColor = Color.White;
            goToTableBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            goToTableBtn.Location = new Point(88, 321);
            goToTableBtn.Margin = new Padding(3, 2, 3, 2);
            goToTableBtn.Name = "goToTableBtn";
            goToTableBtn.Size = new Size(173, 40);
            goToTableBtn.TabIndex = 24;
            goToTableBtn.Text = "Go to table";
            goToTableBtn.UseVisualStyleBackColor = false;
            goToTableBtn.Click += goToTableBtn_Click;
            // 
            // reservedBtn
            // 
            reservedBtn.BackColor = Color.FromArgb(196, 196, 196);
            reservedBtn.FlatStyle = FlatStyle.Flat;
            reservedBtn.Location = new Point(247, 242);
            reservedBtn.Margin = new Padding(3, 2, 3, 2);
            reservedBtn.Name = "reservedBtn";
            reservedBtn.Size = new Size(89, 36);
            reservedBtn.TabIndex = 23;
            reservedBtn.Text = "Reserved";
            reservedBtn.UseVisualStyleBackColor = false;
            // 
            // occupiedBtn
            // 
            occupiedBtn.BackColor = Color.FromArgb(255, 179, 71);
            occupiedBtn.FlatStyle = FlatStyle.Flat;
            occupiedBtn.Location = new Point(126, 242);
            occupiedBtn.Margin = new Padding(3, 2, 3, 2);
            occupiedBtn.Name = "occupiedBtn";
            occupiedBtn.Size = new Size(89, 36);
            occupiedBtn.TabIndex = 22;
            occupiedBtn.Text = "Occupied";
            occupiedBtn.UseVisualStyleBackColor = false;
            // 
            // freeBtn
            // 
            freeBtn.BackColor = Color.FromArgb(138, 210, 176);
            freeBtn.BackgroundImageLayout = ImageLayout.None;
            freeBtn.FlatStyle = FlatStyle.Flat;
            freeBtn.Location = new Point(10, 242);
            freeBtn.Margin = new Padding(3, 2, 3, 2);
            freeBtn.Name = "freeBtn";
            freeBtn.Size = new Size(89, 36);
            freeBtn.TabIndex = 21;
            freeBtn.Text = "Free";
            freeBtn.UseVisualStyleBackColor = false;
            // 
            // TableStatusOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 697);
            Controls.Add(employeeNameLbl);
            Controls.Add(pictureBox1);
            Controls.Add(backBtn);
            Controls.Add(tableNumberLbl);
            Controls.Add(goToTableBtn);
            Controls.Add(reservedBtn);
            Controls.Add(occupiedBtn);
            Controls.Add(freeBtn);
            Margin = new Padding(3, 2, 3, 2);
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