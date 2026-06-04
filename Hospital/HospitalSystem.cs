using System;
using System.Collections.Generic;

namespace MyApp.Hospital
{
    class HospitalSystem
    {
        public void Run()
        {
            List<Person> people = new List<Person>();

          
            Doctor d = new Doctor();
            d.Id = 1;
            d.Name = "Krishna";
            d.Department = "Cardiology";

       
            Nurse n = new Nurse();
            n.Id = 2;
            n.Name = "Ravi";
            n.Department = "General";

            
            Patient p = new Patient();
            p.Id = 3;
            p.Name = "Anu";
            p.SetDisease("Fever");
            people.Add(d);
            people.Add(n);
            people.Add(p);

            Console.WriteLine("\n--- Hospital System ---");

            foreach (Person person in people)
            {
                person.GetDetails();
                person.PerformDuty();
                Console.WriteLine();
            }
        }
    }
}
