using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank_angry_children
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; int.TryParse(Console.ReadLine(), out n);
            int k; int.TryParse(Console.ReadLine(), out k);
            int[] data = new int[n];
            for (int i = 0; i < n; i++)
            {
                int.TryParse(Console.ReadLine(), out data[i]);
            }
            Array.Sort(data);
            int min =0, max = k-1;
            Int64 difference = 999999999999999999;
            int current_difference = 0;
            for (int i = 0; i < k; i++)
                for (int j = i; j < k; j++)
                {
                    int diff = data[i + min] - data[j + min];
                    if (diff < 0)
                        diff *= -1;
                    current_difference += diff;
                }
           
            if (current_difference < difference)
                difference = current_difference;

            min++; max++;
            while (max != data.Length)
            {
                
                for (int i = 0; i < k-1; i++)
                {
                    current_difference -= data[i + min] - data[min - 1];
                    current_difference += data[max] - data[i + min];
                }
                
                if (current_difference < difference)
                    difference = current_difference;

                    min++; max++;
            }
            Console.WriteLine(difference);
            Console.ReadKey();
        }
    }
}
