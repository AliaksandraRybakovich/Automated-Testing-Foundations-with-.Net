using Modules.OOP.Details;
using System;

namespace Modules.OOP.Transports
{
    class Truck : Transport
    {
        public double LoadCapacity { get; set; }

        public Truck(double loadCapacity, string nameTransport, Engine engine, Chassis chassis, Transmission transmission)
            : base(nameTransport, engine, chassis, transmission)
        {
            if (chassis.AmountWheels != 4)
            {
                throw new Exception("У Грузовика 4 колеса");
            }
            LoadCapacity = loadCapacity;
        }
        public override string ToString()
        {
            return base.ToString() +
                "Грузоподъёмность: " + LoadCapacity;
        }
    }
}
