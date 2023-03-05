namespace Novellaoop
{
    partial class castlelNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(castlelNo));
            label1 = new Label();
            label2 = new Label();
            lose1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(0, 374);
            label1.Name = "label1";
            label1.Size = new Size(2194, 38);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gray;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(0, 412);
            label2.Name = "label2";
            label2.Size = new Size(1764, 38);
            label2.TabIndex = 1;
            label2.Text = "Мне кажется, там кто-то есть.....                                                                                                                                                           ";
            // 
            // lose1
            // 
            lose1.BackColor = Color.Gray;
            lose1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lose1.ForeColor = Color.FromArgb(64, 64, 64);
            lose1.Location = new Point(551, 411);
            lose1.Name = "lose1";
            lose1.Size = new Size(94, 39);
            lose1.TabIndex = 4;
            lose1.Text = ":(";
            lose1.UseVisualStyleBackColor = false;
            lose1.Click += lose1_Click;
            // 
            // castlelNo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.лес_нет_jpg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lose1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "castlelNo";
            Text = "castlelNo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button lose1;
    }
}