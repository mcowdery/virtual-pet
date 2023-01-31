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
        private int health;
        private int hunger;
        private int boredom;

        public string Name { get; set; }
        public string Species { get; set; }
        public int Health { get; set; }
        public int Hunger { get; set; }
        public int Boredom { get; set; }


        public Pet(string name,string species,int health, int hunger,int boredom)
        {
            Name = name;
            Species = species;
            Health = health;
            Hunger = hunger;
            Boredom = boredom;
        }


        public Pet()
        {
            Name = "";
            Species = "";
            Hunger = 60;
            Boredom = 60;
            Health = 60;
        }


        public void Feed()
        {
            Hunger -= 10;
        }


        public void NamePet()
        {
            Console.WriteLine("What would you like to name your pet?");
            string petname1 = Console.ReadLine();
        }


        public void UpdateSpecies(string speciesName)
        {
            Console.WriteLine("What would you like to name your pet?");
            Species = speciesName;
        }


        public void Play()
        {
            Console.WriteLine("Would you like to play?");
            Boredom -= 10;
            Hunger += 2;
        }


        public void SeeDoctor()
        {
            Console.WriteLine("Take your pet to the doctor");
            Health += 10;
        }


        public void DisplayStatus()
        {
            Console.WriteLine("Check on your pet!");
            Console.WriteLine(Health + Hunger + Boredom);
            Console.ReadKey();
        }


        public void Tick()
        {
            Boredom += 5;
            Hunger += 5;
        }

    }

}
