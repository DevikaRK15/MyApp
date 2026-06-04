using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Hospital
{
    class Patient : Person
    {
        private string disease;

        public void SetDisease(string d)
        {
            disease = d;
        } public override void PerformDuty()
        {
            Console.WriteLine("Patient " + Name + " is receiving treatment.");
        }
    }
}
