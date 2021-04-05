using System;

namespace RPG
{
    class Warrior : GameCharacter
    {
        public string WeaponType { get; set; }

        public override void Play()
        {
            Console.WriteLine($"{Name} (Int {Intelligence} | Strength {Strength} | Weapon {WeaponType})");
        }

        public Warrior(string name, int intel, int str, string weapon) 
        : base(name, intel, str)
        {
            WeaponType = weapon;
        }
    }
}
