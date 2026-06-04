using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp
{
    internal class StudentData
    {
        public string name;
        public int marks;
    }
    //class Program1
    //{
    //    static List<StudentData> Students = new List<StudentData>();
    //    static void Main()
    //    {

    //        while (true)
    //        {
    //            Console.WriteLine("\n Student Dashboard");
    //            Console.WriteLine("1. Add Student");
    //            Console.WriteLine("2. view Students");
    //            Console.WriteLine("3. Marks > 75");
    //            Console.WriteLine("4. Exit");

    //            Console.WriteLine("Enter your choice");
    //            string choice = Console.ReadLine();
    //            if (choice == "1")
    //                AddStudent();
    //            else if (choice == "2")
    //                ViewStudents();
    //            else if (choice == "3")
    //                ShowTopStudents();
    //            else if (choice == "4")
    //                break;
    //            else
    //                Console.WriteLine("Invalid choice.");

    //        }
    //    }

    //    static void AddStudent()
    //    {
    //        StudentData s = new StudentData();
    //        Console.WriteLine("Enter student name");
    //        s.name = Console.ReadLine();
    //        Console.WriteLine("enter marks");
    //        int marks;
    //        while (!int.TryParse(Console.ReadLine(), out marks))
    //        {
    //            Console.WriteLine("Invalid input. Please enter a valid integer for marks.");
    //        }
    //        s.marks = marks;
    //        Students.Add(s);
    //        Console.WriteLine("Students added successfully.");
    //    }

    //    static void ViewStudents()
    //    {
    //        if (Students.Count == 0)
    //        {
    //            Console.WriteLine("No students to display.");
    //            return;
    //        }
    //        Console.WriteLine("Students :");
    //        foreach (StudentData s in Students)
    //        {
    //            Console.WriteLine($"Name:{s.name}, Marks:{s.marks}");

    //        }
    //    }
    //    static void ShowTopStudents()
    //    {
    //        var top = Students.Where(s => s.marks >= 75).ToList();

    //        if (top.Count == 0)
    //        {
    //            Console.WriteLine("No top students.");
    //            return;
    //        }

    //        Console.WriteLine("Top Students");

    //        foreach (var s in top)
    //        {
    //            Console.WriteLine("Name: " + s.name + ", Marks: " + s.marks);
    //        }
    //    }



    //}
}
