using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace månedsløn
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] løn = { 10000, 20000, 15000, 20000, 30000, 15000 };
            double sum = 0;
            for (int i = 0; i < løn.Length; i++)
            {
                Console.WriteLine(løn[i].ToString("N2"));
                sum += løn[i];
            }
            Console.WriteLine("Lønsum " + sum.ToString("N2") );
            Console.WriteLine("Antal måneder " + løn.Length );
            Console.WriteLine("Gennemsnit månedsløn " + (sum / løn.Length).ToString("N2"));

            Console.ReadKey();
        }
    }
}
