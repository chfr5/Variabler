using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lilleTabel
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x < 11; x++)
            {
                for (int y = 1; y < 11; y++)
                {
                    string t = (x * y).ToString();
                    if ((x * y) >= 50)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    Console.Write(t.PadLeft(3));
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }

            Console.WriteLine("press any key ....");
            Console.ReadKey();

        }
    }
}
