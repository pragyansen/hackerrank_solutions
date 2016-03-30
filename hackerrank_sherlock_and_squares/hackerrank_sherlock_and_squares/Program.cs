using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank_sherlock_and_squares
{
    class Program
    {
        static void Main(string[] args)
        {
            int t; int.TryParse(Console.ReadLine(), out t);
            while (t-- > 0)
            {
                string[] s = Console.ReadLine().Split(' ');
                int a = Convert.ToInt32(s[0]); int b = Convert.ToInt32(s[1]);
                int start = (int)Math.Ceiling(Math.Sqrt(a));
                int counter = 0;
                while(start*start <= b)
                { counter++; start++; }
                Console.WriteLine(counter);
            }
            Console.ReadLine();
        }
    }
}
