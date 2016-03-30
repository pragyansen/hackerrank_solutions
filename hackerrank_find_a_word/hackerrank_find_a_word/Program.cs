using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace hackerrank_find_a_word
{                                                                   
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            
            string[] s = new string[n];
            for (int i = 0; i < n; i++)
            {
               s[i]  = Console.ReadLine();
            }
            int n2;
            int.TryParse(Console.ReadLine(), out n2); 
            for (int i = 0; i < n2; i++)
            {
                int counter = 0;
                string search = Console.ReadLine();
                Regex rx = new Regex(@"(?:^|[^\w\d_])+"+search+@"(?:[^\w\d_]+|$)", RegexOptions.Compiled);
                for (int j = 0; j < n; j++)
                {
                    MatchCollection matches = rx.Matches(s[j]);
                    counter = counter + matches.Count;
                    
                }
                Console.WriteLine(counter);
            }
            Console.ReadKey();

        }
    }
}
