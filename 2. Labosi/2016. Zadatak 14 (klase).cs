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

namespace zadatak3_klasa
{
    class Zadatak
    {
        public float Rez;
        public int Broj = 0;
        public int X;
        public void Unos()
        {
            Console.WriteLine("Unesite broj X:");
            X = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite pocetni rezultat: ");
            Rez = float.Parse(Console.ReadLine());
            Obrada();
        }
        private void Obrada()
        {
            do
            {
                Console.WriteLine("Unesite operaciju: ");
                string op = Console.ReadLine();
                Console.WriteLine("Unesite broj: ");
                Broj = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case "+":
                        Rez += Broj;
                        break;
                    case "-":
                        Rez -= Broj;
                        break;
                    case "*":
                        Rez *= Broj;
                        break;
                    case "/":
                        Rez /= Broj;
                        break;
                }
                Console.WriteLine("Rezultat je sada: " + Rez);
            } while (Rez != X);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Zadatak zadatak = new Zadatak();
            zadatak.Unos();
            Console.ReadLine();
        }
    }
}
