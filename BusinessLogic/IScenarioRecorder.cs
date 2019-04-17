using System.Collections.Generic;
using Contracts.Events;

namespace BusinessLogic
{
    internal interface IScenarioRecorder
    {
        List<IDeviceEventTimer> EventsOnTime { get; }
        bool IsRecording { get; }
        bool StartNewScenario();
        void AddEvent(IDeviceEvent deviceEvent);
        void StopRecording();
    }
}