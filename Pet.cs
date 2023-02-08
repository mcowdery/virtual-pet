using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public class Pet
    {
        private string name = "";
        private string type = "";
        private string species = "";
        private int health = 60;
        private int hunger = 0;
        private int boredom = 0;
        private string condition = "Good";
        private string status = "Resting";
        private int income = 0;

        public string Name { get; set; }
        public string Type { get; set; }
        public string Species { get; set; }
        public int Health { get; set; }
        public int Hunger { get; set; }
        public int Boredom { get; set; }
        public string Condition { get; set; }
        public string Status { get; set; }
        public int Income { get; set; }

        public Pet()
        {
            Name = name;
            Type = type;
            Species = species;
            Health = health;
            Hunger = hunger;
            Boredom = boredom;
            Condition = condition;
            Status = status;
            Income = income;
        }
        public void SetType(string type) { Type = type; }
        public void SetHealth(int health) { Health = health; }
        public void SetHunger(int hunger) { Hunger = hunger; }
        public void SetCondition(string condition) { Condition = condition; }
        public void SetStatus(string status) { Status = status; }
        public void SetIncome(int income) { Income = income; }
        public string GetName() { return Name; }
        public string GetSpecies() { return Species; }
        public int GetHealth() { return Health; }
        public int GetHunger() { return Hunger; }
        public int GetBoredom() { return Boredom; }
        public string GetCondition() { return Condition; }
        public string GetStatus() { return Status; }

        public string PaddedName()
        {
            string PaddedName = Name;
            int namePadAmount = Name.Length + (14 - Name.Length);
            PaddedName = PaddedName.PadLeft(namePadAmount);
            return PaddedName;
        }
        public string PaddedSpecies()
        {
            string PaddedSpecies = Species;
            int namePadAmount = Species.Length + (11 - Species.Length);
            PaddedSpecies = PaddedSpecies.PadLeft(namePadAmount);
            return PaddedSpecies;
        }
        public void Feed()
        {
            //Feed animation
            Hunger -= 10;
            //purr sound
        }
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
        public virtual void Tick()
        {
            //overridden by childs
        }
    }
}



