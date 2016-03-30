using System;
using System.Collections.Generic;
using System.Text;

namespace hackerrank_mark_and_toys
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int n; int.TryParse(s[1], out n);
            string[] p = Console.ReadLine().Split(' ');
            int[] toys = new int[p.Length];
            for (int i = 0; i < p.Length; i++)
            { int.TryParse(p[i],out toys[i]); }
            Array.Sort(toys);
            int count = 0;
            for (int i = 0; i < toys.Length; i++)
            {
                if (n > toys[i])
                { n -= toys[i]; count++; }
                else
                {
                    break;
                }
            }
            Console.WriteLine(count);
        }
    }
}
