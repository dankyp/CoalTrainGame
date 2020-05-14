using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoalTrainGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pointsLabel.Visible = true;
            gameover.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hat(gamespeed);
            enemy(gamespeed);
            gameOver();
            hatCollection();
        }

        int collectedHats = 0;

        Random r = new Random();
        int x;

        void enemy (int speed)
        {
            if (enemy1.Top >= 500)
            {
                x = r.Next(400, 800);
                enemy1.Location = new Point(x, 0);
            }
            else
            { enemy1.Top += speed; }

            if (enemy2.Top >= 500)
            {
                x = r.Next(200, 700);
                enemy2.Location = new Point(x, 0);
            }
            else
            { enemy2.Top += speed; }

            if (enemy3.Top >= 500)
            {
                x = r.Next(0, 500);
                enemy3.Location = new Point(x, 0);
            }
            else
            { enemy3.Top += speed; }
        }

        void hat (int speed)
        {
            if (hat1.Top >= 500)
            {
                x = r.Next(50, 800);
                hat1.Location = new Point(x, 0);
            }
            else
            { hat1.Top += speed; }

            if (hat2.Top >= 500)
            {
                x = r.Next(200, 600);
                hat2.Location = new Point(x, 0);
            }
            else
            { hat2.Top += speed; }

            if (hat3.Top >= 500)
            {
                x = r.Next(400, 850);
                hat3.Location = new Point(x, 0);
            }
            else
            { hat3.Top += speed; }

            if (hat4.Top >= 500)
            {
                x = r.Next(50, 300);
                hat4.Location = new Point(x, 0);
            }
            else
            { hat4.Top += speed; }

            if (santaHat.Top >= 500)
            {
                x = r.Next(50, 800);
                santaHat.Location = new Point(x, 0);
            }
            else
            { santaHat.Top += speed; }

            if (penguinHat.Top >= 500)
            {
                x = r.Next(50, 800);
                penguinHat.Location = new Point(x, 0);
            }
            else
            { penguinHat.Top += speed; }
        }

        void gameOver()
        {
            if (train1.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                gameover.Visible = true;
            }
            if (train1.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                gameover.Visible = true;
            }
            if (train1.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                gameover.Visible = true;
            }
        }

        void hatCollection()
        {
            if (train1.Bounds.IntersectsWith(hat1.Bounds))
            {
                collectedHats++;
                pointsLabel.Text = "Hats = " + collectedHats.ToString();
                x = r.Next(50, 800);
                hat1.Location = new Point(x, 0);
            }

            if (train1.Bounds.IntersectsWith(hat2.Bounds))
            {
                collectedHats++;
                pointsLabel.Text = "Hats = " + collectedHats.ToString();
                x = r.Next(200, 600);
                hat2.Location = new Point(x, 0);
            }

            if (train1.Bounds.IntersectsWith(hat3.Bounds))
            {
                collectedHats++;
                pointsLabel.Text = "Hats = " + collectedHats.ToString();
                x = r.Next(400, 850);
                hat3.Location = new Point(x, 0);
            }

            if (train1.Bounds.IntersectsWith(hat4.Bounds))
            {
                collectedHats++;
                pointsLabel.Text = "Hats = " + collectedHats.ToString();
                x = r.Next(50, 300);
                hat4.Location = new Point(x, 0);
            }

            if (train1.Bounds.IntersectsWith(santaHat.Bounds))
            {
                collectedHats = collectedHats + 5;
                pointsLabel.Text = "Hats = " + collectedHats.ToString();
                x = r.Next(50, 800);
                santaHat.Location = new Point(x, 0);
            }

            if (train1.Bounds.IntersectsWith(penguinHat.Bounds))
            {
                collectedHats = collectedHats + 3;
                pointsLabel.Text = "Hats = " + collectedHats.ToString();
                x = r.Next(50, 800);
                penguinHat.Location = new Point(x, 0);
            }
        }

        int gamespeed = 1;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (train1.Left > 15)
                {
                    train1.Left -= 15;
                }
            }

            if (e.KeyCode == Keys.Right)
            {
                if (train1.Left < 500)
                {
                    train1.Left += 15;
                }
            }

            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                {
                    gamespeed++;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 1)
                {
                    gamespeed--;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
