using System;
using System.Collections.Generic;
using System.Text;


namespace hackerrank_findpoint
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            for (int k = 0; k < n; k++)
            {
                string s = Console.ReadLine();
                string[] z = s.Split(' ');
                int x0, x1, y0, y1, p0, p1;
                int.TryParse(z[0], out x0); int.TryParse(z[1], out x1); int.TryParse(z[2], out y0); int.TryParse(z[3], out y1);
                p0 = (2 * y0)-x0; p1 = (2 * y1)-x1;
                Console.WriteLine(p0 + " " + p1);

                //Console.ReadKey();
            }
        }
    }
}
