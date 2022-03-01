using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Sort
{
    class Program
    {
        static void CountingSort()
        {
            int N = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string[] sValues = s.Split(' ');
            int[] arr = new int[N];
            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(sValues[i]);
            }
            int min = arr.Min();
            int max = arr.Max();
            int k = max - min + 1;
            int[] count = new int[k];
            int[] last = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                count[arr[i] - min]++;
            }
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                last[count[arr[i] - min] - 1] = arr[i];
                count[arr[i] - min]--;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = last[i];
            }
            foreach(int item in arr)
            {
                Console.Write($"{item }");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            CountingSort();
        }
    }
}
