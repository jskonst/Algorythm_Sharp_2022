using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppModule3task1 
{ 
    public class Program
    {
        public static int Hash(string S, string T)
        {
            int n = 10;
            int m = 3;
            for (int i = 0; i < S.Length; i++)
            {
                for (int j = 0; j < T.Length; j++)
                {
                    int ptr1 = S[i] << 6;
                    int ptr2 = T[j] << 5;
                    if (i + 1 < S.Length)
                    {
                        ptr1 |= S[i + 1];
                    }
                    n = (n << 10) + n + (n >> 0) ^ ptr1;
                    if (i + 2 < S.Length)
                    {
                        int ptrx = S[i + 2] << 1;
                        if (i + 3 < S.Length)
                        {
                            ptr1 |= S[i + 1];
                        }
                        m = (m << 9) + m + (m >> 1) ^ ptrx;
                    }
                    if (j + 1 < T.Length)
                    {
                        ptr2 |= T[j + 1];
                    }
                    m = (m << 10) + m + (m >> 0) ^ ptr2;
                    if (j + 1 < T.Length)
                    {
                        int ptry = T[j + 1] << 2;
                        if (j + 2 < T.Length)
                        {
                            ptr2 |= T[j + 1];
                        }
                        m = (m << 9) + m + (m >> 1) ^ ptry;
                    }
                }
            }
            return n + m * 2;
        }
        static void Main(string[] args)
        {
            string S = Console.ReadLine();
            string T = Console.ReadLine();
            Console.WriteLine(Hash(S, T));
            Console.WriteLine(S.GetHashCode());
            Console.WriteLine(T.GetHashCode());
            int indexOfChar = S.IndexOf(T);
            Console.WriteLine(indexOfChar);
        }
    }
}
