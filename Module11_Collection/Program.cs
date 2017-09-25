using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module11_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Bunke b = new Bunke();
            return;
            List<Person> list = new List<Module11_Collection.Person>();
            list.Add(new Person() { Id = 10, Navn = "Christian" });
            list.Add(new Person() { Id = 20, Navn = "Kirstine" });
            foreach (var item in list)
            {
                Console.WriteLine(item.Navn);
            }
            Dictionary<int, Person> list2 = new Dictionary<int, Person>();
            list2.Add(10, new Person() { Id = 10, Navn = "Christian" });
            list2.Add(20, new Person() { Id = 20, Navn = "Kirstine" });
            list2.Add(30, new Person() { Id = 21, Navn = "Carohline" });
            var count = list2.Count;
            Console.WriteLine("antal "+ count );
            var l = list2[10];
            Console.WriteLine(l.Navn);
            return;
            minetyper<int> i = new minetyper<int>();
        }
    }
    public class Kort
    {
        public string Kulør { get; set; }
        public int Værdi { get; set; }
        public override string ToString()
        {
            //return base.ToString();
            return this.Kulør + " " + this.Værdi;
        }
    }
    /// <summary>
    /// dette er en Person
    /// </summary>
    /// <typeparam name="t"></typeparam>
    class Person
    {   
        /// <summary>
        /// Id er nøgle
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Navn består af for og efternavn
        /// </summary>
        public string Navn { get; set; }
    }
    class minetyper<T>
    {
        T temp;


        public static void Swap<T>(ref T a, ref T b)
        {
            T tpm = a;
            a = b;
            b = tmp;
        }
    }
}
