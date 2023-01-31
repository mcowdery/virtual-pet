using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Pet usersPet = new Pet("", "", 60, 60, 60);

bool menuUp = true;
while (menuUp)
{
    Console.Clear();
    Console.WriteLine("WELCOME TO MAS CODE'S VIRTUAL PET\n");
    Console.WriteLine("This pocket universe moves fast, You will have to aswell to keep your new friend alive and happy.\n\n");

    Console.WriteLine("Choose from the options below to start your journey");
    Console.WriteLine("What Species would you like to start with?");
    Console.WriteLine("1. Lion");
    Console.WriteLine("2. Tiger");
    Console.WriteLine("3. Panther");
    Console.WriteLine("4. Exit");
    string userChoice = Console.ReadLine();
    switch (userChoice)
    {
        case "1":
            usersPet.PickLionSpecies(usersPet);
            break;
        case "2":
            usersPet.PickTigerSpecies(usersPet);
            break;
        case "3":
            usersPet.PickPantherSpecies(usersPet);
            break;
        case "4":
            menuUp = false;
            break;
    }
}

