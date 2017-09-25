using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modul10_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                using (StreamReader stream = System.IO.File.OpenText("x:dyrenavne.txt"))
                {
                    while(stream.Peek() != -1)
                    {
                        var l = stream.ReadLine();
                        Console.WriteLine(l.ToUpper());
                    }
                }
            }
            return;
            {
                StreamReader stream = System.IO.File.OpenText("x:dyrenavne.txt");
                while (stream.Peek() != -1)
                {
                    string navn = stream.ReadLine();
                    Console.WriteLine(navn);
                }
                stream.Close();
                stream = null;
            }
            return;
            {
                Hund[] hunde = new Hund[2];
                hunde[0] = new Hund() { Alder = 10, Navn = "Bulder" };
                hunde[1] = new Hund() { Alder = 5, Navn = "Tarzan" };

                Array.Sort(hunde);

                foreach (var item in hunde)
                {
                    Console.WriteLine(item.Navn);
                }
            }
            return;

            IDbFunktioner[] arr = new IDbFunktioner[4];
            arr[0] = new Hund();
            arr[1] = new Ubåd();
            arr[2] = new Hund();
            arr[3] = new Ubåd();
            foreach (var item in arr)
            {
                item.Gem();
            }
        }
    }
    public class Hund:IDbFunktioner , IComparable
    {
        public string Navn { get; set; }
        public int Alder { get; set; }

        public int CompareTo(object obj)
        {
            Hund andenhund = obj as Hund;
            if(this.Alder < andenhund.Alder) { return -1; }
            else if (this.Alder > andenhund.Alder) { return 1; }
            return 0;
        }

        public void Gem()
        {
            Console.WriteLine("Gemmer hund ...");
        }
    }

    class Ubåd:IDbFunktioner
    {
        public int Nummer { get; set; }
        public double Turbine { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer ubåd ...."); 
        }
    }
    interface IDbFunktioner
    {
        void Gem();
    }
    class MyClass
    {

    }
}
