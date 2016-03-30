using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank_codesprint_pennywise_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; int.TryParse(Console.ReadLine(), out n);
            string[] s = Console.ReadLine().Split(' ');
            int my_coin; int.TryParse(s[0], out my_coin);
            int[] coins = new int[my_coin];
            int ta_coin; int.TryParse(s[1], out ta_coin);
            int[] table = new int[ta_coin];
            string[] z = Console.ReadLine().Split(' ');
            for(int i = 0; i<my_coin;i++)
            {
                int.TryParse(z[i], out coins[i]);
            }
            if(ta_coin>0)
            {
                string[] z1 = Console.ReadLine().Split(' ');
                for (int i = 0; i < ta_coin; i++)
                    int.TryParse(z1[i], out table[i]);
            }

            int my_max = coins.Max();   int pos = 0;
            int table_min = 0;
            if(ta_coin > 0)
               table_min = table.Min();
            if (my_max <= table_min || ta_coin==0)
                Console.WriteLine(my_max + " 0");
            else
            {
                int sum = 0;
                while (sum < my_max && pos < table.Length - 1)
                {
                    sum += table[pos++];
                }
                if (sum >= my_max)
                    sum -= table[--pos];


                Console.WriteLine(my_max + " " + pos + 1);
                for (int i = 0; i <= pos; i++)
                    Console.Write(table[pos] + " ");
            }
        }
    }
}
