namespace UI
{
    partial class PaymentOverView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentOverView));
            pictureBox1 = new PictureBox();
            BtnPay = new CustomTools.RoundedButton();
            LblPayment = new Label();
            LblOrderPriceNumber = new Label();
            LblOrderPriceTekst = new Label();
            LblAmountPaid = new Label();
            TbAmountPaid = new TextBox();
            BtnSetAmountPaid = new CustomTools.RoundedButton();
            LblChangeTekst = new Label();
            LblChangeNumber = new Label();
            LblTip = new Label();
            BtnAddChangeAsTip = new CustomTools.RoundedButton();
            LblCustomTip = new Label();
            TbCustomTip = new TextBox();
            BtnSetCustomTip = new CustomTools.RoundedButton();
            LblDeviderSplit = new Label();
            LblDeviderTip = new Label();
            AmountOfPeopleNr = new NumericUpDown();
            LblSplit = new Label();
            LblAmountOfPeople = new Label();
            CbSplitTheBill = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AmountOfPeopleNr).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // BtnPay
            // 
            BtnPay.BackColor = Color.FromArgb(255, 179, 71);
            BtnPay.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnPay.Location = new Point(20, 637);
            BtnPay.Name = "BtnPay";
            BtnPay.Size = new Size(339, 51);
            BtnPay.TabIndex = 10;
            BtnPay.Text = "PAY";
            BtnPay.UseVisualStyleBackColor = false;
            BtnPay.Click += BtnPay_Click;
            // 
            // LblPayment
            // 
            LblPayment.AutoSize = true;
            LblPayment.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LblPayment.Location = new Point(20, 68);
            LblPayment.Name = "LblPayment";
            LblPayment.Size = new Size(115, 30);
            LblPayment.TabIndex = 11;
            LblPayment.Text = "PAYMENT";
            // 
            // LblOrderPriceNumber
            // 
            LblOrderPriceNumber.AutoSize = true;
            LblOrderPriceNumber.Location = new Point(338, 109);
            LblOrderPriceNumber.Name = "LblOrderPriceNumber";
            LblOrderPriceNumber.Size = new Size(21, 15);
            LblOrderPriceNumber.TabIndex = 13;
            LblOrderPriceNumber.Text = "##";
            // 
            // LblOrderPriceTekst
            // 
            LblOrderPriceTekst.AutoSize = true;
            LblOrderPriceTekst.Location = new Point(20, 109);
            LblOrderPriceTekst.Name = "LblOrderPriceTekst";
            LblOrderPriceTekst.Size = new Size(78, 15);
            LblOrderPriceTekst.TabIndex = 12;
            LblOrderPriceTekst.Text = "ORDER PRCE:";
            // 
            // LblAmountPaid
            // 
            LblAmountPaid.AutoSize = true;
            LblAmountPaid.Location = new Point(20, 142);
            LblAmountPaid.Name = "LblAmountPaid";
            LblAmountPaid.Size = new Size(89, 15);
            LblAmountPaid.TabIndex = 14;
            LblAmountPaid.Text = "AMOUNT PAID:";
            // 
            // TbAmountPaid
            // 
            TbAmountPaid.Location = new Point(259, 139);
            TbAmountPaid.Name = "TbAmountPaid";
            TbAmountPaid.Size = new Size(100, 23);
            TbAmountPaid.TabIndex = 15;
            // 
            // BtnSetAmountPaid
            // 
            BtnSetAmountPaid.BackColor = Color.FromArgb(138, 210, 176);
            BtnSetAmountPaid.FlatAppearance.BorderSize = 0;
            BtnSetAmountPaid.Location = new Point(301, 168);
            BtnSetAmountPaid.Name = "BtnSetAmountPaid";
            BtnSetAmountPaid.Size = new Size(58, 40);
            BtnSetAmountPaid.TabIndex = 16;
            BtnSetAmountPaid.Text = "SET";
            BtnSetAmountPaid.UseVisualStyleBackColor = false;
            BtnSetAmountPaid.Click += BtnSetAmountPaid_Click;
            // 
            // LblChangeTekst
            // 
            LblChangeTekst.AutoSize = true;
            LblChangeTekst.Location = new Point(25, 220);
            LblChangeTekst.Name = "LblChangeTekst";
            LblChangeTekst.Size = new Size(58, 15);
            LblChangeTekst.TabIndex = 17;
            LblChangeTekst.Text = "CHANGE:";
            // 
            // LblChangeNumber
            // 
            LblChangeNumber.AutoSize = true;
            LblChangeNumber.Location = new Point(338, 220);
            LblChangeNumber.Name = "LblChangeNumber";
            LblChangeNumber.Size = new Size(21, 15);
            LblChangeNumber.TabIndex = 18;
            LblChangeNumber.Text = "##";
            // 
            // LblTip
            // 
            LblTip.AutoSize = true;
            LblTip.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LblTip.Location = new Point(20, 446);
            LblTip.Name = "LblTip";
            LblTip.Size = new Size(47, 30);
            LblTip.TabIndex = 19;
            LblTip.Text = "TIP";
            // 
            // BtnAddChangeAsTip
            // 
            BtnAddChangeAsTip.BackColor = Color.FromArgb(138, 210, 176);
            BtnAddChangeAsTip.FlatAppearance.BorderSize = 0;
            BtnAddChangeAsTip.Location = new Point(20, 498);
            BtnAddChangeAsTip.Name = "BtnAddChangeAsTip";
            BtnAddChangeAsTip.Size = new Size(334, 32);
            BtnAddChangeAsTip.TabIndex = 20;
            BtnAddChangeAsTip.Text = "ADD CHANGE AS TIP";
            BtnAddChangeAsTip.UseVisualStyleBackColor = false;
            BtnAddChangeAsTip.Click += BtnAddChangeAsTip_Click;
            // 
            // LblCustomTip
            // 
            LblCustomTip.AutoSize = true;
            LblCustomTip.Location = new Point(20, 561);
            LblCustomTip.Name = "LblCustomTip";
            LblCustomTip.Size = new Size(76, 15);
            LblCustomTip.TabIndex = 21;
            LblCustomTip.Text = "CUSTOM TIP:";
            // 
            // TbCustomTip
            // 
            TbCustomTip.Location = new Point(254, 553);
            TbCustomTip.Name = "TbCustomTip";
            TbCustomTip.Size = new Size(100, 23);
            TbCustomTip.TabIndex = 22;
            // 
            // BtnSetCustomTip
            // 
            BtnSetCustomTip.BackColor = Color.FromArgb(138, 210, 176);
            BtnSetCustomTip.FlatAppearance.BorderSize = 0;
            BtnSetCustomTip.Location = new Point(296, 582);
            BtnSetCustomTip.Name = "BtnSetCustomTip";
            BtnSetCustomTip.Size = new Size(58, 40);
            BtnSetCustomTip.TabIndex = 23;
            BtnSetCustomTip.Text = "SET";
            BtnSetCustomTip.UseVisualStyleBackColor = false;
            BtnSetCustomTip.Click += BtnSetCustomTip_Click;
            // 
            // LblDeviderSplit
            // 
            LblDeviderSplit.BorderStyle = BorderStyle.Fixed3D;
            LblDeviderSplit.Location = new Point(-1, 244);
            LblDeviderSplit.Name = "LblDeviderSplit";
            LblDeviderSplit.Size = new Size(400, 2);
            LblDeviderSplit.TabIndex = 24;
            // 
            // LblDeviderTip
            // 
            LblDeviderTip.BorderStyle = BorderStyle.Fixed3D;
            LblDeviderTip.Location = new Point(-1, 444);
            LblDeviderTip.Name = "LblDeviderTip";
            LblDeviderTip.Size = new Size(400, 2);
            LblDeviderTip.TabIndex = 25;
            // 
            // AmountOfPeopleNr
            // 
            AmountOfPeopleNr.Location = new Point(298, 342);
            AmountOfPeopleNr.Name = "AmountOfPeopleNr";
            AmountOfPeopleNr.Size = new Size(58, 23);
            AmountOfPeopleNr.TabIndex = 26;
            AmountOfPeopleNr.Visible = false;
            // 
            // LblSplit
            // 
            LblSplit.AutoSize = true;
            LblSplit.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LblSplit.Location = new Point(20, 246);
            LblSplit.Name = "LblSplit";
            LblSplit.Size = new Size(0, 30);
            LblSplit.TabIndex = 27;
            // 
            // LblAmountOfPeople
            // 
            LblAmountOfPeople.AutoSize = true;
            LblAmountOfPeople.Location = new Point(20, 350);
            LblAmountOfPeople.Name = "LblAmountOfPeople";
            LblAmountOfPeople.Size = new Size(123, 15);
            LblAmountOfPeople.TabIndex = 28;
            LblAmountOfPeople.Text = "AMOUNT OF PEOPLE:";
            LblAmountOfPeople.Visible = false;
            // 
            // CbSplitTheBill
            // 
            CbSplitTheBill.AutoSize = true;
            CbSplitTheBill.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            CbSplitTheBill.Location = new Point(26, 269);
            CbSplitTheBill.Name = "CbSplitTheBill";
            CbSplitTheBill.Size = new Size(178, 41);
            CbSplitTheBill.TabIndex = 29;
            CbSplitTheBill.Text = "Split the bill";
            CbSplitTheBill.UseVisualStyleBackColor = true;
            CbSplitTheBill.CheckedChanged += CbSplitTheBill_CheckedChanged;
            // 
            // PaymentOverView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(398, 697);
            Controls.Add(CbSplitTheBill);
            Controls.Add(LblAmountOfPeople);
            Controls.Add(LblSplit);
            Controls.Add(AmountOfPeopleNr);
            Controls.Add(LblDeviderTip);
            Controls.Add(LblDeviderSplit);
            Controls.Add(BtnSetCustomTip);
            Controls.Add(TbCustomTip);
            Controls.Add(LblCustomTip);
            Controls.Add(BtnAddChangeAsTip);
            Controls.Add(LblTip);
            Controls.Add(LblChangeNumber);
            Controls.Add(LblChangeTekst);
            Controls.Add(BtnSetAmountPaid);
            Controls.Add(TbAmountPaid);
            Controls.Add(LblAmountPaid);
            Controls.Add(LblOrderPriceNumber);
            Controls.Add(LblOrderPriceTekst);
            Controls.Add(LblPayment);
            Controls.Add(BtnPay);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "PaymentOverView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Payment over";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)AmountOfPeopleNr).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private CustomTools.RoundedButton BtnPay;
        private Label LblPayment;
        private Label LblOrderPriceNumber;
        private Label LblOrderPriceTekst;
        private Label LblAmountPaid;
        private TextBox TbAmountPaid;
        private CustomTools.RoundedButton BtnSetAmountPaid;
        private Label LblChangeTekst;
        private Label LblChangeNumber;
        private Label LblTip;
        private CustomTools.RoundedButton BtnAddChangeAsTip;
        private Label LblCustomTip;
        private TextBox TbCustomTip;
        private CustomTools.RoundedButton BtnSetCustomTip;
        private Label LblDeviderSplit;
        private Label LblDeviderTip;
        private NumericUpDown AmountOfPeopleNr;
        private Label LblSplit;
        private Label LblAmountOfPeople;
        private CheckBox CbSplitTheBill;
    }
}