using Modules.OOP.Details;
using Modules.OOP.Exceptions;

namespace Modules.OOP.Transports
{
    public class Bus : Transport
    {
        public int NumberRoute { get; set; }

        public Bus() { }
        public Bus(int numberRoute, string nameTransport, Engine engine, Chassis chassis, Transmission transmission)
            : base(nameTransport, engine, chassis, transmission)
        {
            if (chassis.AmountWheels != 4)
            {
                throw new InitializationException("У Автобуса 4 колеса");
            }
            NumberRoute = numberRoute;
        }
        public override string ToString()
        {
            return base.ToString() +
                "Номер маршрута: " + NumberRoute;
        }
    }
}
