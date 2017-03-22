using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017.Zadatak_04
{
    class Film
    {
        public string nazivFilm { get; set; }
        public int ocjenaFilm { get; set; }

        public Film()
        {

        }

        public void Ispis()
        {
            Console.WriteLine(nazivFilm + " " + ocjenaFilm);
        }

        public bool VecaOdX(int x)
        {
            if(ocjenaFilm > x)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SadrziPojam(string pojam)
        {
            if(nazivFilm.Contains(pojam))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
