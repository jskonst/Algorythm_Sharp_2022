using System;
using System.Collections.Generic;

namespace Module5task3
{
    public class SegmentTree
    {
        private int[] st;
        private int size;
        public SegmentTree(int t)
        {
            st = new int[4 * t];
            size = t;
        }

        public int NOD(int x, int y)
        {
            while (y != 0)
            {
                int temp = y;
                y = x % y;
                x = temp;
            }

            return x;
        }

        public void build(int[] N)
        {
            inner_build(0, 0, size, N);
        }

        public int get_NOD(int ql, int qr)
        {
            return inner_NOD(0, 0, size, st, ql - 1, qr);
        }

        private void inner_build(int idx, int l, int r, int[] N)
        {
            if (r - l == 1)
            {
                st[idx] = N[l];
                return;
            }

            int m = (l + r) / 2;
            inner_build((2 * idx) + 1, l, m, N);
            inner_build((2 * idx) + 2, m, r, N);
            st[idx] = NOD(st[2 * idx + 1], st[2 * idx + 2]);
        }

        private int inner_NOD(int idx, int l, int r, int[] seg, int ql, int qr)
        {
            if (ql <= l && qr >= r)
            {
                return seg[idx];
            }
            if (ql >= r || qr <= l)
            {
                return 0;
            }
            int m = (l + r) / 2;
            int tl = inner_NOD((2 * idx) + 1, l, m, seg, ql, qr);
            int tr = inner_NOD((2 * idx) + 2, m, r, seg, ql, qr);
            return NOD(tl, tr);
        }
    }

    public class NOD_podotrezok
    {
        public static void find()
        {
            int size = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string[] sValues = s.Split(' ');
            int[] N = new int[size];
            for (int i = 0; i < size; i++)
            {
                N[i] = int.Parse(sValues[i]);
            }

            int qc = int.Parse(Console.ReadLine());
            SegmentTree bt = new SegmentTree(size);
            bt.build(N);
            List<int> ans = new List<int>();
            for (int i = 0; i < qc; i++)
            {
                string g = Console.ReadLine();
                string[] gValues = g.Split(' ');
                for (int j = 0; j < qc; j++)
                {
                    ans.Add(bt.get_NOD(g[0], g[1]));
                }
            }

            Console.Write(N[0]);
            Console.Write(' ');
            Console.Write(N[3]);
        }

        static void Main(string[] args)
        {
            find();
        }
    }
}

/*public static void find()
        {
            
            int size = int.Parse(Console.ReadLine());
            SegmentTree bt = new SegmentTree(size);
            string s = Console.ReadLine();
            string[] sValues = s.Split(' ');
            for (int i = 0; i < sValues.Length; i++)
            {
                bt.build(sValues[s]);
            }

            int qc = int.Parse(Console.ReadLine());
            List<int> ans = new List<int>();
            for (int i = 0; i < qc; i++)
            {
                string g = Console.ReadLine();
                string[] gValues = g.Split(' ');
                for (int j = 0; j < ans.Count; i++)
                {
                    ans.Add(bt.get_NOD(g[0], g[1]));
                }
            }

            Console.WriteLine(string.Join(" ", ans));
        }*/


/**/