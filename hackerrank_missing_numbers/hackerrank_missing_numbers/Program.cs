using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace hackerrank_missing_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            string[] s = Console.ReadLine().Split(' ');
            Console.ReadLine();
            string[] z = Console.ReadLine().Split(' ');
            Dictionary<string, int> data = new Dictionary<string, int>();
            for (int i = 0; i < z.Length; i++)
            {
                if (data.ContainsKey(z[i]))
                    data[z[i]]++;
                else
                    data.Add(z[i], 1);
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (data.ContainsKey(s[i]))
                {
                    if (data[s[i]] > 1)
                        data[s[i]]--;
                    else data.Remove(s[i]);
                }
            }
            var list = data.Keys.ToList();
            list.Sort();
            foreach(var key in list)
            {
                for (int i = 0; i < data[key]; i++)
                    Console.Write(key + " ");
            }
            Console.ReadKey();
        }
    }
}
