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
    public partial class Alegere_nivel : Form
    {
        public Alegere_nivel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Joc1 j1 = new Joc1();
            j1.Show();
            j1.Location = this.Location;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Joc2 j2 = new Joc2();
            j2.Show();
            j2.Location = this.Location;
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Joc3 j3 = new Joc3();
            j3.Show();
            j3.Location = this.Location;
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Meniu_principal m = new Meniu_principal();
            m.Show();
            m.Location = this.Location;
            this.Hide();
        }
    }
}
