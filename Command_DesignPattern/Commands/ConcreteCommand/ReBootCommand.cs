using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Command_DesignPattern.Receivers;

namespace Command_DesignPattern.Commands.ConcreteCommand
{
    internal class ReBootCommand:Commander
    {
        public ReBootCommand(IReceiver receiver) : base(receiver)
        {
        }

        public override void execute()
        {
            receiver.Connect();
            receiver.ReBoot();
            receiver.Disconnect();
        }
    }
}
