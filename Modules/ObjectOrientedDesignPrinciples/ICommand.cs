using System.Collections.Generic;

namespace Modules.ObjectOrientedDesignPrinciples
{
    public interface ICommand
    {
        void Execute(List<Car> cars);
    }
}
