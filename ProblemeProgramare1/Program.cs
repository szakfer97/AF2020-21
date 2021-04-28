using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProblemeProgramare1
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Numele meu este Szakacsi Ferenc-Adam");
            Console.WriteLine("Acest program rezolva setul 1 de probleme");
            Problema1();
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
            Thread.Sleep(500);
            Problema2();
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
            Thread.Sleep(500);
            Problema3();
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
            Problema4();
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
            Thread.Sleep(500);
            Problema5();
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
            Thread.Sleep(500);
            Problema6();
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
            Thread.Sleep(500);
            Console.ReadKey();
        }
        private static void Problema1()
        {
            try
            {
                Console.WriteLine("1.Calculati suma numerelor din vector");
                int n = int.Parse(Console.ReadLine());
                int[] v = new int[n];
                for (int i = 0; i < n; i++)
                {
                    v[i] = int.Parse(Console.ReadLine());
                }
                int suma = 0;
                for (int i = 0; i < v.Length; i++)
                {
                    suma += v[i];
                }
                Console.WriteLine($"Suma este: {suma}");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema2()
        {
            try
            {
                Console.WriteLine("2.Calculati diferenta absoluta maxima din vector");
                int n = int.Parse(Console.ReadLine());
                int[] v = new int[n];
                for (int i = 0; i < n; i++)
                {
                    v[i] = int.Parse(Console.ReadLine());
                }
                int max1 = int.MinValue;
                int min1 = int.MaxValue;
                int max2 = int.MinValue;
                int min2 = int.MaxValue;
                for (int i = 0; i < v.Length; i++)
                {
                    max1 = Math.Max(max1, v[i] + i);
                    min1 = Math.Min(min1, v[i] + i);
                    max2 = Math.Max(max2, v[i] - i);
                    min2 = Math.Min(min2, v[i] - i);
                }
                Console.WriteLine($"Diferenta absoluta maxima este: {Math.Max(max1 - min1, max2 - min2)}");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema3()
        {
            try
            {
                Console.WriteLine("3.Aratati vectorul format dupa adunarea elementelor cu unu");
                int n = int.Parse(Console.ReadLine());
                int[] v = new int[n];
                for (int i = 0; i < n; i++)
                {
                    v[i] = int.Parse(Console.ReadLine());
                }
                int carry = 0;
                v[n - 1] += 1;
                carry = v[n - 1] / 10;
                v[n - 1] = v[n - 1] % 10;
                for (int i = n - 2; i >= 0; i--)
                {
                    if (carry == 1)
                    {
                        v[i] += 1;
                        carry = v[i] / 10;
                        v[i] = v[i] % 10;
                    }
                }
                if (carry == 1)
                {
                    Array.Resize(ref v, n + 1);
                    v[0] = carry;
                }
                for (int i = 0; i < v.Length; i++)
                {
                    Console.Write(v[i] + " ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Problema4()
        {
            try
            {
                Console.WriteLine("4.Aratati inversarea cuvintelor");
                string nume1 = "BitStone";
                string nume2 = "BITStone";
                string nume3 = "ABcD";
                Inversare(nume1);
                Inversare(nume2);
                Inversare(nume3);
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Inversare(string nume)
        {
            List<int> lista = new List<int>();
            int num = 1;
            for (int i = 1; i < nume.Length; i++)
            {
                if (char.IsUpper(nume[i]))
                {
                    lista.Add(num);
                    num = 1;
                }
                else
                {
                    num++;
                }
            }
            lista.Add(num);
            char[] c = nume.ToCharArray();
            Array.Reverse(c);
            int k = 0;
            for (int i = lista.Count - 1; i >= 0; i--)
            {
                c[k] = char.ToUpper(c[k]);
                k++;
                for (int j = 1; j < lista[i]; j++)
                {
                    c[k] = char.ToLower(c[k]);
                    k++;
                }
            }
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i]);
            }
            Console.WriteLine();
        }
        private static void Elemente(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = rand.Next(0, 10);
                }
            }
        }
        private static void Afisare(int[,] m)
        {
            int i, j;
            int n = m.GetLength(0);
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                    Console.Write(m[i, j] + " ");
                Console.WriteLine();
            }
        }
        private static void Problema5()
        {
            try
            {
                Console.WriteLine("5.Aratati spiralarea unei matrice");
                int nrlinii = int.Parse(Console.ReadLine());
                int nrcoloane = int.Parse(Console.ReadLine());
                int[,] m = new int[nrlinii, nrcoloane];
                Elemente(m);
                Afisare(m);
                Spirala(nrlinii, nrcoloane, m);
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Spirala(int nrlinii, int nrcoloane, int[,] m)
        {
            int startlinind = 0;
            int startcolind = 0;
            while (startlinind < nrlinii && startcolind < nrcoloane)
            {
                for (int i = startcolind; i < nrcoloane; i++)
                {
                    Console.Write(m[startlinind, i] + " ");
                }                  
                startlinind++;
                for (int i = startlinind; i < nrlinii; i++)
                {
                    Console.Write(m[i, nrcoloane - 1] + " ");
                }                   
                nrcoloane--;
                if (startlinind < nrlinii)
                {
                    for (int i = nrcoloane - 1; i >= 0; i--)
                    {
                        Console.Write(m[nrlinii - 1, i] + " ");
                    }
                    nrlinii--;
                }
                if (startcolind < nrcoloane)
                {
                    for (int i = nrlinii - 1; i >= startlinind; i--)
                    {
                        Console.Write(m[i, startcolind] + " ");
                    }                      
                    startcolind++;
                }
            }
        }
        private static void Problema6()
        {
            try
            {
                Console.WriteLine("6.Aratati rotarea unei imagini");
                int[,] m = new int[,]
            {
                {1, 2, 3, 4 },
                {5, 6, 7, 8 },
                {9, 10, 11, 12 },
                {13, 14, 15, 16 }
            };
                Rezolvare(m);
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Rezolvare(int [,] m)
        {
            int n = m.GetLength(0);
            int i, j;
            int aux;
            for (i = 0; i < n / 2; i++)
            {
                for (j = 0; j < n / 2; j++)
                {
                    aux = m[i, j];
                    m[i, j] = m[n - j - 1, i];
                    m[n - j - 1, i] = m[n - i - 1, n - j - 1];
                    m[n - i - 1, n - j - 1] = m[j, n - i - 1];
                    m[j, n - i - 1] = aux;
                }
            }
            Afisare(m);
        }
    }
}
