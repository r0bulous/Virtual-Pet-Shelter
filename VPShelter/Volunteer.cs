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

        public override void ClockIn()
        {
            Console.WriteLine("Welcome. Too bad you're not getting paid!");
        }

        public override void CheckID()
        {
            Console.WriteLine("That ID looks suspicious. Please turn it to a manager!");
        }
    }

}