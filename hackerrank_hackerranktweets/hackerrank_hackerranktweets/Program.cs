using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace hackerrank_hackerranktweets
{
    class Program
    {
        static void Main(string[] args)
        {
            int c = 0, n;
            int.TryParse(Console.ReadLine(),out n);
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                if (Regex.IsMatch(s, @"hackerrank", RegexOptions.IgnoreCase))
                { c++; }
            }
            Console.WriteLine(c);
        }
    }
}
