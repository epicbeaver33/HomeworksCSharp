using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    class SavingsAccount : BankAccount
    {
        private double interestRate;

        public SavingsAccount(string accountHolder, double interestRate) : base(accountHolder)
        {
            this.interestRate = interestRate;
        }

        public override void Deposit(double amount)
        {
            balance += amount;
            balance += balance * (interestRate / 100);
            Console.WriteLine($"Deposited {amount}, new balance is {balance} after interest.");
        }

        public override void Withdraw(double amount)
        {
            if (amount > balance)
            {
                Console.WriteLine("Insufficient funds for withdrawal.");
            }
            else
            {
                balance -= amount;
                Console.WriteLine($"Withdrew {amount}, new balance is {balance}.");
            }
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"Savings Account Info: Account Number: {accountNumber}, Account Holder: {accountHolder}, Balance: {balance}, Interest Rate: {interestRate}%");
        }
    }
}
