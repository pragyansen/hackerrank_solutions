using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank_manasa_loves_maths
{
    class Program
    {

        static void Main(string[] args)
        {

            var mars = Enumerable.Range(0, 125).Select((i) => new Dictionary<int, int>()).ToArray();
            int c = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 8 == 0)
                {
                    if (i < 10)
                    {
                        if (mars[c].ContainsKey(i))
                            mars[c][i]++;
                        else
                            mars[c].Add(i, 1); c++;
                    }
                    else if (i < 100)
                    {
                        int num = i;
                        while (num != 0)
                        {
                            int temp = num % 10;
                            num = num / 10;
                            if (mars[c].ContainsKey(temp))
                                mars[c][temp]++;
                            else
                                mars[c].Add(temp, 1);

                        } c++;
                    }
                    else
                    {
                        int num = i;
                        while (num != 0)
                        {
                            int temp = num % 10;
                            num = num / 10;
                            if (mars[c].ContainsKey(temp))
                                mars[c][temp]++;
                            else
                                mars[c].Add(temp, 1);

                        } c++;
                    }
                }
            }
            mars[0][0]++; mars[0][0]++;
            int t; int.TryParse(Console.ReadLine(), out t);
            while (t-- > 0)
            {

                string p = Console.ReadLine();
                //   p = p.TrimStart('0');
                int[] sink = new int[10];
                foreach (char i in p)
                {
                    if (sink[i - 48] < 10)
                        sink[i - 48]++;
                }
                if (p.Length < 4)
                {
                    int gif = Convert.ToInt32(p);
                    if (gif == 0)
                    { Console.WriteLine("YES"); continue; }

                    
                }
                

                    bool success = false;
                    for (int i = 0; i < c; i++)
                    {
                        if (p.Length < 4)
                        {
                            int dount = 0;
                            for (int j = 0; j < 10; j++)
                            {
                                if (sink[j] != 0)
                                    dount++;
                            }
                            if (mars[i].Count < dount)
                                continue;
                        }
                        foreach (KeyValuePair<int, int> b in mars[i])
                        {
                            if (sink[b.Key] >= b.Value)
                            {
                                success = true;
                                continue;
                            }
                            else
                            {
                                success = false;
                                break;
                            }

                        }
                        if (success == true)
                        {
                            Console.WriteLine("YES");
                            break;
                        }

                    }
                    if (success == false)
                        Console.WriteLine("NO");

                }
            
        }


    }
}
