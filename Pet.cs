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

            System.Timers.Timer tick = new(5000);//instatiates new timer called tick
            tick.Start();
            tick.Elapsed += Tick_Elapsed; // says once timer is elapsed go to tick_Elapsed function
            Console.ReadLine();     //keeping console running
            void Tick_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
            {
                Boredom += 10;
                Hunger += 10;
                bool starved = false;
                bool crazyBored = false;

                if (Hunger >= 60)
                {
                    Hunger = 60;
                    starved = true;
                }

                if (Boredom >= 60)
                {
                    Boredom = 60;
                    crazyBored = true;
                }

                if (starved && crazyBored)
                {
                    Health -= 5;
                }

                if (Health <= 0)
                {
                    tick.Stop();
                    tick.Dispose();
                    Console.Clear();
                    Console.WriteLine("OOH NOOOO...." + Name + " The " + Species + " Died!!\nYou have to pay attention and move quicker next time.\nGAME OVER");
                }
            }

        }


    }
}



