using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArealBeregning
{
    static class ArealBeregninger
    {
        public static double ArealFirkant( double h, double b)
        {
            return h * b;
        }
        public static double ArealCirkel( double r)
        {
            return Math.Pow(r, 2) * Math.PI;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Firkant " + ArealBeregninger.ArealFirkant(10,10));
            Console.WriteLine("Cirkel " + ArealBeregninger.ArealCirkel(10));
        }
    }
}
