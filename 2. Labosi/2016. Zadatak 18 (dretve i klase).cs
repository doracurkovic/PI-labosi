/* Napravite konzolnu aplikaciju koja crta pravokutnik zadanih dimenzija i u
zadanoj boji koju korisnik unese ("Crvena", "Plava", "Zelena").
Nakon unosa, svake sekunde aplikacija mijenja boju prikazanog
pravokutnika iz bijele u zadanu i tako u nedogled.
Sve elemente u kodu je nužno propisno imenovati.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading; 
using System.Threading.Tasks;


namespace _2016.Zadatak_18
{
    class Zadatak
    {
        private int x, y;
        private string boja, boja2;

        public void Unos()
        {
            Console.Write("Unesite x pravokutnika: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Unesite y pravokutnika: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("Unesite boju(crvena/plava/zelena): ");
            boja2 = Console.ReadLine();
            boja = boja2;

            Ispis();
        }

        void Ispis()
        {
            Console.Clear();
            while(true)
            {
                switch(boja)
                {
                    case "crvena":
                        Console.ForegroundColor = ConsoleColor.Red;
                        boja = "bijela";
                        break;
                    case "plava":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        boja = "bijela";
                        break;
                    case "zelena":
                        Console.ForegroundColor = ConsoleColor.Green;
                        boja = "bijela";
                        break;
                    case "bijela":
                        Console.ForegroundColor = ConsoleColor.White;
                        boja = boja2;
                        break;
                }

                Console.CursorTop = 0;
                Console.CursorLeft = 0;
                for (int i = 0; i < x; i++)
                {
                    Console.Write("-");
                }

                Console.CursorTop = 1;
                Console.CursorLeft = 0;
                for (int i = 1; i < y - 1; i++)
                {
                    Console.Write("|");
                    Console.CursorLeft = x - 1;
                    Console.WriteLine("|");
                }

                for (int i = 0; i < x; i++)
                {
                    Console.Write("-");
                }

                Thread.Sleep(1000);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Zadatak z = new Zadatak();
            z.Unos();

            Console.ReadLine();
        }
    }
}
