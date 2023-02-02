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
    string species = Menus.ChooseYourSpeciesMenu();
    string name = Menus.NameMenu();
    Shelter.AddPet(name, species);
    Menus.Main((Pet)Shelter.GetPet(1));
}

