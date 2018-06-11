using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Volunteer : Employee // Class derived from Employee
    {
        public bool weekendAvailibility { get; set; } // additional property

        public static void WaterAllPets() // Waters all pets -- tried to get this to work with override method
        {
            VirtualPetShelter.thirstList.Clear();
            VirtualPetShelter.thirstList.Add(0);
            VirtualPetShelter.thirstList.Add(0);
            VirtualPetShelter.thirstList.Add(0);
        }

        public static void FeedAllPets() // Feeds all pets -- tried to get this to work with override method
        {
            VirtualPetShelter.hungerList.Clear();
            VirtualPetShelter.hungerList.Add(0);
            VirtualPetShelter.hungerList.Add(0);
            VirtualPetShelter.hungerList.Add(0);
        }

        // Added this to meet requriements for an override method. Couldn't successfully call above methods as override methods.

        //public override string ClockIn()
        //{
        //    throw new NotImplementedException();
        //}

        // public override string CheckID()
        //{
        //    throw new NotImplementedException();
        //}
    }

}



    


// NEED TO DO: An override method(How does a Volunteer do one of the Employee methods differently?).
// : An additional property(for example HoursAvailable, VolunteerType, or VolunteerSpecialty).
// NEED TO DO: A method for feeding all of the pets. (HINT: Don't overthink this. It can return a status of "All pets have been fed.")
// COMPLETE: A method for giving water to all of the pets(see above hint).