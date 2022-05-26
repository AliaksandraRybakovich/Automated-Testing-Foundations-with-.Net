using System;

namespace Modules.OOP.Exceptions
{
    public class UpdateAutoException : Exception
    {
        public UpdateAutoException(string message)
            : base(message)
        {
        }
    }
}
