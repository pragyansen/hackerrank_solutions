using System;
using System.Collections.Generic;
using System.Text;

namespace hackerrank_common_child
{
    class Program
    {
        public static int[,] data;
        static void Main(string[] args)
        {
            string match1 = Console.ReadLine();
            string match2 = Console.ReadLine();
            data = new int[match1.Length+1 , match2.Length+1];
            int result = 0;
            lcs(match1, match2,match1.Length,match2.Length);
         /*   for (int i = 0; i < match1.Length+1; i++)
            {
                for (int j = 0; j < match2.Length+1; j++)
                    Console.Write(" "+data[i, j]);
                Console.WriteLine();
            }   */
            Console.WriteLine(data[match1.Length,match2.Length]);
            Console.ReadKey();
        }

        private static void lcs(string match1, string match2, int m, int n)
        {
            for(int i=0;i<=m;i++)
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0)
                        data[i, j] = 0;
                    else if (match1[i - 1] == match2[j - 1])
                        data[i, j] = data[i - 1, j - 1] + 1;
                    else
                        data[i, j] = max(data[i - 1, j], data[i, j - 1]);
                }
        }

        private static int max(int result, int p)
        {
            return (result>p)? result:  p;
        }
    }
}
