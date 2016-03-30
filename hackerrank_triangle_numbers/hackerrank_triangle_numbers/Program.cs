using System;
using System.Collections.Generic;
using System.Text;

namespace hackerrank_triangle_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            while (n-- > 0)
            {
                int data;
                int.TryParse(Console.ReadLine(), out data);
                if ((data - 1) % 2 == 0)
                    Console.WriteLine("2");
                else if (data % 4 == 0)
                    Console.WriteLine("3");
                else if ((data - 2) % 4 == 0)
                    Console.WriteLine("4");
             }
        }

        
    }
}
