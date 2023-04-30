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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button4 = new Button();
            listView1 = new ListView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(138, 210, 176);
            button1.Location = new Point(16, 83);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(90, 50);
            button1.TabIndex = 1;
            button1.Text = "Lunch";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(138, 210, 176);
            button2.Location = new Point(158, 83);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(90, 50);
            button2.TabIndex = 2;
            button2.Text = "Dinner";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(138, 210, 176);
            button3.Location = new Point(300, 83);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(90, 50);
            button3.TabIndex = 3;
            button3.Text = "Drinks";
            button3.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(196, 196, 196);
            label1.Location = new Point(139, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(153, 33);
            label1.TabIndex = 4;
            label1.Text = "Table #10";
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.BackColor = Color.FromArgb(255, 179, 71);
            label2.Font = new Font("Poppins", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(304, 16);
            label2.Name = "label2";
            label2.Size = new Size(86, 40);
            label2.TabIndex = 5;
            label2.Text = "Employee";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listView1);
            groupBox1.Location = new Point(16, 164);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(374, 369);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(193, 558);
            label3.Name = "label3";
            label3.Size = new Size(58, 28);
            label3.TabIndex = 7;
            label3.Text = "Total:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(202, 595);
            label4.Name = "label4";
            label4.Size = new Size(50, 28);
            label4.TabIndex = 8;
            label4.Text = "VAT:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(330, 595);
            label5.Name = "label5";
            label5.Size = new Size(60, 28);
            label5.TabIndex = 10;
            label5.Text = "___,-";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(330, 558);
            label6.Name = "label6";
            label6.Size = new Size(60, 28);
            label6.TabIndex = 9;
            label6.Text = "___,-";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 179, 71);
            button4.FlatAppearance.BorderColor = Color.Red;
            button4.FlatAppearance.BorderSize = 20;
            button4.Font = new Font("Poppins", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(245, 636);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(145, 50);
            button4.TabIndex = 11;
            button4.Text = "Pay";
            button4.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            listView1.Location = new Point(6, 22);
            listView1.Name = "listView1";
            listView1.Size = new Size(362, 334);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // TableOverview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(398, 697);
            Controls.Add(button4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
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
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button4;
        private ListView listView1;
    }
}