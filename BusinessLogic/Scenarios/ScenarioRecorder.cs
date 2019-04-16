using System;
using System.Collections.Generic;
using Contracts.Events;
using Domains.Models;

namespace BusinessLogic.Scenarios
{
    internal class ScenarioRecorder : IScenarioRecorder
    {
        public List<IDeviceEventTimer> EventsOnTime { get; private set; } = new List<IDeviceEventTimer>();
        private DateTime TimeMarker;
        public bool IsRecording { get; private set; }

        public bool StartNewScenario()
        {
            if (IsRecording) return false;

            TimeMarker = DateTime.Now;
            IsRecording = true;

            return IsRecording;
        }

        public void AddEvent(IDeviceEvent deviceEvent)
        {
            if (!IsRecording)
                return;

            var currentTime = DateTime.Now;
            EventsOnTime.Add(new DeviceEventTimer
            {
                ExecutingEvent = deviceEvent,
                TimerSpanBeforeStart = currentTime - TimeMarker
            });

            TimeMarker = currentTime;
        }

        public void StopRecording()
        {
            IsRecording = false;
            throw new NotImplementedException();
        }

        public void SaveScenario()
        {
            throw new NotImplementedException();
        }
    }
}
