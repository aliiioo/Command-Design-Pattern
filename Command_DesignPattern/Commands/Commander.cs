using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command_DesignPattern.Receivers;

namespace Command_DesignPattern.Commands
{
    public abstract class Commander
    {
        protected IReceiver receiver;
        public Commander(IReceiver receiver)
        {
            this.receiver = receiver;
        }

        public abstract void execute();

    }
}
