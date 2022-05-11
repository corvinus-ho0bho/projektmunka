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
    public partial class ProfilForm : Form
    {
        Database1Entities context = new Database1Entities();
        public ProfilForm()
        {
            InitializeComponent();
            ProfilLista();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ProfilLista();

        }

        private void ProfilLista()
        {
            var profil = from x in context.Profil
                         where x.Nev.Contains(textBox1.Text)
                         select x;
            listBox1.DataSource = profil.ToList();
            listBox1.DisplayMember = "Nev";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var kivalasztottAdat = (Profil)(listBox1.SelectedItem);
            var email = (from x in context.Profil
                        where x.idUgyfelesAdatok == kivalasztottAdat.idUgyfelesAdatok
                        select x.Email_Cim).FirstOrDefault();
            textBox2.Text = email.ToString();

            var szulDatum = (from x in context.Profil
                         where x.idUgyfelesAdatok == kivalasztottAdat.idUgyfelesAdatok
                         select x.SzuletesiDatum).FirstOrDefault();
          
            textBox3.Text = szulDatum.ToString();

            var szallCim = (from x in context.Profil
                         where x.idUgyfelesAdatok == kivalasztottAdat.idUgyfelesAdatok
                         select x.SzallitasiCim).FirstOrDefault();
            textBox4.Text = szallCim.ToString();

            var jogAdat = (from x in context.Ugyfel
                           where x.UgyfelesAdatokFK == kivalasztottAdat.idUgyfelesAdatok
                           select x.Jogosultsag.KedvezmenyTipus).FirstOrDefault();
            textBox5.Text = jogAdat.ToString();

           /*+ var jogKat = from x in context.Jogosultsag
                         select new
                         {
                             x.idJogosultsag,
                             x.KedvezmenyTipus
                         };
            dataGridView1.DataSource = jogKat.ToList();*/

            /*int seged = int.Parse(jogAdat);
            var jogosultsag = (from x in context.Jogosultsag
                               where x.idJogosultsag == jogAdat
                               select x.KedvezmenyTipus);*/

            //dataGridView1.DataSource = eredmeny.ToList();
        }

        private void ProfilForm_Load(object sender, EventArgs e)
        {

        }
    }
}
