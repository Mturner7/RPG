using System;

namespace RPG
{
    class Wizard : MagicUsingCharacter
    {
        public int SpellNumber { get; set; }

        public override void Play()
        {
            Console.WriteLine($"{Name} (Int {Intelligence} | Strength {Strength} | Magic {MagicalEnergy} | Spells {SpellNumber} )");
        }

        public Wizard(string name, int intel, int str, int magicalEnergy, int spellNumber) 
        : base(name, intel, str,  magicalEnergy)        
        {
            SpellNumber = spellNumber;
        }
    }
}
