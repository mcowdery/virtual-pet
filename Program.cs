using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using template_csharp_virtual_pet;

Pet usersPet = new Pet();

bool menuUp = true;
while (menuUp)
{
    Menus.IntroMenu();
    Menus.ChooseYourSpeciesMenu(usersPet);
    Menus.NameMenu(usersPet);
    Menus.Main(usersPet);
}

