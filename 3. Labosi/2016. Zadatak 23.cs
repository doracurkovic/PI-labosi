/* Napravite konzolnu aplikaciju u kojoj korisnik unosi binarne brojeve. Po
završetku unosa zadnjeg broj aplikacija ispisuje sve binarne brojeve
(svaki broj u svojem redu) + decimalnu (dekadsku?) vrijednost unesenog broja. Broj
bitova u broju je fiksan i iznosi 8.
U sklopu vašeg rješenja potrebno je napraviti i koristiti barem jednu
iznimku.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016.Zadatak_23
{
    public class BrojBitova : ApplicationException
    {
        public string DodatnaPoruka { get; set; }

        public BrojBitova(string poruka)
        {
            DodatnaPoruka = poruka;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Koliko binarnih brojeva želite unjeti? ");
            int brojBinBr = int.Parse(Console.ReadLine());

            string[] binarniBr = new string[brojBinBr];

            for (int i = 0; i < brojBinBr; i++)
            {
                try
                {
                    Console.Write("Unesite " + (i + 1) + ". binarni broj: ");
                    binarniBr[i] = Console.ReadLine();

                    if (binarniBr[i].Length != 8 || !binarniBr[i].Contains("0") || !binarniBr[i].Contains("1"))
                    {
                        throw new BrojBitova("Broj bitova u broju ili format nije ispravan! ");
                    }
                }

                catch (BrojBitova ex)
                {
                    Console.WriteLine(ex.DodatnaPoruka);
                }
            }
           
            for (int i = 0; i < brojBinBr; i++)
            {
                if (binarniBr[i].Length != 8)
                    continue;
                else
                {
                    Console.WriteLine(binarniBr[i] + " = " + Convert.ToInt32(binarniBr[i],2));
                }
            }

            Console.ReadLine();
        }
    }
}
