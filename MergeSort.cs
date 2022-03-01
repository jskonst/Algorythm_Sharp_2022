using System;

namespace Merge_Sort
{
    class Program
    {  
        static void Merge(int[] arr, int a, int b, int c)
        {
            int x = b - a + 1;
            int y = c - b;

            int[] left = new int[x];
            int[] right = new int[y];
            int i, j;
            for (i = 0; i < x; i++)
            {
                left[i] = arr[a + i];
                for (j = 0; j < y; j++)
                {
                    right[j] = arr[b + 1 + j];
                }
            }
            i = 0;
            j = 0;
            int k = a;
            while (i < x && j < y)
            {
                if (left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i++;
                }
                else
                {
                    arr[k] = right[j];
                    j++;
                }
                k++;
            }
            while (i < x)
            {
                arr[k] = left[i];
                i++;
                k++;
            }
            while (j < y)
            {
                arr[k] = right[j];
                j++;
                k++;
            }
        }
        static void MergeSorting(int[] arr, int a, int c)
        {
            if (a < c)
            {
                int b = a + (c - a) / 2;
                MergeSorting(arr, a, b);
                MergeSorting(arr, b + 1, c);
                Merge(arr, a, b, c);
            }
            foreach (int item in arr)
            {
                Console.Write($"{item }");
            }
            Console.WriteLine();
        }
        static void Print(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string[] sValues = s.Split(' ');
            int[] arr = new int[N];
            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(sValues[i]);
            }
            MergeSorting(arr, 0, arr.Length - 1);
            Console.WriteLine("\n");
            Print(arr);
        }
    }
}

/*static void Merge(int[] arr, int lowidx, int middleidx, int highidx)
{
    var left = lowidx;
    var right = middleidx + 1;
    var tempArr = new int[highidx - lowidx + 1];
    var N = 0;
    while ((left <= middleidx) && (right <= highidx))
    {
        if (arr[left] < arr[right])
        {
            tempArr[N] = arr[left];
            left++;
        }
        else
        {
            tempArr[N] = arr[right];
            right++;
        }
        N++;
    }
    for (var i = left; i <= middleidx; i++)
    {
        tempArr[N] = arr[i];
        N++;
    }
    for (var i = right; i <= highidx; i++)
    {
        tempArr[N] = arr[i];
        N++;
    }
    for (var i = 0; i < tempArr.Length; i++)
    {
        arr[lowidx + 1] = tempArr[i];
    }
}

static int[] MergeSorting(int[] arr, int lowidx, int highidx)
{
    if (lowidx < highidx)
    {
        var middleidx = (lowidx + highidx) / 2;
        MergeSorting(arr, lowidx, middleidx);
        MergeSorting(arr, middleidx + 1, highidx);
        Merge(arr, lowidx, middleidx, highidx);
    }
    return arr;
}

static int[] MergeSorting(int[] arr)
{
    return MergeSorting(arr, 0, arr.Length - 1);
}
static void Main(string[] args)
{
    Console.WriteLine("Элементы массива:");
    var s = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
    var arr = new int[s.Length];
    for (int i = 0; i < s.Length; i++)
    {
        arr[i] = Convert.ToInt32(s[i]);
    }
    Console.WriteLine("Отсортированный массив: {0}", string.Join(", ", MergeSorting(arr)));
    Console.ReadLine();
}*/

/*static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string[] sValues = s.Split(' ');
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(sValues[i]);
            }
            Console.WriteLine($"Unsorted: {string.Join(", ", arr)}");
            Merge(arr);
            Console.WriteLine($"Sorted: {string.Join(", ", arr)}");
            Console.ReadKey();
        }
        static void Merge(int[] arr)
        {
            var buffer = new int[arr.Length];
            Merge(arr, 0, arr.Length - 1, buffer);
            foreach (int item in arr)
            {
                Console.Write($"{item }");
            }
            Console.WriteLine();
        }
        static void Merge(int[] arr, int left, int right, int[] buffer)
        {
            if (left >= right)
            {
                return;
            }
            var middle = (left + right) / 2;
            Merge(arr, left, middle, buffer);
            Merge(arr, middle + 1, right, buffer);
            MergeHalves(arr, left, middle, right, buffer);
        }
        static void MergeHalves(int[] arr, int left, int middle, int right, int[] buffer)
        {
            var mergecurrentidx = left;
            var leftcurrentidx = left;
            var rightcurrentidx = middle + 1;
            while (leftcurrentidx <= middle && rightcurrentidx <= right)
            {
                if (arr[leftcurrentidx] <= arr[rightcurrentidx])
                {
                    buffer[mergecurrentidx] = arr[leftcurrentidx];
                    leftcurrentidx++;
                }
                else
                {
                    buffer[mergecurrentidx] = arr[rightcurrentidx];
                    rightcurrentidx++;
                }
                mergecurrentidx++;
            }
            leftcurrentidx--;
            rightcurrentidx--;
            mergecurrentidx--;
            var tailOflefthalfLength = middle - leftcurrentidx;
            var tailOfrighthalfLength = right - rightcurrentidx;
            if (tailOflefthalfLength > 0)
            {
                Array.Copy(arr, leftcurrentidx + 1, buffer, mergecurrentidx + 1, tailOflefthalfLength);
            }
            else
            {
                Array.Copy(arr, rightcurrentidx + 1, buffer, mergecurrentidx + 1, tailOfrighthalfLength);
            }
            var size = right - left + 1;
            Array.Copy(buffer, left, arr, left, size);
        }
        static int[] InitArrOfRandonValues(int size)
        {
            var arr = new int[size];
            var rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(10);
            }
            return arr;
        }*/

/*static void Main(string[] args)
        {

        }
       static void MergeSorting(int[] arr)
        {

        }
        static void Merge(int[] Array, int[] arr1, int[] arr2)
        {
            int arr1Minidx = 0;
            int arr2Minidx = 0;
            int ArrayMinidx = 0;
            while(arr1Minidx < arr1.Length && arr2Minidx < arr2.Length) 
            {
                if (arr1[arr1Minidx] <= arr2[arr2Minidx])
                {
                    Array[ArrayMinidx] = arr1[arr1Minidx];
                    arr1Minidx++;
                }
                else
                {
                    Array[ArrayMinidx] = arr2[arr2Minidx];
                    arr2Minidx++;
                }
                ArrayMinidx++;
            }
            while (arr1Minidx < arr1.Length)
            {
                Array[ArrayMinidx] = arr1[arr1Minidx];
                arr1Minidx++;
                ArrayMinidx++;
            }
            while (arr2Minidx < arr2.Length)
            {
                Array[ArrayMinidx] = arr2[arr2Minidx];
                arr2Minidx++;
                ArrayMinidx++;
            }
        }    
        static void DisplayArr(int[] arr)
        {
            for (int k = 0; k <= arr.Length; k++)
            {
                Console.WriteLine();
            }
        }*/
