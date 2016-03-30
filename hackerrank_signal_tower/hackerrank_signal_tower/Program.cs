using System;
using System.Collections.Generic;
using System.Text;

namespace hackerrank_signal_tower
{
    class Program
    {
        struct point
        {
            public Int64 x, y;
        }
        static void Main(string[] args)
        {
            int n,q; string[] z = Console.ReadLine().Split(' ');
            int.TryParse(z[0], out n); int.TryParse(z[1], out q);
            
            
                
            point[] data = new point[n];
            string[] xc = Console.ReadLine().Split(' ');
            string[] yc = Console.ReadLine().Split(' ');
            for (int i = 0; i < xc.Length; i++)
            {
                Int64.TryParse(xc[i], out data[i].x); Int64.TryParse(yc[i], out data[i].y);
            }
            while (q-- > 0)
            {
                double sumx = 0, sumy = 0;
                string[] s = Console.ReadLine().Split(' ');
                int start, end; int.TryParse(s[0], out start); int.TryParse(s[1], out end);
                for (int i = start - 1; i < end; i++)
                {
                    sumx += data[i].x; sumy += data[i].y;
                }
                sumx = sumx / (double)(end-start+1); sumy = (double)sumy / (end-start+1);
                
                double result = 0; double distance = 0;
                for (int i = 0; i < n; i++)
                {
                    double tempx, tempy;
                    tempx = data[i].x - sumx; tempy = data[i].y - sumy;
                    if (tempx < 0) tempx *= -1; if (tempy < 0) tempy *= -1;
                    if (tempx > tempy)
                    { tempx = tempx + tempy; tempy = tempx - tempy; tempx = tempx - tempy; }
                    distance = tempx;
                    distance += tempy - tempx;
                    result += distance;
                }
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }
    }
}
