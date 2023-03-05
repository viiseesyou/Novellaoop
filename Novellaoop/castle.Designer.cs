namespace Novellaoop
{
    partial class castle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(castle));
            label1 = new Label();
            label2 = new Label();
            Yes1 = new Button();
            No1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(0, 375);
            label1.Name = "label1";
            label1.Size = new Size(1611, 38);
            label1.TabIndex = 0;
            label1.Text = "Брр...мы почти на месте...                                                                                                                                                       ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gray;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(0, 413);
            label2.Name = "label2";
            label2.Size = new Size(1941, 38);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // Yes1
            // 
            Yes1.BackColor = Color.Gray;
            Yes1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Yes1.ForeColor = Color.FromArgb(64, 64, 64);
            Yes1.Location = new Point(537, 412);
            Yes1.Name = "Yes1";
            Yes1.Size = new Size(94, 39);
            Yes1.TabIndex = 3;
            Yes1.Text = "Да!";
            Yes1.UseVisualStyleBackColor = false;
            Yes1.Click += Yes1_Click;
            // 
            // No1
            // 
            No1.BackColor = Color.Gray;
            No1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            No1.ForeColor = Color.FromArgb(64, 64, 64);
            No1.Location = new Point(680, 412);
            No1.Name = "No1";
            No1.Size = new Size(94, 39);
            No1.TabIndex = 4;
            No1.Text = "Нет!";
            No1.UseVisualStyleBackColor = false;
            No1.Click += No1_Click;
            // 
            // castle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.castle;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(No1);
            Controls.Add(Yes1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "castle";
            Text = "castle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button Yes1;
        private Button No1;
    }
}