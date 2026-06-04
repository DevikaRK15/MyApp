using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Hospital
{

    abstract class Person
    {
        public int Id;
        public string Name;

        public abstract void PerformDuty();

        public void GetDetails()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Name: " + Name);
        }
    }
}


