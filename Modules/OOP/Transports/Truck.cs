using Modules.OOP.Details;
using Modules.OOP.Exceptions;

namespace Modules.OOP.Transports
{
    public class Truck : Transport
    {
        public double LoadCapacity { get; set; }

        public Truck() { }
        public Truck(double loadCapacity, string nameTransport, Engine engine, Chassis chassis, Transmission transmission)
            : base(nameTransport, engine, chassis, transmission)
        {
            if (chassis.AmountWheels != 4)
            {
                throw new InitializationException("У Грузовика 4 колеса");
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
