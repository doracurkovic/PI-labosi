/* Napravite konzolnu aplikaciju u kojoj korisnik unosi N brojeva. Aplikacija
računa i ispisuje kumulativni niz unesenih brojeva.
Sve elemente u kodu je nužno propisno imenovati.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016.Zadatak_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite N: ");
            int N = int.Parse(Console.ReadLine());
            int[] polje = new int[N];
                
            for(int i = 0; i < N; i++)
            {
                Console.Write("Unesite broj: ");
                polje[i] = int.Parse(Console.ReadLine());
            }

            int rez = 0;

            for(int i = 0; i < N; i++)
            {
                rez = rez + polje[i];
            }

            Console.WriteLine("Kumulativni niz unesenih brojeva: " + rez);
            Console.ReadLine();
        }
    }
}
