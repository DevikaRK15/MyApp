using System;

namespace MyApp.BankingManagementSystem
{
    abstract class Account
    {
        public int accountNumber;
        public string customerName;
        protected double balance;

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public abstract void Withdraw(double amount);
        public abstract void CalculateInterest();

        public void DisplayDetails()
        {
            Console.WriteLine("Account: " + accountNumber);
            Console.WriteLine("Customer: " + customerName);
            Console.WriteLine("Balance: " + balance);
        }
    }
}