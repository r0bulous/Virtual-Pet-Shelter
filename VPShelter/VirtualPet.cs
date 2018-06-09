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
        public int thirst;
        public int hunger;
        public int boredom;
        public bool enoughWater;
        public bool enoughFood;
        public bool enoughPlay;
        public string petName; // Added petName
        public string description; // Added description


        // paramaters

        public int Thirst
        {
            get { return this.thirst; }
            set { this.thirst = value; }
        }
        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }
        public int Boredom
        {
            get { return this.boredom; }
            set { this.boredom = value; }
        }
        public bool EnoughWater
        {
            get { return this.enoughWater; }
            set { this.enoughWater = value; }
        }
        public bool EnoughFood
        {
            get { return this.enoughFood; }
            set { this.enoughFood = value; }
        }
        public bool EnoughPlay
        {
            get { return this.enoughPlay; }
            set { this.enoughPlay = value; }
        }

        // New properties for PetName and Description

        public string PetName
        {
            get { return this.petName; }
            set { this.petName = value; }
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

        public VirtualPet(int thirst, int hunger, int boredom) // constructor to access thirst, hunger, boredom
        {
            this.Thirst = thirst;
            this.Hunger = hunger;
            this.Boredom = boredom;
        }

        public VirtualPet(string petName, string description) // NEW constructor to access pet name and description
        {
            this.PetName = petName;
            this.Description = description;
        }

        public VirtualPet(string petName, string description, int thirst, int hunger, int boredom) // NEW construction to access attributes in addition to name and description
        {
            this.PetName = petName;
            this.Description = description;
            this.Thirst = thirst;
            this.Hunger = hunger;
            this.Boredom = boredom;
        }

        // Methods

        public void Tick() // Tick method
        {
            Thirst--;
            if (Thirst < 1)
            {
                ThirstAlert(true);
            }
            else
            {
                ThirstAlert(false);
            }

            Hunger++;
            if (Hunger > 9)
            {
                StarvingAlert(true);
            }
            else
            {
                StarvingAlert(false);
            }

            Boredom++;
            if (Boredom > 9)
            {
                BoredomAlert(true);
            }
            else
            {
                BoredomAlert(false);
            }
        }

        public void Nap() // Nap method
        {
            Thirst += 4;
            Hunger++;
        }

        public void Eat() // Eat method
        {
            Hunger -= 4;
            Thirst--;
        }

        public void Play() // Play method
        {
            Boredom -= 4;
            Hunger++;
            Thirst--;
        }

        public void Vacation() // Vacation method
        {
            Boredom += 7;
            Hunger += 5;
            Thirst += 5;
        }

        public bool ThirstAlert(bool status)
        {
            EnoughWater = status;
            return EnoughWater;
        }

        public bool StarvingAlert(bool status)
        {
            EnoughFood = status;
            return EnoughFood;
        }

        public bool BoredomAlert(bool status)
        {
            EnoughPlay = status;
            return EnoughPlay;
        }
    }
}