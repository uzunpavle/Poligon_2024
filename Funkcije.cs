using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligon_2024
{
    internal class Funkcije
    {
        public static int SIS(Vektor AB, Tacka C, Tacka D)  //da li su tacke jednog vektora sa iste strane drugog ili ne
        {
            Vektor AC = new Vektor(AB.pocetak, C);
            Vektor AD = new Vektor(AB.pocetak, D);
            double k1 = Vektor.Vektorski(AB, AC);
            double k2 = Vektor.Vektorski(AB, AD);
            if (k1 * k2 > 0)
            {
                return 0;
            }
            else if (k1 * k2 == 0)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
        public static Boolean Presek(Vektor AB, Vektor CD)  //vraca da li se dva vektora seku ili ne
        {
            if (SIS(AB, CD.pocetak, CD.kraj) * SIS(CD, AB.pocetak, AB.kraj) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Presek1(Vektor AB, Vektor CD)
        {   
            bool presek;
            if (Presek(AB, CD)) presek = true;
            else return false;
            if (Math.Max(AB.pocetak.x, AB.kraj.x) >= Math.Min(CD.pocetak.x, CD.kraj.x) && Math.Max(AB.pocetak.y, AB.kraj.y) >= Math.Min(CD.pocetak.y, CD.kraj.y) &&
                Math.Max(CD.pocetak.x, CD.kraj.x) >= Math.Min(AB.pocetak.x, AB.kraj.x) && Math.Max(CD.pocetak.y, CD.kraj.y) >= Math.Min(AB.pocetak.y, AB.kraj.y)) presek = true;
            else presek = false;
            return presek;
        }
    }
}
