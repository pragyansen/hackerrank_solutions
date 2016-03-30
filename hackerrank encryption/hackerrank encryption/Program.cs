using System;
using System.Collections.Generic;
using System.Text;

namespace hackerrank_encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            double width = Math.Floor(Math.Sqrt(s.Length));
            double height = Math.Ceiling(Math.Sqrt(s.Length));
            int head = 0,val=1,counter=0; Console.Write(s[head]); 
            while (counter<s.Length-1)
            {
                head = head + (int)height;
                if (head < s.Length)
                { counter++; Console.Write(s[head]); }
                if (head > s.Length)
                { head = val++; counter++; Console.Write(" " + s[head]); }
                
            
            }
            Console.ReadKey();
        }
    }
}
