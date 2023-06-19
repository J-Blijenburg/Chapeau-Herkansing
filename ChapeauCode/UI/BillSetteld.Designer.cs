namespace UI
{
    partial class BillSetteld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillSetteld));
            pictureBox1 = new PictureBox();
            LblSettled = new Label();
            LblVatNummer = new Label();
            LblOrderPriceNummer = new Label();
            LblVatTekst = new Label();
            LblOrderPriceTekst = new Label();
            LblAmontPaidNummer = new Label();
            LblAmountPaidTekst = new Label();
            LblTipAmountNummer = new Label();
            lblTipAmountTekst = new Label();
            BtnBackTableOverView = new CustomTools.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // LblSettled
            // 
            LblSettled.AutoSize = true;
            LblSettled.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            LblSettled.ForeColor = Color.FromArgb(138, 210, 176);
            LblSettled.Location = new Point(47, 199);
            LblSettled.Name = "LblSettled";
            LblSettled.Size = new Size(326, 90);
            LblSettled.TabIndex = 3;
            LblSettled.Text = "THE BILL HAS BEEN \r\n        SETTLED!\r\n";
            // 
            // LblVatNummer
            // 
            LblVatNummer.AutoSize = true;
            LblVatNummer.Location = new Point(349, 406);
            LblVatNummer.Name = "LblVatNummer";
            LblVatNummer.Size = new Size(21, 15);
            LblVatNummer.TabIndex = 12;
            LblVatNummer.Text = "##";
            // 
            // LblOrderPriceNummer
            // 
            LblOrderPriceNummer.AutoSize = true;
            LblOrderPriceNummer.Location = new Point(348, 327);
            LblOrderPriceNummer.Name = "LblOrderPriceNummer";
            LblOrderPriceNummer.Size = new Size(21, 15);
            LblOrderPriceNummer.TabIndex = 11;
            LblOrderPriceNummer.Text = "##";
            // 
            // LblVatTekst
            // 
            LblVatTekst.AutoSize = true;
            LblVatTekst.Location = new Point(31, 406);
            LblVatTekst.Name = "LblVatTekst";
            LblVatTekst.Size = new Size(29, 15);
            LblVatTekst.TabIndex = 10;
            LblVatTekst.Text = "VAT:";
            // 
            // LblOrderPriceTekst
            // 
            LblOrderPriceTekst.AutoSize = true;
            LblOrderPriceTekst.Location = new Point(30, 327);
            LblOrderPriceTekst.Name = "LblOrderPriceTekst";
            LblOrderPriceTekst.Size = new Size(78, 15);
            LblOrderPriceTekst.TabIndex = 9;
            LblOrderPriceTekst.Text = "ORDER PRCE:";
            // 
            // LblAmontPaidNummer
            // 
            LblAmontPaidNummer.AutoSize = true;
            LblAmontPaidNummer.Location = new Point(348, 354);
            LblAmontPaidNummer.Name = "LblAmontPaidNummer";
            LblAmontPaidNummer.Size = new Size(21, 15);
            LblAmontPaidNummer.TabIndex = 14;
            LblAmontPaidNummer.Text = "##";
            // 
            // LblAmountPaidTekst
            // 
            LblAmountPaidTekst.AutoSize = true;
            LblAmountPaidTekst.Location = new Point(30, 354);
            LblAmountPaidTekst.Name = "LblAmountPaidTekst";
            LblAmountPaidTekst.Size = new Size(89, 15);
            LblAmountPaidTekst.TabIndex = 13;
            LblAmountPaidTekst.Text = "AMOUNT PAID:";
            // 
            // LblTipAmountNummer
            // 
            LblTipAmountNummer.AutoSize = true;
            LblTipAmountNummer.Location = new Point(349, 380);
            LblTipAmountNummer.Name = "LblTipAmountNummer";
            LblTipAmountNummer.Size = new Size(21, 15);
            LblTipAmountNummer.TabIndex = 16;
            LblTipAmountNummer.Text = "##";
            // 
            // lblTipAmountTekst
            // 
            lblTipAmountTekst.AutoSize = true;
            lblTipAmountTekst.Location = new Point(31, 380);
            lblTipAmountTekst.Name = "lblTipAmountTekst";
            lblTipAmountTekst.Size = new Size(80, 15);
            lblTipAmountTekst.TabIndex = 15;
            lblTipAmountTekst.Text = "TIP AMOUNT:";
            // 
            // BtnBackTableOverView
            // 
            BtnBackTableOverView.BackColor = Color.FromArgb(255, 179, 71);
            BtnBackTableOverView.FlatAppearance.BorderSize = 0;
            BtnBackTableOverView.FlatStyle = FlatStyle.Flat;
            BtnBackTableOverView.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnBackTableOverView.Location = new Point(30, 497);
            BtnBackTableOverView.Name = "BtnBackTableOverView";
            BtnBackTableOverView.Size = new Size(339, 51);
            BtnBackTableOverView.TabIndex = 17;
            BtnBackTableOverView.Text = "BACK TO OVERVIEW";
            BtnBackTableOverView.UseVisualStyleBackColor = false;
            BtnBackTableOverView.Click += BtnBackTableOverView_Click;
            // 
            // BillSetteld
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 697);
            Controls.Add(BtnBackTableOverView);
            Controls.Add(LblTipAmountNummer);
            Controls.Add(lblTipAmountTekst);
            Controls.Add(LblAmontPaidNummer);
            Controls.Add(LblAmountPaidTekst);
            Controls.Add(LblVatNummer);
            Controls.Add(LblOrderPriceNummer);
            Controls.Add(LblVatTekst);
            Controls.Add(LblOrderPriceTekst);
            Controls.Add(LblSettled);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            Name = "BillSetteld";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BILL";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label LblSettled;
        private Label LblVatNummer;
        private Label LblOrderPriceNummer;
        private Label LblVatTekst;
        private Label LblOrderPriceTekst;
        private Label LblAmontPaidNummer;
        private Label LblAmountPaidTekst;
        private Label LblTipAmountNummer;
        private Label lblTipAmountTekst;
        private CustomTools.RoundedButton BtnBackTableOverView;
    }
}