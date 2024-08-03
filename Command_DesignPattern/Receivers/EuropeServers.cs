using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_DesignPattern.Receivers
{
    public class EuropeServers:IReceiver
    {
        public void Connect()
        {
            Console.WriteLine("Europe Server Is Connected");
        }

        public void Disconnect()
        {
            Console.WriteLine("Europe Server Is DisConnected");
        }

        public void ShutDown()
        {
            Console.WriteLine("Europe Server Is ShutDown");
        }

        public void ReBoot()
        {
            Console.WriteLine("Europe Server Is ReBoot");
        }
    }
}
