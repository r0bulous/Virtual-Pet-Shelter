using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class VirtualPetShelter // fields/properties for pets and employees
    {

        // Pet fields/properties
        public string petName { get; set; }
        public int thirst { get; set; }
        public int hunger { get; set; }
        public int boredom { get; set; }

       
        // Employee fields/properties
        public string employeeName { get; set; }
        public string employeeNumber { get; set; }

        // Create lists of pets and employees as per project requirements

        List<VirtualPet> petList = new List<VirtualPet>(); // List for pets. Unsure if this will include VirtualPet and VirtualFish classes?
        List<Employee> employeeList = new List<Employee>(); // Employee lis. (Same q as above. Derived classes included?)

        // Constructors

        public VirtualPetShelter()
        {
        // Default constructor
        }

    }
}

//The VirtualPetShelter class MUST include the appropriate instance variable(s) (fields/properties) to store the pets who reside at the shelter.
//The VirtualPetShelter class MUST include the appropriate instance variable(s) (fields/properties) to store all of the employees who volunteer or work at the shelter.
//HINT: Don't overthink this class. You might not instantiate an object from this class in your program. This class allows us to see your ability to appropriately use Lists.