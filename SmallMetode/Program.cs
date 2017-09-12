using System;

namespace SmallMetode
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = LægSammen(5, 2);
            Console.WriteLine(res); // 7
            double res2 = BeregnAreal(5);
            Console.WriteLine(res2); // 78.53
            Udskriv();  // blank linie
            Udskriv("Dette er en test"); // Dette er en test
            double res3 = BeregnMoms(100.35);
            Console.WriteLine(res3);    // 25.0875
                                        // Optional parameter
            double res4 = BeregnMoms(100.35, 0.25);
            Console.WriteLine(res4);    // 25.0875
            int[] løn = { 10000, 5000, 30000 };
            double gns = Gennemsnit(løn);
            Console.WriteLine(gns);     // 15.000
            Console.ReadKey();
        }
        static int LægSammen(int a, int b)
        {
            return a + b;
        }

        static double BeregnAreal(int radius)
        {
            return (radius * radius * System.Math.PI);
        }
        static void Udskriv(string txt = "")
        {
            Console.WriteLine(txt);
        }
        static double BeregnMoms(double beløb, double momsPct = 25)
        {
            return (beløb * momsPct) / 100;
        }
        static double Gennemsnit(int[] månedsløn)
        {
            double sum = 0;
            for (int i = 0; i < månedsløn.Length; i++)
            {
                sum += månedsløn[i];
            }
            return (sum / månedsløn.Length);
        }
    }
}
