using System;
using Contracts;
using static System.Console;

namespace Devices
{
    public class DeviceCommandInterpreter : ICommandInterpreter
    {
        public void ExecuteCommand(string command)
        {
            WriteLine($"{DateTime.Now.ToLongTimeString()} {command}");
        }
    }
}
