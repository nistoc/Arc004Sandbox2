using Devices.Actions.Base;
using Devices.Facilities.Base;

namespace Devices.Actions
{
    public class ActionSwitchOn : DeviceActionBase
    {

        public ActionSwitchOn(FacilityBase facilityBase) : base(facilityBase)
        {
        }


        public override string Name { get; } = "SwitchOn";
    }
}
