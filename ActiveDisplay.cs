﻿using System;
namespace template_csharp_virtual_pet
{
	public class ActiveDisplay
	{
		public static void DisplayStart()
		{
            
            System.Timers.Timer activeDisplay = new(10000);
            activeDisplay.Start();
            activeDisplay.Elapsed += ActiveDisplay_Elapsed;
            void ActiveDisplay_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("\n");
                Shelter.DisplayShelter();
                Console.WriteLine("\n\n");
                Console.SetCursorPosition(0, 8);

            }

        }

        public void DisplayStop(System.Timers.Timer activeDisplay)
        {
           activeDisplay.Stop();
        }


        public static void StopTick(System.Timers.Timer tick)
        {
            tick.Stop();
        }

        public static void StartTick(System.Timers.Timer tick)
        {
            tick.Start();
        }

	}
}

