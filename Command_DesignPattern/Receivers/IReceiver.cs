using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_DesignPattern.Receivers
{
    public interface IReceiver
    {
        public void Connect();
        public void Disconnect();
        public void ShutDown();
        public void ReBoot(); 
    }
}
