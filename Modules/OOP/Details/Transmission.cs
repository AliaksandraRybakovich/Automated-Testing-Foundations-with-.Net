using System;

namespace Modules.OOP.Details
{
    public class Transmission : Detail
    {
        
        public TypeTransmission Type { get; set; }
        public int AmountGears { get; set; }
        public string Manufacture { get; set; }

        public Transmission(TypeTransmission type, int amountGears, string manufacture, NameDetails nameTransmission)
            : base(nameTransmission)
        {
            Type = type;
            AmountGears = amountGears;
            Manufacture = manufacture;
        }
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine +
            "Тип - " + Type + Environment.NewLine +
            "Количество передач - " + AmountGears + Environment.NewLine +
            "Производитель - " + Manufacture + Environment.NewLine;
    }
}
}
