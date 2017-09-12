using System;

namespace Terning1
{
    class Terning
    {
        public int værdi;
        private bool snyd;

        private static System.Random rnd = new Random();

        public Terning()
        {
            this.værdi = 1;
            this.snyd = false;
        }
        public Terning(bool snyd)
        {
            this.værdi = 1;
            this.snyd = snyd;
        }
        public void Skriv()
        {
            Console.Write("[" + this.værdi + "] ");
        }
        public void Ryst()
        {
            if (this.snyd)
                this.værdi = 6;
            else
                this.værdi = rnd.Next(1, 7);
        }
    }
}
