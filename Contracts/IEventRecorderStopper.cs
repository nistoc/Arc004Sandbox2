using System.Collections.Generic;
using Contracts.Events;

namespace Contracts
{
    public interface IEventRecorderStopper
    {
        List<IDeviceEventTimer> StopRecording();
    }
}