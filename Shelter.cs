using System;
using System.Collections.Generic;
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
        public static List<Pet> PetShelter { get; set; }

        public static string GetPetName(int selection) { return petShelter[selection].Name; }
        public static string GetPetSpecies(int selection) { return petShelter[selection].Species;}
        public static object GetPet(int selection) { return petShelter[selection-1]; }
        public static int GetShelterSize() { return petShelter.Count; }
        public static int SelectPetMenu()
        {
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
                    selection = Convert.ToInt32(Console.ReadLine());
                    if (selection >= 0 && selection <= count - 1)
                    { return selection; }
                    else
                    { Console.WriteLine("Invalid input"); }
                }
            }
            else
            {
                return 0;
            }
        }
        public static void DisplayOrganic(int shelterNum)
        {
            shelterNum--;//Decrement so that 
            //switch ()
            string paddedName1;
            string paddedSpecies1;

            paddedName1 = petShelter[0].PaddedName();
            paddedSpecies1 = petShelter[0].PaddedSpecies();

            Console.WriteLine(String.Format($"|  Name{paddedName1,5}  |  "));
            Console.WriteLine(String.Format($"|  Species{paddedSpecies1,5}  |  "));
            Console.WriteLine(String.Format($"|  Health   {petShelter[0].Health,9}  |  "));
            Console.WriteLine(String.Format($"|  Hunger   {petShelter[0].Hunger,9}  |  "));
            Console.WriteLine(String.Format($"|  Boredom   {petShelter[0].Boredom,8}  |  "));
        }
        public static void DisplayShelter()
        {
            string paddedName1;
            string paddedName2;
            string paddedName3;
            string paddedName4;
            string paddedName5;
            string paddedSpecies1;
            string paddedSpecies2;
            string paddedSpecies3;
            string paddedSpecies4;
            string paddedSpecies5;

            switch (petShelter.Count)
            {
                case 1:
                    paddedName1 = petShelter[0].PaddedName();
                    paddedSpecies1 = petShelter[0].PaddedSpecies();

                    string subType = "";
                    if (petShelter[0].Type == "Robotic")
                    { subType = "R.Type "; }
                    else if (petShelter[0].Type == "Organic") { subType = "Species"; }
                    else { subType = "ERROR"; }

                    Console.WriteLine(String.Format($"|  Name{paddedName1,5}  |  "));
                    Console.WriteLine(String.Format($"|  Type   {petShelter[0].Type,11}  |  "));
                    Console.WriteLine(String.Format($"|  {subType}{paddedSpecies1,5}  |  "));
                    Console.WriteLine(String.Format($"|  Health   {petShelter[0].Health,9}  |  "));
                    Console.WriteLine(String.Format($"|  Hunger   {petShelter[0].Hunger,9}  |  "));
                    Console.WriteLine(String.Format($"|  Boredom   {petShelter[0].Boredom,8}  |  "));
                    break;
                case 2:
                    paddedName1 = petShelter[0].PaddedName();
                    paddedName2 = petShelter[1].PaddedName();
                    paddedSpecies1 = petShelter[0].PaddedSpecies();
                    paddedSpecies2 = petShelter[1].PaddedSpecies();

                    Console.WriteLine(String.Format(
                        $"|  Name{paddedName1,5}  |  " +
                        $"Name{paddedName2,5}  |  "));
                    Console.WriteLine(String.Format(
                        $"|  Species{paddedSpecies1,5}  |  " +
                        $"Species{paddedSpecies2,5}  |  "));
                    Console.WriteLine(String.Format(
                        $"|  Health   {petShelter[0].Health,9}  |  " +
                        $"Health   {petShelter[1].Health,9}  |  "));
                    Console.WriteLine(String.Format(
                        $"|  Hunger   {petShelter[0].Hunger,9}  |  " +
                        $"Hunger   {petShelter[1].Hunger,9}  |  "));
                    Console.WriteLine(String.Format(
                        $"|  Boredom   {petShelter[0].Boredom,8}  |  " +
                        $"Boredom   {petShelter[1].Boredom,8}  |  "));
                    break;
                case 3:
                    paddedName1 = petShelter[0].PaddedName();
                    paddedName2 = petShelter[1].PaddedName();
                    paddedName3 = petShelter[2].PaddedName();

                    paddedSpecies1 = petShelter[0].PaddedSpecies();
                    paddedSpecies2 = petShelter[1].PaddedSpecies();
                    paddedSpecies3 = petShelter[2].PaddedSpecies();

                    Console.WriteLine(String.Format(
                        $"|  Name{paddedName1,5}  |  " +
                        $"Name{paddedName2,5}  |  " +
                        $"Name{paddedName3,5}  |  "));
                    Console.WriteLine(String.Format(
                        $"|  Species{paddedSpecies1,5}  |  " +
                        $"Species{paddedSpecies2,5}  |  " +
                        $"Species{paddedSpecies3,5}  |  "));
                    Console.WriteLine(String.Format(
                        $"|  Health   {petShelter[0].Health,9}  |  " +
                        $"Health   {petShelter[1].Health,9}  |  " +
                        $"Health   {petShelter[2].Health,9}  |  "));
                    Console.WriteLine(String.Format(
                        $"|  Hunger   {petShelter[0].Hunger,9}  |  " +
                        $"Hunger   {petShelter[1].Hunger,9}  |  " +
                        $"Hunger   {petShelter[2].Hunger,9}  |  "));
                    Console.WriteLine(String.Format(
                        $"|  Boredom   {petShelter[0].Boredom,8}  |  " +
                        $"Boredom   {petShelter[1].Boredom,8}  |  " +
                        $"Boredom   {petShelter[2].Boredom,8}  |  "));
                    break;
                case 4:
                    paddedName1 = petShelter[0].PaddedName();
                    paddedName2 = petShelter[1].PaddedName();
                    paddedName3 = petShelter[2].PaddedName();
                    paddedName4 = petShelter[3].PaddedName();

                    paddedSpecies1 = petShelter[0].PaddedSpecies();
                    paddedSpecies2 = petShelter[1].PaddedSpecies();
                    paddedSpecies3 = petShelter[2].PaddedSpecies();
                    paddedSpecies4 = petShelter[3].PaddedSpecies();

                    Console.WriteLine(String.Format(
                        $"|  Name{paddedName1,5}  |  " +
                        $"Name{paddedName2,5}  |  " +
                        $"Name{paddedName3,5}  |  " +
                        $"Name{paddedName4,5}  |  "));
                    Console.WriteLine(String.Format(
                        $"|  Species{paddedSpecies1,5}  |  " +
                        $"Species{paddedSpecies2,5}  |  " +
                        $"Species{paddedSpecies3,5}  |  " +
                        $"Species{paddedSpecies4,5}  |  "));
                    Console.WriteLine(String.Format(
                        $"|  Health   {petShelter[0].Health,9}  |  " +
                        $"Health   {petShelter[1].Health,9}  |  " +
                        $"Health   {petShelter[2].Health,9}  |  " +
                        $"Health   {petShelter[3].Health,9}  |  "));
                    Console.WriteLine(String.Format(
                        $"|  Hunger   {petShelter[0].Hunger,9}  |  " +
                        $"Hunger   {petShelter[1].Hunger,9}  |  " +
                        $"Hunger   {petShelter[2].Hunger,9}  |  " +
                        $"Hunger   {petShelter[3].Hunger,9}  |  "));
                    Console.WriteLine(String.Format(
                        $"|  Boredom   {petShelter[0].Boredom,8}  |  " +
                        $"Boredom   {petShelter[1].Boredom,8}  |  " +
                        $"Boredom   {petShelter[2].Boredom,8}  |  " +
                        $"Boredom   {petShelter[3].Boredom,8}  |  "));
                    break;
                case 5:
                    paddedName1 = petShelter[0].PaddedName();
                    paddedName2 = petShelter[1].PaddedName();
                    paddedName3 = petShelter[2].PaddedName();
                    paddedName4 = petShelter[3].PaddedName();
                    paddedName5 = petShelter[4].PaddedName();

                    paddedSpecies1 = petShelter[0].PaddedSpecies();
                    paddedSpecies2 = petShelter[1].PaddedSpecies();
                    paddedSpecies3 = petShelter[2].PaddedSpecies();
                    paddedSpecies4 = petShelter[3].PaddedSpecies();
                    paddedSpecies5 = petShelter[4].PaddedSpecies();

                    Console.WriteLine(String.Format(
                        $"|  Name{paddedName1,5}  |  " +
                        $"Name{paddedName2,5}  |  " +
                        $"Name{paddedName3,5}  |  " +
                        $"Name{paddedName4,5}  |  " +
                        $"Name{paddedName5,5}  |"));
                    Console.WriteLine(String.Format(
                        $"|  Species{paddedSpecies1,5}  |  " +
                        $"Species{paddedSpecies2,5}  |  " +
                        $"Species{paddedSpecies3,5}  |  " +
                        $"Species{paddedSpecies4,5}  |  " +
                        $"Species{paddedSpecies5,5}  |"));
                    Console.WriteLine(String.Format(
                        $"|  Health   {petShelter[0].Health,9}  |  " +
                        $"Health   {petShelter[1].Health,9}  |  " +
                        $"Health   {petShelter[2].Health,9}  |  " +
                        $"Health   {petShelter[3].Health,9}  |  " +
                        $"Health   {petShelter[4].Health,9}  |  "));
                    Console.WriteLine(String.Format(
                        $"|  Hunger   {petShelter[0].Hunger,9}  |  " +
                        $"Hunger   {petShelter[1].Hunger,9}  |  " +
                        $"Hunger   {petShelter[2].Hunger,9}  |  " +
                        $"Hunger   {petShelter[3].Hunger,9}  |  " +
                        $"Hunger   {petShelter[4].Hunger,9}  |  "));
                    Console.WriteLine(String.Format(
                        $"|  Boredom   {petShelter[0].Boredom,8}  |  " +
                        $"Boredom   {petShelter[1].Boredom,8}  |  " +
                        $"Boredom   {petShelter[2].Boredom,8}  |  " +
                        $"Boredom   {petShelter[3].Boredom,8}  |  " +
                        $"Boredom   {petShelter[4].Boredom,8}  |  "));
                    break;
                default:
                    break;
            }
        }
        public static void SelectPetSubMenu()
        {
            int count=1;
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
        public static void FeedPetInShelter (Pet petName)
        {
            int search = petShelter.IndexOf(petName);
            //Feed animation
            petShelter[search].Hunger -= 10;
            //purr sound
        }
    }
}
