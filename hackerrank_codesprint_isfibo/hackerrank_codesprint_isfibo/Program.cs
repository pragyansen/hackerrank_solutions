using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank_codesprint_isfibo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; int.TryParse(Console.ReadLine(), out n);
            
            List<long> store = new List<long>();
            long j = 1;
            long i = 0; store.Add(i); store.Add(j);
            while(i < 10000000000)
            {
                i = i + j;
                store.Add( i);
                long temp = i; i = j; j = temp;
            }

            while(n-- > 0)
            {
                long data; long.TryParse(Console.ReadLine(), out data);

                if (store.Contains(data))
                    Console.WriteLine("IsFibo");
                else
                    Console.WriteLine("IsNotFibo");





            }
        }
        static bool IsFib(long T, out long idx)
        {
            double root5 = Math.Sqrt(5);
            double phi = (1 + root5) / 2;

            idx = (long)Math.Floor(Math.Log(T * root5) / Math.Log(phi) + 0.5);
            long u = (long)Math.Floor(Math.Pow(phi, idx) / root5 + 0.5);

            return (u == T);
        }
    }
}
