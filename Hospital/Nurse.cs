using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Hospital
{
    class Nurse : Person
    {
        public string Department;

        public override void PerformDuty()
        {Console.WriteLine("Nurse " + Name + " is assisting doctors.");
        }
    }
}
