using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JetFinal
{
    public partial class JetGame : Form
    {

        bool GoLeft, GoRight, Shooting, IsGameOver;
        int score;
        int PlayerSpeed = 20;
        int enemySpeed;
        int BulletSpeed;
        Random random = new Random();
        public JetGame()
        {
            InitializeComponent();
            ResetGame();
        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            if(GoLeft== true && Player.Left >0)
            {
                Player.Left -= PlayerSpeed;
            }
            if(GoRight == true && Player.Left<750)
            {
                Player.Left += PlayerSpeed;
            }


        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Player.set = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                GoRight = false;
            }

        }

        //private void JetGame_Load(object sender, EventArgs e)
        //{

        //}

        //private void pictureBox3_Click(object sender, EventArgs e)
        //{

        //}

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Left)
            {
                GoLeft = true;
            }
            if(e.KeyCode==Keys.Right)
            {
                GoRight = true;
            }

        }
        private void ResetGame()
        {
            gameTimer.Start();
        }

        private void GameOver()
        {

        }
    }
}
