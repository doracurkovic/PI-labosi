/* Napravite konzolnu aplikaciju koja je kontinuirani kalkulator u kojoj
korisnik unosi broj i operator (+,-,*,/). Aplikacija ispisuje rezultat
matematičke operacije sa unesenim brojem i prethodnim rezultatom.
Aplikacija završava ukoliko rezultat ikada bude X.
Sve elemente u kodu je nužno propisno imenovati.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016.Zadatak_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite X: ");
            int X = int.Parse(Console.ReadLine());
            Console.Write("Unesite prethodni rezultat: ");
            float rez = float.Parse(Console.ReadLine());

            do
            {
                Console.Write("Unesite broj: ");
                int broj = int.Parse(Console.ReadLine());
                Console.Write("Unesite operaciju(+,-,*,/): ");
                string oper = Console.ReadLine();

                switch(oper)
                {
                    case "+":
                        rez = rez + broj;
                        break;
                    case "-":
                        rez = rez - broj;
                        break;
                    case "*":
                        rez = rez * broj;
                        break;
                    case "/":
                        rez = rez / broj;
                        break;
                }

                Console.WriteLine(rez);
            } while (rez != X);

            Console.ReadLine();
        }
    }
}
