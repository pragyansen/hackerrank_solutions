using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace hackerrank_hackerrank_language
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            string m = "C:CPP:JAVA:PYTHON:PERL:PHP:RUBY:CSHARP:HASKELL:CLOJURE:BASH:SCALA:ERLANG:CLISP:LUA:BRAINFUCK:JAVASCRIPT:GO:D:OCAML:R:PASCAL:SBCL:DART:GROOVY:OBJECTIVEC";
            string[] t = m.Split(':');
            int v = 0;
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine(); 
                string[] z = s.Split(' '); 
                int k = Convert.ToInt32(z[0]);
                if (k <= 100000 && k >= 10000)
                {
                    bool ismatch = false;
                    for (int j = 0; j < t.Length; j++)
                    {
                        if (t[j] == z[1])
                        { ismatch = true; break; }
                    }
                    if (ismatch)
                    {
                        v++;
                        Console.WriteLine("VALID");
                    }
                    else
                        Console.WriteLine("INVALID");
                }
            }
            Console.WriteLine(v);
            Console.ReadKey();
        }
    }
}
