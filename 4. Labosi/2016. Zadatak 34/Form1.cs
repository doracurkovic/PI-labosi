/* Napravite windows forms aplikaciju u kojoj korisnik unosi binarni broj od
8 znakova, svaki znak je zapisan u svojem Textboxu. Unosom bilo koje
znamenke aplikacija računa i ispisuje decimalnu vrijednost unesenog
broja. Broj bitova u broju je fiksan i iznosi 8. Potrebno je napraviti i
validaciju korisničkog unosa. */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2016.Zadatak_34
{
    public partial class FrmBinarni : Form
    {
        private DecimalniBroj decBroj;
        public FrmBinarni()
        {
            InitializeComponent();
            decBroj = new DecimalniBroj();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            List<string> vrijednosti = new List<string>();
            vrijednosti.Add(textBox1.Text);
            vrijednosti.Add(textBox2.Text);
            vrijednosti.Add(textBox3.Text);
            vrijednosti.Add(textBox4.Text);
            vrijednosti.Add(textBox5.Text);
            vrijednosti.Add(textBox6.Text);
            vrijednosti.Add(textBox7.Text);
            vrijednosti.Add(textBox8.Text);

            bool ispravnaKombinacija = decBroj.ProvjeriUnos(vrijednosti);
            if (ispravnaKombinacija == true)
            {
                int ispis = decBroj.Računanje();
                textBoxRez.Text = ispis.ToString();
            }
            else
            {
                MessageBox.Show("Krivo unesen broj! ");
            }
        }

    }
}
