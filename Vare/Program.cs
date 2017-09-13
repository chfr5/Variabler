using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vare
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare v = new Vare();
            v.Navn = "vare #1";
            v.Pris = 100;
            Console.WriteLine("Vare: " + v.Navn + " koster " + v.PrisMedMoms() + "kr inkl moms");
            Vare v2 = new Vare("vare #2", 200);
            Console.WriteLine(v2.PrisMedMoms());
        }
    }
    public class Vare
    {
        public Vare()
        {

        }
        public Vare(string navn, double pris)
        {
            this.Navn = navn;
            this.Pris = pris;
        }
        private string navn;

        public string Navn
        {
            get {
                Console.WriteLine("Nu aflæses navn:" + navn);
                return navn; }
            set {
                Console.WriteLine("Nu sættes navn:" + value);
                navn = value; }
        }
        private double pris;

        public double Pris
        {
            get {
                Console.WriteLine("Nu aflæses pris:" );
                return pris; }
            set {
                Console.WriteLine("Nu tildeles pris: " + value + " til: " + navn);
                pris = value; }
        }

        public double PrisMedMoms()
        {
            return this.pris * 1.25;
        }
    }
}
