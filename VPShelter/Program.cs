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

            string volunteerMenu = "";
            string managerMenu = "";
            string petToPlay;
            string adoptChoice = "";

            // Calls method to populates the initial pet statuses based on starting values from VirtualPet

            VirtualPet.InitialStatus();

            // UI STARTS HERE

            // While loop/start program

            Console.WriteLine("Welcome to the pet shelter! Please type Start to begin.");
            Console.Write("> ");
            string userResponse = Console.ReadLine().ToLower();
            while (userResponse.Equals("start"))
            {


                // Initial start while loop/prompt

                Console.WriteLine("Enter 1 if you're a volunteer or 2 if you're a manager.");
                Console.Write("> ");
                string roleResponse = Console.ReadLine().ToLower();
                while (roleResponse.Equals("1"))
                {


                    // Shows status of pets. Names come from VirtualPet class, others from VirtualPetShelter

                    string pet0Status = $"{VirtualPet.petList[0]}: Thirst: {VirtualPetShelter.thirstList[0]} Hunger: {VirtualPetShelter.hungerList[0]} Boredom: {VirtualPetShelter.boredList[0]} Adopted: {VirtualPetShelter.adoptedList[0]}";
                    string pet1Status = $"{VirtualPet.petList[1]}: Thirst: {VirtualPetShelter.thirstList[1]} Hunger: {VirtualPetShelter.hungerList[1]} Boredom: {VirtualPetShelter.boredList[1]} Adopted: {VirtualPetShelter.adoptedList[1]}";
                    string pet2Status = $"{VirtualPet.petList[2]}: Thirst: {VirtualPetShelter.thirstList[2]} Hunger: {VirtualPetShelter.hungerList[2]} Boredom: {VirtualPetShelter.boredList[2]} Adopted: {VirtualPetShelter.adoptedList[2]}";


                    Console.WriteLine("* Pet Shelter Volunteer Dashboard *");
                    Console.WriteLine("Current status of today's pets:");

                    // OutputStatus();

                    Console.WriteLine(pet0Status);
                    Console.WriteLine(pet1Status);
                    Console.WriteLine(pet2Status);

                    Console.WriteLine();
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("Enter 1 to water all the pets.");
                    Console.WriteLine("Enter 2 to feed all the pets.");
                    Console.WriteLine("Enter 3 to play with a specific pet.");
                    Console.WriteLine("Enter 4 to have your ID checked.");
                    Console.WriteLine("Enter 5 to quit.");
                    volunteerMenu = (Console.ReadLine());

                    if (volunteerMenu.Equals("4"))
                    {
                        Volunteer tina = new Volunteer();
                        tina.CheckID();
                    }

                    if (volunteerMenu.Equals("1"))
                    {
                        Volunteer.WaterAllPets(); // Method call to water all the pets
                        Console.WriteLine("All the pets are hydrated!");
                    }

                    if (volunteerMenu.Equals("2"))
                    {
                        Volunteer.FeedAllPets(); // Method call to feed all the pets
                        Console.WriteLine("All the pets have been fed!");
                    }

                    if (volunteerMenu.Equals("3")) // Play with an individual pet
                    {
                        Console.WriteLine("Which pet would you like to play with?");
                        Console.Write("Enter 1 for {0}, 2 for {1} or 3 for {2}. > ", VirtualPet.petList[0], VirtualPet.petList[1], VirtualPet.petList[2]);
                        petToPlay = (Console.ReadLine());

                        if (petToPlay.Equals("1"))
                        {
                            Console.WriteLine("You played with {0}!", VirtualPet.petList[0]);
                            VirtualPetShelter.boredList[0] = 0;
                        }

                        if (petToPlay.Equals("2"))
                        {
                            Console.WriteLine("You played with {0}!", VirtualPet.petList[1]);
                            VirtualPetShelter.boredList[1] = 0;
                        }

                        if (petToPlay.Equals("3"))
                        {
                            Console.WriteLine("You played with {0}!", VirtualPet.petList[2]);
                            VirtualPetShelter.boredList[2] = 0;
                        }
                    }

                    if (volunteerMenu.Equals("5"))
                    {
                        Console.WriteLine("Thanks again for volunteering. Have a great day!");
                        return;
                    }
                }

                while (roleResponse.Equals("2"))
                {
                    Console.WriteLine("* Pet Shelter Management Dashboard *");
                    Console.WriteLine();
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("Enter 1 to view the status of all pets.");
                    Console.WriteLine("Enter 2 to adopt pets.");
                    Console.WriteLine("Enter 3 to check ID.");
                    Console.WriteLine("Enter 4 to quit.");
                    Console.Write("> ");
                    managerMenu = (Console.ReadLine());

                    if (managerMenu.Equals("1"))
                    {

                        void OutputStatus() // Sets strings and outputs pet status. Wanted to reuse these but ran into problems getting them not to show every time.
                        {
                            string pet0Status = $"{VirtualPet.petList[0]}: Thirst: {VirtualPetShelter.thirstList[0]} Hunger: {VirtualPetShelter.hungerList[0]} Boredom: {VirtualPetShelter.boredList[0]} Adopted: {VirtualPetShelter.adoptedList[0]}";
                            string pet1Status = $"{VirtualPet.petList[1]}: Thirst: {VirtualPetShelter.thirstList[1]} Hunger: {VirtualPetShelter.hungerList[1]} Boredom: {VirtualPetShelter.boredList[1]} Adopted: {VirtualPetShelter.adoptedList[1]}";
                            string pet2Status = $"{VirtualPet.petList[2]}: Thirst: {VirtualPetShelter.thirstList[2]} Hunger: {VirtualPetShelter.hungerList[2]} Boredom: {VirtualPetShelter.boredList[2]} Adopted: {VirtualPetShelter.adoptedList[2]}";
                            Console.WriteLine(pet0Status);
                            Console.WriteLine(pet1Status);
                            Console.WriteLine(pet2Status);
                        }

                        OutputStatus(); // Built this with idea of trying to use for both managers and volunteers but had to shuffle after adding manager functions

                    }



                    if (managerMenu.Equals("3"))
                    {
                        Manager ted = new Manager();
                        ted.CheckID();
                    }




                        if (managerMenu.Equals("2"))
                        {
                            Console.WriteLine("We have the following pets today:");
                            Console.WriteLine();
                            Console.WriteLine("1: {0} is a {1} who {2} and lives off a diet of {3}.", VirtualPet.petList[0], VirtualPetDetails.petTypeList[0], VirtualPet.petDescriptList[0], VirtualPetDetails.petFoodList[0]);
                            Console.WriteLine("2: {0} is a {1} who {2} and lives off a diet of {3}.", VirtualPet.petList[1], VirtualPetDetails.petTypeList[1], VirtualPet.petDescriptList[1], VirtualPetDetails.petFoodList[1]);
                            Console.WriteLine("1: {0} is a {1} who {2} and lives off a diet of {3}.", VirtualPet.petList[2], VirtualPetDetails.petTypeList[2], VirtualPet.petDescriptList[2], VirtualPetDetails.petFoodList[2]);
                            Console.WriteLine("Which pet is the client most interested in? Enter 1, 2, or 3.");
                            Console.Write("> ");
                            adoptChoice = (Console.ReadLine());

                            // Options to place pets
                            if (adoptChoice.Equals("1"))
                            {
                                Console.WriteLine("You successfully placed {0}. Enjoy the rest of your day!", (VirtualPet.petList[0]));
                                Manager.AdoptPet(); // Calls AdoptPet method in Manager class
                            }

                            if (adoptChoice.Equals("2"))
                            {
                                Console.WriteLine("You adopted out {0}. Nice work!", (VirtualPet.petList[0]));
                                Manager.AdoptPet(); // Calls AdoptPet method in Manager class
                            }


                            if (adoptChoice.Equals("3"))
                            {
                                Console.WriteLine("You adopted {0}. Maybe it's time for a nap?", (VirtualPet.petList[2]));
                                Manager.AdoptPet(); // Calls AdoptPet method in Manager class
                            }



                        }
                        if (managerMenu.Equals("4"))
                        {
                            Console.WriteLine("Have a great day!");
                            return;
                        }

                    }

                }


            }

        }
    }

    
    
        
    
