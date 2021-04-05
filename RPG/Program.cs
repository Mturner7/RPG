using System;
using System.Collections.Generic;

namespace RPG
{
    class Program
    {
        static void PlayGame() 
        {
            List<GameCharacter> pawnsInMyWorld = new List<GameCharacter>()
            {
                new Wizard("Wocka Flocka", 100, 2, 30, 21),
                new Wizard("Sosa", 30, 31, 10, 3),
                new Warrior("Skulrg", 10, 100, "Weaponized Smallpox"),
                new Warrior("Dave", 50, 50, "Pfizer Vaccine"),
                new Warrior("Wayne 'The boulder' John", 30, 100, "Whatever he's cooking")
            };

            Console.WriteLine("Welcome to the thunderdome! Here are your contestants: \n\n");

            foreach (GameCharacter pawn in pawnsInMyWorld)
            {
                pawn.Play();
                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {
            PlayGame();
        }
    }
}
