using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016.Zadatak_35
{
    class Kategorija
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public float SumaTroškova { get; set; }

        public static List<Kategorija> listaKategorija = new List<Kategorija>();

        public Kategorija(int id, string n)
        {
            Id = id;
            Naziv = n;
            SumaTroškova = 0;
            listaKategorija.Add(this);
        }

        public string IspisKategorije()
        {
            return this.SumaTroškova + "kn - " + this.Naziv + Environment.NewLine; 
        }
    }
}
