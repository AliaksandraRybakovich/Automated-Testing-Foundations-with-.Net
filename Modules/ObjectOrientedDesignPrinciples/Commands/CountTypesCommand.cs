using System.Collections.Generic;

namespace Modules.ObjectOrientedDesignPrinciples.Commands
{
    public class CountTypesCommand : ICommand
    {
        private Receiver _receiver;

        public CountTypesCommand()
        {
            this._receiver = Receiver.GetInstance();
        } 

        public void Execute(List<Car> cars)
        {
            _receiver.CountTypes(cars);
        }
    }
}
