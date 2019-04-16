using Contracts.Events;

namespace Contracts
{
    public interface IEventSubscriber
    {
        void AcceptNewEvent(IDeviceEvent deviceEvent);
    }
}