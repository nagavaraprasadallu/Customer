using HDFC.Exceptions;

namespace HDFC
{
    /// <summary>
    /// Saving account
    /// </summary>
    public class SavingAccount : Account
    {
        //ctor
        public SavingAccount(int balance, string userName) : base(balance, userName)
        {

        }

        //destructor
        ~SavingAccount()
        {

        }

        /// <summary>
        /// Minimum balance required
        /// </summary>
        public int MinBalanceRequired { get; set; }

        /// <summary>
        /// Get Account Details
        /// </summary>
        public AccountDetails GetAccountDetails()
        {
            return new AccountDetails
            {
                AccountNumber = AccountNumber,
                AvailableBalance = Balance,
                UserName = UserName
            };
        }

        /// <summary>
        /// Open new account
        /// </summary>
        /// <param name="balance"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        public override Account OpenAccount(int balance, string userName)
        {
            var account = new SavingAccount(balance, userName);
            return account;
        }

        /// <summary>
        /// Withdraw given amount from account
        /// </summary>
        /// <param name="withdrawalAmount"></param>
        public override void Withdrawal(int withdrawalAmount)
        {
            if (withdrawalAmount > Balance)
            {
                throw new InsufficientBalanceException($"Insufficient balance in your account. Your balanace is {Balance}");
            }
            if ((Balance - withdrawalAmount) > MinBalanceRequired)
            {
                throw new MinBalanceException("Withdrawal leads to Min balance requirement failure");
            }
            Balance -= withdrawalAmount;
        }
    }
}
