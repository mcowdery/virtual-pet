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
                int time = 0;
                time++;
                Random rnd = new Random();
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
                if (time % rnd.Next(10, 25) == 0)
                {
                    switch (rnd.Next(1, 4))
                    {
                        case 1:
                            SetStatus("Beeping"); break; //
                        case 2:
                            SetStatus("Breaking"); break;  //bad money starts ticking negative
                        case 3:
                            SetStatus("Updating"); break;
                        case 4:
                            SetStatus("Cleaning"); break;
                        case 5:
                            SetStatus("Hacking"); break;
                        case 6:
                            SetStatus("SDeveloping"); break;
                        case 7:
                            SetStatus("Computing"); break; //exercise
                        case 8:
                            SetStatus("Rusting"); break; //bad
                        case 9:
                            SetStatus("Staring"); break;
                        case 10:
                            SetStatus("Loading"); break;
                        case 11:
                            SetStatus("Working"); break;
                        case 12:
                            SetStatus("Planning"); break;
                        case 13:
                            SetStatus("Googling"); break;
                        case 14:
                            SetStatus("Protecting"); break;
                        case 15:
                            SetStatus("Broadcasting"); break; //casting podcasting
                        case 16:
                            SetStatus("Erroring"); break;
                        case 17:
                            SetStatus("Merging"); break;
                        case 18:
                            SetStatus("Git Add..."); break;
                        case 19:
                            SetStatus("Git Commit..."); break;
                        case 20:
                            SetStatus("Git Push..."); break;
                    }
                }
            }
        }
    }
}
