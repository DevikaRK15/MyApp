using System;
using MyApp.BankingManagementSystem;
using MyApp.Hospital;

namespace MyApp
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\n MAIN MENU ");
                Console.WriteLine("1. Banking System");
                Console.WriteLine("2. Hospital System");
                Console.WriteLine("3. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        new BankingSystem().Run();
                        break;

                    case "2":
                        new HospitalSystem().Run();
                        break;

                    case "3":
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }
    }
}