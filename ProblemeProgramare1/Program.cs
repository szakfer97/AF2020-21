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
        static void Main(string[] args)
        {
            Console.WriteLine("Numele meu este Szakacsi Ferenc-Adam");
            Console.WriteLine("Acest program rezolva problemele setului 1 de probleme");
            Problema1();
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
            Thread.Sleep(500);
            Problema2();
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
            Thread.Sleep(500);
            Problema3();
            Console.WriteLine("Va rog asteptati,se incarca problema urmatoare...");
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
    }
}
