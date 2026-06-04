using System;

namespace MyApp.BankingManagementSystem
{
    class BankingSystem
    {
        public void Run()
        {
            Console.WriteLine("\n--- Banking System ---");

            Account acc;

            Console.WriteLine("Choose Account Type:");
            Console.WriteLine("1. Savings Account");
            Console.WriteLine("2. Current Account");

            string choice = Console.ReadLine();

            if (choice == "1")
                acc = new SavingsAcc();
            else
                acc = new CurrentAcc();

            Console.Write("Enter Account Number: ");
            acc.accountNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter Customer Name: ");
            acc.customerName = Console.ReadLine();

            Console.Write("Enter Deposit Amount: ");
            double amount = double.Parse(Console.ReadLine());

            acc.Deposit(amount);

            acc.DisplayDetails();

            Console.Write("\nEnter Withdraw Amount: ");
            double withdraw = double.Parse(Console.ReadLine());

            acc.Withdraw(withdraw);

            acc.CalculateInterest();

            Console.WriteLine("\nFinal Details:");
            acc.DisplayDetails();
        }
    }
}
