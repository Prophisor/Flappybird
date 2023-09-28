using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flaggy_Bird_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {


            InitializeComponent();
        }
        int pipeSpeed = 8; // sppd in left direction
        int birdSpeed = 14; // down and up 
        int score = 0;
        private void pipeTop_Click(object sender, EventArgs e)
        {

        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            GameTimer();
        }

        private void GameTimer()
        {
            flaggyBird.Top += birdSpeed;
            pipeButtom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score;
            if (gameTime.Enabled == true)
            {
                button1.Enabled = false;
            }
            if (pipeButtom.Left < -150)
            {
                pipeButtom.Left = 800;
                score++;
            }
            if (pipeTop.Left < -150)
            {
                pipeTop.Left = 900;
                score++;
            }
            if (flaggyBird.Bounds.IntersectsWith(pipeButtom.Bounds) ||
                flaggyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flaggyBird.Bounds.IntersectsWith(ground.Bounds) ||
                flaggyBird.Top < -25)
            {
                endGame();
            }
            if (score == 10)
            {
                pipeSpeed = 10;
            }
            if (score == 20)
            {
                pipeSpeed = 13;
            }
            if (score == 30)
            {
                pipeSpeed = 15;
            }
            if (score == 60)
            {
                pipeSpeed = 17;
            }
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            GameKeyisdown(e);
        }

        private void GameKeyisdown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                birdSpeed = -15;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            GameKeyisup(e);
        }

        private void GameKeyisup(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                birdSpeed = +15;
            }
        }

        private void flaggyBird_Click(object sender, EventArgs e)
        {


        }
        private void endGame()
        {
            gameTime.Stop();
            scoreText.Text += " Game over!!";
            scoreText.BackColor = Color.CadetBlue;
            if (gameTime.Enabled == false)
            {
                button1.Enabled = true;
            }
        }

        private void scoreText_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            gameTime.Enabled = true;
            flaggyBird.Top = birdSpeed;
           pipeButtom.Left = 950;
            pipeTop.Left = 500;
            score = 0;
        }

        private void pipeButtom_Click(object sender, EventArgs e)
        {

        }
    }
}
