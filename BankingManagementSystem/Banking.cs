using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.BankingManagementSystem
{
    internal class Banking
    {

        static void Main()
        {
            Account acc = new SavingsAcc();

            acc.accountNumber = 1001;
            acc.customerName = "Krishna";

            acc.Deposit(50000);
            acc.DisplayDetails();
            acc.CalculateInterest();
        }
    }
}
