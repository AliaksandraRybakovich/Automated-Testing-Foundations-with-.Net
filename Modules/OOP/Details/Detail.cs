using System.Xml.Serialization;

namespace Modules.OOP.Details
{
    [XmlInclude(typeof(Engine))]
    [XmlInclude(typeof(Chassis))]
    [XmlInclude(typeof(Transmission))]
    public abstract class Detail
    {
        public NameDetails NameDetails { get; set; }

        public Detail() { }
        public Detail(NameDetails nameDetails)
        {
            NameDetails = nameDetails;
        }
        public override string ToString()
        {
            return NameDetails + ": ";
        }
    }
}
