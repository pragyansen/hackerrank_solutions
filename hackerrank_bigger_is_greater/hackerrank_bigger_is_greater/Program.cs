using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank_bigger_is_greater
{
    class Program
    {
        static void Main(string[] args)
        {
            int t; int.TryParse(Console.ReadLine(), out t);

            while (t-- > 0)
            {
                char[] s = Console.ReadLine().ToCharArray();
                int i;  StringBuilder data = new StringBuilder();
                for(i = s.Length-1;i>0;i--)
                {
                    if (s[i] > s[i - 1])
                        break;
                }
                if(i==0)
                    Console.WriteLine("no answer");
                else
                {

                    for (int j = 0; j < i-1; j++)
                        data.Append(s[j]);
                    data.Append(s[i]);
                    data.Append(s[i -1]);

                    for (int j = ++i; j < s.Length; j++)
                        data.Append(s[j]);
                    Console.WriteLine(data);
                }
            }
            Console.ReadKey();
        }
    }
}
