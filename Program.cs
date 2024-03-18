using System;
using System.Collections.Generic;
using System.IO;
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
            /*
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
                        */


            /*****************************************************************************************************/

            Console.WriteLine("Dobro dosli u svet poligona.\nUzivajte u igranju sa poligonima.");
            int akcija = 1;
            Poligon pol = new Poligon(100);
            while (akcija != 0)
            {
                Console.WriteLine("Unesite broj akcije koju zelite da izvrsite.");
                Console.WriteLine("1 Unos poligona\n2 Snimi u fajl\n3 Ucitaj iz fajla\n4 Prost\n5 Povrsina\n6 Obim\n7 Konveksan\n8 Tacka unutra\n9 Konveksni omotac\n0 Izlaz");
                akcija = Convert.ToInt32(Console.ReadLine());
                if (akcija == 1)
                {                   
                    Console.WriteLine("Unesite broj temena.");
                    int broj_temena = Convert.ToInt32(Console.ReadLine());
                    pol.broj_temena = broj_temena;
                    for (int i = 0; i < broj_temena; i++)
                    {
                        Console.WriteLine("Unesite koordinate temena odvojene razmakom.");
                        string[] koo = Console.ReadLine().Split(' ');
                        Tacka pom = new Tacka(Convert.ToDouble(koo[0]), Convert.ToDouble(koo[1]));
                        pol.temena[i] = pom;
                    }
                }
                if (akcija == 2)
                {
                    const string putanja = "Poligon.txt";
                    StreamWriter pisac = new StreamWriter(putanja);
                    pisac.WriteLine(pol.broj_temena);
                    for (int i = 0; i < pol.broj_temena; i++)
                    {
                        pisac.WriteLine(pol.temena[i].x + " " + pol.temena[i].y);
                    }
                    pisac.Close();
                }
                if (akcija == 3)
                {
                    const string putanja = "Poligon.txt";
                    StreamReader citac = new StreamReader(putanja);
                    pol.broj_temena = Convert.ToInt32(citac.ReadLine());
                    for (int i = 0; i < pol.broj_temena; i++)
                    {
                        string[] pom = citac.ReadLine().Split(' ');
                        Tacka tacka = new Tacka(Convert.ToDouble(pom[0]), Convert.ToDouble(pom[1]));
                        pol.temena[i] = tacka;
                    }
                    citac.Close();
                }
                if (akcija == 4)
                {                   
                    if (pol.Prost()) Console.WriteLine("Jeste prost.");
                    else Console.WriteLine("Nije prost.");
                }
                if (akcija == 5)
                {
                    if (pol.Prost()) Console.WriteLine("Povrsina: " + pol.Povrsina());
                    else Console.WriteLine("Poligon nije prost");
                }
                if (akcija == 6)
                {
                    if (pol.Prost()) Console.WriteLine("Obim: " + pol.Obim());
                    else Console.WriteLine("Poligon nije prost");
                }
                if (akcija == 7)
                {
                    if (pol.Prost())
                    {
                        if (pol.Konveksan()) Console.WriteLine("Poligon je konveksan");
                        else Console.WriteLine("Poligon nije konveksan");
                    }
                    else Console.WriteLine("Poligon nije prost");
                }
                if (akcija == 8)
                {
                    Console.WriteLine("Unesite tacku koju zelite da proverite.");
                    string[] pom = Console.ReadLine().Split();
                    Tacka T = new Tacka(Convert.ToDouble(pom[0]), Convert.ToDouble(pom[1]));
                    if (pol.Pripada_Poligonu(T)) Console.WriteLine("Tacka se nalazi u poligonu.");
                    else Console.WriteLine("Tacka se ne nalazi u poligonu.");
                }
                if (akcija == 9)
                {
                    pol.KonveksniOmotac();
                }
            }
        }
    }
}
