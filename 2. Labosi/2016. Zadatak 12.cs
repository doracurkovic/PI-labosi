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

namespace _2016.Zadatak_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Upišite dva decimalna broja odvojena razmakom te ulaznost (u) ili silaznost (s) ispisa: ");
            string linija = Console.ReadLine();
            string[] polje = linija.Split(' ');
            float prvi = float.Parse(polje[0]);
            float drugi = float.Parse(polje[1]);

            //Provjera koji je veći broj
            if (prvi > drugi)
            {
                float pomocni = prvi;
                prvi = drugi;
                drugi = pomocni;
            }

            //Paziti da ovdje idu " a ne ', inace javlja grešku
            if (polje[2] == "u")
            {
                for (int i = (int)prvi + 1; i < drugi; i++)
                {
                    //(int) pretvara u cijeli broj
                    Console.WriteLine(i);
                }
            }

            if (polje[2] == "s")
            {
                for (int i = (int)drugi; i > prvi; i--)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}
