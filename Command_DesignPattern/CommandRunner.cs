using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command_DesignPattern.Commands;

namespace Command_DesignPattern
{
    public class CommandRunner
    {
        private Commander _commander;

        public CommandRunner(Commander commander)
        {
            _commander = commander;
        }

        public void Run()
        {
            _commander.execute();
        }
    }
}
