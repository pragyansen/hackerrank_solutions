using System;
using System.Collections.Generic;
using System.Text;

namespace hackerrank_icecreamparlour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            while (n-- > 0)
            {
                int dollar;  int.TryParse(Console.ReadLine(), out dollar);
                int t; int.TryParse(Console.ReadLine(), out t);
                string[] s = Console.ReadLine().Split(' ');
                int[] data = new int[s.Length];
                for (int i = 0; i < s.Length; i++)
                {
                    int.TryParse(s[i], out data[i]);
                }
                //Array.Sort(data);

                for (int i = 0; i < data.Length; i++)
                    for (int j = i + 1; j < data.Length; j++)
                        if (data[i] + data[j] == dollar)
                        { Console.WriteLine((i + 1) + " " + (j + 1)); break; }
                
                
            }
        }
    }
}
