using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace hackerrank_findhackerrank
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(),out n);
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                Match match1 = Regex.Match(s, @"^hi\s+[^d]",RegexOptions.IgnoreCase);
                if (match1.Success)
                    Console.WriteLine(s);
                

                    
            }
        }
    }
}
