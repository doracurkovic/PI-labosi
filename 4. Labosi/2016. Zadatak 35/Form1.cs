/* Napravite windows forms aplikaciju koja služi za kategorizaciju troškova.
Aplikacija sadrži 4 definirane kategorije (hrana, zabava, zdravlje,
edukacija). Aplikacije ispisuje sve unesene trškove u textboxu gdje je
zadnji trošak na vrhu i svaki trošak je u svojem redu. Zapis ispisa
prikazan primjerom:
44,37kn - Zabava
37,99kn - Hrana */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2016.Zadatak_35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inicijalizirajKategorije();
            pripremiComboBox();
        }

        private void pripremiComboBox()
        {
            comboBoxKategorije.DataSource = Kategorija.listaKategorija;
            comboBoxKategorije.ValueMember = "Id";
            comboBoxKategorije.DisplayMember = "Naziv";
        }

        private void inicijalizirajKategorije()
        {
            Kategorija k1 = new Kategorija(1, "Hrana");
            Kategorija k2 = new Kategorija(2, "Zabava");
            Kategorija k3 = new Kategorija(3, "Edukacija");
            Kategorija k4 = new Kategorija(4, "Zdravlje");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kategorija odabranaKategorija = (Kategorija)comboBoxKategorije.SelectedItem;

            float uneseniTrosak;

            bool jelUnosDobar = float.TryParse(textIznos.Text, out uneseniTrosak);

            if (jelUnosDobar == true)
            {
                odabranaKategorija.SumaTroškova += uneseniTrosak;

                this.textTroškovi.Clear();
                this.textTroškovi.Text = odabranaKategorija.IspisKategorije();
                foreach (Kategorija k in Kategorija.listaKategorija)
                {
                    if (k != odabranaKategorija)
                    {
                        textTroškovi.Text += k.IspisKategorije();
                    }
                }
            }

            else
            {
                MessageBox.Show("Unesena vrijednost nije u pravilnom formatu.", 
                    "Pogreška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
