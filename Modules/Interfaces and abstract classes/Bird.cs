using System;

namespace Modules.Interfaces_and_abstract_classes
{
    internal class Bird : FlyTransport, IFlyable 
    {
        public double speed;
        public Bird(FlyTransports name, Coordinates currentPosition) : base(name, currentPosition) { }

        public double GetFlyTime(Coordinates destinationPoint)
        {
            var distance = base.GetDistanceTo(destinationPoint);

            //птица летит все расстояние с постоянной скоростью в диапазоне 0-20 км/ч (заданной случайно)
            Random random = new Random();
            speed = random.Next(0, 20);

            //каждые 700 метров птица садиться отдыхать на 5 минут
            int amountPause = (int)(distance / 0.7);
            double flyTime = (distance / speed) * 60 + amountPause * 5;

            return flyTime;
        }
        public string FlyTo(Coordinates point)
        {
            return $"Птица летит к координатам {point.X} {point.Y} {point.Z}";
        }
    }
}
