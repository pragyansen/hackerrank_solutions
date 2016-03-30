using System;
using System.Collections.Generic;
using System.Text;

namespace hackerrank_TBAA_Style_of_Spelling
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; 
            int.TryParse(Console.ReadLine(), out n);
            List<string> data = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                data.Add(s);
            }
            int.TryParse(Console.ReadLine(), out n);
            string[] match = new string[n * 2]; int[] count = new int[n * 2];
            for (int i = 0; i < n; i++)
            {
                match[i]=Console.ReadLine();
                if (match[i][match[i].Length - 2] == 's' && match[i][match[i].Length - 1] == 'e')
                { StringBuilder p = new StringBuilder(); p.Append(match[i]); p[p.Length - 2] = 'z'; match[i + n] = p.ToString(); }
                if (match[i][match[i].Length - 2] == 'z' && match[i][match[i].Length - 1] == 'e')
                { StringBuilder p = new StringBuilder(); p.Append(match[i]); p[p.Length - 2] = 's'; match[i + n] = p.ToString(); }
            }
            foreach(string i in data)
            {
                string[] z = i.Split(' ');
                foreach (string k in z)
                {
                    for (int j = 0; j < n * 2; j++)
                    { if (k == match[j]) count[j]++; }
                }

            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(count[i] + count[i + n]);
            }
        }
    }
}
