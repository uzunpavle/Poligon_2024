using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            /*
            int akcija = 1;
            while (akcija != 0)
            {
                // kopiraj ovde Console.WriteLine iz grafova za opcije
                akcija = Convert.ToInt32(Console.ReadLine());
                if (akcija == 1)  //unosenje poligona sa tastature
                {
                    Console.WriteLine("Koliko ima temena polinom?");
                    int br_temena = Convert.ToInt32(Console.ReadLine());
                    Poligon poligon = new Poligon(br_temena);
                    for (int i = 0; i < br_temena; i++)
                    {
                        Console.WriteLine("Unesite x koordinatu temena");
                        double x = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Unesite y koordinatu temena");
                        double y = Convert.ToDouble(Console.ReadLine());
                        poligon.temena[i] = new Tacka(x, y);
                    }
                }
                if (akcija == 2)  //cuvanje poligona u fajl
                {

                }
                if (akcija == 3)  //ucitavanje poligona iz fajla
                {

                }
                if (akcija == 4) //obim poligona, zadatak sa casa, skloni visak koda kad budes pravio deo za obim
                {

                }
                if (akcija == 5)  //proverava da li je tacka u poligonu
                {

                }
                if (akcija == 6)  
                {

                } //nalazi najmanji konveksan cetvorougao
            }
            
            Tacka A = new Tacka(2, -1);
            Tacka b = new Tacka(5.866, 6.5);
            Tacka c = new Tacka(2, 0);
            Tacka d = new Tacka(5, 6);


            /*****************************************************************************/
            /*
            Console.WriteLine("Koliko ima temena polinom?");
            int br_temena = Convert.ToInt32(Console.ReadLine());
            Poligon poligon = new Poligon(br_temena);
            for (int i = 0; i < br_temena; i++)
            {
                Console.WriteLine("Unesite x koordinatu temena");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Unesite y koordinatu temena");
                double y = Convert.ToDouble(Console.ReadLine());
                poligon.temena[i] = new Tacka(x, y);
            }
            double obim = 0;
            for (int i = 0; i < poligon.broj_temena; i++)
            {
                Vektor vektor = new Vektor(poligon.temena[i], poligon.temena[(i + 2) % poligon.temena.Length]);
                obim = obim + (Vektor.Intenzitet(vektor) / 2);
            }
            Console.WriteLine("Obim novog poligona je {0}", obim);
            */
            /**********************************************************************************************/
            /*
            Poligon prvi = new Poligon(4);
            prvi.temena[0] = new Tacka(1, 1);
            prvi.temena[1] = new Tacka(3, 1);
            prvi.temena[2] = new Tacka(2, 1);
            prvi.temena[3] = new Tacka(2, 2);
            Vektor AB = new Vektor(prvi.temena[0], prvi.temena[1]);
            Vektor CD = new Vektor(prvi.temena[2], prvi.temena[3]);
            Console.WriteLine(Funkcije.Presek(AB, CD));
            */
            /*******************************************************************************************/
            /*
            Poligon prvi = new Poligon(4);
            prvi.temena[0] = new Tacka(6, 8);
            prvi.temena[1] = new Tacka(4, 6);
            prvi.temena[2] = new Tacka(5, 3);
            prvi.temena[3] = new Tacka(8, 6);

            Vektor AB = new Vektor(prvi.temena[0], prvi.temena[1]);
            Vektor BC = new Vektor(prvi.temena[1], prvi.temena[2]);
            Vektor CD = new Vektor(prvi.temena[2], prvi.temena[3]);
            Vektor DA = new Vektor(prvi.temena[3], prvi.temena[0]);
            Vektor[] vektori = new Vektor[4];
            vektori[0] = AB;
            vektori[1] = BC;
            vektori[2] = CD;
            vektori[3] = DA;

            bool pravi_uglovi = false;
            bool jeste = true;
            for (int i = 0; i < 4; i++)
            {
                if ((Vektor.Skalarni(vektori[i], vektori[(i + 1) % 4]) == 0) && (Vektor.Skalarni(vektori[(i + 1) % 4], vektori[(i + 2) % 4]) == 0))
                {
                    if (pravi_uglovi == false)
                    {
                        pravi_uglovi = true;
                        continue;
                    }
                    else
                    {
                        jeste = false;
                        break;
                    }
                }
            }
            if ((jeste == true) && (pravi_uglovi == true))
            {
                Console.WriteLine("Jeste");
            }
            else
            {
                Console.WriteLine("Nije");
            }
            */
            /**********************************************************************************************************/

            Poligon prvi = new Poligon(3);
            prvi.temena[0] = new Tacka(6, 8);
            prvi.temena[1] = new Tacka(2, 6);
            prvi.temena[2] = new Tacka(8, 2);

            Vektor AB = new Vektor(prvi.temena[0], prvi.temena[1]);
            Vektor BC = new Vektor(prvi.temena[1], prvi.temena[2]);
            Vektor CA = new Vektor(prvi.temena[2], prvi.temena[0]);

            Vektor[] vektori = new Vektor[3];
            vektori[0] = AB;
            vektori[1] = BC;
            vektori[2] = CA;

            double[] uglovi = new double[3];
            for (int i = 0; i < 3; i++)
            {
                double a = Vektor.Skalarni(vektori[i], vektori[(i + 1) % 3]);
                uglovi[i] = a;
            }
            double max = uglovi[0];
            for (int i = 1; i < 3; i++)
            {
                if (uglovi[i] > max) max = uglovi[i];
            }
            if (max == 0)
            {
                Console.WriteLine("Prav");
            }
            else if (max > 0)
            {
                Console.WriteLine("Tup");
            }
            else
            {
                Console.WriteLine("Ostar");
            }
        }
    }
}
