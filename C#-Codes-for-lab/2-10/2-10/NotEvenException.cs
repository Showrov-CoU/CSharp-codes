using System;
namespace ExceptionHandlingExample
{
    class NotEvenException : Exception
    {
        public NotEvenException(string msg)
            : base(msg)
        {
        }
    }
}