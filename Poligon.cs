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
        public double Obim()
        {
            double obim = 0;
            for (int i = 0; i < broj_temena; i++)
            {
                Vektor novi = new Vektor(temena[i], temena[(i + 1) % broj_temena]);
                obim += novi.Duzina();
            }
            return obim;
        }
        public bool Prost()
        {
            Vektor[] nizV = new Vektor[broj_temena];
            for (int i = 0; i < broj_temena; i++)
            {
                Vektor v = new Vektor(temena[i], temena[(i + 1) % broj_temena]);
                nizV[i] = v;
            }
            for (int i = 0; i < broj_temena - 1; i++)
            {
                for (int j = i + 1; j < broj_temena; j++)
                {
                    if (Tacka.Jednake(temena[i], temena[j]))
                    {
                        return false;
                    }
                }
            }
            bool prost = true;
            for (int i = 0; i < broj_temena - 2; i++)
            {
                for (int j = 0; j < broj_temena - 3; j++)
                {
                    if (Funkcije.Presek1(nizV[i], nizV[(i + j + 2) % broj_temena])) prost = false;
                }
            }
            return prost;

        }
        public double Povrsina()
        {
            double povrsina = 0;
            for (int i = 0; i < broj_temena; i++)
            {
                Tacka A = temena[i];
                Tacka B = temena[(i + 1) % broj_temena];
                povrsina = povrsina + (A.x * B.y - B.x * A.y);
            }
            return Math.Abs(povrsina) / 2;

        }
        public bool Pripada_Poligonu(Tacka N)
        {
            double xmax = temena[0].x;
            for (int i = 1; i < broj_temena; i++)
            {
                if (temena[i].x > xmax) xmax = temena[i].x;
            }
            Tacka M = new Tacka(xmax + 1, N.y);
            Vektor ispit1 = new Vektor(N, M);
            int br_preseka = 0;
            for (int i = 0; i < broj_temena; i++)
            {
                Vektor ispit2 = new Vektor(temena[i], temena[(i + 1) % broj_temena]);
                if (Funkcije.Presek(ispit1, ispit2)) br_preseka++;
                if (Vektor.Presek(ispit1, temena[(i + 1) % broj_temena]))
                {
                    Vektor pom = new Vektor(temena[i], temena[(i + 2) % broj_temena]);
                    if (Funkcije.SIS(pom, N, M) == 2) br_preseka++;
                }
            }
            if (br_preseka % 2 == 0) return false;
            else return true;

        }
        public Poligon KonveksniOmotac()
        {
            if (Konveksan())
            {
                Console.WriteLine("Indexi tacaka koje cine konveksni omotac:");
                for (int i = 0; i < broj_temena; i++)
                {
                    Console.WriteLine(i);
                }
                return this;
            }
            double pom_x = temena[0].x;
            double pom_y = temena[0].y;
            for (int i = 1; i < broj_temena; i++)
            {
                if (temena[i].x < pom_x)
                {
                    pom_x = temena[i].x;
                    pom_y = temena[i].y;
                }
                else
                {
                    if (temena[i].x == pom_x)
                    {
                        if (temena[i].y < pom_y)
                        {
                            pom_y = temena[i].y;
                        }
                    }
                }
            }

            Tacka prva = new Tacka(pom_x, pom_y);

            int index1 = 0;
            for (int i = 0; i < broj_temena; i++)
            {
                if ((temena[i].x == pom_x) && (temena[i].y == pom_y))
                {
                    index1 = i;
                }
            }
            List<Tacka> omotac = new List<Tacka>();
            omotac.Add(temena[index1]);
            Tacka[] SortTeme = new Tacka[broj_temena];
            for (int i = 0; i < broj_temena; i++)
            {
                SortTeme[i] = temena[(index1 + i) % broj_temena];
            }
            index1 = 0;
            double min_ugao = 90;
            int index2 = 0;
            List<int> indexi = new List<int>();
            for (int i = 1; i < broj_temena; i++)
            {
                double pomx = SortTeme[(index1 + i) % broj_temena].x - SortTeme[index1].x;
                double pomy = SortTeme[(index1 + i) % broj_temena].y - SortTeme[index1].y;
                double pomugao = Math.Atan2(pomy, pomx);
                if (pomugao < min_ugao)
                {
                    min_ugao = pomugao;
                    index2 = (index1 + i) % broj_temena;
                }

            }
            for (int i = index2; i > 0; i--)
            {
                indexi.Add(i);
            }
            omotac.Add(SortTeme[index2]);
            
            while (index2 != index1)
            {
                min_ugao = 180;
                int index3 = 0;
                Tacka pom = SortTeme[index2];               
                for (int i = index2 + 1; i <= broj_temena; i++)
                {
                    if (indexi.Contains(i % broj_temena)) continue;
                    Tacka kraj = SortTeme[i % broj_temena];
                    double temp_ugao = 0;
                    double temp_x = kraj.x - pom.x;
                    double temp_y = kraj.y - pom.y;
                    if (kraj.y < pom.y && kraj.x < pom.x)
                    {
                        temp_ugao = 2 * Math.PI + Math.Atan2(temp_y, temp_x);
                    }
                    else
                    {
                        temp_ugao = Math.Atan2(temp_y, temp_x);
                    }
                    if (temp_ugao < min_ugao)
                    {
                        min_ugao = temp_ugao;
                        index3 = i % broj_temena;
                    }

                }
                for (int i = index3; i > 0; i--)
                {
                    indexi.Add(i);
                }
                omotac.Add(temena[index3]);

                index2 = index3;
            }
            Console.WriteLine("Indexi tacaka koje cine konveksni omotac:");
            foreach (var T in omotac)
            {
                Console.Write(Array.IndexOf(temena, T) + " ");
            }
            return null;

        }
    }
}
