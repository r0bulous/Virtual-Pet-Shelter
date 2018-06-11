using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class VirtualPet
    // Declare fields
    {
        // Fields for initial statuses
        public int initialThirst { get; set; }
        public int initialHunger { get; set; }
        public int initialBoredom { get; set; }
        public bool initialAdoption { get; set; }

        // fields/properties for pet names and descriptions
        public string petName {get; set;}
        public string description; // Added description
        public List<string> PetList { get; set; } // field/property for pet names
        public List<string> PetDescriptList { get; set; } // field/property for pet descriptions



        // Adds list of pet names
        public static List<string> petList = new List<string>() { "Mittens", "Kimbop", "Oscar", };
        public static List<string> petDescriptList = new List<string>() { "has feet that look like mittens", "who is from Korea", "has fangs like a bat", };

        // New properties for PetName and Description

        public string PetName
        {
            get { return this.petName; }
            set { this.petName = value; }
        }

        public int IniitalThirst
        {
            get { return this.initialThirst; }
            set { this.initialThirst = value; }
        }

        public string Description
        {
            get { return this.Description; }
            set { this.Description = value; }
        }

        // Constructors

        public VirtualPet()
        {
            // Default Constructor
        }

        // Constructor for name and description

        public VirtualPet(string petName, string description)
        {
            this.PetName = petName;
            this.Description = description;
        }


      
        // Methods

        public static void InitialStatus() // Sets status of pets based on initial values
        {

            // Set values of initial statuses
            int initialThirst = 5;
            int initialHunger = 4;
            int initialBoredom = 3;
            bool initialAdoption = false;

            VirtualPetShelter.thirstList.Add(initialThirst); // 
            VirtualPetShelter.thirstList.Add(initialThirst); //
            VirtualPetShelter.thirstList.Add(initialThirst); //
            VirtualPetShelter.hungerList.Add(initialHunger); // 
            VirtualPetShelter.hungerList.Add(initialHunger); // 
            VirtualPetShelter.hungerList.Add(initialHunger); // 
            VirtualPetShelter.boredList.Add(initialBoredom); // 
            VirtualPetShelter.boredList.Add(initialBoredom); // 
            VirtualPetShelter.boredList.Add(initialBoredom); // 
            VirtualPetShelter.adoptedList.Add(initialAdoption); // 
            VirtualPetShelter.adoptedList.Add(initialAdoption); // 
            VirtualPetShelter.adoptedList.Add(initialAdoption); // 
        }



       
    }
}