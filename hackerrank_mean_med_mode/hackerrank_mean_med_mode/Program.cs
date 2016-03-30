using System;
using System.Collections.Generic;
using System.Text;

namespace hackerrank_mean_med_mode
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; int.TryParse(Console.ReadLine(), out n);
            double[] data = new double[n];
            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                double.TryParse(s[i], out data[i]);
            }
            Array.Sort(data);
            double mean_value = mean(data);
            median(data);
            mode(data);
            double sd = standard_dev(data, mean_value);
            confidence_interval_for_the_mean(data, mean_value, sd);
            Console.ReadKey();
        }

        private static void confidence_interval_for_the_mean(double[] data, double mean_value, double sd)
        {
            double min, max; min = max = data[0];
            foreach (double d in data)
            {
                if (d < min)
                    min = d;
                if (d > max)
                    max = d;
            }

        }

        private static double standard_dev(double[] data, double mean_value)
        {
            double d = 0;
            foreach (double i in data)
            {
                d += Math.Pow(mean_value - i, 2);
            }
            d = Math.Sqrt(d / data.Length);
            Console.WriteLine("{0:F1}", d);
            return d;
        }

        private static void mode(double[] data)
        {
            Dictionary<double, int> map = new Dictionary<double, int>();
            for (int i = 0; i < data.Length; i++)
            {
                if (map.ContainsKey(data[i]))
                    map[data[i]]++;
                else
                    map.Add(data[i], 1);
            }
            double value = 0, key = 9999999;

            foreach (KeyValuePair<double, int> s in map)
            {
                if (value < s.Value)
                {
                    key = s.Key;
                    value = s.Value;
                }
                else if (value == s.Value)
                {
                    if (key > s.Key)
                        key = s.Key;
                }
            }
            Console.WriteLine("{0:F0}", key);
        }

        private static void median(double[] data)
        {
            if (data.Length % 2 == 0)
                Console.WriteLine("{0:F1}", (data[(data.Length / 2) - 1] + data[data.Length / 2]) / 2);
            else
                Console.WriteLine("{0:F1}", data[data.Length / 2]);
        }

        private static double mean(double[] data)
        {
            double count = 0;
            for (int i = 0; i < data.Length; i++)
                count += data[i];
            count /= data.Length;
            Console.WriteLine("{0:F1}", count);
            return (count);
        }
    }
}
