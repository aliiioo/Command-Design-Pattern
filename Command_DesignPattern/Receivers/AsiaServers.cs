using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_DesignPattern.Receivers
{
    public class AsiaServers:IReceiver
    {
        public void Connect()
        {
            Console.WriteLine("Asia Server Is Connected");
        }

        public void Disconnect()
        {
            Console.WriteLine("Asia Server Is DisConnected");
        }

        public void ShutDown()
        {
            Console.WriteLine("Asia Server Is ShutDown");
        }

        public void ReBoot()
        {
            Console.WriteLine("Asia Server Is ReBoot");
        }
    }
}
