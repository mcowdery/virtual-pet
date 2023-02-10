# Virtual Pets Re-Imagined
## Overview
Welcome to VirtualPet! A project by Mathew Cowdery, Adison Reddy, and Sok Eam.

## Starting the program

At the start of the program, you will be brought to the intro menu. After that you will begin making your own pet, which requires a type (Organic or Robotic), 
---- 

## How to Play
The goal of the program is to reach $100,000. But you'll have to go into debt first to get there. Each pet has a certain amount of income that ticks away.
But be careful, incomes can be negative!

A pet's income depends on their condition:

Excellent: +$20/Tick
Great: +$10/Tick
Good: +$5/Tick
Bad: -$5/Tick
Starving: -$10/Tick

You can change these conditions by properly taking care of your pet. But first, let's go over the two types of pets.

Their are two basic types of pets you can buy, organic and robotic, and you can own up to a total of five. However, they cost different amounts. An organic pet (Lion, Panther, or Tiger)
costs $20,000, while a robotic pet costs $100,000. You'll have to find out yourself why one is more expensive than the other. The goal of the game is to explore different
options!

Once you are on the main screen, you are presented with a lot of options, but you're not given much time so it's good to know before hand what each does:

 * '1': Rename your pet.
 * '2': Interact with your pet. This menu is not a necessary part of the program, but we've left it in as a legacy function for fun. It takes you to a submenu where you can do various other tasks. Many of these tasks are redundant, but we've left them in for fun.
 * '3': Adopt a pet
 * '4': Remove a pet
 * '5': Exit

 * Left and Right Arrow Keys: This won't do anything with only one pet in the shelter, but once you add more, this changes which pet is "Active", which you can you use
to feed a specific pet by pressing the appropriate key.
 * 'a': Plays with the current "Active" pet.
 * 'A': Plays with all pets, regardless of which one is "Active".
 * 's': Spanks/Disciplines your pet. 
 * 'S': Spanks/Disciplines all your pets.
 * 'd': Heals your pet with a doctor or a mechanic.
 * 'f': Feeds your pet.
 * 'F': Feeds all your pets.

The main goal of the game is that you need to be able to manage several different pets at one time to make money as fast as possible. In order to properly care for them you need to do a few different things.

First you need to spank/discipline your pet when a "Yellow" status appears by moving the "Active" cursor to the pet and pressing 's'. When you do this, it will change your pets condition
in a positive way if you are pressing it while it is yellow. If you press it during a 'green' status condition, this will negatively effect your pet. You can discipline your pet multiple times
on the same status. The condition may not change on a single time however, so it may require several disciplines before their Condition changes from good to great and so forth.

Secondly, you'll need to keep an eye on hunger levels, and boredom. You can change these values just like above but instead using the 'f' for feed and 'a' for play respectively.
Be warned, if you happen to let hunger level reach max, it will set the Condition of the Pet to "Starving" which overrides all other conditions which will start eating away at the pet's
health.

Finally, their is a hidden menu on the main menu for debugging purposes if you press the '7' key. From here, you can do things like kill a pet or max out your pet shelter. 

Issues and Lessons learned:
* We think we didn't quite hit a lot of our goals as we increased the scope of oiur project a little too much which caused the final project to have some unresolved issues. If we had cut out more things we could have made the final product a little nicer and less buggy.
* The display bugs out on occasion, but we decided it was in a good enough state and took too much time to completely fix it, as we neared the finish line. The most likely reason for this probably has to do with using multiple timers we believe, but we aren't entirely sure. We might try to work on it again at a later time.
* Communicating with the instructors/clients more with any changes we might have to the requirements, or sticking closer to the original requirements. We changed the Tick class to have a timer function which was not allowed. Although we recognized this was different thant the

