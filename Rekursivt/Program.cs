using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rekursivt
{
    class Program
    {
        static void Main(string[] args)
        {
            LoopTheLoop(1, 10);
            Console.WriteLine("Press any key ...");
            Console.ReadKey();
        }
        public static void LoopTheLoop(int start, int stop)
        {
            Console.WriteLine(start);
            if(start >= stop)
            {
                return;
            }
            start++;
            LoopTheLoop(start, stop);
        }
    }
}
