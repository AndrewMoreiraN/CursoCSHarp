using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio8.Entities.Exceptions
{
    internal class NotEnoughBalanceException : ApplicationException
    {
        public NotEnoughBalanceException(string message) : base(message)
        {
        }
    }
}