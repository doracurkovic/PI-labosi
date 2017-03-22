/* Napravit izbornik sa sljedecim funkcionalnostima:
1, Unos filma (film ima naziv i ocjenu)
2. Ispis filmova
3. Pretrazivanje po unesenoj X ocjeni da izbacuje filmove koji imaju ocjenu vecu od X
4. Pretrazivanje po unesenom pojmu
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017.Zadatak_04
{
    public class NeDopuštenaVrijednostOcjeneIznimka : ApplicationException
    {
        public string DodatnaPoruka { get; set; }
        public NeDopuštenaVrijednostOcjeneIznimka(string poruka)
        {
            DodatnaPoruka = poruka;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string izbor = "", naziv = "", pojam = "";
            int ocjena = 0, x = 0;
            Film tmpFilm = null;
            List<Film> filmovi = new List<Film>();

            while(true)
            {
                Console.WriteLine("GLAVNI IZBORNIK");
                Console.WriteLine("1. Unos filma (naziv i ocjena).");
                Console.WriteLine("2. Ispis svih filmova.");
                Console.WriteLine("3. Ispis filmova sa ocjenom vecom od unesenog X.");
                Console.WriteLine("4. Pretrazivanje po unesenom pojmu");
                izbor = Console.ReadLine();

                switch(izbor)
                {
                    case "1": //upis
                        {
                            tmpFilm = new Film();
                            Console.Write("Unesite naziv filma: ");
                            naziv = Console.ReadLine();

                            try //iznimku baca ali kasnije kod ispisa ispisuje i one unose koje nebi smjelo
                            {
                                Console.Write("Unesite ocjenu filma: ");
                                ocjena = int.Parse(Console.ReadLine());

                                if (ocjena > 5 || ocjena < 1)
                                {
                                    throw new NeDopuštenaVrijednostOcjeneIznimka("Ocjena mora biti vrijednost između 1 i 5");
                                }
                                else
                                {
                                    tmpFilm.nazivFilm = naziv;
                                    tmpFilm.ocjenaFilm = ocjena;

                                    filmovi.Add(tmpFilm);
                                }
                            }
                            catch(NeDopuštenaVrijednostOcjeneIznimka ex)
                            {
                                Console.WriteLine(ex.DodatnaPoruka);
                            }

                            

                            break;
                        }
                    case "2": //ispis
                        {
                            foreach (Film jedanFilm in filmovi)
                            {
                                jedanFilm.Ispis();
                            }
                            break;
                        }

                    case "3":
                        {
                            Console.Write("Unesi neki broj x: ");
                            x = int.Parse(Console.ReadLine());

                            foreach (Film jedanFilm in filmovi)
                            {
                                if(jedanFilm.VecaOdX(x))
                                {
                                    jedanFilm.Ispis();
                                }
                            }
                            break;
                        }
                    case "4":
                        {
                            Console.Write("Unesite pojam za pretraživanje: ");
                            pojam = Console.ReadLine();

                            foreach (Film jedanFilm in filmovi)
                            {
                                if(jedanFilm.SadrziPojam(pojam))
                                {
                                    jedanFilm.Ispis();
                                }
                            }
                            break;
                        }
                    default:
                        {
                            return;
                        }
                }
            }
        }
    }
}
