using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorfiDyr1
{
    public class Dyr
    {
        static System.Random rnd = new Random();
        public string Navn { get; set; }
        public virtual void SigNoget()
        {
            Console.WriteLine("jeg er et dyr og hedder " + this.Navn);
        }
        public static Dyr RandomDyr()
        {
            string sti = @"x:\dyrenavne.txt";
            string[] navne = System.IO.File.ReadAllLines(sti);
            int nummer = rnd.Next(0, navne.Length);
            if (nummer % 2 == 0 )
            {
                return new Hund() { Navn = navne[nummer] };
            } else
            {
                return new Kat() { Navn = navne[nummer] };
            }
        }
    }
    class Hund : Dyr
    {
        public override void SigNoget()
        {
            //base.SigNoget();
            Console.WriteLine("jeg er en hund og hedder " + this.Navn);
        }
    }
    class Kat : Dyr
    {
        public override void SigNoget()
        {
            base.SigNoget();
            //Console.WriteLine("jeg er en kat og hedder " + this.Navn);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dyr[] dyr = new Dyr[20];
            for (int i = 0; i < 20; i++)
            {
                dyr[i] = Dyr.RandomDyr();
            }
            foreach (var item in dyr)
            {
                item.SigNoget();
            }
        }
    }
}
