using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank_broken_keyboard
{
    class Program
    {
        static void Main(string[] args)
        {
            int t; int.TryParse(Console.ReadLine(), out t);
            while(t-- >0)
            {
                string k = Console.ReadLine();
                int[] keys = new int[26];
                foreach(char p in k)
                {
                    keys[p-97]=1;
                }
                string w = Console.ReadLine();
                foreach(char p in w)
                {
                    keys[p - 97] = 0;
                }
                int sum = 0;
                for(int i = 0;i<26;i++)
                {
                    sum += keys[i];
                }
                Console.WriteLine(k.Length - sum);
            }
        }
    }
}
