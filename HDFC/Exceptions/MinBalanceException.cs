using System;

namespace HDFC.Exceptions
{
    /// <summary>
    /// MinBalanceException
    /// </summary>
    public class MinBalanceException : Exception
    {
        //ctor
        public MinBalanceException(string message) : base(message)
        {
        }
    }
}
