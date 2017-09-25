using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nedarv
{
    class Program
    {
        static void Main(string[] args)
        {
            LudoTerning 1 = new LudoTerning();
            1.Skriv();
            Terning[] terning = new Terning[4];
            terning[0]=new Terning();
            terning[1]=new LudoTerning();
            terning[2]=new LudoTerning();
            terning[3]=new Terning();
            foreach (var item in terning)
	{
                item.Skriv();
	}

        }
    }
    public class Terning
    {
        private static System.Random rnd;
        private int værdi;
        public int Værdi
        {
            get { return this.værdi; }
            set {
                if (value < 0 || value > 6)
                    value = 1;
                this.værdi = value; 
                }
        }

        public virtual void Skriv()
        {
            Console.WriteLine("[" + this.Værdi + "]");
        }
        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);
        }
        public Terning()
        {
            this.Ryst();
        }
        public Terning(int værdi)
        {
            this.Værdi = værdi;
        }
        static Terning()
        {
            rnd = new Random();
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
            return this.Værdi == 6;
        }
        public LudoTerning() : base() { }
        public LudoTerning(int værdi) : base(værdi) { }
        public override void Skriv()
        {
            switch (this.Værdi)
            {
                case 3:
                    Console.WriteLine("[S]");
                    break;
                case 5:
                    Console.WriteLine("[6]");
                    break;
                default:
                    base.Skriv();
                    break;
            }
            
        }
    }
}
