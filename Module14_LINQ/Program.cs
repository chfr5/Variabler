using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module14_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new PersonNuGetPackage.PersonRepositoryRandom();
            var p = r.GetPeople(20);
            foreach (var person in p)
            {
                Console.WriteLine(person.Name);
            }
            Console.WriteLine(" ------------------ ");
            var p1 = p.OrderBy(i => i.Name);
            foreach (var person in p1)
            {
                Console.WriteLine(person.Name);
            }
            Console.WriteLine(" ------------------ ");
            var p2 = p.Where(i => i.Height < 175);
            foreach (var person in p2)
            {
                Console.WriteLine("Navn {0} højde {1}", person.Name, person.Height );
            }
            Console.WriteLine(" ------------------ ");
            var p3 = p.OrderBy(i => i.Gender ).ThenBy(i=>i.Name);
            foreach (var person in p3)
            {
                Console.WriteLine("Navn {0} køn {1}", person.Name, person.Gender);
            }
            Console.WriteLine(" ------------------ ");
            var p4 = p.Where(i => i.Height < 170 && i.IsHealthy);
            foreach (var person in p4)
            {
                Console.WriteLine("Navn {0} køn {1}", person.Name, person.Gender);
            }
            Console.WriteLine(" ------------------ ");
            int[] range = { 160, 170, 180, 190, 200, 210, 220 };

            var p5 = p.OrderBy(i => i.Height).GroupBy(i=> range.FirstOrDefault(x=>x>i.Height));
            foreach (var grp in p5)
            {
                Console.WriteLine(grp.Key);
                foreach (var person in grp)
                {
                    Console.WriteLine(" => navn {0} højde {1}", person.Name, person.Height);
                }
            }

        }
    }
}
