using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using template_csharp_virtual_pet;

bool menuUp = true;
while (menuUp)
{
    Menus.IntroMenu();

    //Organic or Robotic?
    string type = Menus.OrganicOrRoboticMenu();

    //Go to Job Menu or Species menu depending on if robotic or organic.
    string subType="";
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
    Shelter.AddPet(name, subType);

    //Start the main menu using the new pet just created
    Menus.Main();
}

