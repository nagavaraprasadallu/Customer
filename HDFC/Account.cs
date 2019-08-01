using HDFC.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace HDFC
{
    /// <summary>
    /// Base Account class
    /// </summary>
    public abstract class Account
    {
        //not possible to have 12 digit account number for an integer
        private static int _seedActNumber = 100;
        protected static int GetNextAccNumber
        {
            get
            {
                return ++_seedActNumber;
            }
        }
        private static List<Account> accounts = new List<Account>();

        /// <summary>
        /// Default ctor
        /// </summary>
        public Account()
        {

        }

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="balance"></param>
        /// <param name="userName"></param>
        public Account(int balance, string userName)
        {
            if (balance < 1000)
            {
                throw new InsufficientBalanceException($"Balance cannot be less than 1000. Your balanace is {Balance}");
            }
            Balance = balance;
            UserName = userName;
            //get next account number
            _accountNumber = GetNextAccNumber;
            //add to the list of accounts
            accounts.Add(this);
        }

        /// <summary>
        /// destructor
        /// </summary>
        ~Account()
        {

        }

        private int _accountNumber;

        /// <summary>
        /// Unique account number
        /// </summary>
        public int AccountNumber { get { return _accountNumber; } }

        /// <summary>
        /// User Name
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Account balance
        /// </summary>
        public int Balance { get; set; }

        /// <summary>
        /// Open new account
        /// </summary>
        /// <param name="balance"></param>
        /// <param name="userName"></param>
        /// <returns></returns>
        public abstract Account OpenAccount(int balance, string userName);

        /// <summary>
        /// Close Account
        /// </summary>
        /// <param name="accountNumber"></param>
        public static void CloseAccount(int accountNumber)
        {
            accounts = accounts.Where(x => x.AccountNumber != accountNumber).ToList();
        }

        /// <summary>
        /// Edit account
        /// </summary>
        /// <param name="newUserName"></param>
        public void EditAccount(string newUserName)
        {
            UserName = newUserName;
        }

        /// <summary>
        /// Deposit given amount from account
        /// </summary>
        /// <param name="depositAmount"></param>
        public void Deposit(int depositAmount)
        {
            Balance += depositAmount;
        }

        /// <summary>
        /// Withdraw given amount from account
        /// </summary>
        /// <param name="withdrawalAmount"></param>
        public virtual void Withdrawal(int withdrawalAmount)
        {
            if (withdrawalAmount > Balance)
            {
                throw new InsufficientBalanceException($"Insufficient balance in your account. Your balanace is {Balance}");
            }
            Balance -= withdrawalAmount;
        }

        /// <summary>
        /// Return account balance
        /// </summary>
        /// <returns></returns>
        public int Check_Balance()
        {
            return Balance;
        }

        /// <summary>
        /// Get account by account number
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <returns></returns>
        public static Account GetAccount(int accountNumber)
        {
            return accounts.FirstOrDefault(x => x.AccountNumber == accountNumber);
        }
    }
}
