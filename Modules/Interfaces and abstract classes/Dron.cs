using System;

namespace Modules.Interfaces_and_abstract_classes
{
    internal class Dron : FlyTransport, IFlyable
    {
        private double speed = 20;
        public Dron(FlyTransports name, Coordinates currentPosition) : base(name, currentPosition) { }
        public double GetFlyTime(Coordinates destinationPoint)
        {
            var distance = base.GetDistanceTo(destinationPoint);

            //дальность полёта дрона 1000 км
            if (distance > 1000)
            {
                throw new Exception("Дрон не пролетит больше 1000 км!");
            }

            //дрон зависает в воздухе каждые 10 минут полета на 1 минуту
            int amountPause = (int)((distance / speed) * 60 / 10);
            double flyTime = (distance / speed) * 60 + amountPause * 1;
            return flyTime;
        }
        public string FlyTo(Coordinates point)
        {
            return $"Дрон летит к координатам {point.X} {point.Y} {point.Z}";
        }
    }
}
