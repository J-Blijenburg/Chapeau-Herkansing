namespace UI
{
    partial class Splitbill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splitbill));
            LblToPayTekst = new Label();
            LblToPayNumber = new Label();
            TbInputAmountPaid = new TextBox();
            LblAmountPaid = new Label();
            LblChoosePayment = new Label();
            BtnCash = new CustomTools.RoundedButton();
            BtnVisa = new CustomTools.RoundedButton();
            BtnDebit = new CustomTools.RoundedButton();
            pictureBox1 = new PictureBox();
            BtnPayNew = new CustomTools.RoundedButton();
            LblChangeNumber = new Label();
            LblChangeTekst = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LblToPayTekst
            // 
            LblToPayTekst.AutoSize = true;
            LblToPayTekst.Location = new Point(54, 138);
            LblToPayTekst.Name = "LblToPayTekst";
            LblToPayTekst.Size = new Size(108, 15);
            LblToPayTekst.TabIndex = 0;
            LblToPayTekst.Text = "Remaning balance:";
            // 
            // LblToPayNumber
            // 
            LblToPayNumber.AutoSize = true;
            LblToPayNumber.Location = new Point(279, 138);
            LblToPayNumber.Name = "LblToPayNumber";
            LblToPayNumber.Size = new Size(38, 15);
            LblToPayNumber.TabIndex = 1;
            LblToPayNumber.Text = "label2";
            // 
            // TbInputAmountPaid
            // 
            TbInputAmountPaid.Location = new Point(217, 184);
            TbInputAmountPaid.Name = "TbInputAmountPaid";
            TbInputAmountPaid.Size = new Size(100, 23);
            TbInputAmountPaid.TabIndex = 3;
            // 
            // LblAmountPaid
            // 
            LblAmountPaid.AutoSize = true;
            LblAmountPaid.Location = new Point(54, 184);
            LblAmountPaid.Name = "LblAmountPaid";
            LblAmountPaid.Size = new Size(77, 15);
            LblAmountPaid.TabIndex = 4;
            LblAmountPaid.Text = "Amount Paid";
            // 
            // LblChoosePayment
            // 
            LblChoosePayment.AutoSize = true;
            LblChoosePayment.Location = new Point(34, 290);
            LblChoosePayment.Name = "LblChoosePayment";
            LblChoosePayment.Size = new Size(141, 15);
            LblChoosePayment.TabIndex = 14;
            LblChoosePayment.Text = "CHOOSE PAYMENT TYPE:";
            // 
            // BtnCash
            // 
            BtnCash.BackColor = Color.LightGray;
            BtnCash.FlatAppearance.BorderSize = 0;
            BtnCash.FlatStyle = FlatStyle.Flat;
            BtnCash.Location = new Point(285, 312);
            BtnCash.Name = "BtnCash";
            BtnCash.Size = new Size(91, 39);
            BtnCash.TabIndex = 13;
            BtnCash.Text = "Cash";
            BtnCash.UseVisualStyleBackColor = false;
            BtnCash.Click += Button_Click;
            // 
            // BtnVisa
            // 
            BtnVisa.BackColor = Color.LightGray;
            BtnVisa.FlatAppearance.BorderSize = 0;
            BtnVisa.FlatStyle = FlatStyle.Flat;
            BtnVisa.Location = new Point(163, 312);
            BtnVisa.Name = "BtnVisa";
            BtnVisa.Size = new Size(91, 39);
            BtnVisa.TabIndex = 12;
            BtnVisa.Text = "Visa / Amex";
            BtnVisa.UseVisualStyleBackColor = false;
            BtnVisa.Click += Button_Click;
            // 
            // BtnDebit
            // 
            BtnDebit.BackColor = Color.LightGray;
            BtnDebit.FlatAppearance.BorderSize = 0;
            BtnDebit.FlatStyle = FlatStyle.Flat;
            BtnDebit.Location = new Point(37, 312);
            BtnDebit.Name = "BtnDebit";
            BtnDebit.Size = new Size(91, 39);
            BtnDebit.TabIndex = 11;
            BtnDebit.Text = "Debit\r\n";
            BtnDebit.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // BtnPayNew
            // 
            BtnPayNew.BackColor = Color.FromArgb(255, 179, 71);
            BtnPayNew.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnPayNew.Location = new Point(37, 624);
            BtnPayNew.Name = "BtnPayNew";
            BtnPayNew.Size = new Size(339, 51);
            BtnPayNew.TabIndex = 16;
            BtnPayNew.Text = "PAY";
            BtnPayNew.UseVisualStyleBackColor = false;
            BtnPayNew.Click += BtnPay1_Click;
            // 
            // LblChangeNumber
            // 
            LblChangeNumber.AutoSize = true;
            LblChangeNumber.Location = new Point(296, 228);
            LblChangeNumber.Name = "LblChangeNumber";
            LblChangeNumber.Size = new Size(21, 15);
            LblChangeNumber.TabIndex = 20;
            LblChangeNumber.Text = "##";
            // 
            // LblChangeTekst
            // 
            LblChangeTekst.AutoSize = true;
            LblChangeTekst.Location = new Point(54, 228);
            LblChangeTekst.Name = "LblChangeTekst";
            LblChangeTekst.Size = new Size(58, 15);
            LblChangeTekst.TabIndex = 19;
            LblChangeTekst.Text = "CHANGE:";
            // 
            // Splitbill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 697);
            Controls.Add(LblChangeNumber);
            Controls.Add(LblChangeTekst);
            Controls.Add(BtnPayNew);
            Controls.Add(pictureBox1);
            Controls.Add(LblChoosePayment);
            Controls.Add(BtnCash);
            Controls.Add(BtnVisa);
            Controls.Add(BtnDebit);
            Controls.Add(LblAmountPaid);
            Controls.Add(TbInputAmountPaid);
            Controls.Add(LblToPayNumber);
            Controls.Add(LblToPayTekst);
            MaximizeBox = false;
            Name = "Splitbill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Splitbill";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblToPayTekst;
        private Label LblToPayNumber;
        private Button BtnPay1;
        private TextBox TbInputAmountPaid;
        private Label LblAmountPaid;
        private Label LblChoosePayment;
        private CustomTools.RoundedButton BtnCash;
        private CustomTools.RoundedButton BtnVisa;
        private CustomTools.RoundedButton BtnDebit;
        private PictureBox pictureBox1;
        private CustomTools.RoundedButton BtnPayNew;
        private Label LblChangeNumber;
        private Label LblChangeTekst;
    }
}