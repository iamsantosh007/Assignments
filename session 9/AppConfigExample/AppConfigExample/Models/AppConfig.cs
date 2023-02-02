using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConfigExample.Models
{
    public class AppConfig
    {
        public void ConnectionTwo()
        {
            string connectionTwo = ConfigurationSettings.AppSettings["connection2"];
            string serverName = connectionTwo.Split(';')[0];
            Console.WriteLine(serverName);
            string dataBaseName = connectionTwo.Split(';')[1];
            Console.WriteLine(dataBaseName);
        }

        public void ConnectionOne()
        {
            string connectionOne = ConfigurationSettings.AppSettings["connection1"];
            string serverName = connectionOne.Split(';')[0];
            Console.WriteLine(serverName);

            string dataBaseName = connectionOne.Split(';')[1];
            Console.WriteLine(dataBaseName);
        }
    }
}
