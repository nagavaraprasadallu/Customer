using System;

namespace HDFC.Exceptions
{
    /// <summary>
    /// InsufficientBalanceException
    /// </summary>
    public class InsufficientBalanceException : Exception
    {
        //ctor
        public InsufficientBalanceException(string message) : base(message)
        {
        }
    }
}
