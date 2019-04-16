using Devices.Actions.Base;
using Devices.Facilities.Base;

namespace Devices.Actions
{
    public class ActionClose : DeviceActionBase
    {

        public ActionClose(FacilityBase facilityBase) : base(facilityBase)
        {
        }


        public override string Name { get; } = "Close";
    }
}
