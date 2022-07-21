using System.Collections.Generic;

namespace Modules.ObjectOrientedDesignPrinciples.Commands
{
    public class AveragePrice : ICommand
    {
        private Receiver _receiver;

        public AveragePrice()
        {
            this._receiver = Receiver.GetInstance();
        } 

        public void Execute(List<Car> cars)
        {
            _receiver.AveragePrice(cars);
        }
    }
}
