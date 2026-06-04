using System;

namespace MyApp.BankingManagementSystem
{
    class SavingsAcc : Account
    {
        public override void Withdraw(double amount)
        {
            if (balance >= amount)
                balance -= amount;
            else
                Console.WriteLine("Insufficient balance");
        }

        public override void CalculateInterest()
        {
            double interest = balance * 0.05;
            balance += interest;

            Console.WriteLine("Interest Added: " + interest);
        }
    }
}