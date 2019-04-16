using Contracts.Events;
using System;

namespace Devices
{
    public class DeviceEvent : IDeviceEvent
    {
        public DeviceEvent(/*string deviceName, */string command)
        {
            //DeviceName = deviceName ?? throw new ArgumentNullException(nameof(deviceName));
            Command = command ?? throw new ArgumentNullException(nameof(command));
        }
        //public string DeviceName { get; }
        public string Command { get; }
    }
}
