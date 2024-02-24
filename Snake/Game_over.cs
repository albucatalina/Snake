using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Game_over : Form
    {

        public Game_over()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.White;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Black;
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.White;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Black;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (label4.Text == "1")
            {
                Joc1 j = new Joc1();
                j.Show();
                j.Location = this.Location;
                this.Hide();
            }
            else if (label4.Text == "2")
            {
                Joc2 j = new Joc2();
                j.Show();
                j.Location = this.Location;
                this.Hide();
            }
            else if (label4.Text == "3")
            {
                Joc3 j = new Joc3();
                j.Show();
                j.Location = this.Location;
                this.Hide();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Meniu_principal m = new Meniu_principal();
            m.Show();
            m.Location = this.Location;
            this.Hide();
        }
    }
}
