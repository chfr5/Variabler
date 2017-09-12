using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trekant
{
    class Program
    {
        static void Main(string[] args)
        {
            triangle d = new triangle(25, 10);
            Console.WriteLine(d.Grundlinie.ToString() + '.' + d.Højde.ToString());
            Console.WriteLine(d.Areal);
        }
    }
    class triangle
    {
        public int Grundlinie { get; private set; }
        public int Højde { get; private set; }

        public triangle(int grundlinie, int højde)
        {
            this.Grundlinie = grundlinie;
            this.Højde = højde;
        }
        public double Areal
        {
            get
            {
                return this.Grundlinie * this.Højde * 0.5;
            }
        }
    }
}

