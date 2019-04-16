using System.Collections.Generic;
using Contracts.Events;

namespace BusinessLogic
{
    public interface IScenarioRecorder
    {
        List<IDeviceEventTimer> EventsOnTime { get; }
        bool IsRecording { get; }
        bool StartNewScenario();
        void AddEvent(IDeviceEvent deviceEvent);
        void StopRecording();
        void SaveScenario();
    }
}