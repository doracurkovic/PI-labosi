/* Napravite konzolnu aplikaciju u kojoj korisnik unosi broj duljine N
znamenki. Broj se zapisuje u polje (int) tako da svaka znameka bude u
odgovarajućem elementu polja. Aplikacija zatim ispisuje sadržaj polja
gdje je svaki element odvojen zarezom.
Sve elemente u kodu je nužno propisno imenovati.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016.Zadatak_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Upišite broj: ");
            string linija = Console.ReadLine();
            int N = linija.Length;
            int[] polje = new int[N]; //polje sa N elemenata

            for (int i = 0; i < N; i++)
            {
                //ˇˇ redni broj elementa polja pretvara u int i onda sa ToString ispisuje sadržaj tog elementa
                polje[i] = int.Parse(linija[i].ToString());
                Console.Write(polje[i] + ", ");
            }

            Console.ReadLine();
        }
    }
}
