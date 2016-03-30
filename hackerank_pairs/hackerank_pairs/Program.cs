using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace hackerank_pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] z = s.Split(' ');
            int k;
            int.TryParse(z[1],out k);
            s = Console.ReadLine();
            int[] ints = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(i => int.Parse(i)).ToArray();
            //Console.WriteLine(ints.Length);
            Array.Sort<int>(ints,new Comparison<int>((i1, i2) => i2.CompareTo(i1)));
            
           /* for(int i=0;i<ints.Length;i++)
            Console.WriteLine(ints[i]);*/

            int counter = 0, start = 0, next = 1;
            while (true)
            {
                if (start == ints.Length - 1 || next == ints.Length)
                    break;
                int diff = ints[start]-ints[next];
                if (diff < k)
                    next++;
                if (diff == k)
                { counter++; next++; }
                if (diff > k)
                { start++; next = start + 1; }
                

            }
            Console.WriteLine(counter);
            Console.ReadKey();
        }
    }
}
