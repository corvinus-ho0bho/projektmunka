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
    public partial class KonyvForm : Form
    {
        Database1Entities context = new Database1Entities();
        public KonyvForm()
        {
            InitializeComponent();
            KonyvLista();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            KonyvLista();
        }

        private void KonyvLista()
        {
            var konyv = from x in context.Konyv
                        where x.Nev.Contains(textBox1.Text)
                        select x;
            listBox1.DataSource = konyv.ToList();
            listBox1.DisplayMember = "idKonyv";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kivalasztottAdat = (Konyv)(listBox1.SelectedItem);
            var eredmeny = from x in context.Konyv
                           where x.idKonyv == kivalasztottAdat.idKonyv
                            select new
                            {
                                x.Nev,x.Iro, x.Ar, x.Keszlet, Raktar = x.Raktar.Nev
                            };
            dataGridView1.DataSource = eredmeny.ToList();
        }
    }
}
