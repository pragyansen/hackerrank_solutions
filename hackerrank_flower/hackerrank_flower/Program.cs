using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace hackerrank_flower
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k,counter=0,d_counter = 0,sum=0;
            string s = Console.ReadLine();
            string[] z = s.Split(new Char[] {' ', '\t', '\n'});
            int.TryParse(z[0],out n);
            int.TryParse(z[1],out k);
            s = Console.ReadLine();
            //s = File.ReadAllText("input.txt");
            int[] flowers = s.Split(new char[] {' ', '\t','\n'}, StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).ToArray();
            Array.Sort<int>(flowers,new Comparison<int>((i1,i2) => i2.CompareTo(i1)));
            int[] data = new int[k];
            while (counter < n)
            {
                sum = sum + (data[d_counter] + 1) * flowers[counter];
                data[d_counter]++; d_counter++; counter++; 
                if (d_counter == k)
                { d_counter = 0; }
            }
            Console.Write(sum);
            Console.ReadKey();
        }
    }
}
