using System;
using System.Collections.Generic;
using System.Text;

namespace hackerrank_help_mike
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            while (n-- > 0)
            {
                string s = Console.ReadLine();
                string[] z = s.Split(' ');
                UInt64 num, k, up, lower; UInt64 count = 0;
                UInt64.TryParse(z[0], out num); UInt64.TryParse(z[1], out k); UInt64[] data = new UInt64[k];
                for (UInt64 i = 1; i <= num; i++)
                {
                    if (i <= k)
                    {
                        lower = k - (i % k);
                        while (lower <= i)
                            lower += k;
                        up = ((num / k) * k) - (i % k);
                        if (up + k <= num)
                            up += k;
                        if (lower > num)
                            break;
                        if (lower <= num)
                        { count++; data[i - 1]++; }
                        count = count + (up - lower) / k; data[i - 1] += (up - lower) / k;
                        data[i - 1]--;
                        count += data[i - 1] * (data[i - 1] + 1) / 2;
                        continue;
                    }
                    else break;
                }
           /*     int temp;
                for (int i = 1; i <= k; i++)
                {
                    count = 0;
                    for (int j = i + 1; j <= num; j = j + k)
                    {
                        if (i + j < k)
                        { j = k - i; }
                        else if ((i + j) % k != 0)
                        {
                            temp = (i + j) % k;
                            j = j + k - temp;
                            if (j > num)
                                break;
                        }
                        count++; //Console.WriteLine(i + " " + j);
                    }
                    data[i - 1] = count;
                    
                }
                count = 0;
                for (int i = 0; i < k; i++)
                {
                    //data[i]--;
                    count += data[i] * (data[i] + 1) / 2;
                }
                */


                Console.WriteLine(count);
            }
            Console.ReadKey();
        }
    }
}
