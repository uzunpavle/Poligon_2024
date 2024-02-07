using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligon_2024
{
    internal class Poligon
    {
        int broj_temena;
        Tacka[] temena;
        public Poligon()
        {
            temena = new Tacka[broj_temena];
        }
        public Poligon(int n)
        {
            broj_temena = n;
            temena = new Tacka[broj_temena];
        }
    }
}
