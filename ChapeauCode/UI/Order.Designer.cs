namespace UI
{
    partial class Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
            LblEmployee = new Label();
            LblTableNumber = new Label();
            BtnDrinks = new Button();
            btnDinner = new Button();
            btnLunch = new Button();
            pictureBox1 = new PictureBox();
            BtnPay = new Button();
            ListViewOrderdItems = new ListView();
            groupBox1 = new GroupBox();
            label1 = new Label();
            listView1 = new ListView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // LblEmployee
            // 
            LblEmployee.AutoEllipsis = true;
            LblEmployee.BackColor = Color.FromArgb(255, 179, 71);
            LblEmployee.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblEmployee.Location = new Point(303, 14);
            LblEmployee.Name = "LblEmployee";
            LblEmployee.Size = new Size(86, 40);
            LblEmployee.TabIndex = 11;
            LblEmployee.Text = "Employee";
            LblEmployee.TextAlign = ContentAlignment.MiddleCenter;
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
            LblTableNumber.TabIndex = 10;
            LblTableNumber.Text = "Table #10";
            // 
            // BtnDrinks
            // 
            BtnDrinks.BackColor = Color.FromArgb(138, 210, 176);
            BtnDrinks.Location = new Point(300, 83);
            BtnDrinks.Margin = new Padding(2);
            BtnDrinks.Name = "BtnDrinks";
            BtnDrinks.Size = new Size(90, 50);
            BtnDrinks.TabIndex = 9;
            BtnDrinks.Text = "Drinks";
            BtnDrinks.UseVisualStyleBackColor = false;
            // 
            // btnDinner
            // 
            btnDinner.BackColor = Color.FromArgb(138, 210, 176);
            btnDinner.Location = new Point(158, 83);
            btnDinner.Margin = new Padding(2);
            btnDinner.Name = "btnDinner";
            btnDinner.Size = new Size(90, 50);
            btnDinner.TabIndex = 8;
            btnDinner.Text = "Dinner";
            btnDinner.UseVisualStyleBackColor = false;
            // 
            // btnLunch
            // 
            btnLunch.BackColor = Color.FromArgb(138, 210, 176);
            btnLunch.Location = new Point(16, 83);
            btnLunch.Margin = new Padding(2);
            btnLunch.Name = "btnLunch";
            btnLunch.Size = new Size(90, 50);
            btnLunch.TabIndex = 7;
            btnLunch.Text = "Lunch";
            btnLunch.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // BtnPay
            // 
            BtnPay.BackColor = Color.FromArgb(255, 179, 71);
            BtnPay.FlatAppearance.BorderColor = Color.Red;
            BtnPay.FlatAppearance.BorderSize = 20;
            BtnPay.Font = new Font("Poppins", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnPay.Location = new Point(245, 636);
            BtnPay.Margin = new Padding(2);
            BtnPay.Name = "BtnPay";
            BtnPay.Size = new Size(145, 50);
            BtnPay.TabIndex = 13;
            BtnPay.Text = "ADD";
            BtnPay.UseVisualStyleBackColor = false;
            // 
            // ListViewOrderdItems
            // 
            ListViewOrderdItems.Location = new Point(6, 12);
            ListViewOrderdItems.Name = "ListViewOrderdItems";
            ListViewOrderdItems.Size = new Size(362, 179);
            ListViewOrderdItems.TabIndex = 0;
            ListViewOrderdItems.UseCompatibleStateImageBehavior = false;
            ListViewOrderdItems.View = View.Details;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ListViewOrderdItems);
            groupBox1.Location = new Point(16, 434);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(374, 197);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 416);
            label1.Name = "label1";
            label1.Size = new Size(60, 28);
            label1.TabIndex = 15;
            label1.Text = "Order";
            // 
            // listView1
            // 
            listView1.Location = new Point(16, 160);
            listView1.Name = "listView1";
            listView1.Size = new Size(373, 220);
            listView1.TabIndex = 16;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(398, 697);
            Controls.Add(listView1);
            Controls.Add(groupBox1);
            Controls.Add(BtnPay);
            Controls.Add(LblEmployee);
            Controls.Add(LblTableNumber);
            Controls.Add(BtnDrinks);
            Controls.Add(btnDinner);
            Controls.Add(btnLunch);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Order";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblEmployee;
        private Label LblTableNumber;
        private Button BtnDrinks;
        private Button btnDinner;
        private Button btnLunch;
        private PictureBox pictureBox1;
        private Button BtnPay;
        private ListView ListViewOrderdItems;
        private GroupBox groupBox1;
        private Label label1;
        private ListView listView1;
    }
}