using Devices.Actions.Base;
using Devices.Facilities.Base;

namespace Devices.Actions
{
    public class ActionSwitchOff : DeviceActionBase
    {

        public ActionSwitchOff(FacilityBase facilityBase) : base(facilityBase)
        {
        }


        public override string Name { get; } = "SwitchOff";
    }
}
