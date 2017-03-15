/* Napravite konzolnu aplikaciju u kojoj korisnik unosi broj duljine N
znamenki. Broj se zapisuje u polje (int) tako da svaka znameka bude u
odgovarajućem elementu polja. Aplikacija zatim ispisuje sadržaj polja
gdje je svaki element odvojen zarezom
Sve elemente u kodu je nužno propisno imenovati. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vjezba_pdf_klasa_13
{
    class Zadatak
    {
        string linija;
        int N;
        int[] polje;
        public void Unos()
        {
            linija = Console.ReadLine();
            N = linija.Length;
            polje = new int[N];
            Obrada();
        }
        void Obrada()
        {
            for (int i = 0; i < N; i++)
            {
                polje[i] = int.Parse(linija[i].ToString());
                Console.Write(polje[i] + ", ");
            }
            Console.Read();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Zadatak z = new Zadatak();
            z.Unos();
        }
    }
}
