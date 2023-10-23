namespace RexJump
{
    public partial class Form1 : Form
    {

        bool jumping = false;
        int jumpSpeed = 12;
        int force = 12;
        int puntaje = 0;
        int obstacleSpeed = 10;

        Random random = new Random();
        int position;
        bool isGameOver=false;



        public Form1()
        {
            InitializeComponent();
            GameReset();

        }



        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            Rex.Top += jumpSpeed;
            score.Text = "Score: " + puntaje;
            if (jumping==true && force < 0)
            {
                jumping = false;
            }
            if (jumping == true)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }

            if(Rex.Top > 372 && jumping == false)
            {
                force = 12;
                Rex.Top = 373;
                jumpSpeed = 0;

            }

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed;

                    if (x.Left < -100)
                    {
                        x.Left=this.ClientSize.Width+random.Next(200,500)+(x.Width*15);
                        puntaje++;
                    }

                    if (Rex.Bounds.IntersectsWith(x.Bounds))
                    {
                        gametimer.Stop();
                        Rex.Image = Properties.Resources.dead;
                        score.Text += "                              Presioná R para resetear el juego!";
                        isGameOver = true;

                    }
                }
            }

            if (puntaje > 10)
            {
                obstacleSpeed = 15;
            }
            if (puntaje > 30)
            {
                obstacleSpeed = 20;
            }
            if (puntaje > 60)
            {
                obstacleSpeed = 25;
            }
            if (puntaje > 100)
            {
                obstacleSpeed = 30;
            }
        }
        

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;
            }

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (jumping == true)
            {
                jumping = false;
            }
            if(e.KeyCode==Keys.R && isGameOver == true)
            {
                GameReset();
            }
        }

        private void GameReset()
        {
            force = 12;
            jumpSpeed = 0;
            jumping = false;
            puntaje = 0;
            obstacleSpeed = 10;
            score.Text = "Score: " + puntaje;
            Rex.Image = Properties.Resources.running;
            isGameOver = false;
            Rex.Top = 373;

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag == "obstacle")
                {
                    position = this.ClientSize.Width + random.Next(500, 800) + (x.Width * 10);

                    x.Left = position;

                }
            }

            gametimer.Start();

        }
    }
}