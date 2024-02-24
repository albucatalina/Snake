using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Snake
{
    public partial class Joc1 : Form
    {
        enum Direction
        {
            Right,Left,Up,Down
        }

       
        private Direction obj_direction;
        private Rectangle[] r = new Rectangle[1000];
        private int[] x = new int[1000];
        private int[] y = new int[1000];
        private int s = 20, n=1, i;
        public string scor;
        public int max = 0;

        private Random rnd = new Random();
        int xf, yf;

        public Joc1()
        {
            InitializeComponent();
            
            x[0] = 60; y[0] = 100;

            xf = rnd.Next(20, 620);
            yf = rnd.Next(60, 360);
            while (verif_food() == 0)
            {
                xf = rnd.Next(20, 620);
                yf = rnd.Next(60, 360);
            }

            obj_direction = Direction.Right;
        }

        private void Joc1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.DarkSeaGreen, 20, 60, 640, 380);

            r[0] = new Rectangle(x[0], y[0], 20, 20);
            e.Graphics.FillRectangle(Brushes.Black, r[0]);
            e.Graphics.DrawRectangle(Pens.Black, x[0], y[0], 20, 20);

            for (int i = 1; i < n; i++)
            {
                r[i] = new Rectangle(x[i], y[i], 20, 20);
                e.Graphics.FillRectangle(Brushes.Green, r[i]);
                e.Graphics.DrawRectangle(Pens.Black, x[i], y[i], 20, 20);
            }

            //food
            Rectangle rf = new Rectangle(xf, yf, 20, 20);
            e.Graphics.FillEllipse(Brushes.Red, rf);
        }

        private int verif_food()
        {
            if (xf % s != 0)
                return 0;
            if (yf % s != 0)
                return 0;

            for (i = 0; i < n; i++)
                if (xf == x[i] && yf == y[i])
                    return 0;
            return 1;
        }


        private int game_over()
        {
            //intersectia cu marginea
            if (x[0] < 20 || x[0] > 640 || y[0] < 60 || y[0] > 420)
                return 0;

            //intersectia cu corpul
            for (i = 1; i < n; i++)
                if (x[0] == x[i] && y[0] == y[i])
                    return 0;

            return 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (game_over() == 1)
            {
                for (i = n; i > 0; i--)
                {
                    x[i] = x[i - 1];
                    y[i] = y[i - 1];
                }

                switch (obj_direction)
                {
                    case Direction.Left:
                        x[0] -= s;
                        break;
                    case Direction.Right:
                        x[0] += s;
                        break;
                    case Direction.Up:
                        y[0] -= s;
                        break;
                    case Direction.Down:
                        y[0] += s;
                        break;
                }

                if (x[0] == xf && y[0] == yf)
                {
                    n++;
                    xf = rnd.Next(20, 620);
                    yf = rnd.Next(60, 360);
                    while (verif_food()==0)
                    {
                        xf = rnd.Next(20, 620);
                        yf = rnd.Next(60, 360);
                    }
                }

                scor = Convert.ToString(n * 10 - 10);
                label2.Text = scor;

                Invalidate();
            }
            else
            {
                timer1.Stop();
                Game_over g = new Game_over();
                g.Show();
                g.Location = this.Location;
                g.label2.Text = scor;
                g.label4.Text = "1";
                this.Hide();                

            }
        }

        private void Joc1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right && obj_direction != Direction.Left)
            {
                obj_direction = Direction.Right;
            }
            else if (e.KeyCode == Keys.Left && obj_direction != Direction.Right)
            {
                obj_direction = Direction.Left;
            }
            else if (e.KeyCode == Keys.Up && obj_direction != Direction.Down)
            {
                obj_direction = Direction.Up;
            }
            else if (e.KeyCode == Keys.Down && obj_direction != Direction.Up)
            {
                obj_direction = Direction.Down;
            }
        }

    }
}
