namespace UI
{
    partial class KitchenBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitchenBar));
            lstViewOrders = new ListView();
            OrderID = new ColumnHeader();
            Comment = new ColumnHeader();
            Quantity = new ColumnHeader();
            Description = new ColumnHeader();
            Status = new ColumnHeader();
            lstViewSelectedOrder = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lstViewOrders
            // 
            lstViewOrders.Columns.AddRange(new ColumnHeader[] { OrderID, Comment, Quantity, Description, Status });
            lstViewOrders.FullRowSelect = true;
            lstViewOrders.GridLines = true;
            lstViewOrders.Location = new Point(14, 252);
            lstViewOrders.Margin = new Padding(3, 4, 3, 4);
            lstViewOrders.Name = "lstViewOrders";
            lstViewOrders.Size = new Size(923, 557);
            lstViewOrders.TabIndex = 0;
            lstViewOrders.UseCompatibleStateImageBehavior = false;
            lstViewOrders.View = View.Details;
            lstViewOrders.SelectedIndexChanged += lstViewOrders_SelectedIndexChanged;
            // 
            // OrderID
            // 
            OrderID.Text = "Order ID";
            OrderID.Width = 200;
            // 
            // Comment
            // 
            Comment.Text = "Comment";
            Comment.Width = 200;
            // 
            // Quantity
            // 
            Quantity.Text = "Quantity";
            Quantity.Width = 200;
            // 
            // Description
            // 
            Description.Text = "Description";
            Description.Width = 260;
            // 
            // Status
            // 
            Status.Text = "Status";
            Status.Width = 0;
            // 
            // lstViewSelectedOrder
            // 
            lstViewSelectedOrder.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lstViewSelectedOrder.FullRowSelect = true;
            lstViewSelectedOrder.GridLines = true;
            lstViewSelectedOrder.Location = new Point(944, 465);
            lstViewSelectedOrder.Margin = new Padding(3, 4, 3, 4);
            lstViewSelectedOrder.Name = "lstViewSelectedOrder";
            lstViewSelectedOrder.Size = new Size(673, 344);
            lstViewSelectedOrder.TabIndex = 1;
            lstViewSelectedOrder.UseCompatibleStateImageBehavior = false;
            lstViewSelectedOrder.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Selected order ID";
            columnHeader1.Width = 320;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Order status";
            columnHeader2.Width = 340;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(255, 128, 0);
            textBox1.Font = new Font("Arial Narrow", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(944, 391);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(673, 65);
            textBox1.TabIndex = 2;
            textBox1.Text = "View order status";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(944, 313);
            label1.Name = "label1";
            label1.Size = new Size(2, 73);
            label1.TabIndex = 3;
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(1614, 313);
            label3.Name = "label3";
            label3.Size = new Size(2, 73);
            label3.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Location = new Point(944, 384);
            label4.Name = "label4";
            label4.Size = new Size(673, 3);
            label4.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Location = new Point(944, 313);
            label2.Name = "label2";
            label2.Size = new Size(673, 3);
            label2.TabIndex = 7;
            // 
            // btnInPrep
            // 
            btnInPrep.Location = new Point(969, 328);
            btnInPrep.Margin = new Padding(3, 4, 3, 4);
            btnInPrep.Name = "btnInPrep";
            btnInPrep.Size = new Size(144, 48);
            btnInPrep.TabIndex = 8;
            btnInPrep.Text = "In preparation";
            btnInPrep.UseVisualStyleBackColor = true;
            btnInPrep.Click += btnInPrep_Click;
            // 
            // btnPrepared
            // 
            btnPrepared.BackColor = Color.FromArgb(255, 128, 0);
            btnPrepared.Location = new Point(1216, 328);
            btnPrepared.Margin = new Padding(3, 4, 3, 4);
            btnPrepared.Name = "btnPrepared";
            btnPrepared.Size = new Size(144, 48);
            btnPrepared.TabIndex = 9;
            btnPrepared.Text = "Prepared";
            btnPrepared.UseVisualStyleBackColor = false;
            btnPrepared.Click += btnPrepared_Click;
            // 
            // btnServed
            // 
            btnServed.BackColor = Color.FromArgb(0, 192, 0);
            btnServed.Location = new Point(1448, 328);
            btnServed.Margin = new Padding(3, 4, 3, 4);
            btnServed.Name = "btnServed";
            btnServed.Size = new Size(144, 48);
            btnServed.TabIndex = 10;
            btnServed.Text = "Served";
            btnServed.UseVisualStyleBackColor = false;
            btnServed.Click += btnServed_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(255, 128, 0);
            textBox2.Font = new Font("Arial Narrow", 24F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(944, 252);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(673, 56);
            textBox2.TabIndex = 11;
            textBox2.Text = "Change order status";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTypeOfOrder
            // 
            txtTypeOfOrder.BackColor = Color.FromArgb(255, 128, 0);
            txtTypeOfOrder.Font = new Font("Arial Narrow", 36F, FontStyle.Bold, GraphicsUnit.Point);
            txtTypeOfOrder.Location = new Point(14, 95);
            txtTypeOfOrder.Margin = new Padding(3, 4, 3, 4);
            txtTypeOfOrder.Multiline = true;
            txtTypeOfOrder.Name = "txtTypeOfOrder";
            txtTypeOfOrder.Size = new Size(1602, 84);
            txtTypeOfOrder.TabIndex = 12;
            txtTypeOfOrder.Text = "{typeOfOrder}";
            txtTypeOfOrder.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBoxUser
            // 
            txtBoxUser.BackColor = Color.FromArgb(255, 128, 0);
            txtBoxUser.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtBoxUser.Location = new Point(1448, 44);
            txtBoxUser.Margin = new Padding(3, 4, 3, 4);
            txtBoxUser.Multiline = true;
            txtBoxUser.Name = "txtBoxUser";
            txtBoxUser.Size = new Size(167, 41);
            txtBoxUser.TabIndex = 13;
            txtBoxUser.Text = "{user}";
            txtBoxUser.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 5);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // KitchenBar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1631, 887);
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
            Margin = new Padding(2, 3, 2, 3);
            MaximizeBox = false;
            Name = "KitchenBar";
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
        private ColumnHeader OrderID;
        private ColumnHeader Comment;
        private ColumnHeader Quantity;
        private ColumnHeader Description;
        private ColumnHeader Status;
    }
}