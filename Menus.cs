using System;
using System.Collections.Generic;
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
        public static void ChooseYourSpeciesMenu(Pet usersPet)
        {
            Console.WriteLine("What Species would you like to start with?\n");
            Console.WriteLine("1. Lion");
            Console.WriteLine("2. Tiger");
            Console.WriteLine("3. Panther");

            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    usersPet.Species = "Lion";
                    break;
                case "2":
                    usersPet.Species = "Tiger";
                    break;
                case "3":
                    usersPet.Species = "Panther";
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
        public static void Main(Pet usersPet)
        {
            bool menuUp = true;
            while (menuUp)
            {

                Console.Clear();
                //Panther roar sound
                //panther image

                Console.WriteLine("THE {0} IS A MIGHTY ANIMAL\n", usersPet.Species.ToUpper());
                usersPet.DisplayStatus();

                //Shelter.FeedPetInShelter(usersPet);
                //string bill = String.Format("|{0,5}|{1,5}|{2,5}|{3,5}|{4,5}|", usersPet.Name, usersPet.Name, usersPet.Name, usersPet.Name, usersPet.Name);
                Console.WriteLine(String.Format("|  {0,5}  |  {1,5}  |  {2,5}  |  {3,5}  |  {4,5}  |", usersPet.Name, usersPet.Name, usersPet.Name, usersPet.Name, usersPet.Name));

                Console.WriteLine("1. Rename your " + usersPet.Species);
                Console.WriteLine("2. Feed your " + usersPet.Species);
                Console.WriteLine("3. Play with your " + usersPet.Species);
                Console.WriteLine("4. Go to shelter");
                Console.WriteLine("5. Earn some money");
                Console.WriteLine("6. exit");

                string userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "1":
                        Menus.NameMenu(usersPet);
                        break;
                    case "2":
                        Menus.FeedMenu(usersPet);
                        break;
                    case "3":
                        Menus.PlayMenu(usersPet);
                        break;
                    case "4":
                        Menus.ShelterMenu(usersPet);
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
        public static void NameMenu(Pet usersPet)
        {
            if (usersPet.Name != "") { Console.WriteLine("Current name is " + usersPet.Name); }
            Console.Clear();
            Console.WriteLine("What would you like to name your " + usersPet.Species + "?");
            usersPet.Name = Console.ReadLine();
        }
        public static void FeedMenu(Pet usersPet)
        {
            Console.Clear();
            Console.WriteLine("You played with {0}!", usersPet.Name);
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
            Console.WriteLine("{0} has eaten!", usersPet.Name);
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
        public static void ShelterMenu(Pet usersPet)
        {
            bool menuUp = true;
            while (menuUp)
            {
                Console.Clear();
                Console.WriteLine("1. Exchange {0} for another pet", usersPet.Name);
                Console.WriteLine("2. Show all your pets in shelter");
                Console.WriteLine("3. Go back");

                string userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "1":

                        //add to shelter
                        Console.Clear();
                        Shelter.AddPetToShelter(usersPet);
                        Console.WriteLine("{0} has been added to the Shelter", usersPet.Name);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();

                        //exchange for new pet
                        Console.Clear();
                        Console.WriteLine("Which pet do you wish to remove from the shelter?");
                        Shelter.SelectPetSubMenu();
                        Shelter.RemovePetFromShelter(usersPet);
                        Console.WriteLine("{0} has been removed from the Shelter", usersPet.Name);
                        Console.WriteLine("Press any key to continue...");
                        //Console.ReadKey();
                        break;
                    case "2":
                        Console.Clear();
                        Shelter.ListPetShelter();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case "3":
                        menuUp = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }
    }
}