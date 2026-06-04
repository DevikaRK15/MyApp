using System;

namespace MyApp.BankingManagementSystem
{
    class CurrentAcc : Account
    {
        public override void Withdraw(double amount)
        {
            balance -= amount;
        }

        public override void CalculateInterest()
        {
            Console.WriteLine("No interest");
        }
    }
}
