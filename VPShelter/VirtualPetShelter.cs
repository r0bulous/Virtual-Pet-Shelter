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

        // public List<string> PetList { get; set; } // field/property for PetList
        public List<int> ThirstList { get; set; } // field/property for ThirstList
        public List<int> HungerList { get; set; } // field/property for HungerList
        public List<int> BoredList { get; set; } // field/property for BoredList
        public List<bool> AdoptedList { get; set; } // field/property for AdoptedList

        // Employee fields/properties
        public string employeeName { get; set; }
        public string employeeNumber { get; set; }
        public List<string> EmployeeList { get; set; } // field/property for EmployeeList


        // Constructors

        public VirtualPetShelter()
        {
            // Default constructor
        }

        // Create lists of pets and pet status indicators

        // public static List<string> petList = new List<string>() { "Mittens", "Kimbop", "Oscar", };
        public static List<int> thirstList = new List<int>();
        public static List<int> hungerList = new List<int>();
        public static List<int> boredList = new List<int>();
        public static List<bool> adoptedList = new List<bool>(); 

        // Create employee list

        public static List<string> employeeList = new List<string>() { "Frank", "Betsy", "Pamela", "Charles", }; // Updated to reflect list of types rather than objects and add employee names
    }
       
  }
