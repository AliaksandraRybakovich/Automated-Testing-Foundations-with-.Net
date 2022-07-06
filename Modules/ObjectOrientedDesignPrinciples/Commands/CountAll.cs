﻿using System.Collections.Generic;

namespace Modules.ObjectOrientedDesignPrinciples.Commands
{
    public class CountAll : ICommand
    {
        private Receiver _receiver;

        public CountAll()
        {
            this._receiver = new Receiver();
        }
        public void Execute(List<Car> cars)
        {
            _receiver.CountAll(cars);
        }
    }
}
