namespace UI
{
    partial class OrderComment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderComment));
            button1 = new Button();
            TxtComment = new TextBox();
            BtnAddComment = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 179, 71);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(-10, 10);
            button1.Name = "button1";
            button1.Size = new Size(92, 38);
            button1.TabIndex = 0;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = false;
            // 
            // TxtComment
            // 
            TxtComment.AccessibleName = "";
            TxtComment.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TxtComment.Location = new Point(82, 172);
            TxtComment.Multiline = true;
            TxtComment.Name = "TxtComment";
            TxtComment.PlaceholderText = "Message...";
            TxtComment.Size = new Size(250, 100);
            TxtComment.TabIndex = 1;
            // 
            // BtnAddComment
            // 
            BtnAddComment.BackColor = Color.FromArgb(255, 179, 71);
            BtnAddComment.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAddComment.Location = new Point(107, 284);
            BtnAddComment.Name = "BtnAddComment";
            BtnAddComment.Size = new Size(200, 50);
            BtnAddComment.TabIndex = 2;
            BtnAddComment.Text = "ADD";
            BtnAddComment.UseVisualStyleBackColor = false;
            BtnAddComment.Click += BtnAddComment_Click;
            // 
            // OrderComment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(398, 697);
            Controls.Add(BtnAddComment);
            Controls.Add(TxtComment);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "OrderComment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderComment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox TxtComment;
        private Button BtnAddComment;
    }
}