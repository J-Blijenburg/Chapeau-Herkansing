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
            this.lstViewOrders = new System.Windows.Forms.ListView();
            this.lstViewSelectedOrder = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInPrep = new System.Windows.Forms.Button();
            this.btnPrepared = new System.Windows.Forms.Button();
            this.btnServed = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtTypeOfOrder = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstViewOrders
            // 
            this.lstViewOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lstViewOrders.GridLines = true;
            this.lstViewOrders.Location = new System.Drawing.Point(12, 189);
            this.lstViewOrders.Name = "lstViewOrders";
            this.lstViewOrders.Size = new System.Drawing.Size(808, 419);
            this.lstViewOrders.TabIndex = 0;
            this.lstViewOrders.UseCompatibleStateImageBehavior = false;
            this.lstViewOrders.View = System.Windows.Forms.View.Details;
            // 
            // lstViewSelectedOrder
            // 
            this.lstViewSelectedOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstViewSelectedOrder.FullRowSelect = true;
            this.lstViewSelectedOrder.GridLines = true;
            this.lstViewSelectedOrder.Location = new System.Drawing.Point(826, 349);
            this.lstViewSelectedOrder.Name = "lstViewSelectedOrder";
            this.lstViewSelectedOrder.Size = new System.Drawing.Size(589, 259);
            this.lstViewSelectedOrder.TabIndex = 1;
            this.lstViewSelectedOrder.UseCompatibleStateImageBehavior = false;
            this.lstViewSelectedOrder.View = System.Windows.Forms.View.Details;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(826, 293);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(589, 50);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "View order status";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(826, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 55);
            this.label1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(1412, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 55);
            this.label3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(826, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(589, 2);
            this.label4.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(826, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(589, 2);
            this.label2.TabIndex = 7;
            // 
            // btnInPrep
            // 
            this.btnInPrep.Location = new System.Drawing.Point(848, 246);
            this.btnInPrep.Name = "btnInPrep";
            this.btnInPrep.Size = new System.Drawing.Size(126, 36);
            this.btnInPrep.TabIndex = 8;
            this.btnInPrep.Text = "In preparation";
            this.btnInPrep.UseVisualStyleBackColor = true;
            // 
            // btnPrepared
            // 
            this.btnPrepared.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPrepared.Location = new System.Drawing.Point(1064, 246);
            this.btnPrepared.Name = "btnPrepared";
            this.btnPrepared.Size = new System.Drawing.Size(126, 36);
            this.btnPrepared.TabIndex = 9;
            this.btnPrepared.Text = "Prepared";
            this.btnPrepared.UseVisualStyleBackColor = false;
            // 
            // btnServed
            // 
            this.btnServed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnServed.Location = new System.Drawing.Point(1267, 246);
            this.btnServed.Name = "btnServed";
            this.btnServed.Size = new System.Drawing.Size(126, 36);
            this.btnServed.TabIndex = 10;
            this.btnServed.Text = "Served";
            this.btnServed.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox2.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(826, 189);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(589, 43);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "Change order status";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTypeOfOrder
            // 
            this.txtTypeOfOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtTypeOfOrder.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTypeOfOrder.Location = new System.Drawing.Point(12, 71);
            this.txtTypeOfOrder.Multiline = true;
            this.txtTypeOfOrder.Name = "txtTypeOfOrder";
            this.txtTypeOfOrder.Size = new System.Drawing.Size(1402, 64);
            this.txtTypeOfOrder.TabIndex = 12;
            this.txtTypeOfOrder.Text = "{typeOfOrder}";
            this.txtTypeOfOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(1322, 33);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(92, 32);
            this.textBox3.TabIndex = 13;
            this.textBox3.Text = "{user}";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Selected order ID";
            this.columnHeader1.Width = 320;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Order status";
            this.columnHeader2.Width = 340;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Order ID";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Order number";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Count";
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Description";
            this.columnHeader6.Width = 200;
            // 
            // KitchenBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1427, 665);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtTypeOfOrder);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnServed);
            this.Controls.Add(this.btnPrepared);
            this.Controls.Add(this.btnInPrep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lstViewSelectedOrder);
            this.Controls.Add(this.lstViewOrders);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KitchenBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitchenBar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private TextBox textBox3;
        private PictureBox pictureBox1;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}