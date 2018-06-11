using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class VirtualPetDetails : VirtualPet // VirtualFish class as derived from VirtualPet
    {

        // Fields/properties for type of pet and pet diet per program requirements

        string PetType { get; set; }
        string PetDiet { get; set; }
        public static List<string> petTypeList = new List<string>() { "dog", "cat", "fish", };
        public static List<string> petFoodList = new List<string>() { "dog food", "cat food", "chocolate", };

        // Default Constructor

        public VirtualPetDetails()
        {
            // Default Constructor
        }
    }
}



// The dervied class MUST include instance variables(fields/properties) representing:
// type of pet
// pet's specific diet