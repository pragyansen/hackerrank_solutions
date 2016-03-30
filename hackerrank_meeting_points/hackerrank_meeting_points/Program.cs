using System;
using System.Collections.Generic;
using System.Text;

namespace hackerrank_meeting_points
{
    class Program
    {
        struct point
        {
            public Int64 x, y;
        }
        static void Main(string[] args)
        {
            int n; long sumx = 0, sumy = 0;
            int.TryParse(Console.ReadLine(), out n);
            point[] data = new point[n];
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                string[] z = s.Split(' ');
                Int64.TryParse(z[0], out data[i].x); Int64.TryParse(z[1], out data[i].y);
                sumx += data[i].x; sumy += data[i].y;
            }
            sumx = sumx / n; sumy = sumy / n;
            point center; center.x = data[0].x; center.y = data[0].y;
            Int64 mindis = ((sumx - data[0].x) * (sumx - data[0].x)) + ((sumy - data[0].y) * (sumy - data[0].y));
            for (int i = 1; i < n; i++)
            {
                if (mindis > (((sumx - data[i].x) * (sumx - data[i].x)) + ((sumy - data[i].y)*(sumy - data[i].y))))
                {
                    mindis = ((sumx - data[i].x) * (sumx - data[i].x)) + ((sumy - data[i].y)*(sumy - data[i].y));
                    center.x = data[i].x; center.y = data[i].y;
                }
            }
            long result = 0; long distance=0;
            for (int i = 0; i < n; i++)
            {
                long tempx, tempy;
                tempx = data[i].x - center.x; tempy = data[i].y - center.y;
                if (tempx < 0) tempx *= -1; if (tempy < 0) tempy *= -1;
                if (tempx > tempy)
                { tempx = tempx + tempy; tempy = tempx - tempy; tempx = tempx - tempy; }
                distance = tempx;
                distance += tempy - tempx;
                result += distance;
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
