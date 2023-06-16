namespace UI
{
    partial class KitchenBarView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitchenBarView));
            lstViewOrders = new ListView();
            OrderItemId = new ColumnHeader();
            Comment = new ColumnHeader();
            Quantity = new ColumnHeader();
            TimeInSystem = new ColumnHeader();
            orderDateTime = new ColumnHeader();
            Description = new ColumnHeader();
            OrderItemStatus = new ColumnHeader();
            OrderId = new ColumnHeader();
            lstViewSelectedOrder = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            textBox1 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            btnInPrep = new Button();
            btnPrepared = new Button();
            btnServed = new Button();
            textBox2 = new TextBox();
            txtTypeOfOrder = new TextBox();
            txtBoxUser = new TextBox();
            pictureBox1 = new PictureBox();
            rdbFinishedOrders = new RadioButton();
            rdbRunningOrders = new RadioButton();
            btnSignOff = new Button();
            tableNumber = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lstViewOrders
            // 
            lstViewOrders.Columns.AddRange(new ColumnHeader[] { OrderItemId, tableNumber, Comment, Quantity, TimeInSystem, orderDateTime, Description, OrderItemStatus, OrderId });
            lstViewOrders.FullRowSelect = true;
            lstViewOrders.GridLines = true;
            lstViewOrders.Location = new Point(12, 189);
            lstViewOrders.Name = "lstViewOrders";
            lstViewOrders.Size = new Size(808, 419);
            lstViewOrders.TabIndex = 0;
            lstViewOrders.UseCompatibleStateImageBehavior = false;
            lstViewOrders.View = View.Details;
            lstViewOrders.SelectedIndexChanged += lstViewOrders_SelectedIndexChanged;
            // 
            // OrderItemId
            // 
            OrderItemId.Text = "OrderItemID";
            OrderItemId.Width = 100;
            // 
            // Comment
            // 
            Comment.Text = "Comment";
            Comment.Width = 200;
            // 
            // Quantity
            // 
            Quantity.Text = "Quantity";
            Quantity.Width = 80;
            // 
            // TimeInSystem
            // 
            TimeInSystem.Text = "Elapsed Time (H:M:S)";
            TimeInSystem.Width = 120;
            // 
            // orderDateTime
            // 
            orderDateTime.Text = "Order time";
            orderDateTime.Width = 120;
            // 
            // Description
            // 
            Description.Text = "Description";
            Description.Width = 250;
            // 
            // OrderItemStatus
            // 
            OrderItemStatus.Text = "Status";
            OrderItemStatus.Width = 0;
            // 
            // OrderId
            // 
            OrderId.Text = "OrderId";
            // 
            // lstViewSelectedOrder
            // 
            lstViewSelectedOrder.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader7 });
            lstViewSelectedOrder.FullRowSelect = true;
            lstViewSelectedOrder.GridLines = true;
            lstViewSelectedOrder.Location = new Point(826, 349);
            lstViewSelectedOrder.Name = "lstViewSelectedOrder";
            lstViewSelectedOrder.Size = new Size(589, 259);
            lstViewSelectedOrder.TabIndex = 1;
            lstViewSelectedOrder.UseCompatibleStateImageBehavior = false;
            lstViewSelectedOrder.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "OrderItemId";
            columnHeader1.Width = 320;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Order status";
            columnHeader2.Width = 340;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "OrderId";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 128, 0);
            textBox1.Font = new Font("Arial Narrow", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(826, 293);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(589, 50);
            textBox1.TabIndex = 2;
            textBox1.Text = "View order status";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(826, 235);
            label1.Name = "label1";
            label1.Size = new Size(2, 55);
            label1.TabIndex = 3;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(1412, 235);
            label3.Name = "label3";
            label3.Size = new Size(2, 55);
            label3.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(826, 288);
            label4.Name = "label4";
            label4.Size = new Size(589, 2);
            label4.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(826, 235);
            label2.Name = "label2";
            label2.Size = new Size(589, 2);
            label2.TabIndex = 7;
            // 
            // btnInPrep
            // 
            btnInPrep.Location = new Point(848, 246);
            btnInPrep.Name = "btnInPrep";
            btnInPrep.Size = new Size(126, 36);
            btnInPrep.TabIndex = 8;
            btnInPrep.Text = "In preparation";
            btnInPrep.UseVisualStyleBackColor = true;
            btnInPrep.Click += btnInPrep_Click;
            // 
            // btnPrepared
            // 
            btnPrepared.BackColor = Color.FromArgb(255, 128, 0);
            btnPrepared.Location = new Point(1064, 246);
            btnPrepared.Name = "btnPrepared";
            btnPrepared.Size = new Size(126, 36);
            btnPrepared.TabIndex = 9;
            btnPrepared.Text = "Prepared";
            btnPrepared.UseVisualStyleBackColor = false;
            btnPrepared.Click += btnPrepared_Click;
            // 
            // btnServed
            // 
            btnServed.BackColor = Color.FromArgb(0, 192, 0);
            btnServed.Location = new Point(1267, 246);
            btnServed.Name = "btnServed";
            btnServed.Size = new Size(126, 36);
            btnServed.TabIndex = 10;
            btnServed.Text = "Served";
            btnServed.UseVisualStyleBackColor = false;
            btnServed.Click += btnServed_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(255, 128, 0);
            textBox2.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(826, 189);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(589, 43);
            textBox2.TabIndex = 11;
            textBox2.Text = "Change order status";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTypeOfOrder
            // 
            txtTypeOfOrder.BackColor = Color.FromArgb(255, 128, 0);
            txtTypeOfOrder.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point);
            txtTypeOfOrder.Location = new Point(12, 71);
            txtTypeOfOrder.Multiline = true;
            txtTypeOfOrder.Name = "txtTypeOfOrder";
            txtTypeOfOrder.ReadOnly = true;
            txtTypeOfOrder.Size = new Size(1402, 64);
            txtTypeOfOrder.TabIndex = 12;
            txtTypeOfOrder.Text = "{typeOfOrder}";
            txtTypeOfOrder.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBoxUser
            // 
            txtBoxUser.BackColor = Color.FromArgb(255, 128, 0);
            txtBoxUser.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxUser.Location = new Point(1267, 33);
            txtBoxUser.Multiline = true;
            txtBoxUser.Name = "txtBoxUser";
            txtBoxUser.ReadOnly = true;
            txtBoxUser.Size = new Size(147, 32);
            txtBoxUser.TabIndex = 13;
            txtBoxUser.Text = "{user}";
            txtBoxUser.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // rdbFinishedOrders
            // 
            rdbFinishedOrders.AutoSize = true;
            rdbFinishedOrders.Location = new Point(12, 141);
            rdbFinishedOrders.Name = "rdbFinishedOrders";
            rdbFinishedOrders.Size = new Size(132, 19);
            rdbFinishedOrders.TabIndex = 15;
            rdbFinishedOrders.Text = "Finished order items";
            rdbFinishedOrders.UseVisualStyleBackColor = true;
            rdbFinishedOrders.CheckedChanged += rdbFinishedOrders_CheckedChanged;
            // 
            // rdbRunningOrders
            // 
            rdbRunningOrders.AutoSize = true;
            rdbRunningOrders.Location = new Point(12, 166);
            rdbRunningOrders.Name = "rdbRunningOrders";
            rdbRunningOrders.Size = new Size(133, 19);
            rdbRunningOrders.TabIndex = 16;
            rdbRunningOrders.Text = "Running order items";
            rdbRunningOrders.UseVisualStyleBackColor = true;
            rdbRunningOrders.CheckedChanged += rdbRunningOrders_CheckedChanged;
            // 
            // btnSignOff
            // 
            btnSignOff.BackColor = Color.DarkOrange;
            btnSignOff.Location = new Point(133, 33);
            btnSignOff.Name = "btnSignOff";
            btnSignOff.Size = new Size(75, 32);
            btnSignOff.TabIndex = 17;
            btnSignOff.Text = "Sign off";
            btnSignOff.UseVisualStyleBackColor = false;
            btnSignOff.Click += btnSignOff_Click;
            // 
            // tableNumber
            // 
            tableNumber.Text = "Table";
            // 
            // KitchenBarView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1427, 665);
            Controls.Add(btnSignOff);
            Controls.Add(rdbRunningOrders);
            Controls.Add(rdbFinishedOrders);
            Controls.Add(pictureBox1);
            Controls.Add(txtBoxUser);
            Controls.Add(txtTypeOfOrder);
            Controls.Add(textBox2);
            Controls.Add(btnServed);
            Controls.Add(btnPrepared);
            Controls.Add(btnInPrep);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(lstViewSelectedOrder);
            Controls.Add(lstViewOrders);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "KitchenBarView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KitchenBar";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lstViewOrders;
        private ListView lstViewSelectedOrder;
        private TextBox textBox1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label2;
        private Button btnInPrep;
        private Button btnPrepared;
        private Button btnServed;
        private TextBox textBox2;
        private TextBox txtTypeOfOrder;
        private TextBox txtBoxUser;
        private PictureBox pictureBox1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader Comment;
        private ColumnHeader Quantity;
        private ColumnHeader Description;
        private ColumnHeader OrderItemStatus;
        private ColumnHeader OrderItemId;
        private ColumnHeader OrderId;
        private ColumnHeader columnHeader7;
        private ColumnHeader TimeInSystem;
        private RadioButton rdbFinishedOrders;
        private RadioButton rdbRunningOrders;
        private Button btnSignOff;
        private ColumnHeader orderDateTime;
        private ColumnHeader tableNumber;
    }
}