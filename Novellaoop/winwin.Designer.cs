﻿namespace Novellaoop
{
    partial class winwin
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
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(70, 257);
            label1.Name = "label1";
            label1.Size = new Size(123, 31);
            label1.TabIndex = 0;
            label1.Text = "ПОБЕДА!";
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(192, 0, 0);
            button1.Location = new Point(83, 300);
            button1.Name = "button1";
            button1.Size = new Size(94, 65);
            button1.TabIndex = 1;
            button1.Text = ";)";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // winwin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.поб;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "winwin";
            Text = "winwin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
    }
}