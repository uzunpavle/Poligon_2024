using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Poligon_2024
{
    internal class Vektor
    {
        public Tacka pocetak, kraj;
        public Vektor() { } //prazan konstruktor
        public Vektor (Tacka pocetak, Tacka kraj) //konstruktor vektora sa tackama odakle krece i dokle ide
        {
            this.pocetak= pocetak;
            this.kraj= kraj;
        }
        public static Tacka Vektor_c(Vektor a)  //stavlja vektor u kordinatni pocetak
        {
            Tacka nova = new Tacka();
            nova.x = a.kraj.x - a.pocetak.x;
            nova.y = a.kraj.y - a.pocetak.y;
            return nova;
        }
        public static double Skalarni(Vektor a, Vektor b) //skalarni proizvod dva vekora iz pocetka
        {
            Tacka a_c = Vektor_c(a);
            Tacka b_c = Vektor_c(b);
            double skalarni = a_c.x * b_c.x + a_c.y * b_c.y; 
            return skalarni;
        }
    }
}
