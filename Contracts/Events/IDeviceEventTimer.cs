using System;

namespace Contracts.Events
{
    public interface IDeviceEventTimer
    {
        TimeSpan TimerSpanBeforeStart { get; }
        IDeviceEvent ExecutingEvent { get; }
    }
}
