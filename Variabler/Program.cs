using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 heltal = 10;
            Console.WriteLine(heltal);
            heltal++;
            Console.WriteLine(heltal);
            heltal--;
            Console.WriteLine(heltal);
            heltal += 20;
            Console.WriteLine(heltal);

            double kommatal = 12.5;
            Console.WriteLine(kommatal);
            kommatal++;
            Console.WriteLine(kommatal);
            kommatal *= 2;
            Console.WriteLine(kommatal);

            FilTyper tf = FilTyper.pdf;
            Console.WriteLine(tf);
            Console.WriteLine((int)tf);

            DateTime dato;
            dato = DateTime.Now;
            Console.WriteLine(dato.ToString("ddMMyy"));
            Console.WriteLine(dato.ToString("dddd d MMMM yyyy"));

            Person p;
            p.Id = 1;
            p.Navn = "Mikkel";
            Console.WriteLine(p.Navn);


            Console.ReadKey();
        }
    }
    
    public enum FilTyper
    {
        csv,
        pdf,
        txt
    }
    public struct Person
    {
        public int Id;
        public string Navn;
    }
}
