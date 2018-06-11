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


        public static void AdoptPet0() // Method to initiate pet 0 adoption. Should be changing status in list for each specific pet.
        {
            VirtualPetShelter.adoptedList[0] = true;
        }

        public static void AdoptPet1() // Method to initiate pet 0 adoption. Should be changing status in list for each specific pet.
        {
            VirtualPetShelter.adoptedList[1] = true;
        }

        public static void AdoptPet2() // Method to initiate pet 0 adoption. Should be changing status in list for each specific pet.
        {
            VirtualPetShelter.adoptedList[2] = true;
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

