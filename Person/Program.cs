using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Efternavn = "abc";
            Console.WriteLine(p.FuldtNavn());

            Person p2 = new Person();
            p2.Efternavn = "ab";
            Console.WriteLine(p2.FuldtNavn());
        }
    }
}
