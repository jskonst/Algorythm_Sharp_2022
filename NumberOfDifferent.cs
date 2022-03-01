using System;

namespace Various
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
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    break;
                }
                else
                {
                    temp = temp + 1;
                }
            }
            foreach (int item in arr)
            {
                Console.Write($"{item }");
            }
            Console.WriteLine(temp);
        }
        static void Main(string[] args)
        {
            CountingSort();
        }
    }
}
