using System;

namespace exceptions
{
    internal class OutOfBoardException : ApplicationException
    {
        public OutOfBoardException(string message) : base(message)
        {
        }
    }
}