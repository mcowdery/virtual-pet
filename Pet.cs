using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public class Pet
    {
        private string name;
        private string species;
        private int healthtotal;
        private int currenthealth;
        private int hunger;
        private int boredom;

        public string Name { get; set; }
        public string Species { get; set; }
        public int HealthTotal { get; set; }
        public int CurrentHealth { get; set; }
        public int Hunger { get; set; }
        public int Boredom { get; set; }

        public Pet(string name,string species,int healthtotal,int currenthealth,int hunger,int boredom)
        {
            Name = name;
            Species = species;
            HealthTotal = healthtotal;
            CurrentHealth = currenthealth;
            Hunger = hunger;
            Boredom = boredom;

        }

        public void FeedPet()
        {
            Hunger -= 10;
        }

        public void NamePet()
        {
            Console.WriteLine("What would you like to name your pet?");
            string petname1 = Console.ReadLine();
        }


    }


}
