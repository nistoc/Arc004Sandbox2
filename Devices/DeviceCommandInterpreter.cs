using System;
using Contracts;
using Contracts.Events;

namespace Devices
{
    public class DeviceCommandInterpreter : ICommandInterpreter
    {
        public void ExecuteCommand(IDeviceEvent deviceEvent)
        {
            throw new NotImplementedException();
        }
    }
}
