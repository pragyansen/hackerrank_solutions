using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank_sherlock_and_pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int t; int.TryParse(Console.ReadLine(), out t);
            while(t-- > 0)
            {
                int n; int.TryParse(Console.ReadLine(), out n);
                string[] s = Console.ReadLine().Split(' ');
                int[] data = new int[n+1];
                for(int i=0;i<n;i++)
                {
                    int.TryParse(s[i], out data[i]);
                }
                data[n] = 99999999;
                Array.Sort(data);
                int temp = data[0]; long count = 1; long total = 0;
                for(int i = 1;i<n+1;i++)
                {
                    if (data[i] == temp)
                    { count++; continue; }
                    if(data[i]>temp)
                    {
                        temp = data[i];
                        total += count * (count -1);
                        count = 1;
                    }
                }

                Console.WriteLine(total);






            }
        }
    }
}
