using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Manager : Employee // Class derived from Employee
    {
        bool hasCar { get; set; } // One property as required by project description

        public static bool didAdopt;


        public static void AdoptPet() // Method to initiate pet adoption. Should be changing status in list for each specific pet.
        {
            didAdopt = true;
        }

        // Added this to meet requriements for an override method. Couldn't successfully call override method.

        public override void ClockIn()
        {
          Console.WriteLine("Clocked in.");
        }

        public override void CheckID()
        {
            Console.WriteLine("Looks like a valid ID card.");
        }

    }
}



// NEED TO ADD An override method(How does a Manager do one of the Employee methods differently?).
// DONE  An additional property(for example, Salary, YearsEmployed, or Department).
// NEED TO ADD A method for adopting a pet.
