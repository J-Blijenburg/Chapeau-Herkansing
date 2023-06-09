﻿namespace UI
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
            TxtComment = new TextBox();
            BtnBack = new CustomTools.RoundedButton();
            BtnAddComment = new CustomTools.RoundedButton();
            SuspendLayout();
            // 
            // TxtComment
            // 
            TxtComment.AccessibleName = "";
            TxtComment.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            TxtComment.Location = new Point(117, 287);
            TxtComment.Margin = new Padding(4, 5, 4, 5);
            TxtComment.Multiline = true;
            TxtComment.Name = "TxtComment";
            TxtComment.PlaceholderText = "Message...";
            TxtComment.Size = new Size(355, 164);
            TxtComment.TabIndex = 1;
            // 
            // BtnBack
            // 
            BtnBack.BackColor = Color.FromArgb(255, 179, 71);
            BtnBack.FlatAppearance.BorderSize = 0;
            BtnBack.FlatStyle = FlatStyle.Flat;
            BtnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnBack.Location = new Point(-26, 17);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(131, 63);
            BtnBack.TabIndex = 3;
            BtnBack.Text = "BACK";
            BtnBack.UseVisualStyleBackColor = false;
            BtnBack.Click += BtnBack_Click;
            // 
            // BtnAddComment
            // 
            BtnAddComment.BackColor = Color.FromArgb(255, 179, 71);
            BtnAddComment.FlatAppearance.BorderSize = 0;
            BtnAddComment.FlatStyle = FlatStyle.Flat;
            BtnAddComment.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAddComment.Location = new Point(153, 473);
            BtnAddComment.Name = "BtnAddComment";
            BtnAddComment.Size = new Size(286, 83);
            BtnAddComment.TabIndex = 4;
            BtnAddComment.Text = "ADD Comment";
            BtnAddComment.UseVisualStyleBackColor = false;
            BtnAddComment.Click += BtnAddComment_Click;
            // 
            // OrderComment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(569, 1162);
            Controls.Add(BtnAddComment);
            Controls.Add(BtnBack);
            Controls.Add(TxtComment);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "OrderComment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OrderComment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox TxtComment;
        private CustomTools.RoundedButton BtnBack;
        private CustomTools.RoundedButton BtnAddComment;
    }
}