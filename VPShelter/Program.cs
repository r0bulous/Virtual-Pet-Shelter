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
            // string userResponse = "hi";
            // string exitMainMenu = "no";
            string volunteerMenu = "9";

            // Establishes contents of list (was doing this from VirtualPetShelter but values were reset with every loop)



            // Need these to stop resetting but need values before compiler hits the status strings below







            Console.WriteLine("Welcome to the pet shelter! Please type Start to begin.");
            Console.Write("> ");
            string userResponse = Console.ReadLine().ToLower();
            while (userResponse.Equals("start"))
            {



                //Starting menu while loopr

                //while (exitMainMenu.Equals("no"))
                //{
                //Console.WriteLine("Welcome to the pet shelter!");
                //Console.WriteLine("Enter 1 if you're a manager, or 2 if you're a volunteer.");
                //userResponse = int.Parse(Console.ReadLine());
                //Console.Clear();

                Console.WriteLine("Resetting statuses");
                VirtualPetShelter.thirstList.Add(5); // 
                VirtualPetShelter.thirstList.Add(5); //
                VirtualPetShelter.thirstList.Add(5); //
                VirtualPetShelter.hungerList.Add(5); // 
                VirtualPetShelter.hungerList.Add(5); //
                VirtualPetShelter.hungerList.Add(5); //
                VirtualPetShelter.boredList.Add(5); // 
                VirtualPetShelter.boredList.Add(5); //
                VirtualPetShelter.boredList.Add(5); //
                VirtualPetShelter.adoptedList.Add(false); // 
                VirtualPetShelter.adoptedList.Add(false); //
                VirtualPetShelter.adoptedList.Add(false); //

                // Strings to show status of pets

                //string pet0Status = $"{VirtualPetShelter.petList[0]}: Thirst: {VirtualPetShelter.thirstList[0]} Hunger: {VirtualPetShelter.hungerList[0]} Boredom: {VirtualPetShelter.boredList[0]} Adopted: {VirtualPetShelter.adoptedList[0]}";
                //string pet1Status = $"{VirtualPetShelter.petList[1]}: Thirst: {VirtualPetShelter.thirstList[1]} Hunger: {VirtualPetShelter.hungerList[1]} Boredom: {VirtualPetShelter.boredList[1]} Adopted: {VirtualPetShelter.adoptedList[1]}";
                //string pet2Status = $"{VirtualPetShelter.petList[2]}: Thirst: {VirtualPetShelter.thirstList[2]} Hunger: {VirtualPetShelter.hungerList[2]} Boredom: {VirtualPetShelter.boredList[2]} Adopted: {VirtualPetShelter.adoptedList[2]}";


                Console.WriteLine("Enter 1 if you're a volunteer or 2 if you're a manager.");
                Console.Write("> ");
                string roleResponse = Console.ReadLine().ToLower();
                while (roleResponse.Equals("1"))
                {

                    //Logic to enter do while loop. 
                    // if (roleResponse == 1)

                    string pet0Status = $"{VirtualPetShelter.petList[0]}: Thirst: {VirtualPetShelter.thirstList[0]} Hunger: {VirtualPetShelter.hungerList[0]} Boredom: {VirtualPetShelter.boredList[0]} Adopted: {VirtualPetShelter.adoptedList[0]}";
                    string pet1Status = $"{VirtualPetShelter.petList[1]}: Thirst: {VirtualPetShelter.thirstList[1]} Hunger: {VirtualPetShelter.hungerList[1]} Boredom: {VirtualPetShelter.boredList[1]} Adopted: {VirtualPetShelter.adoptedList[1]}";
                    string pet2Status = $"{VirtualPetShelter.petList[2]}: Thirst: {VirtualPetShelter.thirstList[2]} Hunger: {VirtualPetShelter.hungerList[2]} Boredom: {VirtualPetShelter.boredList[2]} Adopted: {VirtualPetShelter.adoptedList[2]}";


                    Console.WriteLine("* Pet Shelter Volunteer Dashboard *");
                        Console.WriteLine("Current status of today's pets:");
                        Console.WriteLine(pet0Status);
                        Console.WriteLine(pet1Status);
                        Console.WriteLine(pet2Status);
                        Console.WriteLine();
                        Console.WriteLine("What would you like to do?");
                        Console.WriteLine("Enter 1 to water all the pets.");
                        Console.WriteLine("Enter 2 to feed all the pets.");
                        Console.WriteLine("Enter 3 to feed a specific pet.");
                        volunteerMenu = (Console.ReadLine());

                    if (volunteerMenu.Equals("1"))
                    {
                        Volunteer.WaterAllPets(); // Method call to water all the pets
                        Console.WriteLine("All the pets are hydrated!");
                        Console.WriteLine("Current thirst levels: ");
                        Console.WriteLine("{0} {1} {2}", VirtualPetShelter.thirstList[0], VirtualPetShelter.thirstList[1], VirtualPetShelter.thirstList[2]); // Shows water status
                    }

                    if (volunteerMenu.Equals("2"))
                    {
                        Volunteer.FeedAllPets(); // Method call to feed all the pets
                        Console.WriteLine("All the pets have been fed!");
                        Console.WriteLine("Current hunger levels: ");
                        Console.WriteLine("{0} {1} {2}", VirtualPetShelter.hungerList[0], VirtualPetShelter.hungerList[1], VirtualPetShelter.hungerList[2]); // Shows water status


                    }
                    else if (roleResponse.Equals("2"))
                    { Console.WriteLine("Greetings!");
                        Console.WriteLine("We have the following pets today:");
                        Console.WriteLine("1: {0} 2: {1} 3: {2} ", VirtualPetShelter.petList[0], VirtualPetShelter.petList[1], VirtualPetShelter.petList[2]);
                        Console.WriteLine("What would you like to do?");
                        Console.WriteLine("Enter 1 to water all the pets.");
                        Console.WriteLine("Enter 2 to feed all the pets.");
                        Console.WriteLine("Enter 3 to feed a specific pet.");
                    }


                // Functionality for volunteer menu

                        //if (volunteerMenu.Equals("1"))
                        // {
                        //    Volunteer.WaterAllPets(); // Method call to water all the pets
                        //    Console.WriteLine("All the pets are hydrated!");
                        //    // Console.WriteLine("Current thirst levels: ");
                        //    // Console.WriteLine("{0} {1} {2}", VirtualPetShelter.thirstList[0], VirtualPetShelter.thirstList[1], VirtualPetShelter.thirstList[2]); // Shows water status
                        //}

                        //if (volunteerMenu.Equals("2"))
                        //{
                        //    Volunteer.WaterAllPets(); // Method call to feed all the pets
                        //    Console.WriteLine("All the pets have been fed!");
                        //    // Console.WriteLine("Current thirst levels: ");
                        //    // Console.WriteLine("{0} {1} {2}", VirtualPetShelter.thirstList[0], VirtualPetShelter.thirstList[1], VirtualPetShelter.thirstList[2]); // Shows water status
                        }



                        //else
                        //{
                        //    Console.WriteLine("Sorry, we only support managers and volunteers right now.");
                        //    break;
                    }

                }
               }
            }
        
    
