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
            LblToPayTekst = new Label();
            LblToPayNumber = new Label();
            BtnPay = new Button();
            TbInputAmountPaid = new TextBox();
            LblAmountPaid = new Label();
            SuspendLayout();
            // 
            // LblToPayTekst
            // 
            LblToPayTekst.AutoSize = true;
            LblToPayTekst.Location = new Point(54, 125);
            LblToPayTekst.Name = "LblToPayTekst";
            LblToPayTekst.Size = new Size(44, 15);
            LblToPayTekst.TabIndex = 0;
            LblToPayTekst.Text = "To pay:";
            // 
            // LblToPayNumber
            // 
            LblToPayNumber.AutoSize = true;
            LblToPayNumber.Location = new Point(256, 125);
            LblToPayNumber.Name = "LblToPayNumber";
            LblToPayNumber.Size = new Size(38, 15);
            LblToPayNumber.TabIndex = 1;
            LblToPayNumber.Text = "label2";
            // 
            // BtnPay
            // 
            BtnPay.Location = new Point(101, 329);
            BtnPay.Name = "BtnPay";
            BtnPay.Size = new Size(193, 77);
            BtnPay.TabIndex = 2;
            BtnPay.Text = "Pay";
            BtnPay.UseVisualStyleBackColor = true;
            BtnPay.Click += BtnPay_Click;
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
            // Splitbill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 697);
            Controls.Add(LblAmountPaid);
            Controls.Add(TbInputAmountPaid);
            Controls.Add(BtnPay);
            Controls.Add(LblToPayNumber);
            Controls.Add(LblToPayTekst);
            Name = "Splitbill";
            Text = "Splitbill";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblToPayTekst;
        private Label LblToPayNumber;
        private Button BtnPay;
        private TextBox TbInputAmountPaid;
        private Label LblAmountPaid;
    }
}