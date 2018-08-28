using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursus01legeplads
{
    class Program
    {
        static void Main(string[] args)
        {

            int row = 11;
            int space = 11;


            for (int x = 1; x < row; x++)
            {
                for (int y = 1; y < space; y++)
                {
                    string number = (x * y).ToString();
                    if((x*y) > 50)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    Console.Write(number.PadLeft(6));
                }
                Console.WriteLine();

            }
            Console.ForegroundColor = ConsoleColor.White;
            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("\nPress any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
