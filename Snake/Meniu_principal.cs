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

    public partial class Meniu_principal : Form
    {
        
        public Meniu_principal()
        {
            InitializeComponent();
            
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Play_button.ForeColor = Color.White;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            Play_button.ForeColor = Color.Black;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Alegere_nivel f = new Alegere_nivel();
            f.Show();
            f.Location = this.Location;
            this.Hide();
        }

        

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.White;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Black;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Instructiuni i = new Instructiuni();
            i.Show();
            i.Location = this.Location;
            this.Hide();
        }
    }
}
