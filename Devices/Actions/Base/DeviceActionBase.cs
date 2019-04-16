using System;
using System.Collections.Generic;
using System.Text;
using Devices.Facilities.Base;

namespace Devices.Actions.Base
{
    public abstract class DeviceActionBase
    {

        private readonly FacilityBase _facilityBase;

        internal DeviceActionBase(FacilityBase facilityBase)
        {
            _facilityBase = facilityBase;
        }

        public abstract string Name { get; }


        public override string ToString()
        {
            return $"{Name}-{_facilityBase.Name}-{_facilityBase.Address}";
        }
    }
}
