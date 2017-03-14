/* Napravite konzolnu aplikaciju u kojoj korisnik unosi dva broja, aplikacija u
jednom redu ispisuje sve brojeve između ta dva broja koji su dijeljivi za
unesenim N brojevima. U drugom redu aplikacija ispisuje N brojeve */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2016.Zadatak_19.dr
{
        class Zadatak
        {
            int prvi;
            int drugi;
            int N;
            int[] polje;
            int[] elementi;

            public void Unos()
            {
                Console.Write("Unesi donju granicu: ");
                prvi = int.Parse(Console.ReadLine());
                Console.Write("Unesi gornju granicu: ");
                drugi = int.Parse(Console.ReadLine());
                Ispis();

                Console.Write("Unesi N: ");
                N = int.Parse(Console.ReadLine());
                polje = new int[N];

                for (int i = 0; i < N; i++)
                {
                    Console.Write("Unesi {0} element: ", i + 1);
                    polje[i] = int.Parse(Console.ReadLine());
                }
                Obrada();

            }

            void Ispis()
            {
                elementi = new int[drugi + 1 - prvi];
                for (int i = 0; i < elementi.Length; i++)
                {
                    elementi[i] = prvi;
                    Console.Write("{0} ", prvi);
                    prvi++;
                }
                Console.WriteLine();
            }

            void Obrada()
            {
                for (int i = 0; i < elementi.Length; i++)
                {
                    bool djeljivJeSaSvima = true;
                    for (int j = 0; j < N; j++)
                    {
                        if (elementi[i] % polje[j] != 0)
                            djeljivJeSaSvima = false;
                    }
                    if (djeljivJeSaSvima)
                        Console.Write("{0} ", elementi[i]);
                }
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Zadatak z = new Zadatak();
                z.Unos();
                Console.Read();
            }
    }
}
