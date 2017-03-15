/* Korisnik upisuje broj N, zatim upisuje N rijeci. 1. Treba izracunati broj znakova u cijeloj recenici
 i ispisati cijelu recenicu. 2. Treba ispisati svaku rijec, pa crticu (-) pa broj znakova u rijeci. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017.Zadatak_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite broj rijeci: ");
            int brojRijeci = int.Parse(Console.ReadLine());
            string[] rijeci = new string[brojRijeci];

            for(int i = 0; i < brojRijeci; i++)
            {
                Console.Write("Upisite " + (i + 1) + ". rijec: ");
                rijeci[i] = Console.ReadLine();
            }

            string recenica = "";

            for (int i = 0; i < brojRijeci; i++)
            {
                recenica += rijeci[i] + " ";
            }

            Console.WriteLine(recenica);
            Console.WriteLine(recenica.Length - 1); //ovaj -1 zbog zadnjeg razmaka u recenici

            for (int i = 0; i < brojRijeci; i++)
            {
                Console.WriteLine(rijeci[i] + " - " + rijeci[i].Length);
            }

            Console.ReadLine();
        }
    }
}
