using Modules.OOP.Details;
using System;
using System.Xml.Serialization;

namespace Modules.OOP.Transports
{
    [XmlInclude(typeof(Car))]
    [XmlInclude(typeof(Scooter))]
    [XmlInclude(typeof(Bus))]
    [XmlInclude(typeof(Truck))]
    public abstract class Transport
    {
        public string NameTransport { get; set; }
        public Engine Engine { get; set; }
        public Chassis Chassis { get; set; }
        public Transmission Transmission { get; set; }

        public Transport() { }
        public Transport(string nameTransport, Engine engine, Chassis chassis, Transmission transmission)
        {
            NameTransport = nameTransport;
            Engine = engine;
            Chassis = chassis;
            Transmission = transmission;
        }
        public override string ToString()
        {
            return NameTransport + Environment.NewLine +
                Engine.ToString() + Environment.NewLine +
                Chassis.ToString() + Environment.NewLine +
                Transmission.ToString() + Environment.NewLine;
        }
    }
}
