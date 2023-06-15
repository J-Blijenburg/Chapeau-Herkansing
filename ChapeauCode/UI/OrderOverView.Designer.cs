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
            BtnAddOrder = new CustomTools.RoundedButton();
            LblEmployee = new CustomTools.RoundedLabel();
            BtnAddQuantity = new CustomTools.RoundedButton();
            BtnCancelOrder = new CustomTools.RoundedButton();
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
            LblTableNumber.Location = new Point(139, 14);
            LblTableNumber.Margin = new Padding(2, 0, 2, 0);
            LblTableNumber.Name = "LblTableNumber";
            LblTableNumber.Size = new Size(153, 33);
            LblTableNumber.TabIndex = 10;
            LblTableNumber.Text = "Table #10";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(111, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 57);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // ListViewOrderdItems
            // 
            ListViewOrderdItems.FullRowSelect = true;
            ListViewOrderdItems.GridLines = true;
            ListViewOrderdItems.Location = new Point(6, 12);
            ListViewOrderdItems.MultiSelect = false;
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
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 416);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 15;
            label1.Text = "Order";
            // 
            // PnlDinner
            // 
            PnlDinner.AutoScroll = true;
            PnlDinner.Controls.Add(LblDinner);
            PnlDinner.Controls.Add(ListDinner);
            PnlDinner.Location = new Point(16, 138);
            PnlDinner.Name = "PnlDinner";
            PnlDinner.Size = new Size(373, 275);
            PnlDinner.TabIndex = 16;
            // 
            // LblDinner
            // 
            LblDinner.AutoSize = true;
            LblDinner.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblDinner.Location = new Point(158, 13);
            LblDinner.Name = "LblDinner";
            LblDinner.Size = new Size(45, 15);
            LblDinner.TabIndex = 0;
            LblDinner.Text = "Dinner";
            // 
            // ListDinner
            // 
            ListDinner.FullRowSelect = true;
            ListDinner.HeaderStyle = ColumnHeaderStyle.None;
            ListDinner.Location = new Point(6, 43);
            ListDinner.MultiSelect = false;
            ListDinner.Name = "ListDinner";
            ListDinner.Size = new Size(362, 212);
            ListDinner.TabIndex = 1;
            ListDinner.UseCompatibleStateImageBehavior = false;
            ListDinner.View = View.Details;
            ListDinner.Click += ListViewRowClick;
            // 
            // PnlLunch
            // 
            PnlLunch.Controls.Add(LblLunch);
            PnlLunch.Controls.Add(ListLunch);
            PnlLunch.Location = new Point(16, 138);
            PnlLunch.Name = "PnlLunch";
            PnlLunch.Size = new Size(373, 275);
            PnlLunch.TabIndex = 17;
            // 
            // LblLunch
            // 
            LblLunch.AutoSize = true;
            LblLunch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblLunch.Location = new Point(158, 13);
            LblLunch.Name = "LblLunch";
            LblLunch.Size = new Size(40, 15);
            LblLunch.TabIndex = 0;
            LblLunch.Text = "Lunch";
            // 
            // ListLunch
            // 
            ListLunch.FullRowSelect = true;
            ListLunch.HeaderStyle = ColumnHeaderStyle.None;
            ListLunch.Location = new Point(6, 43);
            ListLunch.MultiSelect = false;
            ListLunch.Name = "ListLunch";
            ListLunch.Size = new Size(362, 212);
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
            PnlDrinks.Location = new Point(16, 138);
            PnlDrinks.Name = "PnlDrinks";
            PnlDrinks.Size = new Size(373, 275);
            PnlDrinks.TabIndex = 20;
            // 
            // LblDrinks
            // 
            LblDrinks.AutoSize = true;
            LblDrinks.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblDrinks.Location = new Point(158, 13);
            LblDrinks.Name = "LblDrinks";
            LblDrinks.Size = new Size(43, 15);
            LblDrinks.TabIndex = 0;
            LblDrinks.Text = "Drinks";
            // 
            // ListDrinks
            // 
            ListDrinks.FullRowSelect = true;
            ListDrinks.HeaderStyle = ColumnHeaderStyle.None;
            ListDrinks.Location = new Point(6, 43);
            ListDrinks.MultiSelect = false;
            ListDrinks.Name = "ListDrinks";
            ListDrinks.Size = new Size(362, 212);
            ListDrinks.TabIndex = 1;
            ListDrinks.UseCompatibleStateImageBehavior = false;
            ListDrinks.View = View.Details;
            ListDrinks.Click += ListViewRowClick;
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
            BtnDrinks.TabIndex = 24;
            BtnDrinks.Text = "Drinks\r\n Not Available";
            BtnDrinks.UseVisualStyleBackColor = false;
            BtnDrinks.Click += BtnDrinks_Click;
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
            BtnDinner.TabIndex = 25;
            BtnDinner.Text = "Dinner \r\nNot Available";
            BtnDinner.UseVisualStyleBackColor = false;
            BtnDinner.Click += BtnDinner_Click;
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
            BtnLunch.TabIndex = 26;
            BtnLunch.Text = "Lunch\r\nNot available\r\n";
            BtnLunch.UseVisualStyleBackColor = false;
            BtnLunch.Click += BtnLunch_Click;
            // 
            // BtnAddCommentOrderItem
            // 
            BtnAddCommentOrderItem.BackColor = Color.FromArgb(196, 196, 196);
            BtnAddCommentOrderItem.FlatAppearance.BorderSize = 0;
            BtnAddCommentOrderItem.FlatStyle = FlatStyle.Flat;
            BtnAddCommentOrderItem.Location = new Point(16, 643);
            BtnAddCommentOrderItem.Margin = new Padding(2, 2, 2, 2);
            BtnAddCommentOrderItem.Name = "BtnAddCommentOrderItem";
            BtnAddCommentOrderItem.Size = new Size(104, 35);
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
            BtnRemoveOrderItem.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            BtnRemoveOrderItem.Location = new Point(146, 644);
            BtnRemoveOrderItem.Margin = new Padding(2, 2, 2, 2);
            BtnRemoveOrderItem.Name = "BtnRemoveOrderItem";
            BtnRemoveOrderItem.Size = new Size(35, 33);
            BtnRemoveOrderItem.TabIndex = 28;
            BtnRemoveOrderItem.Text = "-";
            BtnRemoveOrderItem.TextAlign = ContentAlignment.TopCenter;
            BtnRemoveOrderItem.UseVisualStyleBackColor = false;
            BtnRemoveOrderItem.Click += BtnRemoveOrderItem_Click;
            // 
            // BtnAddOrder
            // 
            BtnAddOrder.BackColor = Color.FromArgb(255, 179, 71);
            BtnAddOrder.FlatAppearance.BorderSize = 0;
            BtnAddOrder.FlatStyle = FlatStyle.Flat;
            BtnAddOrder.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAddOrder.Location = new Point(244, 636);
            BtnAddOrder.Margin = new Padding(2, 2, 2, 2);
            BtnAddOrder.Name = "BtnAddOrder";
            BtnAddOrder.Size = new Size(145, 50);
            BtnAddOrder.TabIndex = 29;
            BtnAddOrder.Text = "ADD Order";
            BtnAddOrder.UseVisualStyleBackColor = false;
            BtnAddOrder.Click += BtnAddOrder_Click;
            // 
            // LblEmployee
            // 
            LblEmployee.AutoEllipsis = true;
            LblEmployee.BackColor = Color.FromArgb(255, 179, 71);
            LblEmployee.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            LblEmployee.Location = new Point(303, 14);
            LblEmployee.Margin = new Padding(2, 0, 2, 0);
            LblEmployee.Name = "LblEmployee";
            LblEmployee.Size = new Size(86, 40);
            LblEmployee.TabIndex = 30;
            LblEmployee.Text = "Employee";
            LblEmployee.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnAddQuantity
            // 
            BtnAddQuantity.BackColor = Color.FromArgb(196, 196, 196);
            BtnAddQuantity.FlatAppearance.BorderSize = 0;
            BtnAddQuantity.FlatStyle = FlatStyle.Flat;
            BtnAddQuantity.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAddQuantity.Location = new Point(264, 1073);
            BtnAddQuantity.Name = "BtnAddQuantity";
            BtnAddQuantity.Size = new Size(50, 55);
            BtnAddQuantity.TabIndex = 31;
            BtnAddQuantity.Text = "+";
            BtnAddQuantity.TextAlign = ContentAlignment.TopRight;
            BtnAddQuantity.UseVisualStyleBackColor = false;
            BtnAddQuantity.Click += BtnAddQuantity_Click;
            // 
            // BtnCancelOrder
            // 
            BtnCancelOrder.BackColor = Color.FromArgb(255, 179, 71);
            BtnCancelOrder.FlatAppearance.BorderSize = 0;
            BtnCancelOrder.FlatStyle = FlatStyle.Flat;
            BtnCancelOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCancelOrder.Location = new Point(-26, 17);
            BtnCancelOrder.Name = "BtnCancelOrder";
            BtnCancelOrder.Size = new Size(131, 63);
            BtnCancelOrder.TabIndex = 32;
            BtnCancelOrder.Text = "CANCEL";
            BtnCancelOrder.UseVisualStyleBackColor = false;
            BtnCancelOrder.Click += BtnCancelOrder_Click;
            // 
            // OrderOverView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(569, 1162);
            Controls.Add(BtnCancelOrder);
            Controls.Add(BtnAddQuantity);
            Controls.Add(LblEmployee);
            Controls.Add(BtnAddOrder);
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
            Margin = new Padding(2, 2, 2, 2);
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
        private CustomTools.RoundedButton BtnAddOrder;
        private CustomTools.RoundedLabel LblEmployee;
        private CustomTools.RoundedButton BtnAddQuantity;
        private CustomTools.RoundedButton BtnCancelOrder;
    }
}