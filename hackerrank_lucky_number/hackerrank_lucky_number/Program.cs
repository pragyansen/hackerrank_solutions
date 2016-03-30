using System;
using System.Collections.Generic;
using System.Text;

namespace hackerrank_lucky_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            int ceiling = 600851475143; int[] hash = new int[ceiling]; int[] square = new int[10];
            List<int> dividers = new List<int>();
            List<int> semilist = new List<int>();
            for (int i = 2; i <= ceiling / 2; i++)
            {
            dividers.Add(i);
            }
            int p = 2;
            for (int i = 0; i < 10; i++)
            square[i] = i * i;
            while (p * p < ceiling)
            {
            p = dividers[0]; dividers.Remove(p); semilist.Add(p); hash[p] = 1;
            for (int i = 0; i < dividers.Count; i++)
            if (dividers[i] % p == 0)
            dividers.Remove(dividers[i]);
            }
            for (int i = 0; i < dividers.Count; i++)
            {
            semilist.Add(dividers[i]); hash[dividers[i]] = 1;
            }

        //foreach (int i in semilist)
        //    Console.WriteLine(i);
        for (int i = 0; i < n; i++)
        {
        int counter = 0;
        UInt64 a, b;
        string s = Console.ReadLine();
        string[] z = s.Split(' ');
        UInt64.TryParse(z[0], out a); UInt64.TryParse(z[1], out b);
        if (a < 10)
        a = 11;
        string m = a.ToString(); int sum = 0, sum2 = 0;
        for (int k = 0; k < m.Length; k++)
        { int o = Convert.ToInt32(m[k]); sum = sum + o - 48; sum2 += square[o - 48]; }
        //if (semilist.Contains(sum) && semilist.Contains(sum2))
        if (hash[sum] == 1 && hash[sum2] == 1)
        {
        counter++;
        //Console.WriteLine(a);
        }
        for (UInt64 j = a+1; j <= b; j++)
        {
        string g = j.ToString();
        sum = 0; sum2 = 0;
        for (int k = 0; k < g.Length; k++)
        { int o = Convert.ToInt16(g[k]) - 48; sum = sum + o; sum2 += square[o]; }
        if (hash[sum] == 1 && hash[sum2] == 1)
        counter++;
        }

        Console.WriteLine(counter);
        }
        Console.ReadKey();
        }
        }
        }
