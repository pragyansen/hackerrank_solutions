using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank_cut_the_sticks
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; int.TryParse(Console.ReadLine(), out n);
            string[] s = Console.ReadLine().Split(' ');
            List<int> data = new List<int>();
            for(int i=0;i<n;i++)
            {
                data.Add(Convert.ToInt32(s[i]));
            }
            int min = data.Min();
            while(data.Count!=0)
            {
                Console.WriteLine(data.Count);
                for (int i = 0; i < data.Count;i++ )
                {
                    if(data[i] <= min)
                    {
                        data.Remove(data[i]); i--; 
                    }
                    else
                    {
                        data[i] -= min;
                    }
                }
                    
               
            }
            Console.ReadLine();

        }
    }
}
