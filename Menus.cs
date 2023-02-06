using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace template_csharp_virtual_pet
{
    public static class Menus
    {
        public static void IntroMenu()
        {
            Console.Clear();
            Console.WriteLine("WELCOME TO MAS CODE'S VIRTUAL PET\n");
            Console.WriteLine("This pocket universe moves fast, " +
                "You will have to move fast as well to keep your new" +
                " friend alive and happy.\n");
        }
        public static string OrganicOrRoboticMenu()
        {
            Console.WriteLine("Do you want a robotic or organic pet?\n");
            Console.WriteLine("1. Organic");
            Console.WriteLine("2. Robotic");
            string selection = "";
            bool menuUp = true;
            while (menuUp)
            {
                string userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "1":
                        selection = "Organic";
                        menuUp = false;
                        break;
                    case "2":
                        selection = "Robotic";
                        menuUp = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
            return selection;
        }
        public static string SpeciesMenu()
        {
            Console.Clear();
            Console.WriteLine("What Species would you like?\n");
            Console.WriteLine("1. Lion");
            Console.WriteLine("2. Tiger");
            Console.WriteLine("3. Panther");
            string selection="";
            bool menuUp = true;
            while (menuUp)
            {
                string userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "1":
                        selection = "Lion";
                        menuUp = false;
                        break;
                    case "2":
                        selection = "Tiger";
                        menuUp = false;
                        break;
                    case "3":
                        selection = "Panther";
                        menuUp = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
            return selection;
        }
        public static string RobotTypeMenu()
        {
            Console.Clear();
            Console.WriteLine("What Robot Type do you want?\n");
            Console.WriteLine("1. Robot Type A");
            Console.WriteLine("2. Robot Type B");
            Console.WriteLine("3. Robot Type C");
            string selection = "";
            bool menuUp = true;
            while (menuUp)
            {
                string userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "1":
                        selection = "Type A";
                        menuUp = false;
                        break;
                    case "2":
                        selection = "Type B";
                        menuUp = false;
                        break;
                    case "3":
                        selection = "Type C";
                        menuUp = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
            return selection;
        }
        public static void NameMenu(Pet usersPet)
        {
            Console.Clear();
            Console.WriteLine("What would you like to name your pet?");
            usersPet.Name = Console.ReadLine();
        }
        public static string NameMenu()
        {
            Console.Clear();
            Console.WriteLine("What would you like to name your pet?");
            string name = Console.ReadLine();
            return name;
        }
        public static void Main()
        {
            bool menuUp = true;
            while (menuUp)
            {
                Console.Clear();
                //Panther roar sound
                //panther image
                Console.WriteLine("\n");
                Shelter.DisplayShelter();
                Console.WriteLine("\n\n");

                Console.WriteLine("1. Rename a pet");
                Console.WriteLine("2. Interact with your pets");
                Console.WriteLine("3. Adopt a pet");
                Console.WriteLine("4. Remove a pet");
                Console.WriteLine("5. Earn some money");
                Console.WriteLine("6. Exit");
                Console.SetCursorPosition(0, 8);

                System.Timers.Timer activeDisplay = new(6000);
                activeDisplay.Start();
                activeDisplay.Elapsed += ActiveDisplay_Elapsed; 
                void ActiveDisplay_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
                {
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("\n");
                    Shelter.DisplayShelter();
                    Console.WriteLine("\n\n");
                    Console.SetCursorPosition(0, 8);
                       
                }
                string userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "1": //Rename a pet
                        if (Shelter.GetShelterSize() > 1)
                        {
                            Console.Clear();
                            Console.WriteLine("What pet do you want to rename? ");
                            int choice = Shelter.SelectPetMenu();
                            Menus.NameMenu((Pet)Shelter.GetPet(choice));
                        }
                        else
                        {
                            Menus.NameMenu((Pet)Shelter.GetPet(1));
                        }
                        break;
                    case "2":
                        Menus.EarnMoneyMenu();
                        break;
                    case "3":  //Adopt a pet
                        if (Shelter.GetShelterSize() <= 4)
                        {
                            Console.Clear();
                            //Organic or Robotic?
                            string type = Menus.OrganicOrRoboticMenu();

                            //Go to Job Menu or Species menu depending on if robotic or organic.
                            string subType = "";
                            if (type == "Organic")
                            {
                                subType = Menus.SpeciesMenu();
                            }
                            else if (type == "Robotic")
                            {
                                subType = Menus.RobotTypeMenu();
                            }
                            else { subType = ""; }

                            //Name Pet
                            string name = Menus.NameMenu();

                            Shelter.AddOrganicPet(name, subType);
                            Menus.Main();
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Shelter capacity reached. Please remove a pet before adding anymore.");
                            Console.WriteLine("\nPress any key to go back to the main menu...");
                            Console.ReadKey();
                        }
                        break;
                    case "4": //remove a pet
                        if (Shelter.GetShelterSize() > 1)
                        {
                            Console.Clear();
                            Console.WriteLine("Which Pet do you wish to remove?");
                            int selection = Shelter.SelectPetMenu();
                            Shelter.RemovePetFromShelter((Pet)Shelter.GetPet(selection));
                        }
                        else 
                        { 
                            Console.Clear();
                            Console.WriteLine("Cannot remove. You must have at least one pet in the shelter.");
                            Console.WriteLine("\nPress any key to go back to the main menu...");
                            Console.ReadKey();
                        }
                        break;
                    case "5":
                        Menus.EarnMoneyMenu();
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }
        public static void FeedMenu(Pet usersPet)
        {
            Console.Clear();
            
            Console.WriteLine("{0} has eaten!", usersPet.Name);
            Console.WriteLine("Boredom Level has decreased by 10!");
            int prevHungerLevel = usersPet.Hunger;
            usersPet.Feed();
            Console.WriteLine(prevHungerLevel + "  >>>  " + usersPet.Hunger);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(); 
        }
        public static void PlayMenu(Pet usersPet)
        {
            Console.Clear();
            Console.WriteLine("You played with {0}!", usersPet.Name);
            Console.WriteLine("Hunger Level has decreased by 10!");
            int prevBoredomLevel = usersPet.Boredom;
            usersPet.Play();
            Console.WriteLine(prevBoredomLevel + "  >>>  " + usersPet.Boredom);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        public static void EarnMoneyMenu()
        {
            Console.Clear();
            Console.WriteLine("This function is still a WIP. \n");
            //Console.WriteLine("{0} has eaten!", usersPet.Name);
            //Console.WriteLine("You earned $0!");
            //int moneyLevel = 0;
            //usersPet.Feed();
            //Console.WriteLine(prevHungerLevel + "  >>>  " + usersPet.Hunger);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}