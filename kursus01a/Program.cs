using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursus01a
{
    class Program
    {
        static void Main(string[] args)
        {

            string a;
            a = "a";
            Console.WriteLine($"a = {a}");

            bool test;
            test = a == "a";
            Console.WriteLine($"test {test}");
            Console.WriteLine($"ny test {a == "b"}");

            a = a + " b";
            Console.WriteLine($"a = {a}");
            a += " c";
            Console.WriteLine($"a = {a}");

            // Sammenligning
            string b = "b", c = "c";
            int res = string.Compare(b, c);
            Console.WriteLine($"Sammenlign b med c = {res}");
            res = string.Compare(c, b);
            Console.WriteLine($"Sammenlign c med b = {res}");
            res = string.Compare(c, c);
            Console.WriteLine($"Sammenlign c med c = {res}");

            Console.ReadKey();


            System.Diagnostics.Stopwatch s = new System.Diagnostics.Stopwatch();
            s.Start();
            string ab = "";
            for (int i = 0; i < 50000; i++)
            {
                ab += "*";
            }
            s.Stop();
            Console.WriteLine($"ms = {s.ElapsedMilliseconds}");

            Console.ReadKey();


            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sw.Start();
            for (int i = 0; i < 100000; i++)
            {
                sb.Append("*");
            }
            sw.Stop();
            Console.WriteLine($"ms = {sw.ElapsedMilliseconds}");

            Console.ReadKey();

        }
    }
}
