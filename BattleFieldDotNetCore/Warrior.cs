using System;

namespace BattleFieldDotNetCore
{
    public class Warrior : Character
    {
        public Warrior(string name, int health, int attack, int defence) : base(name, health, attack, defence)
        {
            
        }

        public override void SayName()
        {
            Console.WriteLine($"I'm warrior. My name is {CharacterName}");
        }
    }
}
