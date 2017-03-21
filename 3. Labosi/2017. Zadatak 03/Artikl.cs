using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017.Zadatak_03
{
    public class Artikl
    {
        public string nazivArtikla { get; set; }
        public double jedCijenaArtikla { get; set; }
        public int kolicinaArtikla { get; set; }

        double sumaCijenaArtikla;

        public Artikl()
        {

        }

        public void Ispis()
        {
            Console.WriteLine(nazivArtikla + " " + jedCijenaArtikla + " " + kolicinaArtikla);
        }

        public bool VeceOdX(int x)
        {
            if (x < jedCijenaArtikla)
                return true;
            else
                return false;
        }
        public bool ManjeOdY(int y)
        {
            if (y > jedCijenaArtikla * kolicinaArtikla)
                return true;
            else
                return false;
        }
    }
}
