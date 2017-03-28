/* Zadatak je bio retardirano postavljen na labosima i pola grupe nije skužilo zadatak,
   pa ću ja ovdje objasnit kako treba. Dakle, DNA je neukelinska kiselina u obliku
   dvostruke spiralne zavojnice. Nukleoid može biti A, G, C ili T. Treba napraviti
   Windows formu koja omogućuje da radimo ispis parova nukleoida. 
   Na labosima je A bio u paru sa T, C sa A, T sa G i G sa C. Ovako:
   A - T
   C - A
   T - G
   G - C
   I treba to ispisivati u onom redosljedu kako korisnik napravi. Ustvari je najlakše
   napraviti jedan gumb za svaki par, odnosno za svako slovo i klikom na gumb se ispisuje
   u textboxu to slovo i njegov par kao što je gore navedeno.
   Ako kliknemo na gumb "A" ispisat će nam se "A - T".
   Nadalje, ispod starog ispisa se stavlja novi ispis para itd. (textbox mora biti multiline).
   Nakraju to sve izgleda kao ajmo reć simulacija spiralne zavojnice nukleoida odnosno DNA. */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2017.Zadatak_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inputA_Click(object sender, EventArgs e)
        {
            output.Text += "A - T" + Environment.NewLine;
        }

        private void inputC_Click(object sender, EventArgs e)
        {
            output.Text += "C - A" + Environment.NewLine;
        }

        private void inputT_Click(object sender, EventArgs e)
        {
            output.Text += "T - G" + Environment.NewLine;
        }

        private void inputG_Click(object sender, EventArgs e)
        {
            output.Text += "G - C" + Environment.NewLine;
        }
    }
}
