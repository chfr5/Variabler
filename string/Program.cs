using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Mikkel";
            string efternavn = "Cronberg";

            string samletNavn = (fornavn + " " + efternavn);
            string navnStort = samletNavn.ToUpper();

            string navnLille = samletNavn.ToLower();

            string del;
            del = samletNavn.Substring(7, 4);

            string[] n = samletNavn.Split(' ');
            foreach (var item in n)
            {
                Console.WriteLine(item);

                
            }
            System.IO.File.WriteAllText("c:\\temp\\test.txt", samletNavn);
            Console.ReadKey();
        }
    }
}
