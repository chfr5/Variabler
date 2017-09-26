using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12_delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = Beregn(1, 1, Minus);
            r = Beregn(2, 3, Plus);
            //r = Beregn(2, 3, us);
        }

        public delegate int Beregner(int a, int b);
        public static int Beregn(int a, int b, Beregner regneart)
        {
            return regneart(a, b);
        }

        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }
        public static int Divider(int a, int b)
        {
            return a / b;
        }
        public static int Gange(int a, int b)
        {
            return a * b;
        }
        public static int us(int a)
        {
            return a ;
        }
    }
}
