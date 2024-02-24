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
    public partial class Instructiuni : Form
    {
        public Instructiuni()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Meniu_principal m = new Meniu_principal();
            m.Show();
            m.Location = this.Location;
            this.Hide();
        }
    }
}
