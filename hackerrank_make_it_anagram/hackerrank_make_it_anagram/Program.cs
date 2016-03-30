using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank_make_it_anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int[] a_store = new int[26];
            int[] b_store = new int[26];

            foreach(char c in a)
            {
                a_store[c - 97]++;
            }
            foreach (char c in b)
            {
                b_store[c - 97]++;
            }
            int counter = 0;
            for(int i = 0;i<26;i++)
            {
                counter += diff(a_store[i], b_store[i]);
            }
            Console.WriteLine(counter);
            Console.ReadLine();

        }

        private static int diff(int p1, int p2)
        {
            if (p1 < p2)
                return p2 - p1;
            else return p1 - p2;
        }
    }
}
