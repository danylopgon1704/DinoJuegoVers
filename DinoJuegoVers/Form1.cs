namespace DinoJuegoVers
{
    public partial class Form1 : Form
    {
        bool saltar = false; // Boooleano para verificar si esta saltando o no, se usara para determinar si el dinosaurio ha saltado en el juego.
        int velocidadSalto = 10; // Este entero establece la velocidad del salto
        int fuerza = 12; // Fuerza del salto establecida en enteros
        int puntuaje = 0; // Puntuaje en entero se establece desde 0
        int fuerzaObstaculo = 10; // Velocidad en enteros en la que van los obstaculos
        Random rnd = new Random(); // Crea una nueva clase aleatoria

        public Form1()
        {
            InitializeComponent();

            resetGame(); // Funci�n de reinicio de juego
        }

        private void gameEvent(object sender, EventArgs e)
        {
            Trex.Top += velocidadSalto;

            scoreText.Text = "Score: " + puntuaje;


            if (saltar && fuerza < 0)
            {
                saltar = true;
            }

            if (saltar)
            {
                velocidadSalto = -12;
                fuerza -= 1;
            }

            else
            {
                velocidadSalto = 12;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "obstaculo")
                {
                    x.Left -= fuerzaObstaculo;

                    if (x.Left + x.Width < -120)
                    {
                        x.Left = this.ClientSize.Width + rnd.Next(200, 800);
                        puntuaje++;
                    }

                    if (Trex.Bounds.IntersectsWith(x.Bounds))
                    {
                        GameTimer.Stop();

                        Trex.Image = Properties.Resources.dead;

                        scoreText.Text += "  Press R to restart";
                    }
                }
            }

            if (Trex.Top >= 380 && !saltar)
            {
                fuerza = 12;
                Trex.Top = Piso.Top - Trex.Height;
                velocidadSalto = 0;
            }

            if (puntuaje >= 10)
            {
                fuerzaObstaculo = 15;
            }
        }

        private void keyisdown(object sender, KeyEventArgs e) // Si se presiona la tecla de espacio, entonces el salto se vuelve verdadero
        {
            if (e.KeyCode == Keys.Space && !saltar)
            {
                saltar = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                resetGame();
            }

            if (saltar)
            {
                saltar = false;
            }
        }

        public void resetGame()
        {
            fuerza = 12;
            Trex.Top = Piso.Top - Trex.Height;
            velocidadSalto = 0;
            saltar = false;
            puntuaje = 0;
            fuerzaObstaculo = 10;
            scoreText.Text = "Score: " + puntuaje;
            Trex.Image = Properties.Resources.running;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "obstaculo")
                {
                    int posicion = rnd.Next(600, 1000);

                    x.Left = 640 + (x.Left + posicion + x.Width * 3);
                }
            }

            GameTimer.Start();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}