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
            SetIncome(5);
        }
        public override void Tick()
        {
            int num = 0;
            System.Timers.Timer tick = new(500);//instatiates new timer called tick
            tick.Start();
            tick.Elapsed += Tick_Elapsed; // says once timer is elapsed go to tick_Elapsed function

            void Tick_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
            {

                if (GetStatus()=="Resting")
                {
                    Boredom += 1;
                    if (num%4==0)  //only increase every other tick.
                    { 
                        Hunger += 1;
                        if (Health < 60) { Health += 1; } //resting increases health a little, but not as much as starving decreases it.
                    }
                    num++;
                }
                if (GetStatus() == "Working" || GetStatus() == "Playing")
                {
                    if(Hunger < 60) { Hunger += 1; }
                    if (num % 4 == 0 && Boredom < 60)  //only increase every other tick.
                    {
                        Boredom += 1;
                    }
                    num++;
                    Shelter.AddToWallet(Income);
                }
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
