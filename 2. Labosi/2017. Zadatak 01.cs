/* Korisnik treba unjeti broj N. Zatim unosi N boja (crvena, plava, zelena su ponuđene).
   Program beskonačno ispisuje trenutno vrijeme u određenoj boji a svaki ispis se pokrece pritiskom
   tipke Enter. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017.Zadatak_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite broj boja: ");
            int brojBoja = int.Parse(Console.ReadLine());
            string[] boje = new string[brojBoja];
            
            for (int i = 0; i < brojBoja; i++)
            {
                Console.Write("Unesite boju(crvena/plava/zelena): ");
                boje[i] = Console.ReadLine();
            }

            while(true)
            {
                for (int i = 0; i < brojBoja; i++)
                {
                    switch (boje[i])
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

                    Console.ReadLine();
                    Console.Write(DateTime.Now.ToString());
                }
            }
        }
    }
}
