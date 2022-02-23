namespace Modules.OOP.Details
{
    public abstract class Detail
    {
        public NameDetails NameDetails { get; set; }

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
