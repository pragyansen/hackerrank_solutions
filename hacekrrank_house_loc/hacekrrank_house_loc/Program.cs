using System;
using System.Collections.Generic;
using System.Text;

namespace hacekrrank_house_loc
{
    class Program
    {
        struct data
        { 
            public int x,y;
        }
        static void Main(string[] args)
        {
            int a, b; data[] store = new data[100];
            string s = Console.ReadLine();
            string[] z = s.Split(' ');
            int.TryParse(z[0], out a); int.TryParse(z[1], out b);
            data[] data = new data[4];
            for (int i = 0; i < 4; i++)
            {
                z = Console.ReadLine().Split(' ');
                int.TryParse(z[0], out data[i].x); int.TryParse(z[1], out data[i].y);
            }
            int c = 0;
            for(int x = -1000;x<1001;x++)
                for (int y = -1000; y < 1001; y++)
                {
                    double dis_from_k = calculate_distance(x, y, data[0].x, data[0].y); //distance from kimberly
                    double d1 = dis_from_k / a;
                    if (d1 == calculate_distance(x, y, data[1].x, data[1].y))
                    {
                        double dis_from_jk = calculate_distance(x, y, data[2].x, data[2].y);
                        double d2 = dis_from_jk / b;
                        if (d2 == calculate_distance(x, y, data[3].x, data[3].y))
                        {
                            store[c].x = x; store[c++].y = y;
                        }
                    
                    }
                }
            for (int i = 0; i < c; i++)
                Console.WriteLine(store[i].x + ".00 " + store[i].y+".00");
            Console.ReadKey();
        }

        private static double calculate_distance(int x, int y, int p1, int p2)
        {
            return Math.Sqrt((x - p1) * (x - p1) + (y - p2) * (y - p2));
        }
    }
}
