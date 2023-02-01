using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public class Pet
    {
        private string name = "";
        private string species = "";
        private int health = 60;
        private int hunger = 60;
        private int boredom = 60;

        public string Name { get; set; }
        public string Species { get; set; }
        public int Health { get; set; }
        public int Hunger { get; set; }
        public int Boredom { get; set; }

        public Pet()
        {
            Name = name;
            Species = species;
            Health = health;
            Hunger = hunger;
            Boredom = boredom;
        }
        public void Feed()
        {
            //Feed animation
            Hunger -= 10;
            //purr sound
        }
        public string GetName(){ return Name; }
        public string GetSpecies() { return Species; }
        public int GetHealth(){ return Health; }
        public int GetHunger(){ return Hunger; }
        public int GetBoredom(){ return Boredom; }
        public void Play()
        {
            Boredom -= 20;
            Hunger += 10;
            Health += 10;
        }
        public void SeeDoctor()
        {
            Console.WriteLine("Take your pet to the doctor");
            Health += 30;
            //Stethiscope image
        }
        public void DisplayStatus()
        {
            Console.WriteLine(Name + " The " + Species + ":");
            Console.WriteLine("Health - " + Health + "\n" + "Hunger - " + Hunger + "\n" + "Boredom - " + Boredom + "\n");
        }
        public void Tick()
        {
            Boredom += 5;
            Hunger += 5;
            Health -= 5;
        }
    }
}


