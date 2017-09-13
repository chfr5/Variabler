using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpelFejl1
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            logger.Trace("Start");
            logger.Debug("");

            test1(5, 5);
            test2();
        }

        static void test1(int i, int x)
        {
            Console.WriteLine("test1");
            System.Threading.Thread.Sleep(1000);
        }

        static void test2()
        {
            try
            {
                Console.WriteLine("test2");
                throw new ApplicationException("fejl");
            }
            catch (Exception ex)
            {
                // mangler log
            }
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        try
    //        {
    //            Run();

    //        }
    //        catch (Exception ex)
    //        {
    //            Console.WriteLine("Der er sket en fejl - " + ex.Message);
    //            throw  ;
    //        }        }

    //    private static void Run()
    //    {
    //        Console.WriteLine("Indtast tal 1");
    //        int t1 = Convert.ToInt32(Console.ReadLine());
    //        Console.WriteLine("Indtast tal 2");
    //        int t2 = Convert.ToInt32(Console.ReadLine());
    //        int res = t1 + t2;
    //        Console.WriteLine("Resultat " + res);
    //    }
    //}
    
}

