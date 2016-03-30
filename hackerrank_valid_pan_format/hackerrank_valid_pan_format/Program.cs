using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace hackerrank_valid_pan_format
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                if (Regex.IsMatch(s, @"^[A-Z][A-Z][A-Z][A-Z][A-Z][0-9][0-9][0-9][0-9][A-Z]$"))
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
            Console.ReadKey();
        }
    }
}
