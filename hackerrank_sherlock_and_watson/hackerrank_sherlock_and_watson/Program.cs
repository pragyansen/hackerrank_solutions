using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank_sherlock_and_watson
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k, q;
            string[] s = Console.ReadLine().Split(' ');
            int.TryParse(s[0], out n); int.TryParse(s[1], out k); int.TryParse(s[2], out q);
            int[] num = new int[n];
            string[] z = Console.ReadLine().Split(' ');
            for(int i=0;i<n;i++)
            {
                int.TryParse(z[i], out num[i]); 
            }
            while(q-- > 0)
            {
                
                int pos = Convert.ToInt32(Console.ReadLine());
                k = k % n;
                int p = (pos + n - k) % n;
                Console.WriteLine(num[p]);
            }
            Console.ReadLine();
        }

        
    }
}
