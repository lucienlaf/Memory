namespace _2024_memory_tp
{
    partial class form_menu
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
            buttonQuitter = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textCartes = new TextBox();
            buttonValider = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(834, 58);
            label1.TabIndex = 16;
            label1.Text = "Memory";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonQuitter
            // 
            buttonQuitter.BackgroundImage = Properties.Resources.quitter_small;
            buttonQuitter.BackgroundImageLayout = ImageLayout.Stretch;
            buttonQuitter.Location = new Point(763, 617);
            buttonQuitter.Name = "buttonQuitter";
            buttonQuitter.Size = new Size(59, 65);
            buttonQuitter.TabIndex = 19;
            buttonQuitter.UseVisualStyleBackColor = true;
            buttonQuitter.Click += buttonQuitter_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Italic);
            label2.Location = new Point(0, 58);
            label2.Name = "label2";
            label2.Size = new Size(834, 39);
            label2.TabIndex = 20;
            label2.Text = "Bienvenue dans le jeu du Memory !";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Italic);
            label3.Location = new Point(0, 97);
            label3.Name = "label3";
            label3.Size = new Size(834, 39);
            label3.TabIndex = 21;
            label3.Text = "Choissisez le nombre de paires";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 136);
            label4.Name = "label4";
            label4.Size = new Size(834, 39);
            label4.TabIndex = 22;
            label4.Text = "Minimum 2 paires";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textCartes
            // 
            textCartes.Font = new Font("Comic Sans MS", 8.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            textCartes.Location = new Point(268, 317);
            textCartes.Name = "textCartes";
            textCartes.Size = new Size(314, 23);
            textCartes.TabIndex = 23;
            textCartes.Text = "\r\n";
            // 
            // buttonValider
            // 
            buttonValider.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            buttonValider.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            buttonValider.FlatStyle = FlatStyle.Popup;
            buttonValider.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonValider.ForeColor = Color.LimeGreen;
            buttonValider.Location = new Point(302, 443);
            buttonValider.Name = "buttonValider";
            buttonValider.Size = new Size(250, 44);
            buttonValider.TabIndex = 24;
            buttonValider.Text = "Valider";
            buttonValider.UseVisualStyleBackColor = true;
            buttonValider.Click += buttonValider_Click;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(0, 175);
            label5.Name = "label5";
            label5.Size = new Size(834, 39);
            label5.TabIndex = 25;
            label5.Text = "Maximum 10 paires";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // form_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fond_jeux_video_fili_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(834, 694);
            ControlBox = false;
            Controls.Add(label5);
            Controls.Add(buttonValider);
            Controls.Add(textCartes);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonQuitter);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "form_menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button buttonQuitter;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textCartes;
        private Button buttonValider;
        private Label label5;
    }
}