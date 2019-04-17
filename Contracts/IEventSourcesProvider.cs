using Contracts.Events;

namespace Contracts
{

    /// <summary>
    /// Объявляем делегат
    /// </summary>
    /// <returns></returns>
    public delegate void DeviceEventHappened(IDeviceEvent deviceEvent);

    public interface IEventSourcesProvider
    {
        event DeviceEventHappened EventHappened;
        void RegisterEvent(IDeviceEvent deviceEventHappened);
    }
}
