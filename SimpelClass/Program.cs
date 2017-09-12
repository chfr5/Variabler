using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpelClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.fødselsår = 1999;
            p.forNavn = "Christian";
            p.efterNavn = "Frederiksen";
            Console.WriteLine(p.FuldtNavn());
            Console.WriteLine(p.Alder());
        }
    }
}
