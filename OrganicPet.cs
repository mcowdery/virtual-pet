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
            System.Timers.Timer tick = new(5000);//instatiates new timer called tick
            tick.Start();
            tick.Elapsed += Tick_Elapsed; // says once timer is elapsed go to tick_Elapsed function
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
