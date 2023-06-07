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
            lblChangeTekst = new Label();
            LblChangeNumber = new Label();
            LblTip = new Label();
            BtnAddChangeAsTip = new CustomTools.RoundedButton();
            LblCustomTip = new Label();
            TbCustomTip = new TextBox();
            BtnSetCustomTip = new CustomTools.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            BtnPay.Location = new Point(25, 603);
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
            LblPayment.Location = new Point(25, 87);
            LblPayment.Name = "LblPayment";
            LblPayment.Size = new Size(115, 30);
            LblPayment.TabIndex = 11;
            LblPayment.Text = "PAYMENT";
            // 
            // LblOrderPriceNumber
            // 
            LblOrderPriceNumber.AutoSize = true;
            LblOrderPriceNumber.Location = new Point(343, 145);
            LblOrderPriceNumber.Name = "LblOrderPriceNumber";
            LblOrderPriceNumber.Size = new Size(21, 15);
            LblOrderPriceNumber.TabIndex = 13;
            LblOrderPriceNumber.Text = "##";
            // 
            // LblOrderPriceTekst
            // 
            LblOrderPriceTekst.AutoSize = true;
            LblOrderPriceTekst.Location = new Point(25, 145);
            LblOrderPriceTekst.Name = "LblOrderPriceTekst";
            LblOrderPriceTekst.Size = new Size(78, 15);
            LblOrderPriceTekst.TabIndex = 12;
            LblOrderPriceTekst.Text = "ORDER PRCE:";
            // 
            // LblAmountPaid
            // 
            LblAmountPaid.AutoSize = true;
            LblAmountPaid.Location = new Point(25, 178);
            LblAmountPaid.Name = "LblAmountPaid";
            LblAmountPaid.Size = new Size(89, 15);
            LblAmountPaid.TabIndex = 14;
            LblAmountPaid.Text = "AMOUNT PAID:";
            // 
            // TbAmountPaid
            // 
            TbAmountPaid.Location = new Point(264, 175);
            TbAmountPaid.Name = "TbAmountPaid";
            TbAmountPaid.Size = new Size(100, 23);
            TbAmountPaid.TabIndex = 15;
            // 
            // BtnSetAmountPaid
            // 
            BtnSetAmountPaid.BackColor = Color.FromArgb(138, 210, 176);
            BtnSetAmountPaid.FlatAppearance.BorderSize = 0;
            BtnSetAmountPaid.Location = new Point(306, 204);
            BtnSetAmountPaid.Name = "BtnSetAmountPaid";
            BtnSetAmountPaid.Size = new Size(58, 40);
            BtnSetAmountPaid.TabIndex = 16;
            BtnSetAmountPaid.Text = "SET";
            BtnSetAmountPaid.UseVisualStyleBackColor = false;
            BtnSetAmountPaid.Click += BtnSetAmountPaid_Click;
            // 
            // lblChangeTekst
            // 
            lblChangeTekst.AutoSize = true;
            lblChangeTekst.Location = new Point(30, 266);
            lblChangeTekst.Name = "lblChangeTekst";
            lblChangeTekst.Size = new Size(58, 15);
            lblChangeTekst.TabIndex = 17;
            lblChangeTekst.Text = "CHANGE:";
            // 
            // LblChangeNumber
            // 
            LblChangeNumber.AutoSize = true;
            LblChangeNumber.Location = new Point(343, 266);
            LblChangeNumber.Name = "LblChangeNumber";
            LblChangeNumber.Size = new Size(21, 15);
            LblChangeNumber.TabIndex = 18;
            LblChangeNumber.Text = "##";
            // 
            // LblTip
            // 
            LblTip.AutoSize = true;
            LblTip.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LblTip.Location = new Point(30, 321);
            LblTip.Name = "LblTip";
            LblTip.Size = new Size(47, 30);
            LblTip.TabIndex = 19;
            LblTip.Text = "TIP";
            // 
            // BtnAddChangeAsTip
            // 
            BtnAddChangeAsTip.BackColor = Color.FromArgb(138, 210, 176);
            BtnAddChangeAsTip.FlatAppearance.BorderSize = 0;
            BtnAddChangeAsTip.Location = new Point(30, 379);
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
            LblCustomTip.Location = new Point(30, 442);
            LblCustomTip.Name = "LblCustomTip";
            LblCustomTip.Size = new Size(76, 15);
            LblCustomTip.TabIndex = 21;
            LblCustomTip.Text = "CUSTOM TIP:";
            // 
            // TbCustomTip
            // 
            TbCustomTip.Location = new Point(264, 434);
            TbCustomTip.Name = "TbCustomTip";
            TbCustomTip.Size = new Size(100, 23);
            TbCustomTip.TabIndex = 22;
            // 
            // BtnSetCustomTip
            // 
            BtnSetCustomTip.BackColor = Color.FromArgb(138, 210, 176);
            BtnSetCustomTip.FlatAppearance.BorderSize = 0;
            BtnSetCustomTip.Location = new Point(306, 463);
            BtnSetCustomTip.Name = "BtnSetCustomTip";
            BtnSetCustomTip.Size = new Size(58, 40);
            BtnSetCustomTip.TabIndex = 23;
            BtnSetCustomTip.Text = "SET";
            BtnSetCustomTip.UseVisualStyleBackColor = false;
            BtnSetCustomTip.Click += BtnSetCustomTip_Click;
            // 
            // PaymentOverView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(398, 697);
            Controls.Add(BtnSetCustomTip);
            Controls.Add(TbCustomTip);
            Controls.Add(LblCustomTip);
            Controls.Add(BtnAddChangeAsTip);
            Controls.Add(LblTip);
            Controls.Add(LblChangeNumber);
            Controls.Add(lblChangeTekst);
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
        private Label lblChangeTekst;
        private Label LblChangeNumber;
        private Label LblTip;
        private CustomTools.RoundedButton BtnAddChangeAsTip;
        private Label LblCustomTip;
        private TextBox TbCustomTip;
        private CustomTools.RoundedButton BtnSetCustomTip;
    }
}