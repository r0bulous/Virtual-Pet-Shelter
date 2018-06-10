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
            int volunteerMenu;

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
                    Console.WriteLine("Welcome, manager!");
                }
                if (userResponse == 2)

                    do
                    {
                        Console.WriteLine("Welcome! Thanks for volunteering.");
                        {
                            Console.WriteLine("What would you like to do?");
                            Console.WriteLine("Enter 1 to water all the pets.");
                            Console.WriteLine("Enter 2 to feed all the pets.");
                            Console.WriteLine("Enter 3 to feed a specific pet.");
                            volunteerMenu = int.Parse(Console.ReadLine());

                            // Functionality for volunteer menu

                            if (volunteerMenu == 1)
                            {
                                Volunteer.WaterAllPets(); // Method call to water all the pets
                                Console.WriteLine("All the pets are well hydrated!"); 
                                // Console.WriteLine("Current thirst levels: ");
                                // Console.WriteLine("{0} {1} {2}", VirtualPetShelter.thirstList[0], VirtualPetShelter.thirstList[1], VirtualPetShelter.thirstList[2]); // Shows water status
                            }



                            else
                            {
                                Console.WriteLine("Sorry, we only support managers and volunteers right now.");
                                break;
                            }
                        }
                    } while (volunteerMenu == 2); //End of do while loop
            }
        }
    }
}