using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank_who_is_gonna_be_first
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            //find max length of a
            int length = 0, prev_length = 0;
            foreach(char p in data)
            {
                if (p == 'a')
                    length++;
                else
                {
                    if(prev_length<length)
                    {
                        prev_length = length;
                        length = 0;
                    }
                }
            }
            if (prev_length < length)
            {
                prev_length = length;
                length = 0;
            }

            //Console.WriteLine(prev_length);

          //  StringBuilder op = new StringBuilder();
            for (int i = 0; i <= prev_length;i++ )
            {
                Console.Write('a');
            }
                Console.ReadKey();
        }
    }
}
