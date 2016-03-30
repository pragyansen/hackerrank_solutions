using System;
using System.Collections.Generic;
using System.Text;

namespace hackerrank_lonely_integer
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            string s = Console.ReadLine();
            string[] data = s.Split(' ');
            int[] store = new int[n];
            for (int i = 0; i < n; i++)
            {
                int.TryParse(data[i], out store[i]);
            }
            Array.Sort(store);
            //for(int i = 0;i<n;i++)
            //    Console.WriteLine(store[i]);

            int start = 0, next = 1;
            while (next < n)
            {
                if (store[start] == store[next])
                { start+=2; next+=2; }
                else break;
            }
            Console.Write(store[start]);
            Console.ReadKey();
        }
    }
}
