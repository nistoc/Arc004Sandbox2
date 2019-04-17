using BusinessLogic.Scenarios;
using Contracts;
using Contracts.Events;
using System.Collections.Generic;

namespace BusinessLogic
{
    public class EventRecorder : IEventRecorderStarter, IEventRecorderStopper
    {
        private readonly EventSourcesProvider _eventSources;
        private IScenarioRecorder scenarioRecorder;

        internal EventRecorder(EventSourcesProvider eventSources)
        {
            _eventSources = eventSources;
        }

        public IEventRecorderStopper StartRecording()
        {
            scenarioRecorder = scenarioRecorder ?? new ConcreteScenarioRecorder();

            if (!scenarioRecorder.IsRecording)
            {
                scenarioRecorder.StartNewScenario();
                _eventSources.EventHappened += _eventSources_EventHappened;
            }

            return this;
        }

        private void _eventSources_EventHappened(Contracts.Events.IDeviceEvent deviceEvent)
        {
            scenarioRecorder.AddEvent(deviceEvent);
        }

        public List<IDeviceEventTimer> StopRecording()
        {
            _eventSources.EventHappened -= _eventSources_EventHappened;
            scenarioRecorder.StopRecording();

            return scenarioRecorder.EventsOnTime;
        }

    }
}
