using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public static class Menus
    {
        public static void Start(Pet myPet)
        {
            //Only plays when you first open program.
            Menus.IntroMenu(myPet);

            //Adoption is required before getting to main menu.
            Menus.TypeMenu(myPet);
        }

        public static void IntroMenu(Pet myPet)
        {
            Console.WriteLine("INTRODUCTION\n");
            Console.WriteLine("Welcome to the Virtual Pet!\n");

            Console.WriteLine("sdfsf");

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        public static void TypeMenu(Pet myPet)
        {
            Console.Clear();
            Console.WriteLine("PICK A TYPE\n");
            Console.WriteLine("What type of pet do you want to pick?\n");
            Console.WriteLine("1. Organic");
            Console.WriteLine("2. Robotic");

            while (true)
            {
                Console.Write("\n>>");
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1": Menus.SpeciesMenu(myPet); break;
                    case "2": Menus.SpeciesMenu(myPet); break;
                    default: Console.WriteLine("Invalid Selection"); break;
                }
            }
        }

        public static void SpeciesMenu(Pet myPet)
        {
            Console.Clear();
            Console.WriteLine("PICK A Species\n");
            Console.WriteLine("What species of pet do you want to pick?\n");
            Console.WriteLine("1. Lion");
            Console.WriteLine("2. Jaguar");
            Console.WriteLine("3. Tiger");

            while (true)
            {
                Console.Write("\n>>");
                string selection = Console.ReadLine();
                switch (selection)
                {
                    case "1": 
                        Menus.RenameMenu(myPet);
                        myPet.UpdateSpecies("Lion");
                        break;
                    case "2": Menus.RenameMenu(myPet);
                        myPet.UpdateSpecies("Jaguar");
                        break;
                    case "3": Menus.RenameMenu(myPet);
                        myPet.UpdateSpecies("Tiger");
                        break;
                    default: Console.WriteLine("Invalid Selection"); break;
                }
            }
        }

        public static void RenameMenu(Pet myPet)
        {
            Console.Clear();
            Console.WriteLine("NAME MENU\n");
            Console.WriteLine("Please pick a name for your pet:\n");
        }
    }
}
