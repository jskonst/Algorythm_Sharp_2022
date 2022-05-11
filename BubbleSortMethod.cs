using System;

namespace CourseApp.Module2
{
    public class BubbleSort
    {
        public static void BubbleSortMethod()
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string[] sValues = s.Split(' ');
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(sValues[i]);
            }
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    }
                    else
                    {
                        Console.WriteLine(0);
                    }

                    for (int k = 0; k < arr.Length; k++)
                    {
                        Console.Write($"{arr[k]} ");
                    }
                    
                    Console.ReadKey();
                    Console.WriteLine(); 
                }
            }
        }
        static void Main(string[] args)
        {
            BubbleSortMethod();
        }
    }
}
