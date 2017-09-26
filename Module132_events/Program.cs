using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module132_events
{
    class Program
    {
        static void Main(string[] args)
        {
            Kunde k = new Kunde() { Navn = "M", KreditMax = 500, Saldo = 120 };
            k.OverKreditMax += (s, e) => { Console.WriteLine("Kredit overskredet !!!"); };
            k.Køb(200);
            k.Køb(300);
            string r = "søren";
            Console.WriteLine(r.FormatNavn());
        }

    }
    public static class MyString
    {
        public static string FormatNavn(this string navn)
        {
            if (navn!=null && navn != "")
            {
                string res = navn.Substring(0, 1).ToUpper() + navn.Substring(1);
                return res;
            }
            return navn;
        }
    }
    public class Kunde
    {
        // event
        public event EventHandler OverKreditMax;
        public string Navn { get; set; }
        public int Saldo { get; set; }
        public int KreditMax { get; set; }
        public  void Køb(int værdi)
        {
            Console.WriteLine("Kunde {0} køber for {1}", Navn,værdi);
            this.Saldo += værdi;
            if(Saldo > KreditMax)
            {
                // kald til event
                if (OverKreditMax != null)
                    OverKreditMax(this, new EventArgs());
            }
        }
    }
}
