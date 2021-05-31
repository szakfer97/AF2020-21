using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProblemeProgramare2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numele meu este Szakacsi Ferenc-Adam");
            Console.WriteLine("Acest program rezolva setul 2 de probleme");
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
            Console.WriteLine("Ati ajuns la final!");
            Console.ReadKey();
        }
        private static void Problema1()
        {
            try
            {
                Console.WriteLine("1.Prezentam BubbleSort");
                int[] arr = { 1, 6, 2, 3, 4, 1, 2, 8, 7, 9 };
                Vizualizare(arr);
                BubbleSort(arr);
                Vizualizare(arr);
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void Vizualizare(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
        private static void BubbleSort(int[] arr)
        {
            bool schimbat;
            for (int i = 0; i < arr.Length; i++)
            {
                schimbat = false;
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
                        schimbat = true;
                    }
                }
                if (!schimbat)
                {
                    break;
                }
            }
        }
        private static void Problema2()
        {
            try 
            {
                Console.WriteLine("2.Prezentam QuickSort");
                int[] arr = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
                Vizualizare(arr);
                QuickSort(arr, 0, arr.Length - 1);
                Vizualizare(arr);
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void QuickSort(int[] arr,int stang,int drept)
        {
            if (stang < drept)
            {
                int pivot = Partitionare(arr, stang, drept);
                if (pivot > 1)
                {
                    QuickSort(arr, stang, pivot - 1);
                }
                if (pivot + 1 < drept)
                {
                    QuickSort(arr, pivot + 1, drept);
                }
            }
        }
        private static int Partitionare(int[] arr, int stang, int drept)
        {
            int pivot = arr[stang];
            while (true)
            {
                while (arr[stang] < pivot)
                {
                    stang++;
                }
                while (arr[drept] > pivot)
                {
                    drept--;
                }
                if (stang < drept)
                {
                    if (arr[stang] == arr[drept])
                    {
                        return drept;
                    }
                    int temp = arr[stang];
                    arr[stang] = arr[drept];
                    arr[drept] = temp; 
                }
                else
                {
                    return drept;
                }
            }
        }
        private static void Problema3()
        {
            try
            {
                Console.WriteLine("3.Prezentam MergeSort");
                int[] arr = { 1, 16, 32, 53, 4, 61, 92, 8, 7, 9 };
                Vizualizare(arr);
                MergeSort(arr, 0, arr.Length - 1);
                Vizualizare(arr);
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void MergeSort(int[] arr, int start, int finish)
        {
            int middle;
            if (start < finish)
            {
                middle = (start + finish) / 2;
                MergeSort(arr, start, middle);
                MergeSort(arr, middle + 1, finish);
                MyMerge(arr, start, middle, finish);
            }
        }
        private static void MyMerge(int[] arr, int start, int middle, int finish)
        {
            int[] v1 = new int[middle - start + 1];
            int[] v2 = new int[finish - middle];
            int i, j, k;
            for (i = start; i <= middle; i++)
            {
                v1[i - start] = arr[i];
            }
            for (i = middle + 1; i <= finish; i++)
            {
                v2[i - (middle + 1)] = arr[i];
            }
            i = 0; j = 0; k = 0;
            while (i < v1.Length && j < v2.Length)
            {
                if (v1[i] < v2[j])
                {
                    arr[start + k++] = v1[i++];
                }
                else
                {
                    arr[start + k++] = v2[j++];
                }       
            }
            while (i < v1.Length)
            {
                arr[start + k++] = v1[i++];
            }   
            while (j < v2.Length)
            {
                arr[start + k++] = v2[j++];
            }
        }
        private static void Problema4()
        {
            try
            {
                Console.WriteLine("4.Prezentam SelectionSort");
                int[] arr = { 71, 26, 12, 53, 4, 41, 2, 8, 7, 9 };
                Vizualizare(arr);
                SelectionSort(arr);
                Vizualizare(arr);
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void SelectionSort(int[] arr)
        {
            int aux;
            for (int i = 0; i < arr.Length; i++)
            {
                int k = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[k])
                    {
                        k = j;
                    }
                }
                aux = arr[k];
                arr[k] = arr[i];
                arr[i] = aux;
            }
        }
        private static void Problema5()
        {
            try
            {
                Console.WriteLine("5.Prezentam InsertionSort");
                int[] arr = { 41, 98, 77, 51, 32, 34, 15, 65, 8, 29, 9 };
                Vizualizare(arr);
                InsertionSort(arr);
                Vizualizare(arr);    
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int cheie = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > cheie)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = cheie;
            }
        }
        private static void Problema6()
        {
            try
            {
                Console.WriteLine("6.Prezentam BinarySearch");
                int[] arr = { 2, 93, 11, 22, 34, 45, 65, 78, 59, 88 };
                int cheie = BinarySearch(arr, 34);
                Console.WriteLine(cheie);
            }
            catch (Exception e)
            {
                Console.WriteLine($" {e.Message}");
            }
        }
        private static int BinarySearch(int[] arr, int cheie)
        {
            int stang, mijloc, drept;
            stang = 0; drept = arr.Length - 1;
            while (stang <= drept)
            {
                mijloc = stang + (drept - stang) / 2;
                if (cheie < arr[mijloc])
                {
                    drept = mijloc - 1;
                }
                else if (cheie > arr[mijloc])
                {
                    stang = mijloc + 1;
                }
                else
                {
                    return mijloc;
                }
            }
            return -1;
        }
    }
}
