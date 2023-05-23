namespace UI
{
    partial class OrderOverView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderOverView));
            LblTableNumber = new Label();
            pictureBox1 = new PictureBox();
            ListViewOrderdItems = new ListView();
            groupBox1 = new GroupBox();
            label1 = new Label();
            PnlDinner = new Panel();
            LblDinner = new Label();
            ListDinner = new ListView();
            PnlLunch = new Panel();
            LblLunch = new Label();
            ListLunch = new ListView();
            PnlDrinks = new Panel();
            LblDrinks = new Label();
            ListDrinks = new ListView();
            BtnDrinks = new CustomTools.RoundedButton();
            BtnDinner = new CustomTools.RoundedButton();
            BtnLunch = new CustomTools.RoundedButton();
            BtnAddCommentOrderItem = new CustomTools.RoundedButton();
            BtnRemoveOrderItem = new CustomTools.RoundedButton();
            BtnPay = new CustomTools.RoundedButton();
            LblEmployee = new CustomTools.RoundedLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            PnlDinner.SuspendLayout();
            PnlLunch.SuspendLayout();
            PnlDrinks.SuspendLayout();
            SuspendLayout();
            // 
            // LblTableNumber
            // 
            LblTableNumber.AutoSize = true;
            LblTableNumber.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            LblTableNumber.ForeColor = Color.FromArgb(196, 196, 196);
            LblTableNumber.Location = new Point(199, 23);
            LblTableNumber.Name = "LblTableNumber";
            LblTableNumber.Size = new Size(224, 52);
            LblTableNumber.TabIndex = 10;
            LblTableNumber.Text = "Table #10";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // ListViewOrderdItems
            // 
            ListViewOrderdItems.FullRowSelect = true;
            ListViewOrderdItems.GridLines = true;
            ListViewOrderdItems.Location = new Point(9, 20);
            ListViewOrderdItems.Margin = new Padding(4, 5, 4, 5);
            ListViewOrderdItems.Name = "ListViewOrderdItems";
            ListViewOrderdItems.Size = new Size(515, 296);
            ListViewOrderdItems.TabIndex = 0;
            ListViewOrderdItems.UseCompatibleStateImageBehavior = false;
            ListViewOrderdItems.View = View.Details;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ListViewOrderdItems);
            groupBox1.Location = new Point(23, 723);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(534, 328);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(27, 693);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 42);
            label1.TabIndex = 15;
            label1.Text = "Order";
            // 
            // PnlDinner
            // 
            PnlDinner.AutoScroll = true;
            PnlDinner.Controls.Add(LblDinner);
            PnlDinner.Controls.Add(ListDinner);
            PnlDinner.Location = new Point(23, 230);
            PnlDinner.Margin = new Padding(4, 5, 4, 5);
            PnlDinner.Name = "PnlDinner";
            PnlDinner.Size = new Size(533, 458);
            PnlDinner.TabIndex = 16;
            // 
            // LblDinner
            // 
            LblDinner.AutoSize = true;
            LblDinner.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblDinner.Location = new Point(226, 21);
            LblDinner.Margin = new Padding(4, 0, 4, 0);
            LblDinner.Name = "LblDinner";
            LblDinner.Size = new Size(69, 25);
            LblDinner.TabIndex = 0;
            LblDinner.Text = "Dinner";
            // 
            // ListDinner
            // 
            ListDinner.FullRowSelect = true;
            ListDinner.HeaderStyle = ColumnHeaderStyle.None;
            ListDinner.Location = new Point(9, 72);
            ListDinner.Margin = new Padding(4, 5, 4, 5);
            ListDinner.MultiSelect = false;
            ListDinner.Name = "ListDinner";
            ListDinner.Size = new Size(515, 350);
            ListDinner.TabIndex = 1;
            ListDinner.UseCompatibleStateImageBehavior = false;
            ListDinner.View = View.Details;
            ListDinner.Click += ListViewRowClick;
            // 
            // PnlLunch
            // 
            PnlLunch.Controls.Add(LblLunch);
            PnlLunch.Controls.Add(ListLunch);
            PnlLunch.Location = new Point(23, 230);
            PnlLunch.Margin = new Padding(4, 5, 4, 5);
            PnlLunch.Name = "PnlLunch";
            PnlLunch.Size = new Size(533, 458);
            PnlLunch.TabIndex = 17;
            // 
            // LblLunch
            // 
            LblLunch.AutoSize = true;
            LblLunch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblLunch.Location = new Point(226, 21);
            LblLunch.Margin = new Padding(4, 0, 4, 0);
            LblLunch.Name = "LblLunch";
            LblLunch.Size = new Size(63, 25);
            LblLunch.TabIndex = 0;
            LblLunch.Text = "Lunch";
            // 
            // ListLunch
            // 
            ListLunch.FullRowSelect = true;
            ListLunch.HeaderStyle = ColumnHeaderStyle.None;
            ListLunch.Location = new Point(9, 72);
            ListLunch.Margin = new Padding(4, 5, 4, 5);
            ListLunch.MultiSelect = false;
            ListLunch.Name = "ListLunch";
            ListLunch.Size = new Size(515, 350);
            ListLunch.TabIndex = 1;
            ListLunch.UseCompatibleStateImageBehavior = false;
            ListLunch.View = View.Details;
            ListLunch.Click += ListViewRowClick;
            // 
            // PnlDrinks
            // 
            PnlDrinks.AutoScroll = true;
            PnlDrinks.Controls.Add(LblDrinks);
            PnlDrinks.Controls.Add(ListDrinks);
            PnlDrinks.Location = new Point(23, 230);
            PnlDrinks.Margin = new Padding(4, 5, 4, 5);
            PnlDrinks.Name = "PnlDrinks";
            PnlDrinks.Size = new Size(533, 458);
            PnlDrinks.TabIndex = 20;
            // 
            // LblDrinks
            // 
            LblDrinks.AutoSize = true;
            LblDrinks.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblDrinks.Location = new Point(226, 21);
            LblDrinks.Margin = new Padding(4, 0, 4, 0);
            LblDrinks.Name = "LblDrinks";
            LblDrinks.Size = new Size(66, 25);
            LblDrinks.TabIndex = 0;
            LblDrinks.Text = "Drinks";
            // 
            // ListDrinks
            // 
            ListDrinks.FullRowSelect = true;
            ListDrinks.HeaderStyle = ColumnHeaderStyle.None;
            ListDrinks.Location = new Point(9, 72);
            ListDrinks.Margin = new Padding(4, 5, 4, 5);
            ListDrinks.MultiSelect = false;
            ListDrinks.Name = "ListDrinks";
            ListDrinks.Size = new Size(515, 350);
            ListDrinks.TabIndex = 1;
            ListDrinks.UseCompatibleStateImageBehavior = false;
            ListDrinks.View = View.Details;
            ListDrinks.Click += ListViewRowClick;
            // 
            // BtnDrinks
            // 
            BtnDrinks.BackColor = Color.FromArgb(138, 210, 176);
            BtnDrinks.FlatAppearance.BorderSize = 0;
            BtnDrinks.FlatStyle = FlatStyle.Flat;
            BtnDrinks.Location = new Point(428, 138);
            BtnDrinks.Name = "BtnDrinks";
            BtnDrinks.Size = new Size(129, 83);
            BtnDrinks.TabIndex = 24;
            BtnDrinks.Text = "Drinks";
            BtnDrinks.UseVisualStyleBackColor = false;
            BtnDrinks.Click += BtnDrinks_Click;
            // 
            // BtnDinner
            // 
            BtnDinner.BackColor = Color.FromArgb(138, 210, 176);
            BtnDinner.FlatAppearance.BorderSize = 0;
            BtnDinner.FlatStyle = FlatStyle.Flat;
            BtnDinner.Location = new Point(226, 138);
            BtnDinner.Name = "BtnDinner";
            BtnDinner.Size = new Size(129, 83);
            BtnDinner.TabIndex = 25;
            BtnDinner.Text = "Dinner";
            BtnDinner.UseVisualStyleBackColor = false;
            BtnDinner.Click += BtnDinner_Click;
            // 
            // BtnLunch
            // 
            BtnLunch.BackColor = Color.FromArgb(138, 210, 176);
            BtnLunch.FlatAppearance.BorderSize = 0;
            BtnLunch.FlatStyle = FlatStyle.Flat;
            BtnLunch.Location = new Point(23, 138);
            BtnLunch.Name = "BtnLunch";
            BtnLunch.Size = new Size(129, 83);
            BtnLunch.TabIndex = 26;
            BtnLunch.Text = "Lunch";
            BtnLunch.UseVisualStyleBackColor = false;
            BtnLunch.Click += BtnLunch_Click;
            // 
            // BtnAddCommentOrderItem
            // 
            BtnAddCommentOrderItem.BackColor = Color.FromArgb(196, 196, 196);
            BtnAddCommentOrderItem.FlatAppearance.BorderSize = 0;
            BtnAddCommentOrderItem.FlatStyle = FlatStyle.Flat;
            BtnAddCommentOrderItem.Location = new Point(23, 1072);
            BtnAddCommentOrderItem.Name = "BtnAddCommentOrderItem";
            BtnAddCommentOrderItem.Size = new Size(149, 58);
            BtnAddCommentOrderItem.TabIndex = 27;
            BtnAddCommentOrderItem.Text = "Comment";
            BtnAddCommentOrderItem.UseVisualStyleBackColor = false;
            BtnAddCommentOrderItem.Click += BtnAddCommentOrderItem_Click;
            // 
            // BtnRemoveOrderItem
            // 
            BtnRemoveOrderItem.BackColor = Color.FromArgb(196, 196, 196);
            BtnRemoveOrderItem.FlatAppearance.BorderSize = 0;
            BtnRemoveOrderItem.FlatStyle = FlatStyle.Flat;
            BtnRemoveOrderItem.Location = new Point(185, 1072);
            BtnRemoveOrderItem.Name = "BtnRemoveOrderItem";
            BtnRemoveOrderItem.Size = new Size(149, 58);
            BtnRemoveOrderItem.TabIndex = 28;
            BtnRemoveOrderItem.Text = "Remove";
            BtnRemoveOrderItem.UseVisualStyleBackColor = false;
            BtnRemoveOrderItem.Click += BtnRemoveOrderItem_Click;
            // 
            // BtnPay
            // 
            BtnPay.BackColor = Color.FromArgb(255, 179, 71);
            BtnPay.FlatAppearance.BorderSize = 0;
            BtnPay.FlatStyle = FlatStyle.Flat;
            BtnPay.Font = new Font("Poppins", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnPay.Location = new Point(349, 1060);
            BtnPay.Name = "BtnPay";
            BtnPay.Size = new Size(207, 83);
            BtnPay.TabIndex = 29;
            BtnPay.Text = "ADD Order";
            BtnPay.UseVisualStyleBackColor = false;
            BtnPay.Click += BtnPay_Click;
            // 
            // LblEmployee
            // 
            LblEmployee.AutoEllipsis = true;
            LblEmployee.BackColor = Color.FromArgb(255, 179, 71);
            LblEmployee.Font = new Font("Poppins", 10F, FontStyle.Bold, GraphicsUnit.Point);
            LblEmployee.Location = new Point(433, 23);
            LblEmployee.Name = "LblEmployee";
            LblEmployee.Size = new Size(123, 67);
            LblEmployee.TabIndex = 30;
            LblEmployee.Text = "Employee";
            LblEmployee.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OrderOverView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(569, 1162);
            Controls.Add(LblEmployee);
            Controls.Add(BtnPay);
            Controls.Add(BtnRemoveOrderItem);
            Controls.Add(BtnAddCommentOrderItem);
            Controls.Add(BtnLunch);
            Controls.Add(BtnDinner);
            Controls.Add(BtnDrinks);
            Controls.Add(PnlDinner);
            Controls.Add(PnlDrinks);
            Controls.Add(PnlLunch);
            Controls.Add(groupBox1);
            Controls.Add(LblTableNumber);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "OrderOverView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            PnlDinner.ResumeLayout(false);
            PnlDinner.PerformLayout();
            PnlLunch.ResumeLayout(false);
            PnlLunch.PerformLayout();
            PnlDrinks.ResumeLayout(false);
            PnlDrinks.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LblTableNumber;
        private Button BtnDinner1;
        private PictureBox pictureBox1;
        private ListView ListViewOrderdItems;
        private GroupBox groupBox1;
        private Label label1;
        private Panel PnlDinner;
        private Label LblDinner;
        private ListView ListDinner;
        private Panel PnlLunch;
        private Label LblLunch;
        private ListView ListLunch;
        private Panel PnlDrinks;
        private Label LblDrinks;
        private ListView ListDrinks;
        private CustomTools.RoundedButton BtnDrinks;
        private CustomTools.RoundedButton BtnDinner;
        private CustomTools.RoundedButton BtnLunch;
        private CustomTools.RoundedButton BtnAddCommentOrderItem;
        private CustomTools.RoundedButton BtnRemoveOrderItem;
        private CustomTools.RoundedButton BtnPay;
        private CustomTools.RoundedLabel LblEmployee;
    }
}