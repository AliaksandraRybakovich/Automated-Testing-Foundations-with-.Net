using Modules.OOP.Details;
using Modules.OOP.Exceptions;

namespace Modules.OOP.Transports
{
    public class Car : Transport
    {
        public double Speed10Seconds { get; set; }

        public Car() { }
        public Car(double speed10Seconds, string nameTransport, Engine engine, Chassis chassis, Transmission transmission)
            : base(nameTransport, engine, chassis, transmission)
        {
            if (chassis.AmountWheels != 4)
            {
                throw new InitializationException("У Легкового автомобиля 4 колеса");
            }
            Speed10Seconds = speed10Seconds;
        }
        public override string ToString()
        {
            return base.ToString() +
                "Скорость за 10 секунд после старта: " + Speed10Seconds;
        }
    }
}
