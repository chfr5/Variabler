using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nedarvning1
{
    public class Terning
    {
        private static System.Random rnd;
        private int værdi;

        public int Værdi
        {
            get { return this.værdi; }
            private set { 
                if (value > 6 || value < 1)  value = 1;
                værdi = value; }
        }
        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);
        }
        public Terning()
        {
            Ryst();
        }
        public Terning( int værdi)
        {
            this.Værdi = værdi;
        }
        public void Skriv()
        {
            Console.WriteLine("[" + this.Værdi + "]");
        }

    }
    public class LudoTerning : Terning
    {
        public bool ErGlobus()
        {
            return this.Værdi == 3;
        } 
        public bool ErStjerne()
        {
            return this.Værdi == 5;
        }
        public LudoTerning() : base() { }
        public LudoTerning(int værdi) :base(værdi)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
