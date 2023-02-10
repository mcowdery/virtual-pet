﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using template_csharp_virtual_pet;
using System.Media;

/*if (OperatingSystem.IsWindows())
{
    SoundPlayer BgMusic = new SoundPlayer("backgroundMusic.wav");
    BgMusic.Load();
    BgMusic.PlayLooping();
}*/



bool menuUp = true;
while (menuUp)
{

    //Initial Set up
    Console.SetWindowSize(120, 35);
    Console.ForegroundColor = ConsoleColor.White;
    Console.CursorVisible = false;
    //Console.BackgroundColor = ConsoleColor.DarkGray;
    Menus.IntroMenu();

    //Organic or Robotic?
    string type = Menus.OrganicOrRoboticMenu();

    //Go to Job Menu or Species menu depending on if robotic or organic.
    string subType = "";
    if (type == "Organic")
    {
        subType = Menus.SpeciesMenu();
    }
    else if (type == "Robotic")
    {
        subType = Menus.RobotTypeMenu();
    }
    else { subType = ""; }

    string name = Menus.NameMenu();

    //Add pet to shelter
    if (type == "Organic")
    { Shelter.AddOrganicPet(name, subType); }
    else if (type == "Robotic")
    { Shelter.AddRoboticPet(name, subType); }
    else
    { Console.WriteLine("ERROR: type not set correctly in Program.cs"); }

    //Start the main menu using the new pet just created
    Menus.MainMenu();
}



