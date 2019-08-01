using HDFC.Exceptions;
using System;

namespace HDFC
{
    /// <summary>
    /// Current Account
    /// </summary>
    public class CurrentAccount : Account
    {
        /// <summary>
        /// ctor
        /// </summary>
        public CurrentAccount()
        {

        }

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="balance"></param>
        /// <param name="userName"></param>
        public CurrentAccount(int balance, string userName) : base(balance, userName)
        {

        }

        /// <summary>
        /// destructor
        /// </summary>
        ~CurrentAccount()
        {

        }

        private DateTime _lastTransactionDate;
        private int _totalTranPerDay;

        /// <summary>
        /// Maximum withdrawal amount
        /// </summary>
        public int MaxAmountPerDay { get; set; }

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
            var account = new CurrentAccount(balance, userName);
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

            if (_lastTransactionDate < DateTime.Now.Date)
            {
                //last transaction was done yesterday. Reset total transaction done for the day to zero
                _totalTranPerDay = 0;
            }

            if (_totalTranPerDay + withdrawalAmount > MaxAmountPerDay)
            {
                throw new MaxAmountPerDayException("This transaction exceeds your maximum transaction permitted per day.");
            }

            _lastTransactionDate = DateTime.Now.Date;
            _totalTranPerDay += withdrawalAmount;
            Balance -= withdrawalAmount;
        }
    }
}
