using System;

namespace Modules.OOP.Exceptions
{
    public class InitializationException : Exception
    {
        public InitializationException(string message) :
            base(message)
        {
        }
    }
}
