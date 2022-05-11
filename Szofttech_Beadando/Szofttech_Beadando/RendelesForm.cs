using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szofttech_Beadando
{
    public partial class RendelesForm : Form
    {
        Database1Entities context = new Database1Entities();
        public RendelesForm()
        {
            InitializeComponent();
            button1.Text = "\uE74E";
            button2.Text = "\uE94E";
            button3.Text = "\uE738";
            //button4.Text = "\uE738";
            RendelesLista();
            Adatok();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            RendelesLista();
        }

        private void RendelesLista()
        {
            var rend = from x in context.Profil
                       where x.Nev.Contains(textBox1.Text)
                       select x;
            listBox1.DataSource = rend.ToList();
            listBox1.DisplayMember = "Nev";
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Adatok();
        }
        private void Adatok()
        {
            var kivalasztottAdat = (Profil)listBox1.SelectedItem;
            var eredmeny = from x in context.RendelesOssz
                           where (x.Rendeles.Ugyfel_idUgyfel == kivalasztottAdat.idUgyfelesAdatok)
                           select new RendelesInfo
                           {
                               id = x.Rendeles_FK,
                               konyvCim = x.Konyv.Nev,
                               konyvAr = x.Konyv.Ar,
                               kedvezmeny = x.Rendeles.Ugyfel.Jogosultsag.KedvezmenyTipus,
                               kedvezmenyesAr = x.Konyv.Ar - (x.Rendeles.Ugyfel.Jogosultsag.KedvezmenyTipus * x.Konyv.Ar / 100)
                           };
            rendelesInfoBindingSource.DataSource = eredmeny.ToList();

            var eredmeny2 = from x in context.Rendeles
                            where x.Ugyfel_idUgyfel == kivalasztottAdat.idUgyfelesAdatok
                            select new RendelesInfo2
                            {
                                idRendelesOssz = x.idRendelesOsszesites,
                                rendDatum = x.RendelesiDatum,
                                kedvez = x.Kedvezmenyes
                            };
            rendelesInfo2BindingSource.DataSource = eredmeny2.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rendeles ujRendeles = new Rendeles();
            ujRendeles.Ugyfel_idUgyfel = ((Profil)listBox1.SelectedItem).idUgyfelesAdatok;
            ujRendeles.RendelesiDatum = DateTime.Parse(textBox3.Text);
            ujRendeles.idRendelesOsszesites = (from x in context.Rendeles
                                               select x.idRendelesOsszesites).Max() + 1;
            //ujRendeles.Kedvezmenyes = textBox3.Text;

            context.Rendeles.Add(ujRendeles);

            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Adatok();
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            RendelesOssz ro = new RendelesOssz();
            ro.idKapcsolo = (from x in context.RendelesOssz
                             select x.idKapcsolo).Max() + 1;
            ro.Konyv_FK = int.Parse(textBox2.Text);
            ro.Rendeles_FK = (from x in context.Rendeles
                              select x.idRendelesOsszesites).Max();

            context.RendelesOssz.Add(ro);
            try
            {
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            Adatok();
            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (rendelesInfoBindingSource.Current != null)
            {
                var kivalasztottElem = ((RendelesInfo)rendelesInfoBindingSource.Current).id;
                var torlendo = (from x in context.Rendeles
                                where x.idRendelesOsszesites == kivalasztottElem
                                select x).FirstOrDefault();
                context.Rendeles.Remove(torlendo);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Adatok();
            }
            else
            {
                MessageBox.Show("Nincs törölhető rendelés.");
            }
            if (rendelesInfo2BindingSource.Current != null)
            {
                var kivalasztottElem2 = ((RendelesInfo2)rendelesInfo2BindingSource.Current).idRendelesOssz;
                var torlendo2 = (from x in context.RendelesOssz
                                 where x.idKapcsolo == kivalasztottElem2
                                 select x).FirstOrDefault();
                context.RendelesOssz.Remove(torlendo2);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Adatok();
            }
            else
            {
                MessageBox.Show("Nincs törölhető rendelés.");
            }
        }


        bool kotelezo(string szoveg)
        {
            return !string.IsNullOrEmpty(szoveg);
        }

        bool datumEll(string datum)
        {
            Regex r = new Regex(@"^\d{4}-((0\d)|(1[012]))-(([012]\d)|3[01])$");
            return r.IsMatch(datum);
        }

        bool konyIDell(string id)
        {
            Regex r = new Regex(@"(^[1-9]$)|^(1[0-9]$)|(^2[0-5]$)");
            return r.IsMatch(id);
        }
        private void textBox2_Validating_1(object sender, CancelEventArgs e)
        { 
            if (!konyIDell(textBox2.Text))
            {
                e.Cancel = true;
                button1.Enabled = false;
                errorProvider1.SetError(textBox2, "Kerlek 1-tol 25-ig terjedo intervallumban valassz!");
                textBox2.BackColor = Color.Red;
            }

            if (!kotelezo(textBox2.Text))
            {
                e.Cancel = true;
                button1.Enabled = false;
                 errorProvider1.SetError(textBox2, "Nem lehet üres!");
                 textBox2.BackColor = Color.Red;
             }
            
        }
        private void textBox2_Validated_1(object sender, EventArgs e)
        {
            button1.Enabled = true;
            textBox2.BackColor = Color.Green;
            errorProvider1.SetError(textBox2, "");
        }

        private void textBox3_Validating_1(object sender, CancelEventArgs e)
        {
            if (!kotelezo(textBox3.Text))
            {
                e.Cancel = true;
                button1.Enabled = false;
                errorProvider1.SetError(textBox3, "Nem lehet üres!");
                textBox3.BackColor = Color.Red;
            }

            if (!datumEll(textBox3.Text))
            {
                e.Cancel = true;
                button1.Enabled = false;
                errorProvider1.SetError(textBox3, "Nem megfelelo a formatum pl: yyyy-mm-dd!");
                textBox3.BackColor = Color.Red;
            }

        }

        private void textBox3_Validated_1(object sender, EventArgs e)
        {
            button1.Enabled = true;
            textBox3.BackColor = Color.Green;
            errorProvider1.SetError(textBox3, "");
        }

       


    }
}
