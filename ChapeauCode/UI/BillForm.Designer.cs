namespace UI
{
    partial class BillForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillForm));
            LvBill = new ListView();
            pictureBox1 = new PictureBox();
            BtnDebit = new CustomTools.RoundedButton();
            BtnVisa = new CustomTools.RoundedButton();
            BtnCash = new CustomTools.RoundedButton();
            LblOrderPriceTekst = new Label();
            LblTotalVatTekst = new Label();
            LblOrderPriceNumber = new Label();
            LblTotalVatNumber = new Label();
            BtnProceedToPayment = new CustomTools.RoundedButton();
            LblChoosePayment = new Label();
            LblBill = new Label();
            LblTotalTekst = new Label();
            LblTotalNumber = new Label();
            LblHighVatNumber = new Label();
            LblHighVatTekst = new Label();
            LblLowVatNumber = new Label();
            LbllowVatTekst = new Label();
            backBtn = new Button();
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
            BtnDebit.FlatStyle = FlatStyle.Flat;
            BtnDebit.Location = new Point(28, 440);
            BtnDebit.Name = "BtnDebit";
            BtnDebit.Size = new Size(91, 39);
            BtnDebit.TabIndex = 2;
            BtnDebit.Text = "Debit\r\n";
            BtnDebit.UseVisualStyleBackColor = false;
            BtnDebit.Click += Button_Click;
            // 
            // BtnVisa
            // 
            BtnVisa.BackColor = Color.LightGray;
            BtnVisa.FlatAppearance.BorderSize = 0;
            BtnVisa.FlatStyle = FlatStyle.Flat;
            BtnVisa.Location = new Point(154, 440);
            BtnVisa.Name = "BtnVisa";
            BtnVisa.Size = new Size(91, 39);
            BtnVisa.TabIndex = 3;
            BtnVisa.Text = "Visa / Amex";
            BtnVisa.UseVisualStyleBackColor = false;
            BtnVisa.Click += Button_Click;
            // 
            // BtnCash
            // 
            BtnCash.BackColor = Color.LightGray;
            BtnCash.FlatAppearance.BorderSize = 0;
            BtnCash.FlatStyle = FlatStyle.Flat;
            BtnCash.Location = new Point(276, 440);
            BtnCash.Name = "BtnCash";
            BtnCash.Size = new Size(91, 39);
            BtnCash.TabIndex = 4;
            BtnCash.Text = "Cash";
            BtnCash.UseVisualStyleBackColor = false;
            BtnCash.Click += Button_Click;
            // 
            // LblOrderPriceTekst
            // 
            LblOrderPriceTekst.AutoSize = true;
            LblOrderPriceTekst.Location = new Point(28, 512);
            LblOrderPriceTekst.Name = "LblOrderPriceTekst";
            LblOrderPriceTekst.Size = new Size(78, 15);
            LblOrderPriceTekst.TabIndex = 5;
            LblOrderPriceTekst.Text = "ORDER PRCE:";
            // 
            // LblTotalVatTekst
            // 
            LblTotalVatTekst.AutoSize = true;
            LblTotalVatTekst.Location = new Point(28, 587);
            LblTotalVatTekst.Name = "LblTotalVatTekst";
            LblTotalVatTekst.Size = new Size(64, 15);
            LblTotalVatTekst.TabIndex = 6;
            LblTotalVatTekst.Text = "TOTAL VAT:";
            // 
            // LblOrderPriceNumber
            // 
            LblOrderPriceNumber.AutoSize = true;
            LblOrderPriceNumber.Location = new Point(313, 512);
            LblOrderPriceNumber.Name = "LblOrderPriceNumber";
            LblOrderPriceNumber.Size = new Size(21, 15);
            LblOrderPriceNumber.TabIndex = 7;
            LblOrderPriceNumber.Text = "##";
            // 
            // LblTotalVatNumber
            // 
            LblTotalVatNumber.AutoSize = true;
            LblTotalVatNumber.Location = new Point(313, 587);
            LblTotalVatNumber.Name = "LblTotalVatNumber";
            LblTotalVatNumber.Size = new Size(21, 15);
            LblTotalVatNumber.TabIndex = 8;
            LblTotalVatNumber.Text = "##";
            // 
            // BtnProceedToPayment
            // 
            BtnProceedToPayment.BackColor = Color.FromArgb(138, 210, 176);
            BtnProceedToPayment.FlatAppearance.BorderSize = 0;
            BtnProceedToPayment.FlatStyle = FlatStyle.Flat;
            BtnProceedToPayment.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnProceedToPayment.Location = new Point(28, 634);
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
            LblChoosePayment.Location = new Point(25, 418);
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
            LblTotalTekst.Location = new Point(25, 375);
            LblTotalTekst.Name = "LblTotalTekst";
            LblTotalTekst.Size = new Size(60, 21);
            LblTotalTekst.TabIndex = 13;
            LblTotalTekst.Text = "TOTAL:";
            // 
            // LblTotalNumber
            // 
            LblTotalNumber.AutoSize = true;
            LblTotalNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LblTotalNumber.Location = new Point(306, 375);
            LblTotalNumber.Name = "LblTotalNumber";
            LblTotalNumber.Size = new Size(28, 21);
            LblTotalNumber.TabIndex = 14;
            LblTotalNumber.Text = "##";
            // 
            // LblHighVatNumber
            // 
            LblHighVatNumber.AutoSize = true;
            LblHighVatNumber.Location = new Point(313, 563);
            LblHighVatNumber.Name = "LblHighVatNumber";
            LblHighVatNumber.Size = new Size(21, 15);
            LblHighVatNumber.TabIndex = 16;
            LblHighVatNumber.Text = "##";
            // 
            // LblHighVatTekst
            // 
            LblHighVatTekst.AutoSize = true;
            LblHighVatTekst.Location = new Point(28, 563);
            LblHighVatTekst.Name = "LblHighVatTekst";
            LblHighVatTekst.Size = new Size(61, 15);
            LblHighVatTekst.TabIndex = 15;
            LblHighVatTekst.Text = "HIGH VAT:";
            // 
            // LblLowVatNumber
            // 
            LblLowVatNumber.AutoSize = true;
            LblLowVatNumber.Location = new Point(313, 539);
            LblLowVatNumber.Name = "LblLowVatNumber";
            LblLowVatNumber.Size = new Size(21, 15);
            LblLowVatNumber.TabIndex = 20;
            LblLowVatNumber.Text = "##";
            // 
            // LbllowVatTekst
            // 
            LbllowVatTekst.AutoSize = true;
            LbllowVatTekst.Location = new Point(28, 539);
            LbllowVatTekst.Name = "LbllowVatTekst";
            LbllowVatTekst.Size = new Size(58, 15);
            LbllowVatTekst.TabIndex = 19;
            LbllowVatTekst.Text = "LOW VAT:";
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(255, 179, 71);
            backBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(292, 37);
            backBtn.Margin = new Padding(3, 2, 3, 2);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(81, 27);
            backBtn.TabIndex = 32;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // BillForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(398, 697);
            Controls.Add(backBtn);
            Controls.Add(LblLowVatNumber);
            Controls.Add(LbllowVatTekst);
            Controls.Add(LblHighVatNumber);
            Controls.Add(LblHighVatTekst);
            Controls.Add(LblTotalNumber);
            Controls.Add(LblTotalTekst);
            Controls.Add(LblBill);
            Controls.Add(LblChoosePayment);
            Controls.Add(BtnProceedToPayment);
            Controls.Add(LblTotalVatNumber);
            Controls.Add(LblOrderPriceNumber);
            Controls.Add(LblTotalVatTekst);
            Controls.Add(LblOrderPriceTekst);
            Controls.Add(BtnCash);
            Controls.Add(BtnVisa);
            Controls.Add(BtnDebit);
            Controls.Add(pictureBox1);
            Controls.Add(LvBill);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "BillForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "7";
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
        private Label LblTotalVatTekst;
        private Label LblOrderPriceNumber;
        private Label LblTotalVatNumber;
        private CustomTools.RoundedButton BtnProceedToPayment;
        private Label LblChoosePayment;
        private Label LblBill;
        private Label LblTotalTekst;
        private Label LblTotalNumber;
        private Label LblHighVatNumber;
        private Label LblHighVatTekst;
        private Label LblLowVatNumber;
        private Label LbllowVatTekst;
        private Button backBtn;
    }
}