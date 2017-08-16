using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeregnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 7, 6, 3, 1, 50, 3 };
            var resul = BeregnOgSorterArray(arr);
        }
        public static res BeregnOgSorterArray(int[] a)
        {
            res r;
            r.sum = 0;
            foreach (var item in a)
            {
                r.sum += item;
            }
            r.gennemsnit = r.sum / a.Length;
            Array.Sort(a);
            return r;
        }
    }
    struct res
    {
        public double sum;
        public double gennemsnit;
    }
}
