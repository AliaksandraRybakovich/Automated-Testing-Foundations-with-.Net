using System;

namespace Modules.OOP.Details
{
    public class Engine : Detail
    {
        public int Power { get; set; }
        public double Volume { get; set; }
        public TypeEngine Type { get; set; }
        public string SerialNumber { get; set; }

        public Engine(int power, double volume, TypeEngine type, string serialNumber, NameDetails nameEngine)
            : base(nameEngine)
        {
            Power = power;
            Volume = volume;
            Type = type;
            SerialNumber = serialNumber;
        }
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine +
                "Мощность - " + Power + "л.с." + Environment.NewLine +
                 "Объём - " + Volume + Environment.NewLine +
                 "Тип - " + Type + Environment.NewLine +
                 "Серийный номер - " + SerialNumber + Environment.NewLine;
        }
    }
}
