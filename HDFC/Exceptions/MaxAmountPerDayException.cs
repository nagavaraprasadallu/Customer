using System;

namespace HDFC.Exceptions
{
    /// <summary>
    /// MaxAmountPerDayException
    /// </summary>
    public class MaxAmountPerDayException : Exception
    {
        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="message"></param>
        public MaxAmountPerDayException(string message) : base(message)
        {
        }
    }
}
