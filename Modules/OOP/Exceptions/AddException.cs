using System;

namespace Modules.OOP.Exceptions
{
    public class AddException : Exception
    {
        public AddException(string message) :
            base(message)
        { }
    }
}
