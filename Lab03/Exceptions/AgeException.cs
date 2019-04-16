using System;

namespace Lab03.Exceptions
{
    class AgeException : Exception
    {
        public override string Message => "Wrong age";
    }
}