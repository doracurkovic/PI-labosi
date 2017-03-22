/* 1. Unit artikl u listu artikala. Svaki artikl ima naziv, jedinicnu cijenu i kolicinu 
2. Ispisati sve artikle. 
3. Ispisati artikle kojima je jedinicna cijena veca od x (korisnik unosi broj x) 
4. Ispisatu artikle kojima je sveukupna cijena manja od y (korisnik unosi broj y). 
    sveukupna cijena = misli se na jedinicna cijena * kolicina.  
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017.Zadatak_03
{
    public class NeDopuštenaVrijednostIznimka : ApplicationException
    {
        public string DodatnaPoruka { get; set; }
        public NeDopuštenaVrijednostIznimka(string poruka)
        {
            DodatnaPoruka = poruka;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string izbor = "", naziv = "";
            double cijena = 0;
            int kolicina, x, y;
            Artikl tmpArtikl = null;
            List<Artikl> artikli = new List<Artikl>();

            while (true)
            {
                Console.WriteLine("GLAVNI IZBORNIK");
                Console.WriteLine("1. Upis artikala. ");
                Console.WriteLine("2. Ispis svih artikala. ");
                Console.WriteLine("3. Ispis artikala cija je jedinicna cijena veca od x. ");
                Console.WriteLine("4. Ispis artikala cija je sveukupna cijena manja od y. ");
                izbor = Console.ReadLine();

                switch (izbor)
                {
                    case "1": //upis
                        {
                            tmpArtikl = new Artikl();
                            Console.Write("Upišite naziv artikla: ");
                            naziv = Console.ReadLine();
                            try
                            {
                                Console.Write("Upišite cijenu artikla: ");
                                cijena = double.Parse(Console.ReadLine());

                                if (cijena <= 0)
                                {
                                    throw new NeDopuštenaVrijednostIznimka("Cijena mora biti veća od 0!");
                                }
                                else
                                {
                                    Console.Write("Unesite kolicinu artikla: ");
                                    kolicina = int.Parse(Console.ReadLine());

                                    tmpArtikl.nazivArtikla = naziv;
                                    tmpArtikl.jedCijenaArtikla = cijena;
                                    tmpArtikl.kolicinaArtikla = kolicina;

                                    artikli.Add(tmpArtikl);
                                }
                            }
                            catch (NeDopuštenaVrijednostIznimka ex)
                            {
                                Console.WriteLine(ex.DodatnaPoruka);
                            }
                                               
                            break;
                        }

                    case "2": //ispis
                        {
                            foreach (Artikl jedanArtikl in artikli)
                            {
                                jedanArtikl.Ispis();
                            }
                            break;
                        }

                    case "3":
                        {
                            Console.Write("Unesi broj x: ");
                            x = int.Parse(Console.ReadLine());


                            foreach (Artikl jedanArtikl in artikli)
                            {
                                if (jedanArtikl.VeceOdX(x))
                                {
                                    jedanArtikl.Ispis();
                                }

                            }
                            break;
                        }

                    case "4":
                        {
                            Console.Write("Unesi broj y: ");
                            y = int.Parse(Console.ReadLine());


                            foreach (Artikl jedanArtikl in artikli)
                            {
                                if (jedanArtikl.ManjeOdY(y))
                                {
                                    jedanArtikl.Ispis();
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
