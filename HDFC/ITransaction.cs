namespace HDFC
{
    /// <summary>
    /// ITransaction
    /// </summary>
    public interface ITransaction
    {
        /// <summary>
        /// From Account
        /// </summary>
        int FromAccount { get; set; }

        /// <summary>
        /// To Account
        /// </summary>
        int ToAccount { get; set; }

        /// <summary>
        /// Transfer amount
        /// </summary>
        /// <param name="fromAccount"></param>
        /// <param name="toAccount"></param>
        /// <param name="transferAccount"></param>
        void TransferAmount(int transferAccount);
    }
}
