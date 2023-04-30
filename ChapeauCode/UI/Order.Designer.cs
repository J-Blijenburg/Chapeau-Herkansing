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
            BtnDinner = new Button();
            BtnLunch = new Button();
            pictureBox1 = new PictureBox();
            BtnPay = new Button();
            ListViewOrderdItems = new ListView();
            groupBox1 = new GroupBox();
            label1 = new Label();
            PnlDinner = new Panel();
            LblDinnerStarter = new Label();
            ListDinnerStarter = new ListView();
            LblDinnerEntre = new Label();
            ListDinnerEntre = new ListView();
            LblDinnerMains = new Label();
            ListDinnerMains = new ListView();
            LblDinnerDesserts = new Label();
            ListDinnerDesserts = new ListView();
            PnlLunch = new Panel();
            LblLunchStarter = new Label();
            ListLunchStarter = new ListView();
            LblLunchMains = new Label();
            ListLunchMains = new ListView();
            LblLunchDesserts = new Label();
            ListLunchDesserts = new ListView();
            PnlDrinks = new Panel();
            LblDrinksSoft = new Label();
            ListDrinksSoft = new ListView();
            LblDrinksBeers = new Label();
            ListDrinksBeers = new ListView();
            LblDrinksWines = new Label();
            ListDrinksWines = new ListView();
            LblDrinksSpirits = new Label();
            ListDrinksSpirits = new ListView();
            LblDrinksHot = new Label();
            ListDrinksHot = new ListView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            PnlDinner.SuspendLayout();
            PnlLunch.SuspendLayout();
            PnlDrinks.SuspendLayout();
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
            BtnDrinks.FlatAppearance.BorderSize = 0;
            BtnDrinks.FlatStyle = FlatStyle.Flat;
            BtnDrinks.Location = new Point(300, 83);
            BtnDrinks.Margin = new Padding(2);
            BtnDrinks.Name = "BtnDrinks";
            BtnDrinks.Size = new Size(90, 50);
            BtnDrinks.TabIndex = 9;
            BtnDrinks.Text = "Drinks";
            BtnDrinks.UseVisualStyleBackColor = false;
            BtnDrinks.Click += BtnDrinks_Click;
            // 
            // BtnDinner
            // 
            BtnDinner.BackColor = Color.FromArgb(138, 210, 176);
            BtnDinner.FlatAppearance.BorderSize = 0;
            BtnDinner.FlatStyle = FlatStyle.Flat;
            BtnDinner.Location = new Point(158, 83);
            BtnDinner.Margin = new Padding(2);
            BtnDinner.Name = "BtnDinner";
            BtnDinner.Size = new Size(90, 50);
            BtnDinner.TabIndex = 8;
            BtnDinner.Text = "Dinner";
            BtnDinner.UseVisualStyleBackColor = false;
            BtnDinner.Click += BtnDinner_Click;
            // 
            // BtnLunch
            // 
            BtnLunch.BackColor = Color.FromArgb(138, 210, 176);
            BtnLunch.FlatAppearance.BorderSize = 0;
            BtnLunch.FlatStyle = FlatStyle.Flat;
            BtnLunch.Location = new Point(16, 83);
            BtnLunch.Margin = new Padding(2);
            BtnLunch.Name = "BtnLunch";
            BtnLunch.Size = new Size(90, 50);
            BtnLunch.TabIndex = 7;
            BtnLunch.Text = "Lunch";
            BtnLunch.UseVisualStyleBackColor = false;
            BtnLunch.Click += BtnLunch_Click;
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
            BtnPay.Click += BtnPay_Click;
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
            // PnlDinner
            // 
            PnlDinner.AutoScroll = true;
            PnlDinner.Controls.Add(LblDinnerStarter);
            PnlDinner.Controls.Add(ListDinnerStarter);
            PnlDinner.Controls.Add(LblDinnerEntre);
            PnlDinner.Controls.Add(ListDinnerEntre);
            PnlDinner.Controls.Add(LblDinnerMains);
            PnlDinner.Controls.Add(ListDinnerMains);
            PnlDinner.Controls.Add(LblDinnerDesserts);
            PnlDinner.Controls.Add(ListDinnerDesserts);
            PnlDinner.Location = new Point(16, 138);
            PnlDinner.Name = "PnlDinner";
            PnlDinner.Size = new Size(373, 275);
            PnlDinner.TabIndex = 16;
            // 
            // LblDinnerStarter
            // 
            LblDinnerStarter.AutoSize = true;
            LblDinnerStarter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblDinnerStarter.Location = new Point(158, 8);
            LblDinnerStarter.Name = "LblDinnerStarter";
            LblDinnerStarter.Size = new Size(52, 15);
            LblDinnerStarter.TabIndex = 0;
            LblDinnerStarter.Text = "Starters";
            // 
            // ListDinnerStarter
            // 
            ListDinnerStarter.Location = new Point(6, 28);
            ListDinnerStarter.Name = "ListDinnerStarter";
            ListDinnerStarter.Size = new Size(342, 155);
            ListDinnerStarter.TabIndex = 1;
            ListDinnerStarter.UseCompatibleStateImageBehavior = false;
            // 
            // LblDinnerEntre
            // 
            LblDinnerEntre.AutoSize = true;
            LblDinnerEntre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblDinnerEntre.Location = new Point(155, 193);
            LblDinnerEntre.Name = "LblDinnerEntre";
            LblDinnerEntre.Size = new Size(42, 15);
            LblDinnerEntre.TabIndex = 2;
            LblDinnerEntre.Text = "Entres";
            // 
            // ListDinnerEntre
            // 
            ListDinnerEntre.Location = new Point(9, 214);
            ListDinnerEntre.Name = "ListDinnerEntre";
            ListDinnerEntre.Size = new Size(339, 155);
            ListDinnerEntre.TabIndex = 3;
            ListDinnerEntre.UseCompatibleStateImageBehavior = false;
            // 
            // LblDinnerMains
            // 
            LblDinnerMains.AutoSize = true;
            LblDinnerMains.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblDinnerMains.Location = new Point(155, 381);
            LblDinnerMains.Name = "LblDinnerMains";
            LblDinnerMains.Size = new Size(39, 15);
            LblDinnerMains.TabIndex = 4;
            LblDinnerMains.Text = "Mains";
            // 
            // ListDinnerMains
            // 
            ListDinnerMains.Location = new Point(9, 403);
            ListDinnerMains.Name = "ListDinnerMains";
            ListDinnerMains.Size = new Size(339, 155);
            ListDinnerMains.TabIndex = 5;
            ListDinnerMains.UseCompatibleStateImageBehavior = false;
            // 
            // LblDinnerDesserts
            // 
            LblDinnerDesserts.AutoSize = true;
            LblDinnerDesserts.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblDinnerDesserts.Location = new Point(155, 570);
            LblDinnerDesserts.Name = "LblDinnerDesserts";
            LblDinnerDesserts.Size = new Size(55, 15);
            LblDinnerDesserts.TabIndex = 18;
            LblDinnerDesserts.Text = "Desserts";
            // 
            // ListDinnerDesserts
            // 
            ListDinnerDesserts.Location = new Point(9, 592);
            ListDinnerDesserts.Name = "ListDinnerDesserts";
            ListDinnerDesserts.Size = new Size(339, 155);
            ListDinnerDesserts.TabIndex = 19;
            ListDinnerDesserts.UseCompatibleStateImageBehavior = false;
            // 
            // PnlLunch
            // 
            PnlLunch.AutoScroll = true;
            PnlLunch.Controls.Add(LblLunchStarter);
            PnlLunch.Controls.Add(ListLunchStarter);
            PnlLunch.Controls.Add(LblLunchMains);
            PnlLunch.Controls.Add(ListLunchMains);
            PnlLunch.Controls.Add(LblLunchDesserts);
            PnlLunch.Controls.Add(ListLunchDesserts);
            PnlLunch.Location = new Point(16, 138);
            PnlLunch.Name = "PnlLunch";
            PnlLunch.Size = new Size(373, 275);
            PnlLunch.TabIndex = 17;
            // 
            // LblLunchStarter
            // 
            LblLunchStarter.AutoSize = true;
            LblLunchStarter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblLunchStarter.Location = new Point(158, 8);
            LblLunchStarter.Name = "LblLunchStarter";
            LblLunchStarter.Size = new Size(52, 15);
            LblLunchStarter.TabIndex = 0;
            LblLunchStarter.Text = "Starters";
            // 
            // ListLunchStarter
            // 
            ListLunchStarter.Location = new Point(6, 28);
            ListLunchStarter.Name = "ListLunchStarter";
            ListLunchStarter.Size = new Size(342, 155);
            ListLunchStarter.TabIndex = 1;
            ListLunchStarter.UseCompatibleStateImageBehavior = false;
            // 
            // LblLunchMains
            // 
            LblLunchMains.AutoSize = true;
            LblLunchMains.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblLunchMains.Location = new Point(155, 193);
            LblLunchMains.Name = "LblLunchMains";
            LblLunchMains.Size = new Size(39, 15);
            LblLunchMains.TabIndex = 2;
            LblLunchMains.Text = "Mains";
            // 
            // ListLunchMains
            // 
            ListLunchMains.Location = new Point(9, 214);
            ListLunchMains.Name = "ListLunchMains";
            ListLunchMains.Size = new Size(339, 155);
            ListLunchMains.TabIndex = 3;
            ListLunchMains.UseCompatibleStateImageBehavior = false;
            // 
            // LblLunchDesserts
            // 
            LblLunchDesserts.AutoSize = true;
            LblLunchDesserts.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblLunchDesserts.Location = new Point(155, 381);
            LblLunchDesserts.Name = "LblLunchDesserts";
            LblLunchDesserts.Size = new Size(55, 15);
            LblLunchDesserts.TabIndex = 4;
            LblLunchDesserts.Text = "Desserts";
            // 
            // ListLunchDesserts
            // 
            ListLunchDesserts.Location = new Point(9, 403);
            ListLunchDesserts.Name = "ListLunchDesserts";
            ListLunchDesserts.Size = new Size(339, 155);
            ListLunchDesserts.TabIndex = 5;
            ListLunchDesserts.UseCompatibleStateImageBehavior = false;
            // 
            // PnlDrinks
            // 
            PnlDrinks.AutoScroll = true;
            PnlDrinks.Controls.Add(LblDrinksSoft);
            PnlDrinks.Controls.Add(ListDrinksSoft);
            PnlDrinks.Controls.Add(LblDrinksBeers);
            PnlDrinks.Controls.Add(ListDrinksBeers);
            PnlDrinks.Controls.Add(LblDrinksWines);
            PnlDrinks.Controls.Add(ListDrinksWines);
            PnlDrinks.Controls.Add(LblDrinksSpirits);
            PnlDrinks.Controls.Add(ListDrinksSpirits);
            PnlDrinks.Controls.Add(LblDrinksHot);
            PnlDrinks.Controls.Add(ListDrinksHot);
            PnlDrinks.Location = new Point(16, 138);
            PnlDrinks.Name = "PnlDrinks";
            PnlDrinks.Size = new Size(373, 275);
            PnlDrinks.TabIndex = 20;
            // 
            // LblDrinksSoft
            // 
            LblDrinksSoft.AutoSize = true;
            LblDrinksSoft.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblDrinksSoft.Location = new Point(158, 8);
            LblDrinksSoft.Name = "LblDrinksSoft";
            LblDrinksSoft.Size = new Size(70, 15);
            LblDrinksSoft.TabIndex = 0;
            LblDrinksSoft.Text = "Soft Drinks";
            // 
            // ListDrinksSoft
            // 
            ListDrinksSoft.Location = new Point(6, 28);
            ListDrinksSoft.Name = "ListDrinksSoft";
            ListDrinksSoft.Size = new Size(342, 155);
            ListDrinksSoft.TabIndex = 1;
            ListDrinksSoft.UseCompatibleStateImageBehavior = false;
            // 
            // LblDrinksBeers
            // 
            LblDrinksBeers.AutoSize = true;
            LblDrinksBeers.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblDrinksBeers.Location = new Point(155, 193);
            LblDrinksBeers.Name = "LblDrinksBeers";
            LblDrinksBeers.Size = new Size(39, 15);
            LblDrinksBeers.TabIndex = 2;
            LblDrinksBeers.Text = "Beers";
            // 
            // ListDrinksBeers
            // 
            ListDrinksBeers.Location = new Point(9, 214);
            ListDrinksBeers.Name = "ListDrinksBeers";
            ListDrinksBeers.Size = new Size(339, 155);
            ListDrinksBeers.TabIndex = 3;
            ListDrinksBeers.UseCompatibleStateImageBehavior = false;
            // 
            // LblDrinksWines
            // 
            LblDrinksWines.AutoSize = true;
            LblDrinksWines.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblDrinksWines.Location = new Point(155, 381);
            LblDrinksWines.Name = "LblDrinksWines";
            LblDrinksWines.Size = new Size(41, 15);
            LblDrinksWines.TabIndex = 4;
            LblDrinksWines.Text = "Wines";
            // 
            // ListDrinksWines
            // 
            ListDrinksWines.Location = new Point(9, 403);
            ListDrinksWines.Name = "ListDrinksWines";
            ListDrinksWines.Size = new Size(339, 155);
            ListDrinksWines.TabIndex = 5;
            ListDrinksWines.UseCompatibleStateImageBehavior = false;
            // 
            // LblDrinksSpirits
            // 
            LblDrinksSpirits.AutoSize = true;
            LblDrinksSpirits.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblDrinksSpirits.Location = new Point(155, 570);
            LblDrinksSpirits.Name = "LblDrinksSpirits";
            LblDrinksSpirits.Size = new Size(42, 15);
            LblDrinksSpirits.TabIndex = 18;
            LblDrinksSpirits.Text = "Spirits";
            // 
            // ListDrinksSpirits
            // 
            ListDrinksSpirits.Location = new Point(9, 592);
            ListDrinksSpirits.Name = "ListDrinksSpirits";
            ListDrinksSpirits.Size = new Size(339, 155);
            ListDrinksSpirits.TabIndex = 19;
            ListDrinksSpirits.UseCompatibleStateImageBehavior = false;
            // 
            // LblDrinksHot
            // 
            LblDrinksHot.AutoSize = true;
            LblDrinksHot.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblDrinksHot.Location = new Point(155, 761);
            LblDrinksHot.Name = "LblDrinksHot";
            LblDrinksHot.Size = new Size(67, 15);
            LblDrinksHot.TabIndex = 20;
            LblDrinksHot.Text = "Hot Drinks";
            // 
            // ListDrinksHot
            // 
            ListDrinksHot.Location = new Point(9, 783);
            ListDrinksHot.Name = "ListDrinksHot";
            ListDrinksHot.Size = new Size(339, 155);
            ListDrinksHot.TabIndex = 21;
            ListDrinksHot.UseCompatibleStateImageBehavior = false;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(398, 697);
            Controls.Add(PnlLunch);
            Controls.Add(PnlDrinks);
            Controls.Add(PnlDinner);
            Controls.Add(BtnDinner);
            Controls.Add(groupBox1);
            Controls.Add(BtnPay);
            Controls.Add(LblEmployee);
            Controls.Add(LblTableNumber);
            Controls.Add(BtnDrinks);
            Controls.Add(BtnLunch);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Order";
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

        private Label LblEmployee;
        private Label LblTableNumber;
        private Button BtnDrinks;
        private Button BtnDinner;
        private Button BtnLunch;
        private PictureBox pictureBox1;
        private Button BtnPay;
        private ListView ListViewOrderdItems;
        private GroupBox groupBox1;
        private Label label1;
        private Panel PnlDinner;
        private Label LblDinnerStarter;
        private ListView ListDinnerStarter;
        private Label LblDinnerEntre;
        private ListView ListDinnerEntre;
        private Label LblDinnerMains;
        private ListView ListDinnerMains;
        private Label LblDinnerDesserts;
        private ListView ListDinnerDesserts;
        private Panel PnlLunch;
        private Label LblLunchStarter;
        private ListView ListLunchStarter;
        private Label LblLunchDesserts;
        private ListView ListLunchDesserts;
        private Label LblLunchMains;
        private ListView ListLunchMains;
        private Panel PnlDrinks;
        private Label LblDrinksSpirits;
        private ListView ListDrinksSpirits;
        private Label LblDrinksWines;
        private ListView ListDrinksWines;
        private Label LblDrinksSoft;
        private ListView ListDrinksSoft;
        private Label LblDrinksBeers;
        private ListView ListDrinksBeers;
        private Label LblDrinksHot;
        private ListView ListDrinksHot;
    }
}