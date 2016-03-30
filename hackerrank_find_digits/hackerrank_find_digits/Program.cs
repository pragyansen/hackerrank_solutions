using System;
using System.Collections.Generic;
using System.Text;

namespace hackerrank_find_digits
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
                int d; int.TryParse(s, out d);
                int counter = 0;
                foreach (char data in s)
                {
                    if (data == '0')
                        continue;
                    if (d % Convert.ToInt16(data.ToString()) == 0)
                        counter++;
                }
                Console.WriteLine(counter);

            }
        }
    }
}
