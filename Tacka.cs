using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligon_2024
{
    internal class Tacka
    {
        public double x, y;
        public Tacka() { } //prazan konstruktor
        public Tacka(double x, double y) //konstruktor tacka sa koordinatama x i y
        {
            this.x = x;
            this.y = y;
        }
        public double Get_r() //uzima rastojanje kraja vektora od koordinatnog pocetka
        {
            double r = Math.Sqrt(x * x + y * y);
            return r;
        }
        public static bool Jednake(Tacka A, Tacka B)
        {
            if ((A.x == B.x) && (A.y == B.y)) return true;
            else return false;
        }
    }
}
