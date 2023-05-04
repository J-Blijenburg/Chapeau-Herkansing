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
            BtnRemove = new Button();
            BtnAddComment = new Button();
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
            LblEmployee.Location = new Point(433, 23);
            LblEmployee.Margin = new Padding(4, 0, 4, 0);
            LblEmployee.Name = "LblEmployee";
            LblEmployee.Size = new Size(123, 67);
            LblEmployee.TabIndex = 11;
            LblEmployee.Text = "Employee";
            LblEmployee.TextAlign = ContentAlignment.MiddleCenter;
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
            // BtnDrinks
            // 
            BtnDrinks.BackColor = Color.FromArgb(138, 210, 176);
            BtnDrinks.FlatAppearance.BorderSize = 0;
            BtnDrinks.FlatStyle = FlatStyle.Flat;
            BtnDrinks.Location = new Point(429, 138);
            BtnDrinks.Name = "BtnDrinks";
            BtnDrinks.Size = new Size(129, 83);
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
            BtnDinner.Location = new Point(226, 138);
            BtnDinner.Name = "BtnDinner";
            BtnDinner.Size = new Size(129, 83);
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
            BtnLunch.Location = new Point(23, 138);
            BtnLunch.Name = "BtnLunch";
            BtnLunch.Size = new Size(129, 83);
            BtnLunch.TabIndex = 7;
            BtnLunch.Text = "Lunch";
            BtnLunch.UseVisualStyleBackColor = false;
            BtnLunch.Click += BtnLunch_Click;
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
            // BtnPay
            // 
            BtnPay.BackColor = Color.FromArgb(255, 179, 71);
            BtnPay.FlatAppearance.BorderColor = Color.Red;
            BtnPay.FlatAppearance.BorderSize = 20;
            BtnPay.Font = new Font("Poppins", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BtnPay.Location = new Point(350, 1060);
            BtnPay.Name = "BtnPay";
            BtnPay.Size = new Size(207, 83);
            BtnPay.TabIndex = 13;
            BtnPay.Text = "ADD";
            BtnPay.UseVisualStyleBackColor = false;
            BtnPay.Click += BtnPay_Click;
            // 
            // ListViewOrderdItems
            // 
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
            PnlDinner.Controls.Add(LblDinnerStarter);
            PnlDinner.Controls.Add(ListDinnerStarter);
            PnlDinner.Controls.Add(LblDinnerEntre);
            PnlDinner.Controls.Add(ListDinnerEntre);
            PnlDinner.Controls.Add(LblDinnerMains);
            PnlDinner.Controls.Add(ListDinnerMains);
            PnlDinner.Controls.Add(LblDinnerDesserts);
            PnlDinner.Controls.Add(ListDinnerDesserts);
            PnlDinner.Location = new Point(23, 230);
            PnlDinner.Margin = new Padding(4, 5, 4, 5);
            PnlDinner.Name = "PnlDinner";
            PnlDinner.Size = new Size(533, 458);
            PnlDinner.TabIndex = 16;
            // 
            // LblDinnerStarter
            // 
            LblDinnerStarter.AutoSize = true;
            LblDinnerStarter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblDinnerStarter.Location = new Point(226, 13);
            LblDinnerStarter.Margin = new Padding(4, 0, 4, 0);
            LblDinnerStarter.Name = "LblDinnerStarter";
            LblDinnerStarter.Size = new Size(79, 25);
            LblDinnerStarter.TabIndex = 0;
            LblDinnerStarter.Text = "Starters";
            // 
            // ListDinnerStarter
            // 
            ListDinnerStarter.FullRowSelect = true;
            ListDinnerStarter.Location = new Point(9, 47);
            ListDinnerStarter.Margin = new Padding(4, 5, 4, 5);
            ListDinnerStarter.Name = "ListDinnerStarter";
            ListDinnerStarter.Size = new Size(487, 256);
            ListDinnerStarter.TabIndex = 1;
            ListDinnerStarter.UseCompatibleStateImageBehavior = false;
            ListDinnerStarter.View = View.Details;
            ListDinnerStarter.Click += ListViewRowClick;
            // 
            // LblDinnerEntre
            // 
            LblDinnerEntre.AutoSize = true;
            LblDinnerEntre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblDinnerEntre.Location = new Point(221, 322);
            LblDinnerEntre.Margin = new Padding(4, 0, 4, 0);
            LblDinnerEntre.Name = "LblDinnerEntre";
            LblDinnerEntre.Size = new Size(65, 25);
            LblDinnerEntre.TabIndex = 2;
            LblDinnerEntre.Text = "Entres";
            // 
            // ListDinnerEntre
            // 
            ListDinnerEntre.FullRowSelect = true;
            ListDinnerEntre.Location = new Point(13, 357);
            ListDinnerEntre.Margin = new Padding(4, 5, 4, 5);
            ListDinnerEntre.Name = "ListDinnerEntre";
            ListDinnerEntre.Size = new Size(483, 256);
            ListDinnerEntre.TabIndex = 3;
            ListDinnerEntre.UseCompatibleStateImageBehavior = false;
            ListDinnerEntre.View = View.Details;
            ListDinnerEntre.Click += ListViewRowClick;
            // 
            // LblDinnerMains
            // 
            LblDinnerMains.AutoSize = true;
            LblDinnerMains.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblDinnerMains.Location = new Point(221, 635);
            LblDinnerMains.Margin = new Padding(4, 0, 4, 0);
            LblDinnerMains.Name = "LblDinnerMains";
            LblDinnerMains.Size = new Size(63, 25);
            LblDinnerMains.TabIndex = 4;
            LblDinnerMains.Text = "Mains";
            // 
            // ListDinnerMains
            // 
            ListDinnerMains.FullRowSelect = true;
            ListDinnerMains.Location = new Point(13, 672);
            ListDinnerMains.Margin = new Padding(4, 5, 4, 5);
            ListDinnerMains.Name = "ListDinnerMains";
            ListDinnerMains.Size = new Size(483, 256);
            ListDinnerMains.TabIndex = 5;
            ListDinnerMains.UseCompatibleStateImageBehavior = false;
            ListDinnerMains.View = View.Details;
            ListDinnerMains.Click += ListViewRowClick;
            // 
            // LblDinnerDesserts
            // 
            LblDinnerDesserts.AutoSize = true;
            LblDinnerDesserts.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblDinnerDesserts.Location = new Point(221, 950);
            LblDinnerDesserts.Margin = new Padding(4, 0, 4, 0);
            LblDinnerDesserts.Name = "LblDinnerDesserts";
            LblDinnerDesserts.Size = new Size(84, 25);
            LblDinnerDesserts.TabIndex = 18;
            LblDinnerDesserts.Text = "Desserts";
            // 
            // ListDinnerDesserts
            // 
            ListDinnerDesserts.FullRowSelect = true;
            ListDinnerDesserts.Location = new Point(13, 987);
            ListDinnerDesserts.Margin = new Padding(4, 5, 4, 5);
            ListDinnerDesserts.Name = "ListDinnerDesserts";
            ListDinnerDesserts.Size = new Size(483, 256);
            ListDinnerDesserts.TabIndex = 19;
            ListDinnerDesserts.UseCompatibleStateImageBehavior = false;
            ListDinnerDesserts.View = View.Details;
            ListDinnerDesserts.Click += ListViewRowClick;
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
            PnlLunch.Location = new Point(23, 230);
            PnlLunch.Margin = new Padding(4, 5, 4, 5);
            PnlLunch.Name = "PnlLunch";
            PnlLunch.Size = new Size(533, 458);
            PnlLunch.TabIndex = 17;
            // 
            // LblLunchStarter
            // 
            LblLunchStarter.AutoSize = true;
            LblLunchStarter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblLunchStarter.Location = new Point(226, 13);
            LblLunchStarter.Margin = new Padding(4, 0, 4, 0);
            LblLunchStarter.Name = "LblLunchStarter";
            LblLunchStarter.Size = new Size(79, 25);
            LblLunchStarter.TabIndex = 0;
            LblLunchStarter.Text = "Starters";
            // 
            // ListLunchStarter
            // 
            ListLunchStarter.FullRowSelect = true;
            ListLunchStarter.Location = new Point(9, 47);
            ListLunchStarter.Margin = new Padding(4, 5, 4, 5);
            ListLunchStarter.Name = "ListLunchStarter";
            ListLunchStarter.Size = new Size(487, 256);
            ListLunchStarter.TabIndex = 1;
            ListLunchStarter.UseCompatibleStateImageBehavior = false;
            ListLunchStarter.View = View.Details;
            ListLunchStarter.Click += ListViewRowClick;
            // 
            // LblLunchMains
            // 
            LblLunchMains.AutoSize = true;
            LblLunchMains.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblLunchMains.Location = new Point(221, 322);
            LblLunchMains.Margin = new Padding(4, 0, 4, 0);
            LblLunchMains.Name = "LblLunchMains";
            LblLunchMains.Size = new Size(63, 25);
            LblLunchMains.TabIndex = 2;
            LblLunchMains.Text = "Mains";
            // 
            // ListLunchMains
            // 
            ListLunchMains.FullRowSelect = true;
            ListLunchMains.Location = new Point(13, 357);
            ListLunchMains.Margin = new Padding(4, 5, 4, 5);
            ListLunchMains.Name = "ListLunchMains";
            ListLunchMains.Size = new Size(483, 256);
            ListLunchMains.TabIndex = 3;
            ListLunchMains.UseCompatibleStateImageBehavior = false;
            ListLunchMains.View = View.Details;
            ListLunchMains.Click += ListViewRowClick;
            // 
            // LblLunchDesserts
            // 
            LblLunchDesserts.AutoSize = true;
            LblLunchDesserts.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblLunchDesserts.Location = new Point(221, 635);
            LblLunchDesserts.Margin = new Padding(4, 0, 4, 0);
            LblLunchDesserts.Name = "LblLunchDesserts";
            LblLunchDesserts.Size = new Size(84, 25);
            LblLunchDesserts.TabIndex = 4;
            LblLunchDesserts.Text = "Desserts";
            // 
            // ListLunchDesserts
            // 
            ListLunchDesserts.FullRowSelect = true;
            ListLunchDesserts.Location = new Point(13, 672);
            ListLunchDesserts.Margin = new Padding(4, 5, 4, 5);
            ListLunchDesserts.Name = "ListLunchDesserts";
            ListLunchDesserts.Size = new Size(483, 256);
            ListLunchDesserts.TabIndex = 5;
            ListLunchDesserts.UseCompatibleStateImageBehavior = false;
            ListLunchDesserts.View = View.Details;
            ListLunchDesserts.Click += ListViewRowClick;
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
            PnlDrinks.Location = new Point(23, 230);
            PnlDrinks.Margin = new Padding(4, 5, 4, 5);
            PnlDrinks.Name = "PnlDrinks";
            PnlDrinks.Size = new Size(533, 458);
            PnlDrinks.TabIndex = 20;
            // 
            // LblDrinksSoft
            // 
            LblDrinksSoft.AutoSize = true;
            LblDrinksSoft.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblDrinksSoft.Location = new Point(226, 13);
            LblDrinksSoft.Margin = new Padding(4, 0, 4, 0);
            LblDrinksSoft.Name = "LblDrinksSoft";
            LblDrinksSoft.Size = new Size(106, 25);
            LblDrinksSoft.TabIndex = 0;
            LblDrinksSoft.Text = "Soft Drinks";
            // 
            // ListDrinksSoft
            // 
            ListDrinksSoft.FullRowSelect = true;
            ListDrinksSoft.Location = new Point(9, 47);
            ListDrinksSoft.Margin = new Padding(4, 5, 4, 5);
            ListDrinksSoft.Name = "ListDrinksSoft";
            ListDrinksSoft.Size = new Size(487, 256);
            ListDrinksSoft.TabIndex = 1;
            ListDrinksSoft.UseCompatibleStateImageBehavior = false;
            ListDrinksSoft.View = View.Details;
            ListDrinksSoft.Click += ListViewRowClick;
            // 
            // LblDrinksBeers
            // 
            LblDrinksBeers.AutoSize = true;
            LblDrinksBeers.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblDrinksBeers.Location = new Point(221, 322);
            LblDrinksBeers.Margin = new Padding(4, 0, 4, 0);
            LblDrinksBeers.Name = "LblDrinksBeers";
            LblDrinksBeers.Size = new Size(59, 25);
            LblDrinksBeers.TabIndex = 2;
            LblDrinksBeers.Text = "Beers";
            // 
            // ListDrinksBeers
            // 
            ListDrinksBeers.FullRowSelect = true;
            ListDrinksBeers.Location = new Point(13, 357);
            ListDrinksBeers.Margin = new Padding(4, 5, 4, 5);
            ListDrinksBeers.Name = "ListDrinksBeers";
            ListDrinksBeers.Size = new Size(483, 256);
            ListDrinksBeers.TabIndex = 3;
            ListDrinksBeers.UseCompatibleStateImageBehavior = false;
            ListDrinksBeers.View = View.Details;
            ListDrinksBeers.Click += ListViewRowClick;
            // 
            // LblDrinksWines
            // 
            LblDrinksWines.AutoSize = true;
            LblDrinksWines.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblDrinksWines.Location = new Point(221, 635);
            LblDrinksWines.Margin = new Padding(4, 0, 4, 0);
            LblDrinksWines.Name = "LblDrinksWines";
            LblDrinksWines.Size = new Size(64, 25);
            LblDrinksWines.TabIndex = 4;
            LblDrinksWines.Text = "Wines";
            // 
            // ListDrinksWines
            // 
            ListDrinksWines.FullRowSelect = true;
            ListDrinksWines.Location = new Point(13, 672);
            ListDrinksWines.Margin = new Padding(4, 5, 4, 5);
            ListDrinksWines.Name = "ListDrinksWines";
            ListDrinksWines.Size = new Size(483, 256);
            ListDrinksWines.TabIndex = 5;
            ListDrinksWines.UseCompatibleStateImageBehavior = false;
            ListDrinksWines.View = View.Details;
            ListDrinksWines.Click += ListViewRowClick;
            // 
            // LblDrinksSpirits
            // 
            LblDrinksSpirits.AutoSize = true;
            LblDrinksSpirits.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblDrinksSpirits.Location = new Point(221, 950);
            LblDrinksSpirits.Margin = new Padding(4, 0, 4, 0);
            LblDrinksSpirits.Name = "LblDrinksSpirits";
            LblDrinksSpirits.Size = new Size(65, 25);
            LblDrinksSpirits.TabIndex = 18;
            LblDrinksSpirits.Text = "Spirits";
            // 
            // ListDrinksSpirits
            // 
            ListDrinksSpirits.FullRowSelect = true;
            ListDrinksSpirits.Location = new Point(13, 987);
            ListDrinksSpirits.Margin = new Padding(4, 5, 4, 5);
            ListDrinksSpirits.Name = "ListDrinksSpirits";
            ListDrinksSpirits.Size = new Size(483, 256);
            ListDrinksSpirits.TabIndex = 19;
            ListDrinksSpirits.UseCompatibleStateImageBehavior = false;
            ListDrinksSpirits.View = View.Details;
            ListDrinksSpirits.Click += ListViewRowClick;
            // 
            // LblDrinksHot
            // 
            LblDrinksHot.AutoSize = true;
            LblDrinksHot.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblDrinksHot.Location = new Point(221, 1268);
            LblDrinksHot.Margin = new Padding(4, 0, 4, 0);
            LblDrinksHot.Name = "LblDrinksHot";
            LblDrinksHot.Size = new Size(103, 25);
            LblDrinksHot.TabIndex = 20;
            LblDrinksHot.Text = "Hot Drinks";
            // 
            // ListDrinksHot
            // 
            ListDrinksHot.FullRowSelect = true;
            ListDrinksHot.Location = new Point(13, 1305);
            ListDrinksHot.Margin = new Padding(4, 5, 4, 5);
            ListDrinksHot.Name = "ListDrinksHot";
            ListDrinksHot.Size = new Size(483, 256);
            ListDrinksHot.TabIndex = 21;
            ListDrinksHot.UseCompatibleStateImageBehavior = false;
            ListDrinksHot.View = View.Details;
            ListDrinksHot.Click += ListViewRowClick;
            // 
            // BtnRemove
            // 
            BtnRemove.BackColor = Color.FromArgb(196, 196, 196);
            BtnRemove.Location = new Point(183, 1072);
            BtnRemove.Name = "BtnRemove";
            BtnRemove.Size = new Size(149, 58);
            BtnRemove.TabIndex = 22;
            BtnRemove.Text = "Remove";
            BtnRemove.UseVisualStyleBackColor = false;
            // 
            // BtnAddComment
            // 
            BtnAddComment.BackColor = Color.FromArgb(196, 196, 196);
            BtnAddComment.Location = new Point(23, 1072);
            BtnAddComment.Name = "BtnAddComment";
            BtnAddComment.Size = new Size(149, 58);
            BtnAddComment.TabIndex = 23;
            BtnAddComment.Text = "Comment";
            BtnAddComment.UseVisualStyleBackColor = false;
            // 
            // OrderOverView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(569, 1162);
            Controls.Add(BtnAddComment);
            Controls.Add(BtnRemove);
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
        private Button BtnRemove;
        private Button BtnAddComment;
    }
}