using System.Collections.Generic;

namespace Modules.ObjectOrientedDesignPrinciples.Commands
{
    public class AveragePriceType : ICommand
    {
        private Receiver _receiver;

        public AveragePriceType()
        {
            this._receiver = new Receiver();
        }
        public void Execute(List<Car> cars)
        {
            _receiver.AveragePriceType(cars);
        }
    }
}
