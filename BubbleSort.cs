using System;
using System.Collections.Generic;
using System.Text;

namespace Bubble_Sort
{
    class Program
    {
       static void Bubble()
        {
            
            int N = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string[] sValues = s.Split(' ');
            int[] arr = new int[N];
            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(sValues[i]);
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                    foreach (int item in arr)
                    {
                        Console.Write($"{item }");
                    }
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            Bubble();    
        }
    }
}

/* static void Main(string[] args)
        {

            int[] arr = new int[] { 5, 1, 7, 3, 9, 4, 1 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" {0}", arr[i]);
            }
            Console.WriteLine("\nПосле сортировки:");
            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j + 1] < arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
                Console.Write("\n", i);
                for (int k = 0; k < arr.Length; k += 1)
                {
                    Console.Write(" {0}", arr[k]);
                }
            }
            Console.ReadLine();
        }*/

/*static long[] BSort(long[] arr)
        {
            for (long i = 0; i < arr.Length; i++)
            {
                for (long j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        long temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Unsorted");
            long N;
            N = Convert.ToInt32(Console.ReadLine());
            long[] arr = { N };
            foreach (long n in arr)
                Console.Write(n + " ");
            Console.WriteLine();
            Console.WriteLine("Sorted");
            BSort(arr);
            foreach (long n in arr)
                Console.Write(n + " ");
            Console.WriteLine();
        } */