using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    class CheckingAccount : BankAccount
    {
        private double overdraftLimit;

        public CheckingAccount(string accountHolder, double overdraftLimit) : base(accountHolder)
        {
            this.overdraftLimit = overdraftLimit;
        }

        public override void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited {amount}, new balance is {balance}.");
        }

        public override void Withdraw(double amount)
        {
            if (amount > balance + overdraftLimit)
            {
                Console.WriteLine("Withdrawal exceeds overdraft limit.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Withdrew {amount}, new balance is {balance}.");
            }
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"Checking Account Info: Account Number: {accountNumber}, Account Holder: {accountHolder}, Balance: {balance}, Overdraft Limit: {overdraftLimit}");
        }
    }
}
