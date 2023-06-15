namespace UI
{
    partial class CommentQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommentQuestion));
            pictureBox1 = new PictureBox();
            BtContinueWithPayment = new CustomTools.RoundedButton();
            BtnAddComment = new CustomTools.RoundedButton();
            LblAddComment = new Label();
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
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // BtContinueWithPayment
            // 
            BtContinueWithPayment.BackColor = Color.FromArgb(138, 210, 176);
            BtContinueWithPayment.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtContinueWithPayment.Location = new Point(30, 323);
            BtContinueWithPayment.Name = "BtContinueWithPayment";
            BtContinueWithPayment.Size = new Size(339, 51);
            BtContinueWithPayment.TabIndex = 12;
            BtContinueWithPayment.Text = "CONTINUE WITH PAYMENT";
            BtContinueWithPayment.UseVisualStyleBackColor = false;
            BtContinueWithPayment.Click += BtContinueWithPayment_Click;
            // 
            // BtnAddComment
            // 
            BtnAddComment.BackColor = Color.FromArgb(255, 179, 71);
            BtnAddComment.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAddComment.Location = new Point(30, 266);
            BtnAddComment.Name = "BtnAddComment";
            BtnAddComment.Size = new Size(339, 51);
            BtnAddComment.TabIndex = 13;
            BtnAddComment.Text = "ADD A COMMENT";
            BtnAddComment.UseVisualStyleBackColor = false;
            BtnAddComment.Click += BtnAddComment_Click;
            // 
            // LblAddComment
            // 
            LblAddComment.AutoSize = true;
            LblAddComment.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            LblAddComment.Location = new Point(46, 208);
            LblAddComment.Name = "LblAddComment";
            LblAddComment.Size = new Size(295, 45);
            LblAddComment.TabIndex = 14;
            LblAddComment.Text = "ANY COMMENTS?";
            // 
            // CommentQuestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 697);
            Controls.Add(LblAddComment);
            Controls.Add(BtnAddComment);
            Controls.Add(BtContinueWithPayment);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MaximizeBox = false;
            Name = "CommentQuestion";
            Text = "Comment ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private CustomTools.RoundedButton BtContinueWithPayment;
        private CustomTools.RoundedButton BtnAddComment;
        private Label LblAddComment;
    }
}