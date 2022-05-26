using Modules.OOP.Details;
using Modules.OOP.Transports;
using System.Collections.Generic;

namespace Modules.OOP
{
    public class GroupedTransport
    {
        public TypeTransmission TransmissionKey { get; set; }
        public List<Transport> Transports { get; set; }
    }
}
