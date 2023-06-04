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
            BtnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 110);
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
            BtnLunch.Location = new Point(23, 138);
            BtnLunch.Name = "BtnLunch";
            BtnLunch.Size = new Size(129, 83);
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
            BtnDinner.Location = new Point(226, 138);
            BtnDinner.Name = "BtnDinner";
            BtnDinner.Size = new Size(129, 83);
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
            BtnDrinks.Location = new Point(429, 138);
            BtnDrinks.Name = "BtnDrinks";
            BtnDrinks.Size = new Size(129, 83);
            BtnDrinks.TabIndex = 3;
            BtnDrinks.Text = "Drinks\r\nNot Available\r\n";
            BtnDrinks.UseVisualStyleBackColor = false;
            // 
            // LblTableNumber
            // 
            LblTableNumber.AutoSize = true;
            LblTableNumber.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            LblTableNumber.ForeColor = Color.FromArgb(196, 196, 196);
            LblTableNumber.Location = new Point(199, 23);
            LblTableNumber.Name = "LblTableNumber";
            LblTableNumber.Size = new Size(224, 52);
            LblTableNumber.TabIndex = 4;
            LblTableNumber.Text = "Table #10";
            // 
            // LblEmployee
            // 
            LblEmployee.AutoEllipsis = true;
            LblEmployee.BackColor = Color.FromArgb(255, 179, 71);
            LblEmployee.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblEmployee.Location = new Point(433, 30);
            LblEmployee.Margin = new Padding(4, 0, 4, 0);
            LblEmployee.Name = "LblEmployee";
            LblEmployee.Size = new Size(123, 67);
            LblEmployee.TabIndex = 5;
            LblEmployee.Text = "Employee";
            LblEmployee.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ListViewOrderdItems);
            groupBox1.Location = new Point(23, 273);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(534, 615);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // ListViewOrderdItems
            // 
            ListViewOrderdItems.Location = new Point(9, 37);
            ListViewOrderdItems.Margin = new Padding(4, 5, 4, 5);
            ListViewOrderdItems.Name = "ListViewOrderdItems";
            ListViewOrderdItems.Size = new Size(515, 554);
            ListViewOrderdItems.TabIndex = 0;
            ListViewOrderdItems.UseCompatibleStateImageBehavior = false;
            ListViewOrderdItems.View = View.Details;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(276, 930);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 42);
            label3.TabIndex = 7;
            label3.Text = "Total:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(289, 992);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 42);
            label4.TabIndex = 8;
            label4.Text = "VAT:";
            // 
            // LblVatPrice
            // 
            LblVatPrice.AutoSize = true;
            LblVatPrice.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblVatPrice.Location = new Point(471, 992);
            LblVatPrice.Margin = new Padding(4, 0, 4, 0);
            LblVatPrice.Name = "LblVatPrice";
            LblVatPrice.Size = new Size(90, 42);
            LblVatPrice.TabIndex = 10;
            LblVatPrice.Text = "___,-";
            LblVatPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LblTotalPrice
            // 
            LblTotalPrice.AutoSize = true;
            LblTotalPrice.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblTotalPrice.Location = new Point(471, 930);
            LblTotalPrice.Margin = new Padding(4, 0, 4, 0);
            LblTotalPrice.Name = "LblTotalPrice";
            LblTotalPrice.Size = new Size(90, 42);
            LblTotalPrice.TabIndex = 9;
            LblTotalPrice.Text = "___,-";
            LblTotalPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // BtnAdd
            // 
            BtnAdd.BackColor = Color.FromArgb(255, 179, 71);
            BtnAdd.FlatAppearance.BorderColor = Color.Red;
            BtnAdd.FlatAppearance.BorderSize = 20;
            BtnAdd.Font = new Font("Poppins", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAdd.Location = new Point(350, 1060);
            BtnAdd.Name = "BtnAdd";
            BtnAdd.Size = new Size(207, 83);
            BtnAdd.TabIndex = 11;
            BtnAdd.Text = "Pay";
            BtnAdd.UseVisualStyleBackColor = false;
            // 
            // TableOverview
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(569, 1162);
            Controls.Add(BtnAdd);
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
        private Button BtnAdd;
        private ListView ListViewOrderdItems;
    }
}