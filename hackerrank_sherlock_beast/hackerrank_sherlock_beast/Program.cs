using System;
using System.Collections.Generic;
using System.Text;

namespace hackerrank_sherlock_beast
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            while (n-- > 0)
            {
                int k; int five, three;
                int.TryParse(Console.ReadLine(), out k);
                five = (k / 3)*3; three = k - five;
                bool found = false;
                while (!found)
                {
                    if (five % 3 == 0 && three % 5 == 0)
                    { found = true; break; }
                    if (five == 0 && three % 5 != 0)
                        break;
                    five -= 3; three = k - five;
                   
                }

                if (found == true)
                {
                    for (int i = 0; i < five / 3; i++)
                        Console.Write("555");
                    for (int i = 0; i < three / 5; i++)
                        Console.Write("33333");
                }
                else
                    Console.Write("-1");
                Console.WriteLine();
            }
        }
    }
}
