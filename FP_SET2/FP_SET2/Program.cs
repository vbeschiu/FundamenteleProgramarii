using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Net.NetworkInformation;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace FP_SET2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Meniu();             
        }
        private static void Meniu()
        {
            int p = -1;
            do
            {
                Console.WriteLine("Alegeti o problema introducad numarul corespunzator din lista de mai jos:");
                Console.WriteLine();
                Console.WriteLine("0. IESIRE");
                Console.WriteLine("1. Se da o secventa de n numere. Sa se determine cate din ele sunt pare. ");
                Console.WriteLine("2. Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive.");
                Console.WriteLine("3. Calculati suma si produsul numerelor de la 1 la n.");
                Console.WriteLine("4. Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a.");
                Console.WriteLine("5. Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa.");
                Console.WriteLine("6. Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. ");
                Console.WriteLine("7. Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. ");
                Console.WriteLine("8. Determianti al n-lea numar din sirul lui Fibonacci.");
                Console.WriteLine("9. Sa se determine daca o secventa de n numere este monotona.");
                Console.WriteLine("10. Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. ");
                Console.WriteLine("11. Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. ");
                Console.WriteLine("12. Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere.");
                Console.WriteLine("13. Determinati daca o secventa de n numere este o secventa crescatoare rotita. ");
                Console.WriteLine("14. Determinati daca o secventa de n numere este o secventa monotona rotita. ");
                Console.WriteLine("15. Se da o secventa de n numere. Sa se determine daca este bitonica. ");
                Console.WriteLine("16. Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita. ");
                Console.WriteLine("17. Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor. De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta. ");
                string m = "Apasati Enter pentu a merge la meniu.";
                try
                {
                    Console.WriteLine();
                    p = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                { }

                if (p == 0)
                    break;
                else
                {
                    if (p >= 0 && p <= 17)
                    {
                        switch (p)
                        {
                            case 1: Console.Clear(); P1(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                            case 2: Console.Clear(); P2(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                            case 3: Console.Clear(); P3(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                            case 4: Console.Clear(); P4(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                            case 5: Console.Clear(); P5(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                            case 6: Console.Clear(); P6(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                            case 7: Console.Clear(); P7(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                            case 8: Console.Clear(); P8(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                            case 9: Console.Clear(); P9(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                            case 10: Console.Clear(); P10(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                            case 11: Console.Clear(); P11(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                            case 12: Console.Clear(); P12(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                            case 13: Console.Clear(); P13(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                            case 14: Console.Clear(); P14(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                            case 15: Console.Clear(); P15(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                            case 16: Console.Clear(); P16(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                            case 17: Console.Clear(); P17(); Console.WriteLine(m); Console.ReadLine(); Console.Clear(); break;
                            

                        }

                    }
                }
            } while (p >= 0 && p <= 17);
        }
        /// <summary>
        /// Dtermina cate numere dintr-o secventa sunt pare.
        /// </summary>
        private static void P1()
        {
            Console.WriteLine("1. Se da o secventa de n numere. Sa se determine cate din ele sunt pare."); Console.WriteLine();
            //Console.WriteLine("Introduceti numerele separate printr-un spatiu..");
            //string l = Console.ReadLine();
            //char[] sep = { ' ', ';', ',', };
            //string[] s = l.Split(sep, StringSplitOptions.RemoveEmptyEntries);
            //int even = 0;
            //for (int i = 0; i < s.Length; i++)
            //{
            //    int x = int.Parse(s[i]);
            //    if (x % 2 == 0)
            //        even++;
            //}
            //if(even == 1)
            //Console.WriteLine($"In secventa data este {even} numar par.");
            //else if(even == 0 || (even >= 2 && even <= 19))
            //    Console.WriteLine($"In secventa data sunt {even} numere pare.");
            //else Console.WriteLine($"In secventa data sunt {even} de numere pare.");
            //Console.WriteLine();

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int even = 0;
            for(int i = 0; i < n; i++)
            {
                Console.Write($"n{i + 1} = ");
                int x = int.Parse(Console.ReadLine());
                if(x % 2 == 0)
                    even++;
            }
            if (even == 1)
                Console.WriteLine($"In secventa data este {even} numar par.");
            else if (even == 0 || (even >= 2 && even <= 19))
                Console.WriteLine($"In secventa data sunt {even} numere pare.");
            else Console.WriteLine($"In secventa data sunt {even} de numere pare.");
            Console.WriteLine();
        }
        /// <summary>
        /// Determina cate numere dintr-o secventa sunt negative, zero si pozitive.
        /// </summary>
        private static void P2()
        {
            Console.WriteLine("2. Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive."); Console.WriteLine();
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int nn = 0, zn = 0, pn = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"n{i + 1} = ");
                int x = int.Parse(Console.ReadLine());
                if (x < 0) nn++;
                else if (x > 0) pn++;
                else zn++;
            }
            Console.WriteLine();
            Console.WriteLine($"In secventa data sunt {nn} numere negative");
            Console.WriteLine($"In secventa data sunt {zn} numere zero");
            Console.WriteLine($"In secventa data sunt {pn} numere pozitive");
            Console.WriteLine();
        }
        /// <summary>
        /// Calculeaza suma si produsul numererlor de la 1 la n.
        /// </summary>
        private static void P3()
        {
            Console.WriteLine("3. Calculati suma si produsul numerelor de la 1 la n. "); Console.WriteLine();
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            BigInteger product = 1;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
                product *= i;
            }
            Console.WriteLine($"Suma numerelor de la 1 la {n} este {sum}");
            Console.WriteLine($"Produsul numerelor de la 1 la {n} este {product}");
            Console.WriteLine();
        }
        /// <summary>
        /// Afiseaca pozitia unui numar dintr-o secventa daca acesta se regaseste in acea secventa.
        /// </summary>
        private static void P4()
        {
            Console.WriteLine("4. Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. " +
                              "Se considera ca primul element din secventa este pe pozitia zero. " +
                              "Daca numarul nu se afla in secventa raspunsul va fi -1. "); Console.WriteLine();
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            int pa = -1;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"n{i + 1} = ");
                int x = int.Parse(Console.ReadLine());
                if (x == a)
                {
                    pa = i;
                    break;
                }
            }
            Console.WriteLine(pa);
            Console.WriteLine();
        }
        /// <summary>
        /// Afiseaza cate elemente dintr-o scventa au valoare egala cu pozitia acestora.
        /// </summary>
        private static void P5()
        {
            Console.WriteLine("5. Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. " +
                              "Se considera ca primul element din secventa este pe pozitia 0. "); Console.WriteLine();
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"n{i + 1} = ");
                int x = int.Parse(Console.ReadLine());
                if (x == i)
                    counter++;
            }
            Console.WriteLine($"Exsista {counter} elemente egale cu pozitia lor in secveta");
            Console.WriteLine();
        }
        /// <summary>
        /// Afiseaza un mesaj daca numerele dintr-o secventa sunt sau nu crescatoare
        /// </summary>
        private static void P6()
        {
            Console.WriteLine("6. Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare."); Console.WriteLine();
            Console.WriteLine("Introduceti numerele separate printr-un spatiu..");
            string[] s = Console.ReadLine().Split(' ');
            bool IsAscending = true;
            for (int i = 1; i < s.Length; i++)
                if (Convert.ToInt32(s[i - 1]) > Convert.ToInt32(s[i]))
                    IsAscending = false;
            if (IsAscending)
                Console.WriteLine($"Numerele din secventa sunt crescatoare");
            else Console.WriteLine($"Numerele din secventa NU sunt crescatoare");
            Console.WriteLine();
        }
        /// <summary>
        /// Determina cel mai mare numar dintr-o secventa
        /// </summary>
        private static void P7()
        {
            Console.WriteLine("7. Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa."); Console.WriteLine();
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int max = Int32.MinValue;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"n{i + 1} = ");
                int x = int.Parse(Console.ReadLine());
                if (x > max) max = x;
            }
            Console.WriteLine($"Maximul este {max}");
            Console.WriteLine();
        }
        /// <summary>
        /// Determina al n-lea numar din sirul lui Fibonacci
        /// </summary>
        private static void P8()
        {
            Console.WriteLine("8. Determianti al n-lea numar din sirul lui Fibonacci. " +
                              "Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). " +
                              "Exemplu: 0, 1, 1, 2, 3, 5, 8 ..."); Console.WriteLine();
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int f1 = 0, f2 = 1, fi = 0;
            if (n == 1) Console.WriteLine($"f1 = 1");
            else if (n == 2) Console.WriteLine($"f2 = 2");
            else 
                for (int i = 3; i <= n; i++)
                {
                    fi = f2 + f1;
                    f1 = f2;
                    f2 = fi;
                }
            Console.WriteLine($"f{n} = {fi}");
            Console.WriteLine();
        }
        /// <summary>
        /// Determina daca o secventa de n numere este monotona.
        /// </summary>
        private static void P9()
        {
            Console.WriteLine("9. Sa se determine daca o secventa de n numere este monotona." +
                              "Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. "); Console.WriteLine();
            Console.WriteLine("Introduceti numerele separate printr-un spatiu..");
            string[] s = Console.ReadLine().Split(' ');
            bool IsAscending = true, IsDescending = true;
            for (int i = 1; i < s.Length; i++)
                if (Convert.ToInt32(s[i - 1]) > Convert.ToInt32(s[i]))
                    IsAscending = false;
            else if (Convert.ToInt32(s[i - 1]) < Convert.ToInt32(s[i]))
                    IsDescending = false;
            if (IsAscending)
                Console.WriteLine($"Secventa este monoton crescatoare");
            else if(IsDescending)
                Console.WriteLine($"Secventa este monoton descrescatoare");
            else Console.WriteLine($"Secventa NU este monotona");
            Console.WriteLine();
        }
        /// <summary>
        /// Determina numarul maxim de numere consecutive egale din secventa.
        /// </summary>
        private static void P10()
        {
            Console.WriteLine("10. Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa."); Console.WriteLine();
            Console.WriteLine("Introduceti numerele separate printr-un spatiu..");
            string[] s = Console.ReadLine().Split(' ');
            int counter = 1, counter2 = 1;
            for (int i = 1; i < s.Length; i++)
            {
                if (Convert.ToInt32(s[i - 1]) == Convert.ToInt32(s[i]))
                    counter++;
                else counter = 1;
                if(counter > counter2)
                    counter2 = counter;
            }
            if (counter2 == 1)
                Console.WriteLine("In secventa NU exista numere egale consecutive");
            else
                Console.WriteLine($"Numarul maxim de numere consecutive egale este {counter2}");
            Console.WriteLine();
        }
        /// <summary>
        /// Calculeaza suma inverselor numerelor dintr-o secventa
        /// </summary>
        private static void P11()
        {
            Console.WriteLine("11. Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere."); Console.WriteLine();
            Console.WriteLine("Introduceti numerele separate printr-un spatiu..");
            string[] s = Console.ReadLine().Split(' ');
            double sum = 0;
            for(int i = 0; i < s.Length; i++)
            {
                double x = double.Parse(s[i]);
                sum += 1 / x;
            }
            Console.WriteLine(sum);
            Console.WriteLine();
        }
        /// <summary>
        /// Determina cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere.
        /// </summary>
        private static void P12()
        {
            Console.WriteLine("12. Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. " +
                                  "Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. " +
                                  "De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. "); Console.WriteLine();
            Console.WriteLine("Introduceti numerele separate printr-un spatiu..");
            string[] s = Console.ReadLine().Split(' ');
            string s1 = "";
            foreach (string s2 in s)
                s1 += s2;
            string[] s3 = s1.Split('0');
            int counter = 0;
            foreach (string s4 in s3)
                if (s4 != "")
                    counter++;
            Console.WriteLine($"In secventa sunt {counter} grupuri de numere diferite de 0.");
            Console.WriteLine();      
        }
        /// <summary>
        /// Determina daca o secventa este crescatoare rotita 
        /// </summary>
        private static void P13()
        {
            Console.WriteLine("13. O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare " +
                              "sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive " +
                              "(rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si " +
                              "primul element devine ultimul). Determinati daca o secventa de n numere este o secventa crescatoare " +
                              "rotita. "); Console.WriteLine();
            Console.WriteLine("Introduceti numerele separate printr-un spatiu..");
            string[] s = Console.ReadLine().Split(' ');
            int first = 0, last = 0, previous = 0, counter = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int x = int.Parse(s[i]);
                if (i == 0) 
                { 
                    first = x; 
                    previous = x; 
                }
                if (previous > x) 
                    counter++;
                if (i == s.Length - 1) 
                    last = x;                   
                previous = x;
            }
            if (counter == 0)
                Console.WriteLine("Secventa este crescatoare");
            else
                if (counter == 1 && last < first)
                    Console.WriteLine("Secventa este crescatoare rotita");
                else
                    Console.WriteLine("Secventa nu este crescatoare rotita");
            Console.WriteLine();
        }
        /// <summary>
        /// Determina daca o secventa este monotona rotita
        /// </summary>
        private static void P14()
        {
            Console.WriteLine("14. O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata " +
                              "intr-o secventa montona prin rotiri succesive. Determinati daca o secventa de n numere este o " +
                              "secventa monotona rotita."); Console.WriteLine();
            Console.WriteLine("Introduceti numerele separate printr-un spatiu..");
            string[] s = Console.ReadLine().Split(' ');
            int first = 0, last = 0, previous = 0, counter = 0, counter2 = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int x = int.Parse(s[i]);
                if (i == 0)
                {
                    first = x;
                    previous = x;
                }
                if (previous > x)
                    counter++;
                else if(previous < x)
                    counter2++;
                if (i == s.Length - 1)
                    last = x;
                previous = x;
            }
            if (counter == 0)
                Console.WriteLine("Secventa este monotona crescatoare");
            else if (counter2 == 0)
                Console.WriteLine("Secventa este monotona descrescatioare");
            else
                if (counter == 1 && last < first)
                Console.WriteLine("Secventa este monotona crescatoare rotita");
            else if (counter2 == 1 && last > first)
                Console.WriteLine("Secventa este monotona descrescatoare rotita");
            else
                Console.WriteLine("Secventa nu este monotona rotita");
            Console.WriteLine();
        }
        /// <summary>
        /// Determina daca o secventa este bitonica
        /// </summary>
        private static void P15()
        {
            Console.WriteLine("15. O secventa bitonica este o secventa de numere care incepe monoton crescator si " +
                              "continua monoton descrecator. De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. " +
                              "Se da o secventa de n numere. Sa se determine daca este bitonica. "); Console.WriteLine();
            Console.WriteLine("Introduceti numerele separate printr-un spatiu..");
            string[] s = Console.ReadLine().Split(' ');
            int previous = 0, counter = 0, counter2 = 0;
            int max = int.Parse(s[0]), pmax = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int x = int.Parse(s[i]);
                if (x > max)
                {
                    max = x;
                    pmax = i;
                }
            }
            for (int i = 0; i <= pmax; i++)
            {
                int x = int.Parse(s[i]);
                if (i == 0)                                   
                    previous = x;
                if (previous > x)
                    counter++;         
                previous = x;
            }
            for (int i = pmax; i < s.Length; i++)
            {
                int x = int.Parse(s[i]);
                if (i == 0)  
                    previous = x;
                if (previous < x)
                    counter2++;          
                previous = x;
            }
            if (counter == 0 && counter2 == 0)
                Console.WriteLine("Secventa este bitonica");
            else Console.WriteLine("Secventa NU este bitonica");
            Console.WriteLine();
        }
        /// <summary>
        /// Determina daca o sewcventa este bitonica rotita
        /// </summary>
        private static void P16()
        {
            Console.WriteLine("16. O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o " +
                              "secventa bitonica prin rotiri succesive (rotire = primul element devine ultimul). " +
                              "Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita."); Console.WriteLine();
            Console.WriteLine("Introduceti numerele separate printr-un spatiu..");
            char[] sep = {' ', ',', ';', '/'};
            string[] s = Console.ReadLine().Split(sep, StringSplitOptions.RemoveEmptyEntries);
            if (EsteBitonica(s))
                Console.WriteLine("Secventa este bitonica");
            else
            {
                Rotire(s);
                if (EsteBitonica(s))
                        Console.WriteLine("Secventa este bitonica rotita");
                else
                    Console.WriteLine("Secventa NU este bitonica rotita");
            }  
            Console.WriteLine();
        }
        /// <summary>
        /// Returneaza true sau false daca o secventa este sau nu bitonica
        /// </summary>
        private static bool EsteBitonica(string[] s)
        {
            int previous = 0, counter = 0, counter2 = 0;
            int max = int.Parse(s[0]), pmax = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int x = int.Parse(s[i]);
                if (x > max)
                {
                    max = x;
                    pmax = i;
                }
            }
            for (int i = 0; i <= pmax; i++)
            {
                int x = int.Parse(s[i]);
                if (i == 0)
                    previous = x;
                if (previous > x)
                    counter++;
                previous = x;
            }
            for (int i = pmax; i < s.Length; i++)
            {
                int x = int.Parse(s[i]);
                if (i == 0)
                    previous = x;
                if (previous < x)
                    counter2++;
                previous = x;
            }
            if (counter == 0 && counter2 == 0)
                return true;
            else return false;
        }
        /// <summary>
        /// Roteste succesiv o secventa pana cand elementul cu valoare minima va fi pe pozitia 0
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private static string[] Rotire(string[] s)
        {
            int min = int.Parse(s[0]);
            for (int i = 0; i < s.Length; i++)
            {
                int x = int.Parse(s[i]);
                if (x < min)
                    min = x;
            }
            while (Convert.ToInt32(s[0]) != min)
            {
                string aux = s[0];
                for (int i = 1; i < s.Length; i++)
                    s[i - 1] = s[i];
                s[s.Length - 1] = aux;

            }
            return s;
        }
        private static void P17()
        {
            Console.WriteLine("17. Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. " +
                              "Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, " +
                              "determinati nivelul maxim de incuibare a parantezelor. De exemplu 0 1 0 0 1 0 1 1 este corecta si are " +
                              "nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta."); Console.WriteLine();
            Console.WriteLine("Introduceti numerele separate printr-un spatiu..");
            char[] sep = { ' ', ',', ';', '/' };
            string[] s = Console.ReadLine().Split(sep, StringSplitOptions.RemoveEmptyEntries);
            bool ok = true;
            if (s.Length % 2 != 0)
            {
                Console.WriteLine("Secventa de paranteze este gresita, exista o paranteza in plus."); ok = false;
            }
            if(ok)
            for (int i = 0; i < s.Length; i++)
            {
                int x = int.Parse(s[i]);
                if (x != 0 && x != 1 )
                {
                    Console.WriteLine("Secventa este gresita, aceasta trebuie sa contina doar 0 si 1"); ok = false; break; 
                }
                if (i == 0 && x == 1)
                {
                    Console.WriteLine("Secventa de paranteze este gresita, incepe cu paranteza inchisa"); ok = false; break; 
                }
                if (i == s.Length - 1 && x == 0)
                {
                    Console.WriteLine("Secventa de paranteze este gresita, se tremina cu paranteza deschisa"); ok = false; break;
                }

            }
            int c0 = 1, c1 = 1;
            if(ok)
                for (int i = 1; i < s.Length; i++)
                {
                    int x = int.Parse(s[i]);
                    if (x == 0) c0++;
                    else c1++;



                }
            Console.WriteLine($"c0 = {c0}");
            Console.WriteLine($"c1 = {c1}");

        }
    }
}

