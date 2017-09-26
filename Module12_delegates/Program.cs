using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12_delegates
{
    class Program
    {
        
        static void Main(string[] args)
        {
            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            w.EnableRaisingEvents = true;
            w.NotifyFilter = System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.Size;
            w.Changed += W_Changed;
            do
            {

            } while (true);


            return;
            Maskine M = new Maskine();
            M.Log = Console.WriteLine;
            //M.Log += AppendLog;
            M.Log += (txt) => { System.IO.File.AppendAllText(@"c:\temp\log12.txt", txt + "\r\n"); };
            M.Start();
            M.Stop();
        }

        private static void W_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine(e.Name);
        }

        static void AppendLog(string txt)
        {
            System.IO.File.AppendAllText(@"c:\temp\log12.txt", txt + "\r\n");
        }
    }
    public class Maskine
    {
        public Action<string> Log { get; set; }
                
        public void Start()
        {
            if (Log!=null)
            Log(DateTime.Now.ToShortTimeString() + " starter !!");
            //Console.WriteLine(DateTime.Now.ToShortTimeString() + " starter !!");
        }
        public void Stop()
        {
            if (Log != null)
                Log(DateTime.Now.ToShortTimeString() + " stopper !!");
            //Console.WriteLine(DateTime.Now.ToLongTimeString() + " stopper !! ");
        }
    }
}
