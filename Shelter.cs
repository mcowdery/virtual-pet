using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public static class Shelter
    {
        private static List<Pet> petShelter = new List<Pet>();
        public static List<Pet> PetShelter { get; set; }
        public static void ListPetShelter()
        {
            Console.WriteLine("\nHere's a list of the pets in the shelter:\n");
            for (int i = 0; i < petShelter.Count; i++)
            {
                petShelter[i].DisplayStatus();
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
        public static void AddPetToShelter(Pet usersPet)
        {
            petShelter.Add(usersPet);
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
