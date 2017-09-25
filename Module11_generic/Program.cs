using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module11_generic
{
    class Program
    {
        static void Main(string[] args)
        {
            string ip = "";
            ip = System.Configuration.ConfigurationManager.AppSettings["ip"];

            ip = GetAppSetting("ip", "123");
            int MaxRcd = GetAppSettingGen("maxRecords", 12);

        }
        static string GetAppSetting(string nøgle, string ellersVærdi)
        {
            string x = System.Configuration.ConfigurationManager.AppSettings[nøgle];
            if (x == null)
                return ellersVærdi;
            return x; 
        }
        static T GetAppSettingGen<T>(string nøgle, T ellersVærdi)
        {
            string x = System.Configuration.ConfigurationManager.AppSettings[nøgle];
            if (x == null)
                return ellersVærdi;
            return (T)Convert.ChangeType(x, typeof(T));
        }
    }
}
