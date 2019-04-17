using Domains;

namespace BusinessLogic
{
    public class EventRecorderFabrika
    {
        private readonly EventSourcesProvider _eventSources;

        public EventRecorderFabrika(EventSourcesProvider eventSources)
        {
            _eventSources = eventSources;
        }

        public EventRecorder GetRecorder()
        {
            var eventRecorder = new EventRecorder(_eventSources);
            return eventRecorder;
        }
    }
}
