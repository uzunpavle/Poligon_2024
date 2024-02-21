using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligon_2024
{
    internal class Poligon
    {
        public int broj_temena;
        public Tacka[] temena;
        public Poligon()  //konstruktor gde se unose samo temena
        {
            temena = new Tacka[broj_temena];
        }
        public Poligon(int n)  //konstruktor gde se unose temena i broj temena
        {
            broj_temena = n;
            temena = new Tacka[broj_temena];
        }
        public bool Konveksan()  //proverava da li je cetvorougao konveksan
        {
            int plusevi = 0;
            for (int i = 0; i < temena.Length-1; i++)
            {
                Vektor prvi = new Vektor(temena[i], temena[(i + 1) % broj_temena]);
                Vektor drugi = new Vektor(temena[(i + 1) % broj_temena], temena[(i + 2) % broj_temena]);
                if (Vektor.Vektorski(prvi, drugi) > 0) 
                {
                    plusevi++;
                }
            }
            if ((plusevi == 0) || (plusevi == broj_temena))
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
