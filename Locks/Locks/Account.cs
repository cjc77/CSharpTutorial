using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Locks
{
    class Account
    {
        private Object accountLock = new Object();
        float balance;
        const float minBalance = 20;

        Random r = new Random();

        public Account(int initial)
        {
            balance = initial;
        }

        // can only withdraw an integer amount
        float Withdraw(int amount)
        {
            if (!ValidBalance)
            {
                NegativeBalanceException();
            }

            lock (accountLock)
            {
                if (this.balance - minBalance >= amount)
                {
                    Console.WriteLine("Balance Before Withdrawal : {0}", this.balance);
                    Console.WriteLine("Amount to Withdraw : {0}", amount);
                    this.balance -= amount;
                    Console.WriteLine("Balance After Withdrawal : {0}", this.balance);
                    return amount;
                }
                else
                {
                    return 0;
                }
            }
        }

        public void DoTransactions()
        {
            // make 10 withdrawals of random amounts between 0 and 100
            for (int i = 0; i < 100; i++)
                Withdraw(r.Next(1, 200));
        }

        bool ValidBalance
        {
            get
            {
                if (this.balance < 0)
                    return false;
                return true;
            }
        }

        void NegativeBalanceException()
        {
            throw new Exception("Negative Balance");
        }
    }
}
