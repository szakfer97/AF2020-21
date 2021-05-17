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
            Problema7();
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
            Thread.Sleep(500);
            Problema8();
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
            Thread.Sleep(500);
            Problema9();
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
            Thread.Sleep(500);
            Problema10();
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
            Thread.Sleep(500);
            Problema11();
            Console.WriteLine("Ati ajuns la final!");
            Console.ReadKey();
        }
        private static void Problema1()
        {
            try
            {
                Console.WriteLine("1.Facem rotirea spre stanga al unui vector");
                int lungime = int.Parse(Console.ReadLine());
                int[] arr = new int[lungime];
                Citirea(arr);
                Console.Write("Numarul de rotatii :");
                int rotirenum = int.Parse(Console.ReadLine());
                Vizualizarea(arr);
                int[] vectorrotit = Rotirea(arr, rotirenum);
                Console.WriteLine("Vectorul dupa rotatii");
                Vizualizarea(vectorrotit);
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Citirea(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        private static int[] Rotirea(int[] arr, int rotirenum)
        {
            if (rotirenum >= arr.Length)
            {
                rotirenum %= arr.Length;
            }
            if (rotirenum == 0)
            {
                return arr;
            }
            int[] aux = new int[arr.Length];
            int j = 0;
            for (int i = rotirenum; i < arr.Length; i++)
            {
                aux[j++] = arr[i];
            }
            for (int i = 0; i < rotirenum; i++)
            {
                aux[j++] = arr[i];
            }   
            return aux;
        }      
        private static void Vizualizarea(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
        private static void Problema2()
        {
            try
            {
                Console.WriteLine("2.Calculati suma numerelor din vector");
                int[] arr = { 1, 2, 3, 4, 5 };
                Console.Write("Suma elementelor vectorului: ");
                Console.WriteLine(Suma(arr));
                Console.WriteLine(SumaRecursiva(arr, 0));
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static int Suma(int[] arr)
        {
            int suma = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                suma += arr[i];
            }
            return suma;
        }
        private static int SumaRecursiva(int[] arr, int index)
        {
            if (index == arr.Length)
            {
                return 0;
            }
            return arr[index] + SumaRecursiva(arr, index + 1);
        }
        private static void Problema3()
        {
            try
            {
                Console.WriteLine("3.Calculati diferenta absoluta maxima din vector");
                int n = int.Parse(Console.ReadLine());
                int[] arr = new int[n];
                Citirea(arr);
                Vizualizarea(arr);
                int max = GasesteMax(arr);
                Console.WriteLine($"Maximul este {max}");
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static int GasesteMax(int[] arr)
        {
            int n = arr.Length;
            int max = 0;
            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                {
                    int res = Abs(arr, i, j);
                    if (res > max)
                        max = res;
                }
            return max;
        }
        private static int Abs(int[] arr, int i, int j)
        {
            return (Math.Abs(arr[i] - arr[j]) + Math.Abs(i - j));
        }
        private static void Problema4()
        {
            try
            {
                Console.WriteLine("4.Aratati vectorul format dupa adunarea elementelor cu unu");
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
        private static void Problema5()
        {
            try
            {
                Console.WriteLine("5.Aratati inversarea cuvintelor");
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
        private static void Problema6()
        {
            try
            {
                Console.WriteLine("6.Aratati spiralarea unei matrice");
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
        private static void Problema7()
        {
            try
            {
                Console.WriteLine("7.Aratati rotarea unei imagini");
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
        private static void Problema8()
        {
            try
            {
                Console.WriteLine("8.Rezolvam problema turnurilor din Hanoi");
                int n = 3;
                int a = 1;
                int b = 2;
                int c = 3;
                Hanoi(n, a, b, c);
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Hanoi(int n, int a, int b, int c)
        {
            if (n == 0)
            {
                return;
            }
            else
            {
                Hanoi(n - 1, a, c, b);
                Console.WriteLine($"{a} -> {b}");
                Hanoi(n - 1, c, b, a);
            }
        }
        private static void Problema9()
        {
            try
            {
                Console.WriteLine("9.Gasim elementul dorit din sirul lui Fibonacci");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine(Fibonacci(a));
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static int Fibonacci(int a)
        {
            if (a <= 1)
            {
                return a;
            }
            else
            {
                return Fibonacci(a - 1) + Fibonacci(a - 2);
            }
        }
        private static void Problema10()
        {
            try
            {
                Console.WriteLine("10.Rezolvam problema reginelor");
                int n = int.Parse(Console.ReadLine());
                int[] rand = new int[n];
                bool[] vis = new bool[n];
                Generare(0, n, rand, vis);
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        static int num = 1;
        private static void Generare(int v, int n, int[] rand, bool[] vis)
        {
            if (v >= n)
            {
                bool eValid = true;
                for (int i = 0; i < n - 1; i++)
                    for (int j = i + 1; j < n; j++)
                        if (Math.Abs(i - j) == Math.Abs(rand[i] - rand[j]))
                        {
                            eValid = false;
                            break;
                        }
                if (eValid)
                {
                    Console.Clear();
                    Console.WriteLine($"Solutie {num}:");
                    Vizualizare(n, rand);
                    num++;
                    Console.ReadKey();
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (!vis[i])
                    {
                        vis[i] = true;
                        rand[v] = i;
                        Generare(v + 1, n, rand, vis);
                        vis[i] = false;
                    }
                }
            }
        }
        private static void Vizualizare(int marime, int[] rand)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            for (int i = 0; i < marime; i++)
            {
                for (int j = 0; j < marime; j++)
                {
                    if (j % 2 == 0 && i % 2 != 0 || j % 2 != 0 && i % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                    }   
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                    }
                    if (j == rand[i])
                    {
                        Console.Write(" Q ");
                    }   
                    else
                    {
                        Console.Write("   ");
                    }  
                }
                Console.WriteLine();
            }
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
        private static void Problema11()
        {
            try
            {
                Console.WriteLine("11.Prezentam ciurul lui Eratostene");
                n = int.Parse(Console.ReadLine());
                array = new int[n + 1];
                CalculareNumerePrime();
                AfisareNumerePrime();
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void CalculareNumerePrime()
        {
            array[0] = 1;
            array[1] = 1;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (array[i] == 0)
                {
                    for (int j = 2; j <= n / i; j++)
                    {
                        array[i * j] = 1;
                    }
                }
            }
        }
        private static void AfisareNumerePrime()
        {
            Console.Write($"Numerele prime pana la {n} sunt: ");
            for (int i = 2; i <= array.Length; i++)
            {
                if (array[i] == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
        public static int n { get; set; }
        public static int[] array { get; set; }
    }
}
