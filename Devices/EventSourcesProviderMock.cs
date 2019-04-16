using Contracts.Events;
using Devices.Actions;
using Devices.Facilities;

namespace Devices
{
    public class EventSourcesProviderMock
    {
        private Chandelier chandelier1;
        private Chandelier lamp1;

        public EventSourcesProviderMock()
        {
            chandelier1 = new Chandelier("Люстра в зале", "Room1.Ceiling.Center");
            lamp1 = new Chandelier("Свет на кухне", "Kitchen.Floor3.Center");
        }

        public IDeviceEvent GenerateEvent_Lamp1_Enable()
        {
            var actionSwitchOn = new ActionSwitchOn(chandelier1);
            var deviceEvent = new DeviceEvent(actionSwitchOn.ToString());
            return deviceEvent;
        }


        public IDeviceEvent GenerateEvent_Lamp1_Disable()
        {
            var actionSwitchOn = new ActionSwitchOff(chandelier1);
            var deviceEvent = new DeviceEvent(actionSwitchOn.ToString());
            return deviceEvent;
        }


        public IDeviceEvent GenerateEvent_Lamp2_Enable()
        {
            var actionSwitchOn = new ActionSwitchOn(lamp1);
            var deviceEvent = new DeviceEvent(actionSwitchOn.ToString());

            return deviceEvent;
        }


        public IDeviceEvent GenerateEvent_Lamp2_Disable()
        {
            var actionSwitchOn = new ActionSwitchOff(lamp1);
            var deviceEvent = new DeviceEvent(actionSwitchOn.ToString());

            return deviceEvent;
        }
    }
}
