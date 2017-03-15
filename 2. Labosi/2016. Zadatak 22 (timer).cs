/* Napravite konzolnu aplikaciju u kojoj korisnik unosi širinu i visinu prozora
konzole. Nije moguće unesti vrijednosti manje od 1. Nakon unosa
zadnjeg broja (visine) veličina prozora konzole je minimalne veličine te
se postupno (svake X milisekunde) povecava za 1 do zadane širine i
visine
Sve elemente u kodu je nužno propisno imenovati.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _22_a
{
    class Program
    {
        public static void Tick(object o)
        {

            if (Console.WindowHeight != visina) Console.WindowHeight += 1;
            if (Console.WindowWidth != sirina) Console.WindowWidth += 1;
            if (Console.WindowWidth == visina && Console.WindowHeight == sirina)
            {
                timer.Dispose();
            }


        }
        static int sirina = 0;
        static int visina = 0;
        static Timer timer;
        static void Main(string[] args)
        {

            do
            {
                Console.WriteLine("Unesite sirinu: ");
                sirina = int.Parse(Console.ReadLine());

            } while (sirina < 1 || sirina <= Console.WindowWidth);
            do
            {
                Console.WriteLine("Unesite visinu: ");
                visina = int.Parse(Console.ReadLine());
            } while (visina < 1 || visina <= Console.WindowHeight || visina >= 84);
            timer = new Timer(Tick, null, 0, 1000);


            Console.ReadLine();
        }
    }
}
