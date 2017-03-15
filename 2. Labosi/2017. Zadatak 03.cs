/* Korisnik upisuje N (broj rijeci) i zatim upisuje N rijeci. Program beskonacno pita korisnika
 da upise neko slovo i program zatim ispise sve unesene rijeci koje pocinju na to slovo. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017.Zadatak_03
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
                Console.Write("Unesite " + (i + 1) + ". rijec: ");
                rijeci[i] = Console.ReadLine();
            }

            while(true)
            {
                Console.Write("Unesite slovo: ");
                string slovo = Console.ReadLine();
                for(int i = 0; i < brojRijeci; i++)
                {
                    if(rijeci[i].StartsWith(slovo))
                    {
                        Console.WriteLine(rijeci[i]);
                    }
                }
            }
        }
    }
}
