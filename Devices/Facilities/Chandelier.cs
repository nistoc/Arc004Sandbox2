using Devices.Facilities.Base;

namespace Devices.Facilities
{
    public class Chandelier : FacilityBase
    {
        public Chandelier(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public override string Name { get; }

        public override string Address { get; }
    }
}
