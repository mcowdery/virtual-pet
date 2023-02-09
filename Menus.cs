﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Channels;
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

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
        public static string OrganicOrRoboticMenu()
        {
            Console.Clear();
            Console.WriteLine("Do you want a robotic or organic pet?\n");
            Console.WriteLine("1. Organic");
            Console.WriteLine("2. Robotic");
            string selection = "";
            bool menuUp = true;
            while (menuUp)
            {
                Console.SetCursorPosition(0, 5);
                Console.Write("\n>> ");
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
                        Console.SetCursorPosition(0, 6);
                        Console.Write("".PadRight(Console.BufferWidth) + "\r");
                        break;
                }
            }
            return selection;
        }
        public static string OrganicOrRoboticMenu2()
        {
            Console.Clear();
            Shelter.DisplayShelter();

            Console.SetCursorPosition(0, Shelter.cursorPos+3);
            Console.WriteLine("Do you want a robotic or organic pet?\n");
            Console.WriteLine("1. Organic");
            Console.WriteLine("2. Robotic");


            string selection = "";
            bool menuUp = true;
            while (menuUp)
            {
                Console.SetCursorPosition(0, Shelter.cursorPos);
                Console.Write("\n>>");
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
                        //Clears the input and then goes back to beginning of line.
                        if (Shelter.GetShelterSize() < 1) { Console.SetCursorPosition(0, Shelter.cursorPos); } //Active display 

                        Console.SetCursorPosition(0, 2);
                        Console.Write("".PadRight(Console.BufferWidth) + "\r");
                        break;
                }
            }
            return selection;
        }
    public static string SpeciesMenu()
        {
            Console.Clear();
            Console.WriteLine("What Species would you like to start with?\n");
            Console.WriteLine("1. Lion");
            Console.WriteLine("2. Tiger");
            Console.WriteLine("3. Panther");

            string selection = "";
            bool menuUp = true;
            while (menuUp)
            {
                Console.SetCursorPosition(0, 5);
                Console.Write("\n>> ");
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
                        Console.SetCursorPosition(0, 6);
                        Console.Write("".PadRight(Console.BufferWidth) + "\r");
                        break;
                }
            }
            return selection;
        }
        public static string SpeciesMenu2()
        {
            Console.Clear();
            Shelter.DisplayShelter();

            Console.SetCursorPosition(0, Shelter.cursorPos + 3);
            Console.WriteLine("What Species would you like to start with?\n");
            Console.WriteLine("1. Lion");
            Console.WriteLine("2. Tiger");
            Console.WriteLine("3. Panther");
            Console.SetCursorPosition(0, Shelter.cursorPos);

            string selection = "";
            bool menuUp = true;
            while (menuUp)
            {
                Console.Write("\n>>");
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
                        //Clears the input and then goes back to beginning of line.
                        if (Shelter.GetShelterSize() <= 1) { Console.SetCursorPosition(0, Shelter.cursorPos); } //Active display 
                        else
                        {
                            Console.CursorTop = 0;
                            Console.CursorLeft = 0;
                        }
                        Console.Write("".PadRight(Console.BufferWidth) + "\r");
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
                Console.SetCursorPosition(0, 5);
                Console.Write("\n>> ");
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
                        //Clears the input and then goes back to beginning of line.
                        Console.SetCursorPosition(0, 6);
                        Console.Write("".PadRight(Console.BufferWidth) + "\r");
                        break;
                }
            }
            return selection;
        }
        public static string RobotTypeMenu2()
        {
            Console.Clear();
            Shelter.DisplayShelter();

            Console.SetCursorPosition(0, Shelter.cursorPos + 3);
            Console.WriteLine("What Robot Type do you want?\n");
            Console.WriteLine("1. Robot Type A");
            Console.WriteLine("2. Robot Type B");
            Console.WriteLine("3. Robot Type C");
            Console.SetCursorPosition(0, Shelter.cursorPos);
            string selection = "";
            bool menuUp = true;
            while (menuUp)
            {
                Console.Write("\n>>");
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
                        //Clears the input and then goes back to beginning of line.
                        if (Shelter.GetShelterSize() <= 1) { Console.SetCursorPosition(0, Shelter.cursorPos); } //Active display 
                        else
                        {
                            Console.CursorTop = 0;
                            Console.CursorLeft = 0;
                        }
                        Console.Write("".PadRight(Console.BufferWidth) + "\r");
                        break;
                }
            }
            return selection;
        }
        public static string NameMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("What would you like to name your pet?");
                Console.SetCursorPosition(0, 5);
                Console.Write("\n>> ");
                string name = Console.ReadLine();
                if (name.Length < 12) { return name; }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\nSorry. Name must be less than 11 characters long.");
                    Console.Write("Press any key...");
                    Console.ReadKey();
                }
            }
        }
        public static void NameMenu2(Pet usersPet)
        {
            while (true)
            {
                Console.Clear();
                Shelter.DisplayShelter();

                Console.SetCursorPosition(0, Shelter.cursorPos + 3);
                Console.WriteLine("What would you like to name your pet?");
                Console.SetCursorPosition(0, Shelter.cursorPos);
                Console.Write("\n>> ");
                usersPet.Name = Console.ReadLine();
                if (usersPet.Name.Length < 12) { break; }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\nSorry. Name must be less than 11 characters long.");
                    Console.Write("Press any key...");
                    Console.ReadKey();
                }
            }
        }
        public static string NameMenu2()
        {
            while (true)
            {
                Console.Clear();
                Shelter.DisplayShelter();

                Console.SetCursorPosition(0, Shelter.cursorPos + 3);
                Console.WriteLine("What would you like to name your pet?");
                Console.SetCursorPosition(0, Shelter.cursorPos);
                Console.Write("\n>> ");
                string name = Console.ReadLine();
                if (name.Length < 12) { return name; }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\nSorry. Name must be less than 11 characters long.");
                    Console.Write("Press any key...");
                    Console.ReadKey();
                }
            }
        }
        public static void MainMenu()
        {
            var activeDisplay = ActiveDisplay.DisplayStart(); //pulling the active display from ActiveDisplay class to here
            bool menuUp = true;
            while (menuUp)
            {
                ActiveDisplay.DisplayStop((System.Timers.Timer)activeDisplay);//Pauses Active Display
                Console.Clear();

                Shelter.DisplayShelter();
                Console.SetCursorPosition(0, Shelter.cursorPos+3);
                Console.WriteLine("1. Rename a pet");
                Console.WriteLine("2. Interact with your pets");
                Console.WriteLine("3. Adopt a pet");
                Console.WriteLine("4. Remove a pet");
                Console.WriteLine("5. Earn some money");
                Console.WriteLine("6. Exit");




                Console.SetCursorPosition(0, Shelter.cursorPos);
                Console.Write("\n>> ");

                ActiveDisplay.DisplayStart((System.Timers.Timer)activeDisplay);//Starts Active Display back up
                string userChoice = Console.ReadLine();
                ActiveDisplay.DisplayStop((System.Timers.Timer)activeDisplay);//Pauses Display during input


                switch (userChoice)
                {
                    case "1": //Rename a pet
                        if (Shelter.GetShelterSize() > 1)
                        {
                            ActiveDisplay.DisplayStop((System.Timers.Timer)activeDisplay);//Pauses Active Display
                            Console.Clear();
                            Shelter.DisplayShelter();//Static display
                            Console.WriteLine("What pet do you want to rename? ");
                            Console.SetCursorPosition(0, Shelter.cursorPos);
                            int choice = Shelter.SelectPetMenu();
                            Menus.NameMenu2((Pet)Shelter.GetPet(choice));
                        }
                        else
                        {
                            ActiveDisplay.DisplayStop((System.Timers.Timer)activeDisplay);//Pauses Active Display
                            Menus.NameMenu2((Pet)Shelter.GetPet(1));
                        }
                        break;
                    case "2":
                        InteractMenu();
                        break;
                    case "3":  //Adopt a pet
                        if (Shelter.GetShelterSize() <= 4)
                        {
                            ActiveDisplay.DisplayStop((System.Timers.Timer)activeDisplay);//Pauses Active Display
                            Console.Clear();
                            //Organic or Robotic?
                            string type = Menus.OrganicOrRoboticMenu2();

                            //Go to Job Menu or Species menu depending on if robotic or organic.
                            string subType = "";
                            if (type == "Organic")
                            {
                                subType = Menus.SpeciesMenu2();
                                //Name Pet
                                ActiveDisplay.DisplayStop((System.Timers.Timer)activeDisplay);//Pauses Active Display
                                string name = Menus.NameMenu2();
                                //Add to shelter
                                Shelter.AddOrganicPet(name, subType);
                            }
                            else if (type == "Robotic")
                            {
                                subType = Menus.RobotTypeMenu2();
                                //Name Pet
                                ActiveDisplay.DisplayStop((System.Timers.Timer)activeDisplay);//Pauses Active Display
                                string name = Menus.NameMenu2();
                                //Add to shelter
                                Shelter.AddRoboticPet(name, subType);
                            }
                            else { subType = ""; }




                            Menus.MainMenu();
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            Shelter.DisplayShelter();//Static display
                            Console.WriteLine("Shelter capacity reached. Please remove a pet before adding anymore.");
                            Console.WriteLine("\nPress any key to go back to the main menu...");
                            Console.SetCursorPosition(0, Shelter.cursorPos);
                            Console.ReadKey();
                        }
                        break;
                    case "4": //remove a pet
                        if (Shelter.GetShelterSize() > 1)
                        {
                            Console.Clear();
                            Shelter.DisplayShelter();//Active display
                            Console.WriteLine("Which Pet do you wish to remove?");
                            Console.SetCursorPosition(0, Shelter.cursorPos);
                            int selection = Shelter.SelectPetMenu();
                            Shelter.RemovePetFromShelter((Pet)Shelter.GetPet(selection));
                        }
                        else
                        {
                            Console.Clear();
                            Shelter.DisplayShelter();
                            Console.WriteLine("Cannot remove. You must have at least one pet in the shelter.");
                            Console.WriteLine("\nPress any key to go back to the main menu...");
                            Console.SetCursorPosition(0, Shelter.cursorPos);
                            Console.ReadKey();
                        }
                        break;
                    case "5":
                        Pet pet = (Pet)Shelter.GetPet(1);
                        pet.SetStatus("Working");
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                    case "7":
                        Menus.DebugMenu();
                        break;
                    default:
                        Console.Clear();
                        Shelter.DisplayShelter();//Active display
                        Console.SetCursorPosition(0, Shelter.cursorPos);
                        //Console.WriteLine("Invalid Input");
                        Console.SetCursorPosition(0, Shelter.cursorPos);
                        Console.Write("".PadRight(Console.BufferWidth) + "\r");
                        break;
                }
            ActiveDisplay.DisplayStart((System.Timers.Timer)activeDisplay);//Pauses Display during input
            }
        }
        public static void FeedMenu(Pet usersPet)
        {
            Console.Clear();

            Shelter.DisplayShelter();//Active display

            Console.WriteLine("{0} has eaten!", usersPet.Name);
            Console.WriteLine("Boredom Level has decreased by 10!");
            int prevHungerLevel = usersPet.Hunger;
            usersPet.Feed();
            Console.WriteLine(prevHungerLevel + "  >>>  " + usersPet.Hunger);
            Console.WriteLine("Press any key to continue...");
            Console.SetCursorPosition(0, Shelter.cursorPos);
            Console.ReadKey();
        }
        public static void PlayMenu(Pet usersPet)
        {
            Console.Clear();
            Shelter.DisplayShelter();//Active display
            Console.WriteLine("You played with {0}!", usersPet.Name);
            Console.WriteLine("Hunger Level has decreased by 10!");
            int prevBoredomLevel = usersPet.Boredom;
            usersPet.Play();
            Console.WriteLine(prevBoredomLevel + "  >>>  " + usersPet.Boredom);
            Console.WriteLine("Press any key to continue...");
            Console.SetCursorPosition(0, Shelter.cursorPos);
            Console.ReadKey();
        }
        public static void EarnMoneyMenu()
        {
            Console.Clear();
            Shelter.DisplayShelter();
            Console.WriteLine("This function is still a WIP. \n");
            //Console.WriteLine("{0} has eaten!", usersPet.Name);
            //Console.WriteLine("You earned $0!");
            //int moneyLevel = 0;
            //usersPet.Feed();
            //Console.WriteLine(prevHungerLevel + "  >>>  " + usersPet.Hunger);
            Console.WriteLine("Press any key to continue...");
            Console.SetCursorPosition(0, Shelter.cursorPos); //Active displayy
            Console.ReadKey();
        }
        public static void InteractMenu()
        {
            Console.Clear();
            Shelter.DisplayShelter();//Active display

            Console.SetCursorPosition(0, Shelter.cursorPos + 3);
            Console.WriteLine("1. Interact with all pets");
            Console.WriteLine("2. Choose one pet");
            Console.SetCursorPosition(0, Shelter.cursorPos);
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
                    //Clears the input and then goes back to beginning of line.
                    Console.SetCursorPosition(0, Shelter.cursorPos);
                    Console.Write("".PadRight(Console.BufferWidth) + "\r");
                    break;
            }
        }

        public static void DebugMenu()
        {
            Console.Clear();
            Console.SetCursorPosition(0, Shelter.cursorPos+3);
            Console.WriteLine("What would you like to debug?");
            Console.WriteLine("1. Kill a pet");
            Console.WriteLine("2. Max out shelter");
            Console.WriteLine("3. Set conditions, moods, etc");
            Console.WriteLine("4. Credit page : Hear from the creators of Virtual Pet: Pocket Universe of madness");
            Console.WriteLine("5. Return to main menu");
            Console.WriteLine("\n");

            string userchoice = Console.ReadLine();

            switch (userchoice)
            {
                case "1":
                    Console.SetCursorPosition(0, Shelter.cursorPos);
                    int choice = Shelter.SelectPetMenu();
                    if (Shelter.GetShelterSize() < 2) { choice = 1; } 
                    Pet pet = (Pet)Shelter.GetPet(choice);
                    pet.SetHealth(0);
                    break;
                case "2":
                   while(Shelter.GetShelterSize() < 5)
                    {
                        Shelter.AddOrganicPet("Tim", "Parrot");
                    }
                    break;
                case "3":

                    break;
                case "4":
                    break;
                case "5":
                    break;
                default:
                    break;
            }


            Console.WriteLine("Press any key to continue...");
            Console.SetCursorPosition(0, 8); //Active displayy
            Console.ReadKey();

        }

    }
}