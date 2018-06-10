using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Volunteer : Employee // Class derived from Employee
    {
        public bool weekendAvailibility { get; set; } // additional property

        public static void WaterAllPets() // Feeds all pets
        {
            VirtualPetShelter.thirstList.Clear();
            VirtualPetShelter.thirstList.Add(0);
            VirtualPetShelter.thirstList.Add(0);
            VirtualPetShelter.thirstList.Add(0);
        }


    }

}



    


// NEED TO DO: An override method(How does a Volunteer do one of the Employee methods differently?).
// : An additional property(for example HoursAvailable, VolunteerType, or VolunteerSpecialty).
// NEED TO DO: A method for feeding all of the pets. (HINT: Don't overthink this. It can return a status of "All pets have been fed.")
// COMPLETE: A method for giving water to all of the pets(see above hint).