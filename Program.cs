using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligon_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Tacka a = new Tacka(0, 4);
            Tacka b = new Tacka(1, 3);
            Tacka c = new Tacka(3, 2);
            Tacka d = new Tacka(5, 4);

            Vektor prvi = new Vektor(a, b);
            Vektor drugi = new Vektor(c, d);
            Console.WriteLine("ab * cd = {0}", Vektor.Skalarni(prvi,drugi));
            */

            //napisi jos neku poruku dobrodoslice
            int akcija = 1;
            while (akcija != 0)
            {
                // kopiraj ovde Console.WriteLine iz grafova
                akcija = Convert.ToInt32(Console.ReadLine());
                if (akcija == 1)
                {
                    Console.WriteLine("Koliko ima temena polinom?");
                    int br_temena = Convert.ToInt32(Console.ReadLine());
                    Poligon prvi = new Poligon(br_temena);
                    for (int i = 0; i < br_temena; i++)
                    {

                    }
                }
            }
        }
    }
}
