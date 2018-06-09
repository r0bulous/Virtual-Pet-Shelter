using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Program
    {
        public static void Main(string[] args)
        {

            // Define local variables for UI

            //Local variables 
            int userResponse;
            string exitMainMenu = "no";

            //Starting menu while loop

            while (exitMainMenu.Equals("no"))
            {
                Console.WriteLine("Welcome to the pet shelter! We have the following pets today:");
                Console.WriteLine("1: {0} 2: {1} 3: {2} ", VirtualPetShelter.petList[0], VirtualPetShelter.petList[1], VirtualPetShelter.petList[2]);
                Console.WriteLine("Are you a manager or a volunteer? Enter 1 if you're a manager, or 2 if you're a volunteer.");
                userResponse = int.Parse(Console.ReadLine());
                Console.Clear();

                //Logic to enter do while loop. 
                if (userResponse == 1)
                {
                    Console.WriteLine("Oh, I see you're a manager.");
                }
                if (userResponse == 2)
                {
                    Console.WriteLine("Welcome! Thanks for volunteering.");
                }
                else
                {
                    Console.WriteLine("Sorry, we only support managers and volunteers right now.");
                    break;
                }
            }
        }
    }
}