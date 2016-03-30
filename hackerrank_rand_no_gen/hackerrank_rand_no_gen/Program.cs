using System;
using System.Collections.Generic;
using System.Text;

namespace hackerrank_rand_no_gen
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            while (n-- > 0)
            {
                string s = Console.ReadLine();
                string[] p = s.Split(' ');
                int x, y, z;
                int.TryParse(p[0], out x); int.TryParse(p[1], out y); int.TryParse(p[2], out z);
                int range=0;
                if (x == y)
                    range = x + y;

            }
        }
    }
}
