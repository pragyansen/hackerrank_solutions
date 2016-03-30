using System;
using System.Collections.Generic;
using System.Text;

namespace hackerrank_mike_mark
{
    class Program
    {
        static void Main(string[] args)
        {
            int t; int.TryParse(Console.ReadLine(), out t);
            while (t-- >0)
            {
                int a, b, k;
                string[] s = Console.ReadLine().Split(' ');
                int.TryParse(s[0], out a); int.TryParse(s[1], out b); int.TryParse(s[2], out k);
                //b++; a++;
                if(k<=(a*b))
                    Console.WriteLine("NO");
                else
                    Console.WriteLine("YES");
            }
        }
    }
}
