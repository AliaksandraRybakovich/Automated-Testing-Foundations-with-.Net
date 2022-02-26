using System;

namespace Modules.Interfaces_and_abstract_classes
{
    internal abstract class FlyTransport
    {
        public FlyTransports Name { get; set; }
        public Coordinates CurrentPosition { get; set; }
        public FlyTransport(FlyTransports name, Coordinates currentPosition)
        {
            Name = name;
            CurrentPosition = currentPosition;
        }

        public double GetDistanceTo(Coordinates destinationPoint)
        {
            return Math.Sqrt(Math.Pow((destinationPoint.X - CurrentPosition.X), 2)
                + Math.Pow((destinationPoint.Y - CurrentPosition.Y), 2)
                + Math.Pow((destinationPoint.Z - CurrentPosition.Z), 2));
        }
    }
}
