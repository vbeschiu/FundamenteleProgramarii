using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace FP_SET1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Meniu();
        }
        /// <summary>
        /// Meniu al problemelor din setul 1 de probleme
        /// </summary>
        private static void Meniu()
        {
            int p = -1;
            do
            {
                Console.WriteLine("Alegeti o problema introducad numarul corespunzator din lista de mai jos:");
                Console.WriteLine();
                Console.WriteLine("0. IESIRE");
                Console.WriteLine("1. Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. ");
                Console.WriteLine("2. Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. ");
                Console.WriteLine("3. Determinati daca n se divide cu k, unde n si k sunt date de intrare. ");
                Console.WriteLine("4. Detreminati daca un an y este an bisect. ");
                Console.WriteLine("5. Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. ");
                Console.WriteLine("6. Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.");
                Console.WriteLine("7. (Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor. ");
                Console.WriteLine("8. (Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare. ");
                Console.WriteLine("9. Afisati toti divizorii numarului n.");
                Console.WriteLine("10. Test de primalitate: determinati daca un numar n este prim.");
                Console.WriteLine("11. Afisati in ordine inversa cifrele unui numar n.");
                Console.WriteLine("12. Determinati cate numere integi divizibile cu n se afla in intervalul [a, b].");
                Console.WriteLine("13. Determianti cati ani bisecti sunt intre anii y1 si y2.");
                Console.WriteLine("14. Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321.");
                Console.WriteLine("15. Se dau 3 numere. Sa se afiseze in ordine crescatoare.");
                Console.WriteLine("16. Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)");
                Console.WriteLine("17. Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid.");
                Console.WriteLine("18. Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1176 afisati 2^3 x 3^1 x 7^2.");
                Console.WriteLine("19. Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt.");
                Console.WriteLine("20. Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3).");
                Console.WriteLine("21. Ghiciti un numar intre 1 si 1024 prin intrebari de forma \"numarul este mai mare sau egal decat x?");
                try
                {
                    p = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                { }

                if (p == 0)
                    break;
                else
                {
                    if (p >= 0 && p <= 21)
                    {
                        switch (p)
                        {
                            case 1: Console.Clear(); P1(); Console.WriteLine("Apasati Enter pentu a merge la meniu."); Console.ReadLine(); break;
                            case 2: Console.Clear(); P2(); Console.WriteLine("Apasati Enter pentu a merge la meniu."); Console.ReadLine(); break;
                            case 3: Console.Clear(); P3(); Console.WriteLine("Apasati Enter pentu a merge la meniu."); Console.ReadLine(); break;
                            case 4: Console.Clear(); P4(); Console.WriteLine("Apasati Enter pentu a merge la meniu."); Console.ReadLine(); break;
                            case 5: Console.Clear(); P5(); Console.WriteLine("Apasati Enter pentu a merge la meniu."); Console.ReadLine(); break;
                            case 6: Console.Clear(); P6(); Console.WriteLine("Apasati Enter pentu a merge la meniu."); Console.ReadLine(); break;
                            case 7: Console.Clear(); P7(); Console.WriteLine("Apasati Enter pentu a merge la meniu."); Console.ReadLine(); break;
                            case 8: Console.Clear(); P8(); Console.WriteLine("Apasati Enter pentu a merge la meniu."); Console.ReadLine(); break;
                            case 9: Console.Clear(); P9(); Console.WriteLine("Apasati Enter pentu a merge la meniu."); Console.ReadLine(); break;
                            case 10: Console.Clear(); P10(); Console.WriteLine("Apasati Enter pentu a merge la meniu."); Console.ReadLine(); break;
                            case 11: Console.Clear(); P11(); Console.WriteLine("Apasati Enter pentu a merge la meniu."); Console.ReadLine(); break;
                            case 12: Console.Clear(); P12(); Console.WriteLine("Apasati Enter pentu a merge la meniu."); Console.ReadLine(); break;
                            case 13: Console.Clear(); P13(); Console.WriteLine("Apasati Enter pentu a merge la meniu."); Console.ReadLine(); break;
                            case 14: Console.Clear(); P14(); Console.WriteLine("Apasati Enter pentu a merge la meniu."); Console.ReadLine(); break;
                            case 15: Console.Clear(); P15(); Console.WriteLine("Apasati Enter pentu a merge la meniu."); Console.ReadLine(); break;
                            case 16: Console.Clear(); P16(); Console.WriteLine("Apasati Enter pentu a merge la meniu."); Console.ReadLine(); break;
                            case 17: Console.Clear(); P17(); Console.WriteLine("Apasati Enter pentu a merge la meniu."); Console.ReadLine(); break;
                            case 18: Console.Clear(); P18(); Console.WriteLine("Apasati Enter pentu a merge la meniu."); Console.ReadLine(); break;
                            case 19: Console.Clear(); P19(); Console.WriteLine("Apasati Enter pentu a merge la meniu."); Console.ReadLine(); break;
                            case 20: Console.Clear(); P20(); Console.WriteLine("Apasati Enter pentu a merge la meniu."); Console.ReadLine(); break;
                            case 21: Console.Clear(); P21(); Console.WriteLine("Apasati Enter pentu a merge la meniu."); Console.ReadLine(); break;

                        }

                    }
                }
            } while (p >= 0 && p <= 21);
        }
        /// <summary>
        /// Genereaza un numar aleator intre 1 si 1024. Acesta de poate ghici prin intrebari de forma "Numarul este mai mare sau egaldecat x?
        /// </summary>
        private static void P21()
        {
            Console.WriteLine("21. Ghiciti un numar intre 1 si 1024 prin intrebari de forma \"numarul este mai mare sau egal decat x?"); Console.WriteLine();

            int n = new Random().Next(1, 1025);
            int x = 0;
            Console.WriteLine("Ghiciti un numar intre 1 si 1024..");
            Console.WriteLine();
            while (n != x)
            {
                Console.Write("Numarul este mai mare sau egal decat.. ");
                x = int.Parse(Console.ReadLine());
                if (n > x)
                    Console.WriteLine("DA");
                else
                if (n < x)
                    Console.WriteLine("NU");
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Felicitari! Numarul este {n}");
                    Console.WriteLine();
                }
            }

        }
        /// <summary>
        /// Afiseaza frctii zecimale, cu perioada intre paranteze (daca e cazul)
        /// </summary>
        private static void P20()
        {
            Console.WriteLine("20. Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3)."); Console.WriteLine();
            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int parteInt, parteFract;
            parteInt = m / n;
            parteFract = m % n;
            Console.Write($"{parteInt},");
            int cifra, rest;
            List<int> resturi = new List<int>();
            List<int> cifre = new List<int>();
            resturi.Add(parteFract);
            bool periodic = false;
            do
            {
                cifra = parteFract * 10 / n;
                cifre.Add(cifra);
                rest = parteFract * 10 % n;
                if (!resturi.Contains(rest))
                {
                    resturi.Add(rest);
                }
                else
                {
                    periodic = true;
                    break;
                }
                parteFract = rest;
            } while (rest != 0);

            if (!periodic)
            {
                foreach (var item in cifre)
                {
                    Console.Write(item);
                }
            }
            else
            {
                for (int i = 0; i < resturi.Count; i++)
                {
                    if (resturi[i] == rest)
                    {
                        Console.Write("(");
                    }
                    Console.Write(cifre[i]);
                }
                Console.WriteLine(")");
            }
        }
        /// <summary>
        /// Determina daca un numar este foarmat doar din doua cifre care se pot repeta
        /// </summary>
        private static void P19()
        {
            Console.WriteLine("19. Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt."); Console.WriteLine();
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
                n *= -1;
            string s = n.ToString();
            string result = "";
            var unique = new HashSet<char>(s);
            foreach (char c in unique)
                result += c;
            if (result.Length == 2)
                Console.WriteLine("Numarul este format doar cu doua cifre care se pot repeta.");
            else
                Console.WriteLine("Numarul NU este format doar cu doua cifre care se pot repeta.");
            Console.WriteLine();
        }

        /// <summary>
        /// Desccompune un numar in facori primi
        /// </summary>
        private static void P18()
        {
            Console.WriteLine("18. Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1176 afisati 2^3 x 3^1 x 7^2."); Console.WriteLine();
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            string result = "";
            bool prim = true;
            for (int i = 2; i * i < n; i++)
                if (n % i == 0)
                    prim = false;
            if (prim)
                Console.WriteLine($"{n}^1");

            else
            {
                int p, fp = 2;
                while (n > 1)
                {
                    p = 0;
                    while (n % fp == 0)
                    {
                        p++;
                        n /= fp;
                    }
                    if (p != 0)
                        result += $"{fp}^{p} x ";
                    fp++;
                }
            }
            Console.WriteLine(result.Remove(result.Length - 3));
            Console.WriteLine();
        }
        /// <summary>
        /// Caculeaze CMMDC CMMMC a doua numere
        /// </summary>
        private static void P17()
        {
            Console.WriteLine("17. Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid."); Console.WriteLine();
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            int a1 = a, b1 = b;
            while (a1 != b1)
            {
                if (a1 < b1)
                    b1 -= a1;
                else
                    a1 -= b1;
            }
            Console.Write($"Cel mai mare divizor comun al lui {a} si al lui {b} este: ");
            Console.WriteLine(a1);
            a1 = a;
            b1 = b;
            while (a1 != b1)
            {
                if (a1 < b1)
                    a1 += a;
                else
                    b1 += b;
            }
            Console.Write($"Cel mai mic multiplu comun al lui {a} si al lui {b} este: ");
            Console.WriteLine(a1);
            Console.WriteLine();
        }
        /// <summary>
        /// Afiseaza 5 numere in ordine crescatoare
        /// </summary>
        private static void P16()
        {
            Console.WriteLine("16. Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)"); Console.WriteLine();
            int a, b, c, d, e, min;
            Console.WriteLine("Introduceti valorile pentr a, b, c, d si e separate printr-un spatiu..");
            string line = Console.ReadLine();
            char[] sep = { ' ', ',', ';', '/' };
            string[] tokens = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            a = int.Parse(tokens[0]);
            b = int.Parse(tokens[1]);
            c = int.Parse(tokens[2]);
            d = int.Parse(tokens[3]);
            e = int.Parse(tokens[4]);
            unsafe
            {
                for (int i = 0; i < 5; i++)
                {
                    min = Int32.MaxValue;
                    int* p = &min;
                    if (a < min)
                    {
                        min = a;
                        p = &a;
                    }
                    if (b < min)
                    {
                        min = b;
                        p = &b;
                    }
                    if (c < min)
                    {
                        min = c;
                        p = &c;
                    }
                    if (d < min)
                    {
                        min = d;
                        p = &d;
                    }
                    if (e < min)
                    {
                        min = e;
                        p = &e;
                    }
                    *p = Int32.MaxValue;
                    Console.Write($"{min} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Afiseaza 3 numere in ordine crescatoare
        /// </summary>
        private static void P15()
        {
            Console.WriteLine("15. Se dau 3 numere. Sa se afiseze in ordine crescatoare."); Console.WriteLine();
            int a, b, c, aux;
            Console.WriteLine("Introduceti valorilile pentr a, b si c, separate printr-un spatiu..");
            string line = Console.ReadLine();
            char[] sep = { ' ', ',', ';', '/' };
            string[] tokens = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            a = int.Parse(tokens[0]);
            b = int.Parse(tokens[1]);
            c = int.Parse(tokens[2]);
            if (a > b)
            {
                aux = a;
                a = b;
                b = aux;
            }
            if (a > c)
            {
                aux = a;
                a = c;
                c = aux;
            }
            if (b > c)
            {
                aux = b;
                b = c;
                c = aux;
            }
            Console.WriteLine($"{a} {b} {c}");
            Console.WriteLine();
        }

        /// <summary>
        /// Determina daca un numar n este palindrom.
        /// </summary>
        private static void P14()
        {
            Console.WriteLine("14. Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321."); Console.WriteLine();
            Console.Write("n = ");
            string n = Console.ReadLine();
            string nr = "";
            for (int i = n.Length - 1; i >= 0; i--)
                nr += n.Substring(i, 1);
            if (n == nr)
                Console.WriteLine($"Numarul {n} este palindrom.");
            else
                Console.WriteLine($"Numarul {n} NU este palindrom.");
            Console.WriteLine();
        }
        /// <summary>
        /// Determina cati ani bisecti sunt intre doi ani.
        /// </summary>
        private static void P13()
        {
            Console.WriteLine("13. Determianti cati ani bisecti sunt intre anii y1 si y2."); Console.WriteLine();
            int y1, y2, nr = 0;
            Console.Write("y1 = ");
            y1 = int.Parse(Console.ReadLine());
            Console.Write("y2 = ");
            y2 = int.Parse(Console.ReadLine());
            for (int i = y1; i <= y2; i++)
                if ((i % 400 == 0) || ((i % 4 == 0) && (i % 100 != 0)))
                    nr++;
            if (nr == 1)
                Console.WriteLine($"Intre anii {y1} si {y2} este {nr} an bisect.");
            else
                if (nr <= 19)
                Console.WriteLine($"Intre anii {y1} si {y2} sunt {nr} ani bisecti.");
            else
                Console.WriteLine($"Intre anii {y1} si {y2} sunt {nr} de ani bisecti.");
            Console.WriteLine();
        }
        /// <summary>
        /// Determina cati divizori are n in intervalul [a, b].
        /// </summary>
        private static void P12()
        {
            Console.WriteLine("12. Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]."); Console.WriteLine();
            int n, a, b, nr = 0;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
                if (n % i == 0)
                    nr++;
            Console.WriteLine($"In intervalul [{a}, {b}] sunt {nr} divizori ai lui {n}");
            Console.WriteLine();
        }
        /// <summary>
        /// Afiseaza in ordine innversa cifrele uni numar.
        /// </summary>
        private static void P11()
        {
            Console.WriteLine("11. Afisati in ordine inversa cifrele unui numar n."); Console.WriteLine();
            int n, ni;
            ni = 0;
            Console.Write("n = ");
            n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                ni = ni * 10 + n % 10;
                n /= 10;
            }
            Console.WriteLine($"Cifrele in ordine inversa sunt: {ni}");
            Console.WriteLine();

        }
        /// <summary>
        /// Determina daca un numar este prim.
        /// </summary>
        private static void P10()
        {
            Console.WriteLine("10. Test de primalitate: determinati daca un numar n este prim."); Console.WriteLine();
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            bool prim = true;
            for (int i = 2; i * i < n; i++)
                if (n % i == 0)
                    prim = false;
            if (prim)
                Console.WriteLine("Numarul este prim.");
            else
                Console.WriteLine("Numarul NU este prim.");
            Console.WriteLine();
        }
        /// <summary>
        /// Afiseaza toti divizorii unui numar
        /// </summary>
        private static void P9()
        {
            Console.WriteLine("9. Afisati toti divizorii numarului n. "); Console.WriteLine();
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Divizorii numarului {n} sunt: ");
            for (int i = 1; i <= n; i++)
                if (n % i == 0)
                    Console.WriteLine(i);
            Console.WriteLine();
        }
        /// <summary>
        /// Inverseaza valorile a doua variabile fara variabila auxiliara
        /// </summary>
        private static void P8()
        {
            Console.WriteLine("8. (Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare."); Console.WriteLine();
            int a, b;
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Numerele inversate sunt:");
            a += b;
            b = a - b;
            a -= b;
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine();
        }
        /// <summary>
        /// Inverseaza valorile a doua variabile (cu variabila auxiliara)
        /// </summary>
        private static void P7()
        {
            Console.WriteLine("7. (Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor."); Console.WriteLine();
            int a, b, c = 0;
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Numerele inversate sunt:");
            c = a;
            a = b;
            b = c;
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine();
        }
        /// <summary>
        /// Determina daca trei numere pot fi laturile unu triunghi
        /// </summary>
        private static void P6()
        {
            Console.WriteLine("6. Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi."); Console.WriteLine();
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());
            if (a < b + c && b < a + c && c < a + b)
                Console.WriteLine($"Numerele {a}, {b} si {c} pot fi laturile unui triunghi");
            else
                Console.WriteLine($"Numerele {a}, {b} si {c} NU pot fi laturile unui triunghi");
            Console.WriteLine();
        }
        /// <summary>
        /// Afiseaza a k-a cifra de la sfarsitul unui numar.
        /// Cifrele se numara de la dreapta la stanga
        /// </summary>
        private static void P5()
        {
            Console.WriteLine("5. Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. "); Console.WriteLine();
            Console.Write("n = ");
            string n = Console.ReadLine();
            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());
            Console.Write($"A {k}-a cifra este: ");
            Console.WriteLine(n.Substring(n.Length - k, 1));
            Console.WriteLine();
        }
        /// <summary>
        /// Detremina daca un an y este an bisect.
        /// </summary>
        private static void P4()
        {
            Console.WriteLine("4. Detreminati daca un an y este an bisect. "); Console.WriteLine();
            int y;
            Console.Write("Introduceti anul...");
            y = int.Parse(Console.ReadLine());
            if ((y % 400 == 0) || ((y % 4 == 0) && (y % 100 != 0)))
                Console.WriteLine("Anul este bisect ");
            else
                Console.WriteLine("Anule NU este bisect");
            Console.WriteLine();
        }
        /// <summary>
        /// Determina daca n se divide cu k
        /// </summary>
        private static void P3()
        {
            Console.WriteLine("3. Determinati daca n se divide cu k, unde n si k sunt date de intrare. "); Console.WriteLine();
            int n, k;
            Console.WriteLine("Introduceti cele doua numere n si k separate printr-un stpatiu..");
            string[] variabile = Console.ReadLine().Split(' ');
            n = int.Parse(variabile[0]);
            k = int.Parse(variabile[1]);
            if (n % k == 0)
            {
                Console.WriteLine($"{n} se divide cu {k}");
            }
            else
            {
                Console.WriteLine($"{n} NU se divide cu {k}");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Rezolva ecuatia de gradul 2 ax^2 + bx + c = 0
        /// </summary>
        private static void P2()
        {
            Console.WriteLine("2. Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile."); Console.WriteLine();
            double a, b, c, x1, x2, delta;
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = int.Parse(Console.ReadLine());
            delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"x1 = {x1}");
                Console.WriteLine($"x2 = {x2}");
            }
            else
            {
                if (delta == 0)
                {
                    x1 = (-b / (2 * a));
                    Console.WriteLine($"x1 = x2 = {x1}");
                }
                else
                {
                    Console.WriteLine("Discriminantul ecuatiei este negativ deci solutiile ecuaitiei sunt numere complexe");
                }

            }
            Console.WriteLine();
        }
        /// <summary>
        /// Rezolva ecuatia de gradul 1 ax+b = 0
        /// </summary>
        private static void P1()
        {
            Console.WriteLine("1. Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare."); Console.WriteLine();
            double a, b, x;
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            b = int.Parse(Console.ReadLine());
            x = -1 * b / a;
            Console.WriteLine($"Pentru ecuatia {a} x + {b} = 0,");
            Console.WriteLine($"x = {x}");
            Console.WriteLine();
        }
    }
}
