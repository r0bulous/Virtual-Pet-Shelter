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

        // reserved

        // public int thirst;
        // public int hunger;
        // public int boredom;
        // public bool enoughWater;
        // public bool enoughFood;
        // public bool enoughPlay;



        // paramaters

        //public int Hunger
        //{
        //    get { return this.hunger; }
        //    set { this.hunger = value; }
        //}
        //public int Boredom
        //{
        //    get { return this.boredom; }
        //    set { this.boredom = value; }
        //}

        //public bool EnoughWater
        //{
        //    get { return this.enoughWater; }
        //    set { this.enoughWater = value; }
        //}
        //public bool EnoughFood
        //{
        //    get { return this.enoughFood; }
        //    set { this.enoughFood = value; }
        //}
        //public bool EnoughPlay
        //{
        //    get { return this.enoughPlay; }
        //    set { this.enoughPlay = value; }
        //}

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


        // This is supposed to be the constructor to take initial values + name and description but Visual Studio says they haven't been defined.

        //    public VirtualPet(string petName, int initialThirst, int initialHunger, int initialBoredom, bool initialAdoption)
        //{
        //    this.PetName = petName;
        //    this.Description = description;
        //    this.InitialThirst = initialThirst; // Visual Studio says all these initial values haven't been defined
        //    this.InitialHunger = initialHunger;
        //    this.InitialBoredom = initialBoredom;
        //    this.InitialAdoption = initialAdoption;

        //public VirtualPet(int thirst, int hunger, int boredom) // Constructor to access thirst, hunger, boredom
        //{
        //    this.InitialThirst = initialThirst;
        //    this.Hunger = hunger;
        //    this.Boredom = boredom;
        //}

        //public VirtualPet(string petName, string description, int thirst, int hunger, int boredom) // NEW construction to access attributes in addition to name and description
        //{
        //    this.PetName = petName;
        //    this.Description = description;
        //    this.Thirst = thirst;
        //    this.Hunger = hunger;
        //    this.Boredom = boredom;
        //}



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



        //public void Tick() // Tick method
        //{
        //    Thirst--;
        //    if (Thirst < 1)
        //    {
        //        ThirstAlert(true);
        //    }
        //    else
        //    {
        //        ThirstAlert(false);
        //    }

        //    Hunger++;
        //    if (Hunger > 9)
        //    {
        //        StarvingAlert(true);
        //    }
        //    else
        //    {
        //        StarvingAlert(false);
        //    }

        //    Boredom++;
        //    if (Boredom > 9)
        //    {
        //        BoredomAlert(true);
        //    }
        //    else
        //    {
        //        BoredomAlert(false);
        //    }
        //}

        //public void Nap() // Nap method
        //{
        //    Thirst += 4;
        //    Hunger++;
        //}

        //public void Eat() // Eat method
        //{
        //    Hunger -= 4;
        //    Thirst--;
        //}

        //public void Play() // Play method
        //{
        //    Boredom -= 4;
        //    Hunger++;
        //    Thirst--;
        //}

        //public void Vacation() // Vacation method
        //{
        //    Boredom += 7;
        //    Hunger += 5;
        //    Thirst += 5;
        //}

        //public bool ThirstAlert(bool status)
        //{
        //    EnoughWater = status;
        //    return EnoughWater;
        //}

        //public bool StarvingAlert(bool status)
        //{
        //    EnoughFood = status;
        //    return EnoughFood;
        //}

        //public bool BoredomAlert(bool status)
        //{
        //    EnoughPlay = status;
        //    return EnoughPlay;
        //}
    }
}