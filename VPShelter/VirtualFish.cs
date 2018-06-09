using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class VirtualFish : VirtualPet // VirtualFish class as derived from VirtualPet
    {

        // Fields/properties for type of pet and pet diet per program requirements

        string PetType { get; set; }
        string PetDiet { get; set; }

    }
}


// The dervied class MUST include instance variables(fields/properties) representing:
// type of pet
// pet's specific diet