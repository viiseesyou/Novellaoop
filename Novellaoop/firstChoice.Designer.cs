namespace Novellaoop
{
    partial class firstChoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(firstChoice));
            label1 = new Label();
            label2 = new Label();
            forest = new Button();
            castle = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(-5, 374);
            label1.Name = "label1";
            label1.Size = new Size(1171, 38);
            label1.TabIndex = 0;
            label1.Text = "Повсюду ни души...                                                                                                               ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gray;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.ImageAlign = ContentAlignment.BottomLeft;
            label2.Location = new Point(-5, 412);
            label2.Name = "label2";
            label2.Size = new Size(2675, 38);
            label2.TabIndex = 1;
            label2.Text = resources.GetString("label2.Text");
            // 
            // forest
            // 
            forest.BackColor = Color.Gray;
            forest.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            forest.ForeColor = Color.FromArgb(64, 64, 64);
            forest.Location = new Point(496, 412);
            forest.Name = "forest";
            forest.Size = new Size(94, 39);
            forest.TabIndex = 2;
            forest.Text = "Лес";
            forest.UseVisualStyleBackColor = false;
            forest.Click += forest_Click;
            // 
            // castle
            // 
            castle.BackColor = Color.Gray;
            castle.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            castle.ForeColor = Color.FromArgb(64, 64, 64);
            castle.Location = new Point(662, 412);
            castle.Name = "castle";
            castle.Size = new Size(94, 39);
            castle.TabIndex = 3;
            castle.Text = "Замок";
            castle.UseVisualStyleBackColor = false;
            castle.Click += castle_Click;
            // 
            // firstChoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(castle);
            Controls.Add(forest);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "firstChoice";
            Text = "firstChoice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button forest;
        private Button castle;
    }
}