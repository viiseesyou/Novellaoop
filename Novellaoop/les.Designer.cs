namespace Novellaoop
{
    partial class les
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
            label2 = new Label();
            right = new Button();
            left = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 224, 192);
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(128, 64, 0);
            label1.Location = new Point(-2, 374);
            label1.Name = "label1";
            label1.Size = new Size(1312, 38);
            label1.TabIndex = 0;
            label1.Text = "Ох, опять эта развилка...                                                                                                                    ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 224, 192);
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(128, 64, 0);
            label2.Location = new Point(-2, 412);
            label2.Name = "label2";
            label2.Size = new Size(1051, 38);
            label2.TabIndex = 1;
            label2.Text = "Ну, куда пойдёшь?                                                                                                 ";
            // 
            // right
            // 
            right.BackColor = Color.FromArgb(255, 224, 192);
            right.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            right.ForeColor = Color.FromArgb(128, 64, 0);
            right.Location = new Point(637, 375);
            right.Name = "right";
            right.Size = new Size(137, 63);
            right.TabIndex = 2;
            right.Text = "Направо";
            right.UseVisualStyleBackColor = false;
            right.Click += right_Click;
            // 
            // left
            // 
            left.BackColor = Color.FromArgb(255, 224, 192);
            left.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            left.ForeColor = Color.FromArgb(128, 64, 0);
            left.Location = new Point(452, 374);
            left.Name = "left";
            left.Size = new Size(137, 63);
            left.TabIndex = 3;
            left.Text = "Налево";
            left.UseVisualStyleBackColor = false;
            left.Click += left_Click;
            // 
            // les
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.развилка;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(left);
            Controls.Add(right);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "les";
            Text = "les";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button right;
        private Button left;
    }
}