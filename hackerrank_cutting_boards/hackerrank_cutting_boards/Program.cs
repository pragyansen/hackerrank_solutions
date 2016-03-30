using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank_cutting_boards
{
    class Program
    {
        static void Main(string[] args)
        {
            int t; int.TryParse(Console.ReadLine(), out t);
            while (t-- > 0)
            {
                int m, n; string[] s = Console.ReadLine().Split(' ');
                int.TryParse(s[0], out m); int.TryParse(s[1], out n);
                string[] p = Console.ReadLine().Split(' ');
                string[] q = Console.ReadLine().Split(' ');

                int[] x = new int[m - 1]; int[] y = new int[n - 1];
                for (int i = 0; i < m - 1; i++) { int.TryParse(p[i], out x[i]); }
                for (int i = 0; i < n - 1; i++) { int.TryParse(q[i], out y[i]); }

                Array.Sort<int>(x, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));
                Array.Sort<int>(y, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));

                long total = 0;
                int xin = 0, yin = 0;
                while (xin != m-1 || yin != n-1)
                {
                    total = total % 1000000007;
                    if(xin==m-1)
                    { total += y[yin] * (xin + 1); yin++; continue; }
                    if(yin==n-1)
                    { total += x[xin] * (yin + 1); xin++; continue; }
                    if (x[xin] > y[yin] || yin==n-1)
                    { total += x[xin] * (yin + 1); xin++; continue; }
                    if (x[xin] < y[yin] || xin==m-1)
                    { total += y[yin] * (xin + 1); yin++; continue; }
                    else
                    {
                        if(xin>=yin)
                        { total += x[xin] * (yin + 1); xin++; continue; }
                        else
                        { total += y[yin] * (xin + 1); yin++; continue; }

                    }

                    
                }

                Console.WriteLine(total);
            }
        }
    }
}
