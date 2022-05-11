using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szofttech_Beadando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "\uE779";
            button2.Text = "\uE736";
            button3.Text = "\uE929";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            ProfilForm profilForm = new ProfilForm();
            profilForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KonyvForm konyvForm = new KonyvForm();
            konyvForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RendelesForm rendelesForm = new RendelesForm();
            rendelesForm.ShowDialog();
        }
    }
}
