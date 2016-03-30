using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank_game_of_thrones_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine().ToLower();
            int[] a = new int[26];
            foreach(char p in s)
            {
                a[p - 97]++;
            }
            int len = s.Length;
            bool status = true; int count = 0;
            if(len%2 == 0)
            {
                for(int i = 0;i<26;i++)
                {
                    if (a[i] % 2 != 0)
                        status = false;
                }
            }
            else
                for(int i=0;i<26;i++)
                {
                    if(a[i]%2!=0)
                    {
                        if (count == 0)
                            count++;
                        else
                            status = false;

                    }
                }
            if (status == false)
                Console.WriteLine("NO");
            else
                Console.WriteLine("YES");

        }
    }
}
