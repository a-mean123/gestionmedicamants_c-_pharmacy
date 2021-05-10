using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace samar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contact c = new Contact();
            c.Show();
        }

        private void Docteur_Click(object sender, EventArgs e)
        {
            Docteur d = new Docteur();
            d.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Medicament m = new Medicament();
            m.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Actualite a = new Actualite();
            a.Show();
        }
    }
}
