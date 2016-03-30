using System;
using System.Collections.Generic;
using System.Text;

namespace hackerrank_string_similarity
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            while (n-- > 0)
            {
                string s = Console.ReadLine();
                int start = 1, sum = s.Length; int final = 1;
                while (final < s.Length)
                {
                    //final = start;
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (s.Length == start)
                        {  sum = sum + s.Length - final; break; }
                        if (s[start++] != s[i])
                        { sum = sum + start - final-1; break; }
                        
                    }
                    final++;
                    start = final;
                }
                Console.WriteLine(sum);
                
            }
            Console.ReadKey();
        }
    }
}
