using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class GameCharacter
    {
        public int Strength { get; set; }

        public int Intelligence { get; set; }

        public string Name { get; set; }
        


        public virtual void Play() { }

        public GameCharacter(string name, int intelligence, int strength) 
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
        }
    }
}
