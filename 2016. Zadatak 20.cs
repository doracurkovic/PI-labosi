/* Napravite konzolnu aplikaciju u kojoj korisnik unosi N parova cijelih
brojeva. Nakon što je uneseno svih N parova brojeva, brojeve je
potrebno ispisati u obliku:
(prviBrojPara < drugiBrojPara) ili
(prviBrojPara > drugiBrojPara) ili
(prviBrojPara = drugiBrojPara).
Sve elemente u kodu je nužno propisno imenovati.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016.Zadatak_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite N: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] prviBroj = new int[n];
            int[] drugiBroj = new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write("Unesite 1. broj: ");
                prviBroj[i] = int.Parse(Console.ReadLine());
                Console.Write("Unesite 2. broj: ");
                drugiBroj[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                if(prviBroj[i] > drugiBroj[i])
                {
                    Console.WriteLine("{0} > {1}", prviBroj[i], drugiBroj[i]);
                }
                else if (prviBroj[i] == drugiBroj[i])
                {
                    Console.WriteLine("{0} = {1}", prviBroj[i], drugiBroj[i]);
                }
                else
                {
                    Console.WriteLine("{0} < {1}", prviBroj[i], drugiBroj[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
