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


        public static void AdoptPet() // Method to initiate pet adoption
        {
            didAdopt = true;           
        }

        // Added this to meet requriements for an override method. Couldn't successfully call override method.

        //public override string ClockIn()
        //{
        //  throw new NotImplementedException();
        //}

    }
}



// NEED TO ADD An override method(How does a Manager do one of the Employee methods differently?).
// DONE  An additional property(for example, Salary, YearsEmployed, or Department).
// NEED TO ADD A method for adopting a pet.
