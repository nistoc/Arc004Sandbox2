using System;
using Contracts.Events;

namespace Domains.Models
{
    public class DeviceEventTimer: IDeviceEventTimer
    {
        public DeviceEventTimer()
        {
            
        }

        public TimeSpan TimerSpanBeforeStart { get; set; }
        public IDeviceEvent ExecutingEvent { get; set; }
    }
}
