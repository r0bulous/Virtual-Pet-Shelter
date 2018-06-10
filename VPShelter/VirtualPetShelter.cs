using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class VirtualPetShelter // fields/properties for pets and employees
    {

        // Pet fields/properties
        public string petName { get; set; }
        public int thirst { get; set; }
        public int hunger { get; set; }
        public int boredom { get; set; }
        public List<string> PetList { get; set; } // field/property for PetList
        public List<int> ThirstList { get; set; } // field/property for ThirstList
        public List<int> HungerList { get; set; } // field/property for HungerList
        public List<int> BoredList { get; set; } // field/property for BoredList

        // Employee fields/properties
        public string employeeName { get; set; }
        public string employeeNumber { get; set; }
        public List<string> EmployeeList { get; set; } // field/property for EmployeeList


        // Constructors

        public VirtualPetShelter()
        {
            // Default constructor
        }

        // Create lists of pets and their attributes

        public static List<string> petList = new List<string>() { "Mittens", "Kimbop", "Oscar", }; // Updated to reflect list of types rather than objects and add pet names
        public static List<int> thirstList = new List<int>() { 5, 5, 5 };
        public static List<int> hungerList = new List<int>() { 5, 5, 5 };
        public static List<int> boredList = new List<int>() { 5, 5, 5 };

        // Create employee list

        public List<string> employeeList = new List<string>() { "Frank", "Betsy", "Pamela", "Charles", }; // Updated to reflect list of types rather than objects and add employee names



        public void ShowPetList()
        {
            Console.WriteLine( " 1 {0} 2 {1} 3 {2} ", VirtualPetShelter.petList[0], VirtualPetShelter.petList[1], VirtualPetShelter.petList[2]);
        }
    }

   

  }




//The VirtualPetShelter class MUST include the appropriate instance variable(s) (fields/properties) to store the pets who reside at the shelter.
//The VirtualPetShelter class MUST include the appropriate instance variable(s) (fields/properties) to store all of the employees who volunteer or work at the shelter.
//HINT: Don't overthink this class. You might not instantiate an object from this class in your program. This class allows us to see your ability to appropriately use Lists.