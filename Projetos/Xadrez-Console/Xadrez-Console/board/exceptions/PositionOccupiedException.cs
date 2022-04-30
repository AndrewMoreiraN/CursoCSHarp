using System;

namespace exceptions
{
    internal class PositionOccupiedException : ApplicationException
    {
        public PositionOccupiedException(string message) : base(message)
        {
        }
    }
}