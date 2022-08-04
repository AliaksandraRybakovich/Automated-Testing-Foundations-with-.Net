using System.Collections.Generic;

namespace Modules.ObjectOrientedDesignPrinciples.Commands
{
    public class Exit : ICommand
    {
        private Receiver _receiver;

        public Exit()
        {
            this._receiver = Receiver.GetInstance();
        }

        public void Execute(List<Car> cars)
        {
            _receiver.Exit();
        }
    }
}
