// See https://aka.ms/new-console-template for more information

using Command_DesignPattern;
using Command_DesignPattern.Commands;
using Command_DesignPattern.Commands.ConcreteCommand;
using Command_DesignPattern.Receivers;

IReceiver receiver = new EuropeServers();
Commander shutdown=new ReBootCommand(receiver);
CommandRunner Invoker = new CommandRunner(shutdown);
Invoker.Run();

