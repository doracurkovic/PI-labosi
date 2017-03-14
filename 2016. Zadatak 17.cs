/* Napravite konzolnu aplikaciju u kojoj korisnik unosi N parova teksta i
boje. Aplikacija ispisuje sav tekst u odgovarajucoj zadanoj boji. Moguće
boje su "Crvena", "Plava" i "Zelena".
Sve elemente u kodu je nužno propisno imenovati.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016.Zadatak_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite N; ");
            int N = int.Parse(Console.ReadLine());
            string[] poljeT = new string[N];
            string[] poljeB = new string[N];

            for (int i = 0; i < N; i++)
            {
                Console.Write("Upišite tekst: ");
                poljeT[i] = Console.ReadLine();
                Console.Write("Upišite boju (crvena/plava/zelena): ");
                poljeB[i] = Console.ReadLine();
            }

            for (int i = 0; i < N; i++)
            {
                switch (poljeB[i])
                {
                    case "crvena":
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case "plava":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case "zelena":
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                }
                Console.WriteLine(poljeT[i]);
            }
            Console.ReadLine();
        }
    }
}
