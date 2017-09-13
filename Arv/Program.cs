using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    public class Person
    {
        public string ForNavn { get; set; }
        public string EfterNavn { get; set; }

        public string FuldtNavn()
        {
            if (ForNavn != "") {
                return ForNavn + " " + EfterNavn;
            } else
            {
                return EfterNavn;
            }
        }
    }
    public class Elev : Person
    {
        public string Klasselokale { get; set; }
    }
    public class Underviser : Person
    {
        public int NøgleId { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
        
            p.ForNavn = "Per";
            p.EfterNavn = "Hansen";
            Console.WriteLine(p.FuldtNavn());
            Underviser u = new Underviser();
            u.EfterNavn = "PETERSEN";
            u.NøgleId = 5;
            Console.WriteLine("Underviser "+u.FuldtNavn()+" med nøglekort nr:" + u.NøgleId     );
        }
    }
}
