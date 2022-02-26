using System;

namespace Modules.Interfaces_and_abstract_classes
{
    internal class Airplane : FlyTransport,IFlyable
    {
        private double startSpeed = 200;
        public Airplane(FlyTransports name, Coordinates currentPosition) : base(name, currentPosition) { }
        public double GetFlyTime(Coordinates destinationPoint)
        {
            var distance = base.GetDistanceTo(destinationPoint);

            //самолет увеличивает скорость на 10 км/ч каждые 10 км полета от начальной скорости 200 км/ч            
            double resultTime = 0;
            for (int i = 0; i < distance / 10; i++)
            {
                resultTime += 10 / startSpeed;
                startSpeed += 10;              
            }

            //каждые 1000 км заправка на 15 минут
            int amountPause = (int)(distance / 1000);
            double flyTime = resultTime*60 + amountPause * 15;

            return flyTime;
        }
        public string FlyTo(Coordinates point)
        {
            return $"Самолёт летит к координатам {point.X} {point.Y} {point.Z}";
        }
    }
}
