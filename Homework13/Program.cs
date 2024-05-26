using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework13
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount savings = new SavingsAccount("Alice", 2.5);
            CheckingAccount checking = new CheckingAccount("Bob", 500);

            while (true)
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Deposit to Savings Account");
                Console.WriteLine("2. Withdraw from Savings Account");
                Console.WriteLine("3. Display Savings Account Info");
                Console.WriteLine("4. Deposit to Checking Account");
                Console.WriteLine("5. Withdraw from Checking Account");
                Console.WriteLine("6. Display Checking Account Info");
                Console.WriteLine("7. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter amount to deposit to Savings Account: ");
                        double savingsDeposit = double.Parse(Console.ReadLine());
                        savings.Deposit(savingsDeposit);
                        break;
                    case "2":
                        Console.Write("Enter amount to withdraw from Savings Account: ");
                        double savingsWithdraw = double.Parse(Console.ReadLine());
                        savings.Withdraw(savingsWithdraw);
                        break;
                    case "3":
                        savings.DisplayAccountInfo();
                        break;
                    case "4":
                        Console.Write("Enter amount to deposit to Checking Account: ");
                        double checkingDeposit = double.Parse(Console.ReadLine());
                        checking.Deposit(checkingDeposit);
                        break;
                    case "5":
                        Console.Write("Enter amount to withdraw from Checking Account: ");
                        double checkingWithdraw = double.Parse(Console.ReadLine());
                        checking.Withdraw(checkingWithdraw);
                        break;
                    case "6":
                        checking.DisplayAccountInfo();
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }
    }
}
