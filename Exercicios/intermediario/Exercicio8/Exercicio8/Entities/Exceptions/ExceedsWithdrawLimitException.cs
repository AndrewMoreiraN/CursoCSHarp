using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio8.Entities.Exceptions
{
    internal class ExceedsWithdrawLimitException : ApplicationException
    {
        public ExceedsWithdrawLimitException(string message) : base(message)
        {
        }
    }
}