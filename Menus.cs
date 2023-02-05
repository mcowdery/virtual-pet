﻿using System;
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
            Console.WriteLine("WELCOME TO MAS CODE'S\n");
            Console.WriteLine(@"                _________ _______ _________          _______  _             _______  _______ _________  ");
            Console.WriteLine(@"       |\     /|\__   __/(  ____ )\__   __/|\     /|(  ___  )( \           (  ____ )(  ____ \\__   ___| ");
            Console.WriteLine(@"       | )   ( |   ) (   | (    )|   ) (   | )   ( || (   ) || (           | (    )|| (    \/   ) (     ");
            Console.WriteLine(@"       | |   | |   | |   | (____)|   | |   | |   | || (___) || |           | (____)|| (__       | |     ");
            Console.WriteLine(@"       ( (   ) )   | |   |     __)   | |   | |   | ||  ___  || |           |  _____)|  __)      | |     ");
            Console.WriteLine(@"       \ \_ / /    | |   | (\ (      | |   | |   | || (   ) || |           | (      | (         | |     ");
            Console.WriteLine(@"        \    /  ___) (___| ) \ \__   | |   | (___) || )   ( || (____/\     | )      | (____/\   | |     ");
            Console.WriteLine(@"         \__/   \_______/|/   \__/   )_(   (_______)|/     \|(_______/     |__|    |_________| |___|    " + "\n");
            Console.WriteLine("This pocket universe moves fast, " +
                "You will have to move fast as well to keep your new" +
                " friend alive and happy.\n");
        }
        public static string InitialChooseYourSpeciesMenu()
        {

            Console.WriteLine("What Species would you like to start with?\n");
            Console.WriteLine("1. Lion");
            Console.WriteLine("2. Tiger");
            Console.WriteLine("3. Panther");

            string selection = "";
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
        public static string SecondaryChooseYourSpeciesMenu()
        {

            Console.Clear();
            Console.WriteLine("\n");
            Shelter.DisplayShelter();//Active display
            Console.WriteLine("\n\n");
            Console.WriteLine("What Species would you like to start with?\n");
            Console.WriteLine("1. Lion");
            Console.WriteLine("2. Tiger");
            Console.WriteLine("3. Panther");
            Console.SetCursorPosition(0, 8); //Active display

            string selection = "";
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

        public static void ReNameMenu(Pet usersPet)
        {
            Console.Clear();
            Console.WriteLine("\n");
            Shelter.DisplayShelter();//Active display
            Console.WriteLine("\n\n");
            Console.WriteLine("What would you like to rename your " + usersPet.Species + "?");
            Console.SetCursorPosition(0, 8); //Active displayy

            usersPet.Name = Console.ReadLine();
        }

        public static string NameMenu()
        {
            Console.Clear();
            Console.WriteLine("What would you like to name your pet" + "?");
            string name = Console.ReadLine();
            return name;
        }

        public static string AdoptNameMenu()
        {
            Console.Clear();
            Console.WriteLine("\n");
            Shelter.DisplayShelter();//Active display
            Console.WriteLine("\n\n");
            Console.WriteLine("What would you like to name your pet" + "?");
            Console.SetCursorPosition(0, 8); //Active displayy

            string name = Console.ReadLine();
            return name;
        }

        public static void Main(Pet usersPet)
        {

            bool menuUp = true;
            while (menuUp)
            {

                int menuNumber = 1;
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
                ActiveDisplay.DisplayStart();




                string userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "1": //Rename a pet
                        if (Shelter.GetShelterSize() > 1)
                        {
                            Console.Clear();
                            Console.WriteLine("\n");
                            Shelter.DisplayShelter();//Active display
                            Console.WriteLine("\n\n");
                            Console.WriteLine("What pet do you want to rename? ");
                            Console.SetCursorPosition(0, 8);

                            int choice = Shelter.SelectPetMenu();
                            Menus.ReNameMenu((Pet)Shelter.GetPet(choice));
                            //ActiveDisplay.StopTick();

                        }
                        else
                        {
                            Menus.ReNameMenu((Pet)Shelter.GetPet(1));
                        }
                        break;
                    case "2":
                        Menus.InteractMenu();
                        break;
                    case "3":  //Adopt a pet
                        if (Shelter.GetShelterSize() <= 4)
                        {
                            Console.Clear();
                            string species = Menus.SecondaryChooseYourSpeciesMenu();
                            string name = Menus.AdoptNameMenu();
                            Shelter.AddPet(name, species);
                            Menus.Main(usersPet);
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("\n");
                            Shelter.DisplayShelter();//Active display
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Shelter capacity reached. Please remove a pet before adding anymore.");
                            Console.WriteLine("\nPress any key to go back to the main menu...");
                            Console.SetCursorPosition(0, 8);
                            Console.ReadKey();
                        }
                        break;
                    case "4": //remove a pet
                        if (Shelter.GetShelterSize() > 1)
                        {
                            Console.Clear();
                            Console.WriteLine("\n");
                            Shelter.DisplayShelter();//Active display
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Which Pet do you wish to remove?");
                            Console.SetCursorPosition(0, 8);

                            int selection = Shelter.SelectPetMenu();
                            Shelter.RemovePetFromShelter((Pet)Shelter.GetPet(selection));

                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("\n");
                            Shelter.DisplayShelter();//Active display
                            Console.WriteLine("\n\n");
                            Console.WriteLine("Cannot remove. You must have at least one pet in the shelter.");
                            Console.WriteLine("\nPress any key to go back to the main menu...");
                            Console.SetCursorPosition(0, 8);
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
                        Console.Clear();
                        Console.WriteLine("\n");
                        Shelter.DisplayShelter();//Active display
                        Console.WriteLine("\n\n");
                        Console.SetCursorPosition(0, 8);
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }
        public static void FeedMenu(Pet usersPet)
        {
            Console.Clear();
            Console.WriteLine("\n");
            Shelter.DisplayShelter();//Active display
            Console.WriteLine("\n\n");

            Console.WriteLine("{0} has eaten!", usersPet.Name);
            Console.WriteLine("Boredom Level has decreased by 10!");
            int prevHungerLevel = usersPet.Hunger;
            usersPet.Feed();
            Console.WriteLine(prevHungerLevel + "  >>>  " + usersPet.Hunger);
            Console.WriteLine("Press any key to continue...");
            Console.SetCursorPosition(0, 8);
            Console.ReadKey();
        }
        public static void PlayMenu(Pet usersPet)
        {
            Console.Clear();
            Console.WriteLine("\n");
            Shelter.DisplayShelter();//Active display
            Console.WriteLine("\n\n");
            Console.WriteLine("You played with {0}!", usersPet.Name);
            Console.WriteLine("Hunger Level has decreased by 10!");
            int prevBoredomLevel = usersPet.Boredom;
            usersPet.Play();
            Console.WriteLine(prevBoredomLevel + "  >>>  " + usersPet.Boredom);
            Console.WriteLine("Press any key to continue...");
            Console.SetCursorPosition(0, 8);
            Console.ReadKey();
        }
        public static void EarnMoneyMenu()
        {
            Console.Clear();
            Console.WriteLine("\n");
            Shelter.DisplayShelter();//Active display
            Console.WriteLine("\n\n");
            Console.WriteLine("This function is still a WIP. \n");
            //Console.WriteLine("{0} has eaten!", usersPet.Name);
            //Console.WriteLine("You earned $0!");
            //int moneyLevel = 0;
            //usersPet.Feed();
            //Console.WriteLine(prevHungerLevel + "  >>>  " + usersPet.Hunger);
            Console.WriteLine("Press any key to continue...");
            Console.SetCursorPosition(0, 8); //Active displayy
            Console.ReadKey();
        }

        public static void InteractMenu()
        {
            Console.Clear();
            Console.WriteLine("\n");
            Shelter.DisplayShelter();//Active display
            Console.WriteLine("\n\n");
            Console.WriteLine("1. Interact with all pets");
            Console.WriteLine("2. Choose one pet");
            Console.SetCursorPosition(0, 8);
            string playersChoice = Console.ReadLine();
            switch (playersChoice)
            {
                case "1":
                    Shelter.interact();
                    break;
                case "2":
                    Shelter.InteractWithOne();
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}