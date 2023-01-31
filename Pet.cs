using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace menuOption;


public class Pet
{
    private string name;
    private string species;
    private int health;
    private int hunger;
    private int boredom;

    public string Name { get; set; }
    public string Species { get; set; }
    public int Health { get; set; }
    public int Hunger { get; set; }
    public int Boredom { get; set; }


    public Pet(string name, string species, int health, int hunger, int boredom)
    {
        Name = name;
        Species = species;
        Health = health;
        Hunger = hunger;
        Boredom = boredom;
    }

    public void PickLionSpecies(Pet usersPet)
    {

        bool menuUp = true;
        while (menuUp)
        {
            Console.Clear();
            Species = "Lion";

            //lion roar sound
            //lion image


            Console.WriteLine("THE LION IS A MIGHTY ANIMAL\n");
            Console.WriteLine("Choose from the options below.\nStart by giving your Lion a name.\n\n");


            Console.WriteLine("1. Name your Lion");
            Console.WriteLine("2. Feed " + Name);
            Console.WriteLine("3. Play with " + Name);
            Console.WriteLine("4. See how your " + Species + " is doing");
            Console.WriteLine("5. exit");
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    usersPet.NamePet();
                    break;
                case "2":
                    usersPet.Feed();
                    break;
                case "3":
                    usersPet.Play();
                    break;
                case "4":
                    usersPet.DisplayStatus();
                    break;
                case "5":
                    Name = "";
                    Species = "";
                    menuUp = false;
                    break;
            }

        }

    }




    public void PickTigerSpecies(Pet usersPet)
    {


        bool menuUp = true;
        while (menuUp)
        {

            Console.Clear();
            Species = "Tiger";

            //Tiger roar sound
            //tiger image


            Console.WriteLine("THE TIGER IS A MIGHTY ANIMAL\n");
            Console.WriteLine("Choose from the options below.\nStart by giving your Tiger a name.\n\n");


            Console.WriteLine("1. Name your Tiger");
            Console.WriteLine("2. Feed " + Name);
            Console.WriteLine("3. Play with " + Name);
            Console.WriteLine("4. See how your " + Species + " is doing");
            Console.WriteLine("5. exit");
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    usersPet.NamePet();
                    break;
                case "2":
                    usersPet.Feed();
                    break;
                case "3":
                    usersPet.Play();
                    break;
                case "4":
                    usersPet.DisplayStatus();
                    break;
                case "5":
                    Name = "";
                    Species = "";
                    menuUp = false;
                    break;
            }
        }

    }



    public void PickPantherSpecies(Pet usersPet)
    {

        bool menuUp = true;
        while (menuUp)
        {

            Console.Clear();
            Species = "Panther";

            //Panther roar sound
            //panther image

            Console.WriteLine("THE PANTHER IS A MIGHTY ANIMAL\n");
            Console.WriteLine("Choose from the options below.\nStart by giving your Panther a name.\n\n");


            Console.WriteLine("1. Name your Panther");
            Console.WriteLine("2. Feed " + Name);
            Console.WriteLine("3. Play with " + Name);
            Console.WriteLine("4. See how your " + Species + " is doing");
            Console.WriteLine("5. exit");
            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    usersPet.NamePet();
                    break;
                case "2":
                    usersPet.Feed();
                    break;
                case "3":
                    usersPet.Play();
                    break;
                case "4":
                    usersPet.DisplayStatus();
                    break;
                case "5":
                    Name = "";
                    Species = "";
                    menuUp = false;
                    break;
            }
        }
    }



    public void NamePet()
    {
        Console.Clear();
        Console.WriteLine("What would you like to name your " + Species + "?");
        Name = Console.ReadLine();
    }


    public void Feed()
    {
        //Feed animation
        Hunger -= 10;
        //purr sound
    }


    public void Play()
    {
        Boredom -= 10;
        Hunger += 2;
        Health -= 2;

    }


    public void SeeDoctor()
    {
        Console.WriteLine("Take your pet to the doctor");
        Health += 10;
        //Stethiscope image
    }


    public void DisplayStatus()
    {
        Console.Clear();
        Console.WriteLine(Name + " The " + Species + ":");
        Console.WriteLine("Health - " + Health + "\n" + "Hunger - " + Hunger + "\n" + "Boredom - " + Boredom);
        Console.ReadKey();
    }


    public void Tick()
    {
        Boredom += 10;
        Hunger += 10;
        Health -= 10;
    }

}


