namespace DinoJuegoVers
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Piso = new PictureBox();
            Trex = new PictureBox();
            Obstacle1 = new PictureBox();
            Obstaculo2 = new PictureBox();
            scoreText = new Label();
            GameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Piso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Trex).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Obstacle1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Obstaculo2).BeginInit();
            SuspendLayout();
            // 
            // Piso
            // 
            Piso.BackColor = Color.Black;
            Piso.Location = new Point(-12, 452);
            Piso.Name = "Piso";
            Piso.Size = new Size(652, 50);
            Piso.TabIndex = 0;
            Piso.TabStop = false;
            Piso.Click += pictureBox1_Click;
            // 
            // Trex
            // 
            Trex.BackColor = Color.White;
            Trex.Image = Properties.Resources.running;
            Trex.Location = new Point(131, 385);
            Trex.Name = "Trex";
            Trex.Size = new Size(44, 60);
            Trex.SizeMode = PictureBoxSizeMode.StretchImage;
            Trex.TabIndex = 1;
            Trex.TabStop = false;
            // 
            // Obstacle1
            // 
            Obstacle1.Image = Properties.Resources.obstacle_1;
            Obstacle1.Location = new Point(379, 408);
            Obstacle1.Name = "Obstacle1";
            Obstacle1.Size = new Size(23, 46);
            Obstacle1.SizeMode = PictureBoxSizeMode.AutoSize;
            Obstacle1.TabIndex = 2;
            Obstacle1.TabStop = false;
            Obstacle1.Tag = "obstaculo";
            // 
            // Obstaculo2
            // 
            Obstaculo2.Image = Properties.Resources.obstacle_2;
            Obstaculo2.Location = new Point(535, 404);
            Obstaculo2.Name = "Obstaculo2";
            Obstaculo2.Size = new Size(50, 50);
            Obstaculo2.SizeMode = PictureBoxSizeMode.StretchImage;
            Obstaculo2.TabIndex = 3;
            Obstaculo2.TabStop = false;
            Obstaculo2.Tag = "obstaculo";
            Obstaculo2.Click += pictureBox4_Click;
            // 
            // scoreText
            // 
            scoreText.AutoSize = true;
            scoreText.Font = new Font("Myanmar Text", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            scoreText.Location = new Point(13, 13);
            scoreText.Name = "scoreText";
            scoreText.Size = new Size(98, 34);
            scoreText.TabIndex = 4;
            scoreText.Text = "SCORE- 0";
            scoreText.Click += label1_Click;
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Interval = 20;
            GameTimer.Tick += gameEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 475);
            Controls.Add(scoreText);
            Controls.Add(Obstaculo2);
            Controls.Add(Obstacle1);
            Controls.Add(Trex);
            Controls.Add(Piso);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += keyisdown;
            KeyUp += keyisup;
            ((System.ComponentModel.ISupportInitialize)Piso).EndInit();
            ((System.ComponentModel.ISupportInitialize)Trex).EndInit();
            ((System.ComponentModel.ISupportInitialize)Obstacle1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Obstaculo2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Piso;
        private PictureBox Trex;
        private PictureBox Obstacle1;
        private PictureBox Obstaculo2;
        private Label scoreText;
        private System.Windows.Forms.Timer GameTimer;
    }
}