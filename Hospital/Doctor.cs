using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Hospital
{
    class Doctor : Person
    {
        public string Department;

        public override void PerformDuty()
        {

            Console.WriteLine("Doctor " + Name + " is treating patients.");
        }
    }


}
