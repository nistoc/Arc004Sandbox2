using System;
using System.Collections.Generic;
using System.Text;
using Contracts.Events;

namespace Contracts
{
    public class EventSourcesProvider
    {
        /// <summary>
        /// Объявляем делегат
        /// </summary>
        /// <returns></returns>
        public delegate void DeviceEventHappened(IDeviceEvent deviceEvent);

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
