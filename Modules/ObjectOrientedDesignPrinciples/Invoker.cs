using Modules.ObjectOrientedDesignPrinciples.Commands;
using System.Collections.Generic;

namespace Modules.ObjectOrientedDesignPrinciples
{
    public class Invoker
    {
        ICommand command;
        public List<Car> _cars;
        public Invoker() { }

        public void SetCommand(int userCommand)
        {
            switch (userCommand)
            {
                case 0:
                    command = new CountTypesCommand();
                    break;
                case 1:
                    command = new CountAll();
                    break;
                case 2:
                    command = new AveragePrice();
                    break;
                case 3:
                    command = new AveragePriceType();
                    break;
                case 4:
                    command = new Exit();
                    break;
            }
        }
        public void SetCar(List<Car> cars)
        {
            _cars = cars;
        }
        public void Do()
        {
            command.Execute(_cars);
        }
    }
}
