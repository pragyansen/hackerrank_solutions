using System;
using System.Collections.Generic;
using System.Text;

namespace hackerrank_sherlock_puzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] z = s.Split(' ');
            int n; int.TryParse(z[0],out n);
            string data = z[1];
            int zero = 0, one = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == '1')
                    one++;
                else zero++;
            }
            if (2 * zero <= 3 * one)
            { Console.WriteLine(data.Length * n); return; }
            int start = 0, end = data.Length - 1;
            while (2 * zero >= 3 * one)
            {
                if (data[start] == '0')
                { start++; zero--; }
                if (data[end] == '0')
                { end--; zero--; }
            
            }
            Console.WriteLine(end - start + 1);

            Console.ReadKey();
        }
    }
}
