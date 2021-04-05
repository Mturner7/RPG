using System;

namespace RPG
{
    class MagicUsingCharacter : GameCharacter
    {
        public int MagicalEnergy { get; set; }

        public override void Play()
        {
            Console.WriteLine($"{Name} (Int {Intelligence} | Strength {Strength} | Magic {MagicalEnergy})");
        }

        public MagicUsingCharacter(string name, int intel, int str, int magicalEnergy) 
        : base(name, intel, str) 
        {
            MagicalEnergy = magicalEnergy;
        }
    }
}

