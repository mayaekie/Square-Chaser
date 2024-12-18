using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Square_Chaser
{
    public partial class Form1 : Form
    {
        // global variables
        Rectangle player1 = new Rectangle(475, 160, 30, 30);
        Rectangle player2 = new Rectangle(80, 160, 30, 30);
        Rectangle point = new Rectangle(280, 160, 15, 15);
        Rectangle speed = new Rectangle(220, 125, 15, 15);

        int player1Score = 0;
        int player2Score = 0;

        int playerTurn = 1;
        int playerSpeed1 = 4;
        int playerSpeed2 = 4;

        bool wPressed = false;
        bool sPressed = false;
        bool upPressed = false;
        bool downPressed = false;

        bool aPressed = false;
        bool dPressed = false;
        bool leftPressed = false;
        bool rightPressed = false;

        SolidBrush blueBrush = new SolidBrush(Color.DodgerBlue);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush redBrush = new SolidBrush(Color.Crimson);
        SolidBrush yellowBrush = new SolidBrush(Color.Gold);

        Random randGen = new Random();
        int random;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            p1Label.Text = $"{player1Score}";
            p2Label.Text = $"{player2Score}";

            e.Graphics.FillRectangle(redBrush, player1);
            e.Graphics.FillRectangle(blueBrush, player2);
            e.Graphics.FillRectangle(whiteBrush, point);
            e.Graphics.FillRectangle(yellowBrush, speed);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = true;
                    break;
                case Keys.S:
                    sPressed = true;
                    break;
                case Keys.Up:
                    upPressed = true;
                    break;
                case Keys.Down:
                    downPressed = true;
                    break;
                case Keys.A:
                    aPressed = true;
                    break;
                case Keys.D:
                    dPressed = true;
                    break;
                case Keys.Left:
                    leftPressed = true;
                    break;
                case Keys.Right:
                    rightPressed = true;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wPressed = false;
                    break;
                case Keys.S:
                    sPressed = false;
                    break;
                case Keys.Up:
                    upPressed = false;
                    break;
                case Keys.Down:
                    downPressed = false;
                    break;
                case Keys.A:
                    aPressed = false;
                    break;
                case Keys.D:
                    dPressed = false;
                    break;
                case Keys.Left:
                    leftPressed = false;
                    break;
                case Keys.Right:
                    rightPressed = false;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // move player 1
            if (wPressed == true && player1.Y > 0)
            {
                player1.Y -= playerSpeed1;
            }

            if (sPressed == true && player1.Y < this.Height - player1.Height)
            {
                player1.Y += playerSpeed1;
            }

            if (aPressed == true && player1.X > 0)
            {
                player1.X -= playerSpeed1;
            }

            if (dPressed == true && player1.X < this.Width - player1.Width)
            {
                player1.X += playerSpeed1;
            }

            // move player 2
            if (upPressed == true && player2.Y > 0)
            {
                player2.Y -= playerSpeed2;
            }

            if (downPressed == true && player2.Y < this.Height - player2.Height)
            {
                player2.Y += playerSpeed2;
            }
            if (leftPressed == true && player2.X > 0)
            {
                player2.X -= playerSpeed2;
            }
            if (rightPressed == true && player2.X < this.Width - player2.Width)
            {
                player2.X += playerSpeed2;
            }


            // if player hits point square
            if (player1.IntersectsWith(point))
            {
                player1Score += 1;
                point.X = randGen.Next(5, 200);
                point.Y = randGen.Next(this.Height - 180);

            }
            else if (player2.IntersectsWith(point))
            {
                player2Score += 1;
                point.X = randGen.Next(5, 200);
                point.Y = randGen.Next(this.Height - 25);
            }

            // if player hits speed boost
            if (player1.IntersectsWith(speed))
            {
                speed.X = randGen.Next(5, 200);
                speed.Y = randGen.Next(this.Height - 180);

            }
            else if (player2.IntersectsWith(speed))
            {
                speed.X = randGen.Next(5, 200);
                speed.Y = randGen.Next(this.Height - 25);
            }


            // speedboost interact and move
            if (player1.IntersectsWith(speed))
            {
                playerSpeed1 += 2;
            }
            else if (player2.IntersectsWith(speed))
            {
                playerSpeed2 += 2;
            }

            //wait 3 seconds, -3
            if (playerSpeed1 == 7)
            {
                speedTimer2.Enabled = true;
            }
            else if (playerSpeed2 == 7)
            {
                speedTimer1.Enabled = true;
            }

            // check score and end game
            if (player1Score == 5)
            {
                timer1.Stop();
            }

            if (player2Score == 5)
            {
                timer1.Stop();
            }




            Refresh();



        }


        private void speedTimer1_Tick(object sender, EventArgs e)
        {
            speedTimer1.Enabled = false;

            if (speedTimer1.Enabled == false)
            {
                playerSpeed1 -= 3;
            }
            else
            {

            }
        }

        private void speedTimer2_Tick(object sender, EventArgs e)
        {
            speedTimer2.Enabled = false;
            if (speedTimer1.Enabled == false)
            {
                playerSpeed2 -= 3;
            }
            else
            {

            }
        }
    }
}
