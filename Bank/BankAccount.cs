using System;

namespace BankAccountNS
{
    // class for bank account
    public class BankAccount
    {
        //Attributes for bank account
        private readonly string m_customerName;
        private double m_balance;
        public const string DebitAmountExceedsBalanceMessage = "Debit amount exceeds balance";
        public const string DebitAmountLessThanZeroMessage = "Debit amount is less than zero";

        private BankAccount() { }

        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        //Customer name 
        public string CustomerName
        {
            get { return m_customerName; }
        }

        //Customer Balance
        public double Balance
        {
            get { return m_balance; }
        }

        //Method for checking Debit
        public void Debit(double amount)
        {
            if (amount > m_balance)
            {
                throw new System.ArgumentOutOfRangeException("amount", amount, DebitAmountExceedsBalanceMessage);
            }

            if (amount < 0)
            {
                throw new System.ArgumentOutOfRangeException("amount", amount, DebitAmountLessThanZeroMessage);
            }

            m_balance -= amount;
        }

        //Method for Credit
        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance += amount;
        }

        //Object for bank account
        public static void Main()
        {
            BankAccount ba = new BankAccount("Mr. Bryan Walton", 11.99);

            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Current balance is ${0}", ba.Balance);
        }
    }
}