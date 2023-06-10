namespace UI
{
    partial class Bill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill));
            LvBill = new ListView();
            pictureBox1 = new PictureBox();
            BtnDebit = new CustomTools.RoundedButton();
            BtnVisa = new CustomTools.RoundedButton();
            BtnCash = new CustomTools.RoundedButton();
            LblOrderPriceTekst = new Label();
            LblVat = new Label();
            LblOrderPriceNumber = new Label();
            LblVatNumber = new Label();
            BtnProceedToPayment = new CustomTools.RoundedButton();
            LblChoosePayment = new Label();
            LblBill = new Label();
            LblTotalTekst = new Label();
            LblTotalNumber = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LvBill
            // 
            LvBill.GridLines = true;
            LvBill.Location = new Point(25, 110);
            LvBill.Name = "LvBill";
            LvBill.Size = new Size(348, 252);
            LvBill.TabIndex = 0;
            LvBill.UseCompatibleStateImageBehavior = false;
            LvBill.View = View.Details;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, -2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // BtnDebit
            // 
            BtnDebit.BackColor = Color.LightGray;
            BtnDebit.FlatAppearance.BorderSize = 0;
            BtnDebit.Location = new Point(28, 458);
            BtnDebit.Name = "BtnDebit";
            BtnDebit.Size = new Size(91, 23);
            BtnDebit.TabIndex = 2;
            BtnDebit.Text = "Debit\r\n";
            BtnDebit.UseVisualStyleBackColor = false;
            BtnDebit.Click += Button_Click;
            // 
            // BtnVisa
            // 
            BtnVisa.BackColor = Color.LightGray;
            BtnVisa.FlatAppearance.BorderSize = 0;
            BtnVisa.Location = new Point(154, 458);
            BtnVisa.Name = "BtnVisa";
            BtnVisa.Size = new Size(91, 23);
            BtnVisa.TabIndex = 3;
            BtnVisa.Text = "Visa / Amex";
            BtnVisa.UseVisualStyleBackColor = false;
            BtnVisa.Click += Button_Click;
            // 
            // BtnCash
            // 
            BtnCash.BackColor = Color.LightGray;
            BtnCash.FlatAppearance.BorderSize = 0;
            BtnCash.Location = new Point(276, 458);
            BtnCash.Name = "BtnCash";
            BtnCash.Size = new Size(91, 23);
            BtnCash.TabIndex = 4;
            BtnCash.Text = "Cash";
            BtnCash.UseVisualStyleBackColor = false;
            BtnCash.Click += Button_Click;
            // 
            // LblOrderPriceTekst
            // 
            LblOrderPriceTekst.AutoSize = true;
            LblOrderPriceTekst.Location = new Point(28, 519);
            LblOrderPriceTekst.Name = "LblOrderPriceTekst";
            LblOrderPriceTekst.Size = new Size(78, 15);
            LblOrderPriceTekst.TabIndex = 5;
            LblOrderPriceTekst.Text = "ORDER PRCE:";
            // 
            // LblVat
            // 
            LblVat.AutoSize = true;
            LblVat.Location = new Point(28, 547);
            LblVat.Name = "LblVat";
            LblVat.Size = new Size(29, 15);
            LblVat.TabIndex = 6;
            LblVat.Text = "VAT:";
            // 
            // LblOrderPriceNumber
            // 
            LblOrderPriceNumber.AutoSize = true;
            LblOrderPriceNumber.Location = new Point(346, 519);
            LblOrderPriceNumber.Name = "LblOrderPriceNumber";
            LblOrderPriceNumber.Size = new Size(21, 15);
            LblOrderPriceNumber.TabIndex = 7;
            LblOrderPriceNumber.Text = "##";
            // 
            // LblVatNumber
            // 
            LblVatNumber.AutoSize = true;
            LblVatNumber.Location = new Point(346, 547);
            LblVatNumber.Name = "LblVatNumber";
            LblVatNumber.Size = new Size(21, 15);
            LblVatNumber.TabIndex = 8;
            LblVatNumber.Text = "##";
            // 
            // BtnProceedToPayment
            // 
            BtnProceedToPayment.BackColor = Color.FromArgb(138, 210, 176);
            BtnProceedToPayment.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnProceedToPayment.Location = new Point(28, 612);
            BtnProceedToPayment.Name = "BtnProceedToPayment";
            BtnProceedToPayment.Size = new Size(339, 51);
            BtnProceedToPayment.TabIndex = 9;
            BtnProceedToPayment.Text = "PROCEED TO PAYEMENT";
            BtnProceedToPayment.UseVisualStyleBackColor = false;
            BtnProceedToPayment.Click += BtnProceedToPayment_Click;
            // 
            // LblChoosePayment
            // 
            LblChoosePayment.AutoSize = true;
            LblChoosePayment.Location = new Point(25, 424);
            LblChoosePayment.Name = "LblChoosePayment";
            LblChoosePayment.Size = new Size(141, 15);
            LblChoosePayment.TabIndex = 10;
            LblChoosePayment.Text = "CHOOSE PAYMENT TYPE:";
            // 
            // LblBill
            // 
            LblBill.AutoSize = true;
            LblBill.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LblBill.Location = new Point(18, 77);
            LblBill.Name = "LblBill";
            LblBill.Size = new Size(56, 30);
            LblBill.TabIndex = 12;
            LblBill.Text = "BILL";
            // 
            // LblTotalTekst
            // 
            LblTotalTekst.AutoSize = true;
            LblTotalTekst.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblTotalTekst.Location = new Point(25, 382);
            LblTotalTekst.Name = "LblTotalTekst";
            LblTotalTekst.Size = new Size(60, 21);
            LblTotalTekst.TabIndex = 13;
            LblTotalTekst.Text = "TOTAL:";
            // 
            // LblTotalNumber
            // 
            LblTotalNumber.AutoSize = true;
            LblTotalNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LblTotalNumber.Location = new Point(345, 382);
            LblTotalNumber.Name = "LblTotalNumber";
            LblTotalNumber.Size = new Size(28, 21);
            LblTotalNumber.TabIndex = 14;
            LblTotalNumber.Text = "##";
            // 
            // Bill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(398, 697);
            Controls.Add(LblTotalNumber);
            Controls.Add(LblTotalTekst);
            Controls.Add(LblBill);
            Controls.Add(LblChoosePayment);
            Controls.Add(BtnProceedToPayment);
            Controls.Add(LblVatNumber);
            Controls.Add(LblOrderPriceNumber);
            Controls.Add(LblVat);
            Controls.Add(LblOrderPriceTekst);
            Controls.Add(BtnCash);
            Controls.Add(BtnVisa);
            Controls.Add(BtnDebit);
            Controls.Add(pictureBox1);
            Controls.Add(LvBill);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Bill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bill";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView LvBill;
        private PictureBox pictureBox1;
        private CustomTools.RoundedButton BtnDebit;
        private CustomTools.RoundedButton BtnVisa;
        private CustomTools.RoundedButton BtnCash;
        private Label LblOrderPriceTekst;
        private Label LblVat;
        private Label LblOrderPriceNumber;
        private Label LblVatNumber;
        private CustomTools.RoundedButton BtnProceedToPayment;
        private Label LblChoosePayment;
        private Label LblBill;
        private Label LblTotalTekst;
        private Label LblTotalNumber;
    }
}