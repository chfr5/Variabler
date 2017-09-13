using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdvRnd1
{
        public class UdvidetRandom : System.Random
    {
        public bool NextBool()
        {
            return this.Next(1, 1001) < 500;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            UdvidetRandom r = new UdvidetRandom();
            Console.WriteLine(r.NextBool());
            Console.WriteLine(r.NextBool());
            Console.WriteLine(r.NextBool());
            Console.WriteLine(r.NextBool());
            Console.WriteLine(r.NextBool());
            Console.WriteLine(r.NextBool());
            Console.WriteLine(r.NextBool());
            Console.WriteLine(r.NextBool());
            Console.WriteLine(r.NextBool());
            Console.WriteLine(r.NextBool());
            Console.WriteLine(r.NextBool());
            Console.WriteLine(r.NextBool());
            Console.WriteLine(r.NextBool());
            Console.WriteLine(r.NextBool());

        }
    }
}
