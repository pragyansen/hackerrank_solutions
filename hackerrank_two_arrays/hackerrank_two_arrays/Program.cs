using System;
using System.Collections.Generic;
using System.Text;

namespace hackerrank_two_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int t; int.TryParse(Console.ReadLine(), out t);
            while (t-- > 0)
            {
                string[] s = Console.ReadLine().Split(' ');
                int n, k; int.TryParse(s[0], out n); int.TryParse(s[1], out k);
                string[] array1 = Console.ReadLine().Split(' ');
                string[] array2 = Console.ReadLine().Split(' ');
                int[] A = new int[n]; int[] B = new int[n];
                for (int i = 0; i < n; i++)
                {
                    int.TryParse(array1[i], out A[i]); int.TryParse(array2[i], out B[i]);
                }
                Array.Sort(A);
                Array.Sort<int>(B, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));
                bool isdone = true;
                for (int i = 0; i < A.Length; i++)
                    if (A[i] + B[i] < k)
                        isdone = false;
                if (isdone)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
