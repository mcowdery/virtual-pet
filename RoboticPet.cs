using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace template_csharp_virtual_pet
{
    public class RoboticPet : Pet
    {
        public RoboticPet()
        {
            SetType("Robotic");
            SetHealth(100);
            SetHunger(100);
            SetStatus("Charging");
        }
        public override void Tick()
        {
            System.Timers.Timer tick = new(500);//instatiates new timer called tick
            tick.Start();
            tick.Elapsed += Tick_Elapsed; // says once timer is elapsed go to tick_Elapsed function
            void Tick_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
            {
                if (Status == "Charging" && Hunger <= 100 )
                { Hunger += 20; }
                else
                { Hunger -= 10;}
                if (Hunger < 0) { Hunger = 0; }
                if (Hunger > 100) { Hunger = 100; }
                if (Health <= 0)
                {
                    tick.Stop();
                    tick.Dispose();
                    SetStatus("BROKEN");
                    Console.Clear();
                    //Shelter.DisplayShelter();
                    Console.SetCursorPosition(0, Shelter.cursorPos);
                    Console.WriteLine("OOH NOOOO...." + Name + " The " + Species + " Died!!\nYou have to pay attention and move quicker next time.\nGAME OVER");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
