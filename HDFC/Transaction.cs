namespace HDFC
{
    /// <summary>
    /// Transaction
    /// </summary>
    public class Transaction : ITransaction
    {
        /// <summary>
        /// From Account
        /// </summary>
        public int FromAccount { get; set; }

        /// <summary>
        /// To Account
        /// </summary>
        public int ToAccount { get; set; }

        /// <summary>
        /// Transfer amount
        /// </summary>
        /// <param name="fromAccount"></param>
        /// <param name="toAccount"></param>
        /// <param name="transferAccount"></param>
        public void TransferAmount(int transferAccount)
        {
            var fromAccount = Account.GetAccount(FromAccount);
            var toAccount = Account.GetAccount(ToAccount);
            fromAccount.Withdrawal(transferAccount);
            toAccount.Deposit(transferAccount);
        }
    }
}
