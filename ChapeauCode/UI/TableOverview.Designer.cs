namespace UI
{
    partial class TableOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableOverview));
            pictureBox1 = new PictureBox();
            BtnLunch = new Button();
            BtnDinner = new Button();
            BtnDrinks = new Button();
            LblTableNumber = new Label();
            LblEmployee = new Label();
            groupBox1 = new GroupBox();
            ListViewOrderdItems = new ListView();
            label3 = new Label();
            label4 = new Label();
            LblVatPrice = new Label();
            LblTotalPrice = new Label();
            BtnPayment = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // BtnLunch
            // 
            BtnLunch.BackColor = Color.Silver;
            BtnLunch.Enabled = false;
            BtnLunch.FlatAppearance.BorderSize = 0;
            BtnLunch.FlatStyle = FlatStyle.Flat;
            BtnLunch.Font = new Font("Segoe UI", 9F, FontStyle.Strikeout, GraphicsUnit.Point);
            BtnLunch.Location = new Point(16, 83);
            BtnLunch.Margin = new Padding(2, 2, 2, 2);
            BtnLunch.Name = "BtnLunch";
            BtnLunch.Size = new Size(90, 50);
            BtnLunch.TabIndex = 1;
            BtnLunch.Text = "Lunch\r\nNot Available\r\n";
            BtnLunch.UseVisualStyleBackColor = false;
            // 
            // BtnDinner
            // 
            BtnDinner.BackColor = Color.Silver;
            BtnDinner.Enabled = false;
            BtnDinner.FlatAppearance.BorderSize = 0;
            BtnDinner.FlatStyle = FlatStyle.Flat;
            BtnDinner.Font = new Font("Segoe UI", 9F, FontStyle.Strikeout, GraphicsUnit.Point);
            BtnDinner.Location = new Point(158, 83);
            BtnDinner.Margin = new Padding(2, 2, 2, 2);
            BtnDinner.Name = "BtnDinner";
            BtnDinner.Size = new Size(90, 50);
            BtnDinner.TabIndex = 2;
            BtnDinner.Text = "Dinner\r\nNot Available\r\n";
            BtnDinner.UseVisualStyleBackColor = false;
            // 
            // BtnDrinks
            // 
            BtnDrinks.BackColor = Color.Silver;
            BtnDrinks.Enabled = false;
            BtnDrinks.FlatAppearance.BorderSize = 0;
            BtnDrinks.FlatStyle = FlatStyle.Flat;
            BtnDrinks.Font = new Font("Segoe UI", 9F, FontStyle.Strikeout, GraphicsUnit.Point);
            BtnDrinks.Location = new Point(300, 83);
            BtnDrinks.Margin = new Padding(2, 2, 2, 2);
            BtnDrinks.Name = "BtnDrinks";
            BtnDrinks.Size = new Size(90, 50);
            BtnDrinks.TabIndex = 3;
            BtnDrinks.Text = "Drinks\r\nNot Available\r\n";
            BtnDrinks.UseVisualStyleBackColor = false;
            // 
            // LblTableNumber
            // 
            LblTableNumber.AutoSize = true;
            LblTableNumber.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            LblTableNumber.ForeColor = Color.FromArgb(196, 196, 196);
            LblTableNumber.Location = new Point(139, 14);
            LblTableNumber.Margin = new Padding(2, 0, 2, 0);
            LblTableNumber.Name = "LblTableNumber";
            LblTableNumber.Size = new Size(153, 33);
            LblTableNumber.TabIndex = 4;
            LblTableNumber.Text = "Table #10";
            // 
            // LblEmployee
            // 
            LblEmployee.AutoEllipsis = true;
            LblEmployee.BackColor = Color.FromArgb(255, 179, 71);
            LblEmployee.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblEmployee.Location = new Point(303, 18);
            LblEmployee.Name = "LblEmployee";
            LblEmployee.Size = new Size(86, 40);
            LblEmployee.TabIndex = 5;
            LblEmployee.Text = "Employee";
            LblEmployee.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ListViewOrderdItems);
            groupBox1.Location = new Point(16, 164);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(374, 369);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // ListViewOrderdItems
            // 
            ListViewOrderdItems.Location = new Point(6, 22);
            ListViewOrderdItems.Name = "ListViewOrderdItems";
            ListViewOrderdItems.Size = new Size(362, 334);
            ListViewOrderdItems.TabIndex = 0;
            ListViewOrderdItems.UseCompatibleStateImageBehavior = false;
            ListViewOrderdItems.View = View.Details;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(193, 558);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 7;
            label3.Text = "Total:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(202, 595);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 8;
            label4.Text = "VAT:";
            // 
            // LblVatPrice
            // 
            LblVatPrice.AutoSize = true;
            LblVatPrice.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblVatPrice.Location = new Point(330, 595);
            LblVatPrice.Name = "LblVatPrice";
            LblVatPrice.Size = new Size(45, 20);
            LblVatPrice.TabIndex = 10;
            LblVatPrice.Text = "___,-";
            LblVatPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LblTotalPrice
            // 
            LblTotalPrice.AutoSize = true;
            LblTotalPrice.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblTotalPrice.Location = new Point(330, 558);
            LblTotalPrice.Name = "LblTotalPrice";
            LblTotalPrice.Size = new Size(45, 20);
            LblTotalPrice.TabIndex = 9;
            LblTotalPrice.Text = "___,-";
            LblTotalPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BtnPayment
            // 
            BtnPayment.BackColor = Color.FromArgb(255, 179, 71);
            BtnPayment.FlatAppearance.BorderColor = Color.Red;
            BtnPayment.FlatAppearance.BorderSize = 20;
            BtnPayment.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnPayment.Location = new Point(245, 636);
            BtnPayment.Margin = new Padding(2, 2, 2, 2);
            BtnPayment.Name = "BtnPayment";
            BtnPayment.Size = new Size(145, 50);
            BtnPayment.TabIndex = 11;
            BtnPayment.Text = "Pay";
            BtnPayment.UseVisualStyleBackColor = false;
            BtnPayment.Click += BtnPayment_Click;
            // 
            // TableOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(398, 697);
            Controls.Add(BtnPayment);
            Controls.Add(LblVatPrice);
            Controls.Add(LblTotalPrice);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(LblEmployee);
            Controls.Add(LblTableNumber);
            Controls.Add(BtnDrinks);
            Controls.Add(BtnDinner);
            Controls.Add(BtnLunch);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            Name = "TableOverview";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TableOverview";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button BtnLunch;
        private Button BtnDinner;
        private Button BtnDrinks;
        private Label LblTableNumber;
        private Label LblEmployee;
        private GroupBox groupBox1;
        private Label label3;
        private Label label4;
        private Label LblVatPrice;
        private Label LblTotalPrice;
        private Button BtnPayment;
        private ListView ListViewOrderdItems;
    }
}