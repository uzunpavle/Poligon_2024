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
    }
}
