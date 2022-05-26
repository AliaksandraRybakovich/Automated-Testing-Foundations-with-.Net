using System;

namespace Modules.OOP.Exceptions
{
    public class GetAutoByParameterException : Exception
    {
        public GetAutoByParameterException(string message) :
            base(message)
        {
        }
    }
}
