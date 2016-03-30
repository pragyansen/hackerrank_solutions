using System;
using System.Collections.Generic;
using System.Text;

namespace hackerrank_2s_complement
{
    class Program
    {
        static int[] table = new int[] { 0, 1, 1, 2, 1, 2, 2, 3, 1, 2, 2, 3, 2, 3, 3, 4 }; 
        static void Main(string[] args)
        {
            int n; int[] tab = new int[256];
            int.TryParse(Console.ReadLine(), out n);
            for (int i = 0; i <= 255; i++)
            {
                int count = 0;
                int p = i;
                for (int j = 0; j < 8; j++)
                {
                    count = count + table[p & 0xF];
                    p >>= 4;
                }
                tab[i] = count;
            }
            while (n-- > 0)
            {
                string s = Console.ReadLine();
                string[] z = s.Split(' ');
                int a, b; Int64 count = 0; 
                int.TryParse(z[0], out a); int.TryParse(z[1], out b);
                for (int i = a; i <= b; i++)
                {
                    //count = 0;
                    int p = i;
                    for (int j = 0; j < 4; j++)
                    {
                        count = count + tab[p & 0xFF];
                        p >>= 8;
                    }
                    //Console.Write(count+", ");
                }
                Console.WriteLine(count);
            }
            Console.ReadKey();
        }
    }
}
