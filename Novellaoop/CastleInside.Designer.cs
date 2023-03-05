namespace Novellaoop
{
    partial class CastleInside
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CastleInside));
            label1 = new Label();
            label2 = new Label();
            dontgo = new Button();
            gothere = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 255);
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(192, 0, 192);
            label1.Location = new Point(-5, 374);
            label1.Name = "label1";
            label1.Size = new Size(1690, 38);
            label1.TabIndex = 0;
            label1.Text = "А тут симпатично...                                                                                                                                                                           ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 192, 255);
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(192, 0, 192);
            label2.Location = new Point(-5, 412);
            label2.Name = "label2";
            label2.Size = new Size(1573, 38);
            label2.TabIndex = 1;
            label2.Text = "Кажется, я слышу голоса...Здесь есть люди!                                                                                                                    ";
            // 
            // dontgo
            // 
            dontgo.BackColor = Color.FromArgb(255, 192, 255);
            dontgo.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dontgo.ForeColor = Color.FromArgb(192, 0, 192);
            dontgo.Location = new Point(668, 374);
            dontgo.Name = "dontgo";
            dontgo.Size = new Size(114, 76);
            dontgo.TabIndex = 2;
            dontgo.Text = "Не идти к ним";
            dontgo.UseVisualStyleBackColor = false;
            dontgo.Click += dontgo_Click;
            // 
            // gothere
            // 
            gothere.BackColor = Color.FromArgb(255, 192, 255);
            gothere.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            gothere.ForeColor = Color.FromArgb(192, 0, 192);
            gothere.Location = new Point(428, 374);
            gothere.Name = "gothere";
            gothere.Size = new Size(192, 44);
            gothere.TabIndex = 3;
            gothere.Text = "Пойти к ним";
            gothere.UseVisualStyleBackColor = false;
            gothere.Click += gothere_Click;
            // 
            // CastleInside
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(gothere);
            Controls.Add(dontgo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CastleInside";
            Text = "CastleInside";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button dontgo;
        private Button gothere;
    }
}