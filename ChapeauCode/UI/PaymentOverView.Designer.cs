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
            LblTotalPriceNumber = new Label();
            LblTotalPriceTekst = new Label();
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
            LblAmountOfPeople = new Label();
            CbSplitTheBill = new CheckBox();
            backBtn = new Button();
            LblhasBeenAdded = new Label();
            LblEnterCustomTip = new Label();
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
            // LblTotalPriceNumber
            // 
            LblTotalPriceNumber.AutoSize = true;
            LblTotalPriceNumber.Location = new Point(338, 109);
            LblTotalPriceNumber.Name = "LblTotalPriceNumber";
            LblTotalPriceNumber.Size = new Size(21, 15);
            LblTotalPriceNumber.TabIndex = 13;
            LblTotalPriceNumber.Text = "##";
            // 
            // LblTotalPriceTekst
            // 
            LblTotalPriceTekst.AutoSize = true;
            LblTotalPriceTekst.Location = new Point(20, 109);
            LblTotalPriceTekst.Name = "LblTotalPriceTekst";
            LblTotalPriceTekst.Size = new Size(64, 15);
            LblTotalPriceTekst.TabIndex = 12;
            LblTotalPriceTekst.Text = "Total Price:";
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
            LblTip.Location = new Point(20, 382);
            LblTip.Name = "LblTip";
            LblTip.Size = new Size(47, 30);
            LblTip.TabIndex = 19;
            LblTip.Text = "TIP";
            // 
            // BtnAddChangeAsTip
            // 
            BtnAddChangeAsTip.BackColor = Color.FromArgb(138, 210, 176);
            BtnAddChangeAsTip.FlatAppearance.BorderSize = 0;
            BtnAddChangeAsTip.Location = new Point(20, 456);
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
            LblCustomTip.Location = new Point(25, 551);
            LblCustomTip.Name = "LblCustomTip";
            LblCustomTip.Size = new Size(76, 15);
            LblCustomTip.TabIndex = 21;
            LblCustomTip.Text = "CUSTOM TIP:";
            // 
            // TbCustomTip
            // 
            TbCustomTip.Location = new Point(254, 543);
            TbCustomTip.Name = "TbCustomTip";
            TbCustomTip.Size = new Size(100, 23);
            TbCustomTip.TabIndex = 22;
            // 
            // BtnSetCustomTip
            // 
            BtnSetCustomTip.BackColor = Color.FromArgb(138, 210, 176);
            BtnSetCustomTip.FlatAppearance.BorderSize = 0;
            BtnSetCustomTip.Location = new Point(296, 572);
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
            LblDeviderTip.Location = new Point(-1, 380);
            LblDeviderTip.Name = "LblDeviderTip";
            LblDeviderTip.Size = new Size(400, 2);
            LblDeviderTip.TabIndex = 25;
            // 
            // AmountOfPeopleNr
            // 
            AmountOfPeopleNr.Location = new Point(303, 302);
            AmountOfPeopleNr.Name = "AmountOfPeopleNr";
            AmountOfPeopleNr.Size = new Size(58, 23);
            AmountOfPeopleNr.TabIndex = 26;
            AmountOfPeopleNr.Visible = false;
            // 
            // LblAmountOfPeople
            // 
            LblAmountOfPeople.AutoSize = true;
            LblAmountOfPeople.Location = new Point(25, 310);
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
            CbSplitTheBill.Location = new Point(25, 249);
            CbSplitTheBill.Name = "CbSplitTheBill";
            CbSplitTheBill.Size = new Size(178, 41);
            CbSplitTheBill.TabIndex = 29;
            CbSplitTheBill.Text = "Split the bill";
            CbSplitTheBill.UseVisualStyleBackColor = true;
            CbSplitTheBill.CheckedChanged += CbSplitTheBill_CheckedChanged;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.FromArgb(255, 179, 71);
            backBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            backBtn.Location = new Point(287, 39);
            backBtn.Margin = new Padding(3, 2, 3, 2);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(81, 27);
            backBtn.TabIndex = 33;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = false;
            backBtn.Click += backBtn_Click;
            // 
            // LblhasBeenAdded
            // 
            LblhasBeenAdded.AutoSize = true;
            LblhasBeenAdded.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LblhasBeenAdded.ForeColor = Color.FromArgb(138, 210, 176);
            LblhasBeenAdded.Location = new Point(25, 423);
            LblhasBeenAdded.Name = "LblhasBeenAdded";
            LblhasBeenAdded.Size = new Size(199, 30);
            LblhasBeenAdded.TabIndex = 34;
            LblhasBeenAdded.Text = "HAS BEEN ADDED";
            LblhasBeenAdded.Visible = false;
            // 
            // LblEnterCustomTip
            // 
            LblEnterCustomTip.AutoSize = true;
            LblEnterCustomTip.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LblEnterCustomTip.ForeColor = Color.Black;
            LblEnterCustomTip.Location = new Point(25, 506);
            LblEnterCustomTip.Name = "LblEnterCustomTip";
            LblEnterCustomTip.Size = new Size(133, 30);
            LblEnterCustomTip.TabIndex = 35;
            LblEnterCustomTip.Text = "Custom tip:";
            // 
            // PaymentOverView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(398, 697);
            Controls.Add(LblEnterCustomTip);
            Controls.Add(LblhasBeenAdded);
            Controls.Add(backBtn);
            Controls.Add(CbSplitTheBill);
            Controls.Add(LblAmountOfPeople);
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
            Controls.Add(LblTotalPriceNumber);
            Controls.Add(LblTotalPriceTekst);
            Controls.Add(LblPayment);
            Controls.Add(BtnPay);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "PaymentOverView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)AmountOfPeopleNr).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private CustomTools.RoundedButton BtnPay;
        private Label LblPayment;
        private Label LblTotalPriceNumber;
        private Label LblTotalPriceTekst;
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
        private Label LblAmountOfPeople;
        private CheckBox CbSplitTheBill;
        private Button backBtn;
        private Label LblhasBeenAdded;
        private Label LblEnterCustomTip;
    }
}