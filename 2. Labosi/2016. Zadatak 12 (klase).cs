/* Napravite konzolnu aplikaciju u kojoj korisnik unosi:
- dva decimalna broja
- razmak između dva broja
- uzlaznost ili silaznost ispisa
Aplikacija ispisuje sve brojeve između ta dva broja ovisno o ulaznim
parametrima.
Sve elemente u kodu je nužno propisno imenovati.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016.Zadatak_12_dr
{
    class Zadatak //Klasa zadatak
    {
        public float prvi, drugi;
        public string ispis;

        public void Unos() //Public metoda za unos podataka
        {
            Console.Write("Upišite dva decimalna broja odvojena razmakom te ulaznost (u) ili silaznost (s) ispisa: ");
            string linija = Console.ReadLine();
            string[] polje = linija.Split(' ');
            prvi = float.Parse(polje[0]);
            drugi = float.Parse(polje[1]);
            ispis = polje[2];
            Provjera();
        }
        
        private void Provjera() //Private metoda za provjeru koji je veći broj
        {
            if (prvi > drugi)
            {
                float pomocni = prvi;
                prvi = drugi;
                drugi = pomocni;
            }
        }

        public void Ispis() //Public metoda za ispis
        {
            if (ispis == "u")
            {
                for (int i = (int)prvi + 1; i < drugi; i++)
                {
                    //(int) pretvara u cijeli broj
                    Console.WriteLine(i);
                }
            }

            if (ispis == "s")
            {
                for (int i = (int)drugi; i > prvi; i--)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

    class Program //Klasa program
    {
        static void Main(string[] args)
        {
            Zadatak z = new Zadatak();
            z.Unos();
            z.Ispis();
            Console.Read();
        }
    }
}
