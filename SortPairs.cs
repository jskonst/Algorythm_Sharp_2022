using System;

namespace Insertion_Sort
{
    class Program
    {
        static void Insertion()
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string[] sValues = s.Split(' ');
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(sValues[i]);
            }
            for (int i = 1; i < arr.Length; i++)
            {
                int mas = arr[i];
                int j = i;
                while (j > 0 && mas < arr[j - 1])
                {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[j] = mas;
            }
            foreach (int item in arr)
            {
                Console.Write($"{item }");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Insertion();
        }
    }
}
