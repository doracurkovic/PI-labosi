using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016.Zadatak_34
{
    class DecimalniBroj
    {
        public List<int> BinarniBrojevi { get; set; }

        public DecimalniBroj()
        {
            BinarniBrojevi = new List<int>();
        }

        public bool ProvjeriUnos(List<string> korisnickiUnos) //vrijednosti se unose u List korisnickiUnos
        {
            bool ispravni = false;
            BinarniBrojevi.Clear();

            foreach(string v in korisnickiUnos)
            {
                int broj = 0; 
                if (int.TryParse(v, out broj) == true)
                {
                    if(broj == 1 || broj == 0)
                    {
                        BinarniBrojevi.Add(broj);
                    }
                }
            }

            if(BinarniBrojevi.Count == 8)
            {
                ispravni = true;
            }
            return ispravni;
        }

        public int Računanje()
        {
            string pretvorba = "";
            int rezultatRacunaj = 0;
            
            foreach(int binBroj in BinarniBrojevi)
            {
                pretvorba += Convert.ToString(binBroj);
            }
            rezultatRacunaj = Convert.ToInt32(pretvorba, 2);
            return rezultatRacunaj;
        }
    }
}
