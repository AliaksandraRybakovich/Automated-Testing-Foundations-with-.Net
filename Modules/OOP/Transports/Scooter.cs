using Modules.OOP.Details;
using System;

namespace Modules.OOP.Transports
{
    public class Scooter : Transport
    {
        public double MaxSpeed { get; set; }

        public Scooter() { }
        public Scooter(double maxSpeed, string nameTransport, Engine engine, Chassis chassis, Transmission transmission)
            : base(nameTransport, engine, chassis, transmission)
        {
            if (chassis.AmountWheels != 2)
            {
                throw new Exception("У Скутера 2 колеса");
            }
            MaxSpeed = maxSpeed;
        }
        public override string ToString()
        {
            return base.ToString() +
                 "Максимальная скорость: " + MaxSpeed;
        }
    }
}
