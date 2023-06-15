namespace UI
{
    partial class CommentInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommentInput));
            pictureBox1 = new PictureBox();
            TbComment = new RichTextBox();
            BtConfirm = new CustomTools.RoundedButton();
            BtnBack = new CustomTools.RoundedButton();
            lblSuccesMessage = new Label();
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
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // TbComment
            // 
            TbComment.Location = new Point(30, 120);
            TbComment.Name = "TbComment";
            TbComment.Size = new Size(339, 323);
            TbComment.TabIndex = 5;
            TbComment.Text = "";
            // 
            // BtConfirm
            // 
            BtConfirm.BackColor = Color.FromArgb(138, 210, 176);
            BtConfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtConfirm.Location = new Point(30, 470);
            BtConfirm.Name = "BtConfirm";
            BtConfirm.Size = new Size(339, 51);
            BtConfirm.TabIndex = 11;
            BtConfirm.Text = "CONFIRM";
            BtConfirm.UseVisualStyleBackColor = false;
            BtConfirm.Click += BtConfirm_Click;
            // 
            // BtnBack
            // 
            BtnBack.BackColor = Color.FromArgb(255, 179, 71);
            BtnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnBack.Location = new Point(303, 26);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(66, 40);
            BtnBack.TabIndex = 12;
            BtnBack.Text = "BACK";
            BtnBack.UseVisualStyleBackColor = false;
            BtnBack.Click += BtnBack_Click;
            // 
            // lblSuccesMessage
            // 
            lblSuccesMessage.AutoSize = true;
            lblSuccesMessage.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblSuccesMessage.ForeColor = Color.FromArgb(138, 210, 176);
            lblSuccesMessage.Location = new Point(25, 553);
            lblSuccesMessage.Name = "lblSuccesMessage";
            lblSuccesMessage.Size = new Size(361, 56);
            lblSuccesMessage.TabIndex = 13;
            lblSuccesMessage.Text = "The comment has been saved!\r\nPlease go back to continue payment.";
            // 
            // CommentInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 697);
            Controls.Add(lblSuccesMessage);
            Controls.Add(BtnBack);
            Controls.Add(BtConfirm);
            Controls.Add(TbComment);
            Controls.Add(pictureBox1);
            Name = "CommentInput";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private RichTextBox TbComment;
        private CustomTools.RoundedButton BtConfirm;
        private CustomTools.RoundedButton BtnBack;
        private Label lblSuccesMessage;
    }
}