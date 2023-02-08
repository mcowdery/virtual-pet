using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public class OrganicPet : Pet
    {
        public OrganicPet()
        {
            SetType("Organic");
        }
        public override void Tick()
        {
            System.Timers.Timer tick = new(500);//instatiates new timer called tick
            tick.Start();
            tick.Elapsed += Tick_Elapsed; // says once timer is elapsed go to tick_Elapsed function
            void Tick_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
            {
                Boredom += 1;
                Hunger += 1;
                bool starved = false;
                bool crazyBored = false;

                if (Hunger >= 60)
                {
                    Hunger = 60;
                    starved = true;
                }
                else if (Hunger < 60)
                {
                    starved = false;
                    SetCondition("Good");
                }

                if (Boredom >= 60)
                {
                    Boredom = 60;
                    crazyBored = true;
                }
                else if (Boredom < 60)
                {
                    crazyBored = false;
                }

                if (starved && crazyBored)
                {
                    Health -= 5;
                    SetCondition("Starving");
                }

                if (Health <= 0)
                {
                    tick.Stop();
                    tick.Dispose();
                    SetStatus("DEAD");
                    SetCondition("DEAD");
                    Console.Clear();
                    //Shelter.DisplayShelter();
                    Console.SetCursorPosition(0, Shelter.cursorPos+3);
                    Console.WriteLine("OOH NOOOO...." + Name + " The " + Species + " Died!!\nYou have to pay attention and move quicker next time.");
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
            }
        }
    }
}
