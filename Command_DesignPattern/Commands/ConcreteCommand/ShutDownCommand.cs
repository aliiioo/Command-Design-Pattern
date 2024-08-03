using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command_DesignPattern.Receivers;

namespace Command_DesignPattern.Commands.ConcreteCommand
{
    public class ShutDownCommand:Commander
    {
        public ShutDownCommand(IReceiver receiver) : base(receiver)
        {
        }

        public override void execute()
        {
           receiver.Connect();
           receiver.ShutDown();
           receiver.Disconnect();
        }
    }
}
