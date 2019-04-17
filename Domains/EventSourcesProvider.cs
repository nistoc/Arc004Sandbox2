using Contracts;
using Contracts.Events;

namespace Domains
{

    public class EventSourcesProvider : IEventSourcesProvider
    {

        /// <summary>
        /// Событие, возникающее при выводе денег
        /// </summary>
        public event DeviceEventHappened EventHappened;

        public void RegisterEvent(IDeviceEvent deviceEventHappened)
        {
            EventHappened?.Invoke(deviceEventHappened);
        }

    }
}
