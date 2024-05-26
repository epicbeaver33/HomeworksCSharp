using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    abstract class BankAccount
    {
        private static int accountCounter = 1000;
        protected int accountNumber;
        protected string accountHolder;
        protected double balance;

        public BankAccount(string accountHolder)
        {
            this.accountNumber = ++accountCounter;
            this.accountHolder = accountHolder;
            this.balance = 0;
        }

        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
        public abstract void DisplayAccountInfo();
    }
}
