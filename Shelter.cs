using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public static class Shelter
    {
        private static List<Pet> petShelter = new List<Pet>();
        private static int money;
        public static int cursorPos = 14;

        public static List<Pet> PetShelter { get; set; }
        public static int Money { get; set; }
        public static int CursorPos { get; set; }

        public static string GetPetName(int selection) { return petShelter[selection].Name; }
        public static string GetPetSpecies(int selection) { return petShelter[selection].Species; }
        public static object GetPet(int selection) { return petShelter[selection - 1]; }
        public static int GetShelterSize() { return petShelter.Count; }
        public static int GetCursorPos() { return CursorPos; }
        public static int SelectPetMenu()
        {
            Console.WriteLine("\n\n");
            if (Shelter.GetShelterSize() > 1)
            {
                int selection = 0;
                while (true)
                {
                    int count = 1;
                    foreach (var pet in petShelter)
                    {
                        Console.WriteLine(count + ". " + pet.Name);
                        count++;
                    }
                    Console.SetCursorPosition(0, cursorPos);
                    try { 
                    selection = Convert.ToInt32(Console.ReadLine());

                        if (selection >= 0 && selection <= count - 1)
                        { return selection; }
                        else
                        {
                            Console.SetCursorPosition(0, cursorPos);
                            Console.Write("".PadRight(Console.BufferWidth) + "\r");
                            Console.SetCursorPosition(0, cursorPos + 3);
                        }
                        Console.SetCursorPosition(0, cursorPos);
                    }
                    catch
                    {
                        Console.SetCursorPosition(0, cursorPos);
                        Console.Write("".PadRight(Console.BufferWidth) + "\r");
                        Console.SetCursorPosition(0, cursorPos + 3);
                    }
                }
            }
            else
            {
                return 0;
            }
        }

        public static int SelectPetMenu2()
        {
            Console.WriteLine("\n\n");
            if (Shelter.GetShelterSize() > 1)
            {
                int selection = 0;
                while (true)
                {
                    Console.Clear();
                    Console.SetCursorPosition(0, cursorPos + 3);
                    int count = 1;
                    foreach (var pet in petShelter)
                    {
                       
                        Console.WriteLine(count + ". " + pet.Name);
                        count++;
                    }
                    Console.SetCursorPosition(0, cursorPos);
                    try
                    {
                        selection = Convert.ToInt32(Console.ReadLine());

                        if (selection >= 0 && selection <= count - 1)
                        { return selection; }
                        else
                        {
                            Console.SetCursorPosition(0, cursorPos);
                            Console.Clear();
                            Console.Write("".PadRight(Console.BufferWidth) + "\r");
                            Console.SetCursorPosition(0, cursorPos + 3);
                        }
                        Console.SetCursorPosition(0, cursorPos);
                    }
                    catch
                    {
                        Console.SetCursorPosition(0, cursorPos);
                        Console.Clear();
                        Console.Write("".PadRight(Console.BufferWidth) + "\r");
                        Console.SetCursorPosition(0, cursorPos + 3);
                    }
                }
            }
            else
            {
                return 0;
            }
        }
        public static void DisplaySetCursorPosition(int shelterNum, int line)
        {
            int position = 2;
            switch (line)
            {
                case 1: position = 4; break;
                case 2: position = 5; break;
                case 3: position = 6; break;
                case 4: position = 7; break;
                case 5: position = 8; break;
                case 6: position = 9; break;
                case 7: position = 10; break;
                case 8: position = 11; break;
                case 9: position = 12; break;
                case 10: position = 13; break;
            }

            shelterNum++;
            switch (shelterNum)
            {
                case 2: Console.SetCursorPosition(23, position); break;
                case 3: Console.SetCursorPosition(46, position); break;
                case 4: Console.SetCursorPosition(69, position); break;
                case 5: Console.SetCursorPosition(92, position); break;
                case 6: Console.SetCursorPosition(115, position); break;
                case 7: Console.SetCursorPosition(138, position); break;
                case 8: Console.SetCursorPosition(161, position); break;
                case 9: Console.SetCursorPosition(184, position); break;
                case 10: Console.SetCursorPosition(207, position); break;
            }
        }
        public static void DisplayOrganic(int shelterNum)
        {
            shelterNum--;//Decrement to match list position

            string paddedName = petShelter[shelterNum].PaddedName();
            string paddedSpecies = petShelter[shelterNum].PaddedSpecies();

            DisplaySetCursorPosition(shelterNum, 1);
            Console.WriteLine(String.Format($"|  Name{paddedName,5}  |  "));
            DisplaySetCursorPosition(shelterNum, 2);
            Console.WriteLine(String.Format($"|  Type   {petShelter[shelterNum].Type,11}  |  "));
            DisplaySetCursorPosition(shelterNum, 3);
            Console.WriteLine(String.Format($"|  Species{paddedSpecies,5}  |  "));
            DisplaySetCursorPosition(shelterNum, 4);
            Console.WriteLine(String.Format($"|  Health   {petShelter[shelterNum].Health,6}/60  |  "));
            DisplaySetCursorPosition(shelterNum, 5);
            Console.WriteLine(String.Format($"|  Hunger   {petShelter[shelterNum].Hunger,6}/60  |  "));
            DisplaySetCursorPosition(shelterNum, 6);
            Console.WriteLine(String.Format($"|  Boredom   {petShelter[shelterNum].Boredom,5}/60  |  "));
            DisplaySetCursorPosition(shelterNum, 7);
            Console.Write(String.Format($"|  Condition   "));
            if (petShelter[shelterNum].Condition == "Starving")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{petShelter[shelterNum].Condition.Remove(5),6}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("  | ");
            }
            else if (petShelter[shelterNum].Condition == "DEAD")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{petShelter[shelterNum].Condition,6}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("  | ");
            }
            else
            {
                Console.WriteLine(String.Format($"{petShelter[shelterNum].Condition,6}  | "));
            }

            DisplaySetCursorPosition(shelterNum, 8);
            Console.Write(String.Format($"|  Status   "));
            if (petShelter[shelterNum].Status == "DEAD")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{petShelter[shelterNum].Status,9}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("  | ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{petShelter[shelterNum].Status,9}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("  | ");
            }

            DisplaySetCursorPosition(shelterNum, 9);
            Console.WriteLine(String.Format($"|  Income   ${petShelter[shelterNum].Income,8}  |  "));
        }
        public static void DisplayRobotic(int shelterNum)
        {
            shelterNum--;//Decrement to match list position

            string paddedName = petShelter[shelterNum].PaddedName();
            string paddedSpecies = petShelter[shelterNum].PaddedSpecies();

            DisplaySetCursorPosition(shelterNum, 1);
            Console.WriteLine(String.Format($"|  Name{paddedName,5}  |  "));
            DisplaySetCursorPosition(shelterNum, 2);
            Console.WriteLine(String.Format($"|  Type   {petShelter[shelterNum].Type,11}  |  "));
            DisplaySetCursorPosition(shelterNum, 3);
            Console.WriteLine(String.Format($"|  Robot Type  {petShelter[shelterNum].Species,5}  |  "));
            DisplaySetCursorPosition(shelterNum, 4);
            Console.WriteLine(String.Format($"|  Health   {petShelter[shelterNum].Health,5}/100  |  "));
            DisplaySetCursorPosition(shelterNum, 5);
            Console.WriteLine(String.Format($"|  Battery   {petShelter[shelterNum].Hunger,4}/100  |  "));
            DisplaySetCursorPosition(shelterNum, 6);
            Console.WriteLine(String.Format($"|                      |  "));
            DisplaySetCursorPosition(shelterNum, 7);
            Console.Write(String.Format($"|  Condition   "));
            if (petShelter[shelterNum].Condition == "Starving")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{petShelter[shelterNum].Condition.Remove(5),6}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("  | ");
            }
            else if (petShelter[shelterNum].Condition == "DEAD")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{petShelter[shelterNum].Condition,6}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("  | ");
            }
            else
            {
                Console.WriteLine(String.Format($"{petShelter[shelterNum].Condition,6}  | "));
            }

            DisplaySetCursorPosition(shelterNum, 8);
            Console.Write(String.Format($"|  Status   "));
            if (petShelter[shelterNum].Status == "DEAD")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{petShelter[shelterNum].Status,9}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("  | ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{petShelter[shelterNum].Status,9}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("  | ");
            }

            DisplaySetCursorPosition(shelterNum, 9);
            Console.WriteLine(String.Format($"|  Income   ${petShelter[shelterNum].Income,8}  |  "));
        }
        public static void DisplayShelter()
        {
            DisplayWallet();
            Console.WriteLine("");
            switch (petShelter.Count)
            {
                case 1:
                    //Shelter 1
                    if (petShelter[0].Type == "Organic") { DisplayOrganic(1); }
                    else if (petShelter[0].Type == "Robotic") { DisplayRobotic(1); }
                    else { Console.WriteLine("Error"); }
                    break;
                case 2:
                    //Shelter 1
                    if (petShelter[0].Type == "Organic") { DisplayOrganic(1); }
                    else if (petShelter[0].Type == "Robotic") { DisplayRobotic(1); }
                    else { Console.WriteLine("Error"); }

                    //Shelter2 
                    if (petShelter[1].Type == "Organic") { DisplayOrganic(2); }
                    else if (petShelter[1].Type == "Robotic") { DisplayRobotic(2); }
                    else { Console.WriteLine("Error"); }

                    break;
                case 3:
                    //Shelter 1
                    if (petShelter[0].Type == "Organic") { DisplayOrganic(1); }
                    else if (petShelter[0].Type == "Robotic") { DisplayRobotic(1); }
                    else { Console.WriteLine("Error"); }

                    //Shelter2 
                    if (petShelter[1].Type == "Organic") { DisplayOrganic(2); }
                    else if (petShelter[1].Type == "Robotic") { DisplayRobotic(2); }
                    else { Console.WriteLine("Error"); }

                    //Shelter3 
                    if (petShelter[2].Type == "Organic") { DisplayOrganic(3); }
                    else if (petShelter[2].Type == "Robotic") { DisplayRobotic(3); }
                    else { Console.WriteLine("Error"); }

                    break;
                case 4:
                    //Shelter 1
                    if (petShelter[0].Type == "Organic") { DisplayOrganic(1); }
                    else if (petShelter[0].Type == "Robotic") { DisplayRobotic(1); }
                    else { Console.WriteLine("Error"); }

                    //Shelter2 
                    if (petShelter[1].Type == "Organic") { DisplayOrganic(2); }
                    else if (petShelter[1].Type == "Robotic") { DisplayRobotic(2); }
                    else { Console.WriteLine("Error"); }

                    //Shelter3 
                    if (petShelter[2].Type == "Organic") { DisplayOrganic(3); }
                    else if (petShelter[2].Type == "Robotic") { DisplayRobotic(3); }
                    else { Console.WriteLine("Error"); }

                    //Shelter4 
                    if (petShelter[3].Type == "Organic") { DisplayOrganic(4); }
                    else if (petShelter[3].Type == "Robotic") { DisplayRobotic(4); }
                    else { Console.WriteLine("Error"); }

                    break;
                case 5:
                    //Shelter 1
                    if (petShelter[0].Type == "Organic") { DisplayOrganic(1); }
                    else if (petShelter[0].Type == "Robotic") { DisplayRobotic(1); }
                    else { Console.WriteLine("Error"); }

                    //Shelter2 
                    if (petShelter[1].Type == "Organic") { DisplayOrganic(2); }
                    else if (petShelter[1].Type == "Robotic") { DisplayRobotic(2); }
                    else { Console.WriteLine("Error"); }

                    //Shelter3 
                    if (petShelter[2].Type == "Organic") { DisplayOrganic(3); }
                    else if (petShelter[2].Type == "Robotic") { DisplayRobotic(3); }
                    else { Console.WriteLine("Error"); }

                    //Shelter4 
                    if (petShelter[3].Type == "Organic") { DisplayOrganic(4); }
                    else if (petShelter[3].Type == "Robotic") { DisplayRobotic(4); }
                    else { Console.WriteLine("Error"); }

                    //Shelter5
                    if (petShelter[4].Type == "Organic") { DisplayOrganic(5); }
                    else if (petShelter[4].Type == "Robotic") { DisplayRobotic(5); }
                    else { Console.WriteLine("Error"); }

                    break;
                default:
                    break;
            }
        }
        public static void DisplayWallet()
        { Console.WriteLine("Wallet: $" + money); }

        public static void SelectPetSubMenu()
        {
            int count = 1;
            foreach (var pet in petShelter)
            {
                Console.WriteLine("{0}. {1}", count, pet.GetName());
                count++;
            }
        }
        public static void AddOrganicPet(string name, string species)
        {
            switch (petShelter.Count)
            {
                case 0:
                    OrganicPet pet1 = new OrganicPet();
                    pet1.Name = name;
                    pet1.Species = species;
                    pet1.Tick();
                    petShelter.Add(pet1);
                    break;
                case 1:
                    OrganicPet pet2 = new OrganicPet();
                    pet2.Name = name;
                    pet2.Species = species;
                    pet2.Tick();
                    petShelter.Add(pet2);
                    break;
                case 2:
                    OrganicPet pet3 = new OrganicPet();
                    pet3.Name = name;
                    pet3.Species = species;
                    pet3.Tick();
                    petShelter.Add(pet3);
                    break;
                case 3:
                    OrganicPet pet4 = new OrganicPet();
                    pet4.Name = name;
                    pet4.Species = species;
                    pet4.Tick();
                    petShelter.Add(pet4);
                    break;
                case 4:
                    OrganicPet pet5 = new OrganicPet();
                    pet5.Name = name;
                    pet5.Species = species;
                    pet5.Tick();
                    petShelter.Add(pet5);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Sorry! You can't have more than 5 pets!");
                    Console.ReadKey();
                    break;
            }
        }
        public static void AddRoboticPet(string name, string species)
        {
            switch (petShelter.Count)
            {
                case 0:
                    RoboticPet pet1 = new RoboticPet();
                    pet1.Name = name;
                    pet1.Species = species;
                    pet1.Tick();
                    petShelter.Add(pet1);
                    break;
                case 1:
                    RoboticPet pet2 = new RoboticPet();
                    pet2.Name = name;
                    pet2.Species = species;
                    pet2.Tick();
                    petShelter.Add(pet2);
                    break;
                case 2:
                    RoboticPet pet3 = new RoboticPet();
                    pet3.Name = name;
                    pet3.Species = species;
                    pet3.Tick();
                    petShelter.Add(pet3);
                    break;
                case 3:
                    RoboticPet pet4 = new RoboticPet();
                    pet4.Name = name;
                    pet4.Species = species;
                    pet4.Tick();
                    petShelter.Add(pet4);
                    break;
                case 4:
                    RoboticPet pet5 = new RoboticPet();
                    pet5.Name = name;
                    pet5.Species = species;
                    pet5.Tick();
                    petShelter.Add(pet5);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Sorry! You can't have more than 5 pets!");
                    Console.ReadKey();
                    break;
            }
        }
        public static void RemovePetFromShelter(Pet usersPet)
        {
            petShelter.Remove(usersPet);
        }
        public static void FeedPetInShelter(Pet petName)
        {
            int search = petShelter.IndexOf(petName);
            //Feed animation
            petShelter[search].Hunger -= 10;
            //purr sound
        }
        public static void interact()
        {
            Console.Clear();
            Console.WriteLine("How would you like to interact with all pets in the shelter?\n1. Feed\n2. Play\n3. See Doctor");
            var interactAll = Console.ReadLine().ToLower();
            for (int i = 0; i < petShelter.Count; i++)
            {
                if (interactAll == "1")
                {
                    petShelter[i].Feed();
                }
                else if (interactAll == "2")
                {
                    petShelter[i].Play();
                }
                else if (interactAll == "3")
                {
                    petShelter[i].SeeDoctor();
                }
                petShelter[i].DisplayStatus();
            }
            var action = "";
            if (interactAll == "1")
            {
                action = "fed";
            }
            else if (interactAll == "2")
            {
                action = "played with";
            }
            else if (interactAll == "3")
            {
                action = "visited the doctor with";
            }
            Console.Clear();
            Console.WriteLine("\nYou " + action + " all the pets");
            Console.WriteLine("\nPress enter to return to the Main Menu");
            Console.ReadLine();
        }
        public static void InteractWithOne()
        {
            Console.Clear();
            int choice = 1;
            if (GetShelterSize() > 1)
            {
                Console.WriteLine("Which pet do you want to interact with?");
                choice = SelectPetMenu();
            }
            choice--;
            Console.Clear();
            Console.WriteLine(petShelter[choice].Name + " is in the shelter\n");
            Console.WriteLine("How would you like to interact with this pet?\n1. Feed\n2. Play\n3. See Doctor");

            var interact = Console.ReadLine();
            if (interact == "1")
            {
                Console.Clear();
                petShelter[choice].Feed();
                Console.WriteLine(" You fed " + petShelter[choice].Name + " Well done!");
                Console.WriteLine("\nPress enter to return to the Main Menu");
                Console.ReadLine();
            }
            else if (interact == "2")
            {
                Console.Clear();
                petShelter[choice].Play();
                Console.WriteLine("You played with " + petShelter[choice].Name);
                Console.WriteLine("\nPress enter to return to the Main Menu");
                Console.ReadLine();
            }
            else if (interact == "3")
            {
                Console.Clear();
                petShelter[choice].SeeDoctor();
                Console.WriteLine(petShelter[choice].Name + " is extra healthy after seeing the doc");
                Console.WriteLine("\nPress enter to return to the Main Menu");
                Console.ReadLine();
            }

        }
    }
}
