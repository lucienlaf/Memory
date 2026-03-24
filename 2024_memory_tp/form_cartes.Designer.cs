namespace _2024_memory_tp
{
    partial class form_cartes
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
            buttonQuitter = new Button();
            label1 = new Label();
            titreChoissisez = new Label();
            snakeImage = new Button();
            bombermanImage = new Button();
            pacmanImage = new Button();
            wormsImage = new Button();
            tetrisImage = new Button();
            snake = new Label();
            bomberman = new Label();
            pacman = new Label();
            worms = new Label();
            tetris = new Label();
            buttonValider = new Button();
            minecraftImage = new Button();
            demineurImage = new Button();
            kirbyImage = new Button();
            raymanImage = new Button();
            donkeykongImage = new Button();
            demineur = new Label();
            kirby = new Label();
            minecraft = new Label();
            rayman = new Label();
            donkeykong = new Label();
            SuspendLayout();
            // 
            // buttonQuitter
            // 
            buttonQuitter.BackgroundImage = Properties.Resources.quitter_small;
            buttonQuitter.BackgroundImageLayout = ImageLayout.Stretch;
            buttonQuitter.Location = new Point(753, 607);
            buttonQuitter.Name = "buttonQuitter";
            buttonQuitter.Size = new Size(59, 65);
            buttonQuitter.TabIndex = 20;
            buttonQuitter.UseVisualStyleBackColor = true;
            buttonQuitter.Click += buttonQuitter_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Comic Sans MS", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(824, 58);
            label1.TabIndex = 21;
            label1.Text = "Memory";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // titreChoissisez
            // 
            titreChoissisez.BackColor = Color.Transparent;
            titreChoissisez.Dock = DockStyle.Top;
            titreChoissisez.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Italic);
            titreChoissisez.Location = new Point(0, 58);
            titreChoissisez.Name = "titreChoissisez";
            titreChoissisez.Size = new Size(824, 39);
            titreChoissisez.TabIndex = 22;
            titreChoissisez.Text = "Choissisez un total de ";
            titreChoissisez.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // snakeImage
            // 
            snakeImage.BackColor = Color.Gainsboro;
            snakeImage.BackgroundImage = Properties.Resources.snake;
            snakeImage.BackgroundImageLayout = ImageLayout.Stretch;
            snakeImage.Cursor = Cursors.Hand;
            snakeImage.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            snakeImage.FlatAppearance.BorderSize = 3;
            snakeImage.FlatStyle = FlatStyle.Flat;
            snakeImage.ForeColor = SystemColors.ControlText;
            snakeImage.Location = new Point(68, 192);
            snakeImage.Name = "snakeImage";
            snakeImage.Size = new Size(116, 115);
            snakeImage.TabIndex = 23;
            snakeImage.Tag = "snake";
            snakeImage.UseVisualStyleBackColor = false;
            snakeImage.Click += button_Click;
            // 
            // bombermanImage
            // 
            bombermanImage.BackColor = Color.Gainsboro;
            bombermanImage.BackgroundImage = Properties.Resources.bomberman;
            bombermanImage.BackgroundImageLayout = ImageLayout.Stretch;
            bombermanImage.Cursor = Cursors.Hand;
            bombermanImage.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            bombermanImage.FlatAppearance.BorderSize = 3;
            bombermanImage.FlatStyle = FlatStyle.Flat;
            bombermanImage.Location = new Point(211, 192);
            bombermanImage.Name = "bombermanImage";
            bombermanImage.Size = new Size(116, 115);
            bombermanImage.TabIndex = 24;
            bombermanImage.Tag = "bomberman";
            bombermanImage.UseVisualStyleBackColor = false;
            bombermanImage.Click += button_Click;
            // 
            // pacmanImage
            // 
            pacmanImage.BackColor = Color.Gainsboro;
            pacmanImage.BackgroundImage = Properties.Resources.pacman;
            pacmanImage.BackgroundImageLayout = ImageLayout.Stretch;
            pacmanImage.Cursor = Cursors.Hand;
            pacmanImage.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            pacmanImage.FlatAppearance.BorderSize = 3;
            pacmanImage.FlatStyle = FlatStyle.Flat;
            pacmanImage.Location = new Point(350, 192);
            pacmanImage.Name = "pacmanImage";
            pacmanImage.Size = new Size(116, 115);
            pacmanImage.TabIndex = 25;
            pacmanImage.Tag = "pacman";
            pacmanImage.UseVisualStyleBackColor = false;
            pacmanImage.Click += button_Click;
            // 
            // wormsImage
            // 
            wormsImage.BackColor = Color.Gainsboro;
            wormsImage.BackgroundImage = Properties.Resources.worms;
            wormsImage.BackgroundImageLayout = ImageLayout.Stretch;
            wormsImage.Cursor = Cursors.Hand;
            wormsImage.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            wormsImage.FlatAppearance.BorderSize = 3;
            wormsImage.FlatStyle = FlatStyle.Flat;
            wormsImage.Location = new Point(493, 192);
            wormsImage.Name = "wormsImage";
            wormsImage.Size = new Size(116, 115);
            wormsImage.TabIndex = 26;
            wormsImage.Tag = "worms";
            wormsImage.UseVisualStyleBackColor = false;
            wormsImage.Click += button_Click;
            // 
            // tetrisImage
            // 
            tetrisImage.BackColor = Color.Gainsboro;
            tetrisImage.BackgroundImage = Properties.Resources.tetris;
            tetrisImage.BackgroundImageLayout = ImageLayout.Stretch;
            tetrisImage.Cursor = Cursors.Hand;
            tetrisImage.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            tetrisImage.FlatAppearance.BorderSize = 3;
            tetrisImage.FlatStyle = FlatStyle.Flat;
            tetrisImage.Location = new Point(633, 192);
            tetrisImage.Name = "tetrisImage";
            tetrisImage.Size = new Size(116, 115);
            tetrisImage.TabIndex = 27;
            tetrisImage.Tag = "tetris";
            tetrisImage.UseVisualStyleBackColor = false;
            tetrisImage.Click += button_Click;
            // 
            // snake
            // 
            snake.Anchor = AnchorStyles.None;
            snake.BackColor = Color.IndianRed;
            snake.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            snake.ForeColor = Color.FromArgb(128, 255, 128);
            snake.Location = new Point(97, 310);
            snake.Name = "snake";
            snake.Size = new Size(57, 20);
            snake.TabIndex = 28;
            snake.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bomberman
            // 
            bomberman.Anchor = AnchorStyles.None;
            bomberman.BackColor = Color.IndianRed;
            bomberman.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            bomberman.ForeColor = Color.FromArgb(128, 255, 128);
            bomberman.Location = new Point(242, 310);
            bomberman.Name = "bomberman";
            bomberman.Size = new Size(57, 20);
            bomberman.TabIndex = 29;
            bomberman.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pacman
            // 
            pacman.Anchor = AnchorStyles.None;
            pacman.BackColor = Color.IndianRed;
            pacman.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            pacman.ForeColor = Color.FromArgb(128, 255, 128);
            pacman.Location = new Point(380, 310);
            pacman.Name = "pacman";
            pacman.Size = new Size(57, 20);
            pacman.TabIndex = 30;
            pacman.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // worms
            // 
            worms.Anchor = AnchorStyles.None;
            worms.BackColor = Color.IndianRed;
            worms.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            worms.ForeColor = Color.FromArgb(128, 255, 128);
            worms.Location = new Point(522, 310);
            worms.Name = "worms";
            worms.Size = new Size(57, 20);
            worms.TabIndex = 31;
            worms.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tetris
            // 
            tetris.Anchor = AnchorStyles.None;
            tetris.BackColor = Color.IndianRed;
            tetris.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            tetris.ForeColor = Color.FromArgb(128, 255, 128);
            tetris.Location = new Point(662, 310);
            tetris.Name = "tetris";
            tetris.Size = new Size(57, 20);
            tetris.TabIndex = 32;
            tetris.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonValider
            // 
            buttonValider.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 224, 192);
            buttonValider.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 128);
            buttonValider.FlatStyle = FlatStyle.Popup;
            buttonValider.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonValider.ForeColor = Color.LimeGreen;
            buttonValider.Location = new Point(224, 586);
            buttonValider.Name = "buttonValider";
            buttonValider.Size = new Size(385, 65);
            buttonValider.TabIndex = 33;
            buttonValider.Text = "Valider";
            buttonValider.UseVisualStyleBackColor = true;
            buttonValider.Click += buttonValider_Click;
            // 
            // minecraftImage
            // 
            minecraftImage.BackColor = Color.Gainsboro;
            minecraftImage.BackgroundImage = Properties.Resources.minecraft;
            minecraftImage.BackgroundImageLayout = ImageLayout.Stretch;
            minecraftImage.Cursor = Cursors.Hand;
            minecraftImage.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            minecraftImage.FlatAppearance.BorderSize = 3;
            minecraftImage.FlatStyle = FlatStyle.Flat;
            minecraftImage.Location = new Point(350, 344);
            minecraftImage.Name = "minecraftImage";
            minecraftImage.Size = new Size(116, 115);
            minecraftImage.TabIndex = 34;
            minecraftImage.Tag = "minecraft";
            minecraftImage.UseVisualStyleBackColor = false;
            minecraftImage.Click += button_Click;
            // 
            // demineurImage
            // 
            demineurImage.BackColor = Color.Gainsboro;
            demineurImage.BackgroundImage = Properties.Resources.demineur;
            demineurImage.BackgroundImageLayout = ImageLayout.Stretch;
            demineurImage.Cursor = Cursors.Hand;
            demineurImage.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            demineurImage.FlatAppearance.BorderSize = 3;
            demineurImage.FlatStyle = FlatStyle.Flat;
            demineurImage.ForeColor = SystemColors.ControlText;
            demineurImage.Location = new Point(68, 344);
            demineurImage.Name = "demineurImage";
            demineurImage.Size = new Size(116, 115);
            demineurImage.TabIndex = 35;
            demineurImage.Tag = "demineur";
            demineurImage.UseVisualStyleBackColor = false;
            demineurImage.Click += button_Click;
            // 
            // kirbyImage
            // 
            kirbyImage.BackColor = Color.Gainsboro;
            kirbyImage.BackgroundImage = Properties.Resources.kirby;
            kirbyImage.BackgroundImageLayout = ImageLayout.Stretch;
            kirbyImage.Cursor = Cursors.Hand;
            kirbyImage.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            kirbyImage.FlatAppearance.BorderSize = 3;
            kirbyImage.FlatStyle = FlatStyle.Flat;
            kirbyImage.ForeColor = SystemColors.ControlText;
            kirbyImage.Location = new Point(211, 344);
            kirbyImage.Name = "kirbyImage";
            kirbyImage.Size = new Size(116, 115);
            kirbyImage.TabIndex = 36;
            kirbyImage.Tag = "kirby";
            kirbyImage.UseVisualStyleBackColor = false;
            kirbyImage.Click += button_Click;
            // 
            // raymanImage
            // 
            raymanImage.BackColor = Color.Gainsboro;
            raymanImage.BackgroundImage = Properties.Resources.rayman;
            raymanImage.BackgroundImageLayout = ImageLayout.Stretch;
            raymanImage.Cursor = Cursors.Hand;
            raymanImage.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            raymanImage.FlatAppearance.BorderSize = 3;
            raymanImage.FlatStyle = FlatStyle.Flat;
            raymanImage.ForeColor = SystemColors.ControlText;
            raymanImage.Location = new Point(493, 344);
            raymanImage.Name = "raymanImage";
            raymanImage.Size = new Size(116, 115);
            raymanImage.TabIndex = 37;
            raymanImage.Tag = "rayman";
            raymanImage.UseVisualStyleBackColor = false;
            raymanImage.Click += button_Click;
            // 
            // donkeykongImage
            // 
            donkeykongImage.BackColor = Color.Gainsboro;
            donkeykongImage.BackgroundImage = Properties.Resources.donkeykong;
            donkeykongImage.BackgroundImageLayout = ImageLayout.Stretch;
            donkeykongImage.Cursor = Cursors.Hand;
            donkeykongImage.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            donkeykongImage.FlatAppearance.BorderSize = 3;
            donkeykongImage.FlatStyle = FlatStyle.Flat;
            donkeykongImage.ForeColor = SystemColors.ControlText;
            donkeykongImage.Location = new Point(633, 344);
            donkeykongImage.Name = "donkeykongImage";
            donkeykongImage.Size = new Size(116, 115);
            donkeykongImage.TabIndex = 38;
            donkeykongImage.Tag = "donkeykong";
            donkeykongImage.UseVisualStyleBackColor = false;
            donkeykongImage.Click += button_Click;
            // 
            // demineur
            // 
            demineur.Anchor = AnchorStyles.None;
            demineur.BackColor = Color.IndianRed;
            demineur.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            demineur.ForeColor = Color.FromArgb(128, 255, 128);
            demineur.Location = new Point(97, 462);
            demineur.Name = "demineur";
            demineur.Size = new Size(57, 20);
            demineur.TabIndex = 39;
            demineur.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kirby
            // 
            kirby.Anchor = AnchorStyles.None;
            kirby.BackColor = Color.IndianRed;
            kirby.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            kirby.ForeColor = Color.FromArgb(128, 255, 128);
            kirby.Location = new Point(242, 462);
            kirby.Name = "kirby";
            kirby.Size = new Size(57, 20);
            kirby.TabIndex = 40;
            kirby.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minecraft
            // 
            minecraft.Anchor = AnchorStyles.None;
            minecraft.BackColor = Color.IndianRed;
            minecraft.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            minecraft.ForeColor = Color.FromArgb(128, 255, 128);
            minecraft.Location = new Point(380, 462);
            minecraft.Name = "minecraft";
            minecraft.Size = new Size(57, 20);
            minecraft.TabIndex = 41;
            minecraft.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rayman
            // 
            rayman.Anchor = AnchorStyles.None;
            rayman.BackColor = Color.IndianRed;
            rayman.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            rayman.ForeColor = Color.FromArgb(128, 255, 128);
            rayman.Location = new Point(522, 462);
            rayman.Name = "rayman";
            rayman.Size = new Size(57, 20);
            rayman.TabIndex = 42;
            rayman.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // donkeykong
            // 
            donkeykong.Anchor = AnchorStyles.None;
            donkeykong.BackColor = Color.IndianRed;
            donkeykong.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic);
            donkeykong.ForeColor = Color.FromArgb(128, 255, 128);
            donkeykong.Location = new Point(662, 462);
            donkeykong.Name = "donkeykong";
            donkeykong.Size = new Size(57, 20);
            donkeykong.TabIndex = 43;
            donkeykong.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // form_cartes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fond_jeux_video_fili_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(824, 684);
            ControlBox = false;
            Controls.Add(donkeykong);
            Controls.Add(rayman);
            Controls.Add(minecraft);
            Controls.Add(kirby);
            Controls.Add(demineur);
            Controls.Add(donkeykongImage);
            Controls.Add(raymanImage);
            Controls.Add(kirbyImage);
            Controls.Add(demineurImage);
            Controls.Add(minecraftImage);
            Controls.Add(buttonValider);
            Controls.Add(tetris);
            Controls.Add(worms);
            Controls.Add(pacman);
            Controls.Add(bomberman);
            Controls.Add(snake);
            Controls.Add(tetrisImage);
            Controls.Add(wormsImage);
            Controls.Add(pacmanImage);
            Controls.Add(bombermanImage);
            Controls.Add(snakeImage);
            Controls.Add(titreChoissisez);
            Controls.Add(label1);
            Controls.Add(buttonQuitter);
            Name = "form_cartes";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonQuitter;
        private Label label1;
        private Label titreChoissisez;
        private Button snakeImage;
        private Button bombermanImage;
        private Button pacmanImage;
        private Button wormsImage;
        private Button tetrisImage;
        private Label snake;
        private Label bomberman;
        private Label pacman;
        private Label worms;
        private Label tetris;
        private Button buttonValider;
        private Button minecraftImage;
        private Button demineurImage;
        private Button kirbyImage;
        private Button raymanImage;
        private Button donkeykongImage;
        private Label demineur;
        private Label kirby;
        private Label minecraft;
        private Label rayman;
        private Label donkeykong;
    }
}