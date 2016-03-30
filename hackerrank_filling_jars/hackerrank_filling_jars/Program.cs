using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank_filling_jars
{
    class Program
    {
        static void Main(string[] args)
        {
            int jars, n;
            int total = 0;
            string[] z = Console.ReadLine().Split(' ');
            int.TryParse(z[0], out jars); int.TryParse(z[1], out n);
            while(n-- > 0)
            {
                string[] s = Console.ReadLine().Split(' ');
                int start = Convert.ToInt32(s[0]); int end = Convert.ToInt32(s[1]); int candy = Convert.ToInt32(s[2]);
                total = total + ((end - start)+1) * candy;

            }
            Console.WriteLine(total / jars);
            Console.ReadKey();
        }
    }
}
