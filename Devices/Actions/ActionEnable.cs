using Devices.Actions.Base;
using Devices.Facilities.Base;

namespace Devices.Actions
{
    public class ActionEnable : DeviceActionBase
    {

        public ActionEnable(FacilityBase facilityBase) : base(facilityBase)
        {
        }


        public override string Name => "Enable";

    }
}
