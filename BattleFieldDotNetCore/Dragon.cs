using System;

namespace BattleFieldDotNetCore
{
    public class Dragon : Character
    {
        public Dragon(string name, int health, int attack, int defence):base(name, health, attack, defence)
        {

        }

        public override void SayName()
        {
            Console.WriteLine($"I'm dragon. My name is {CharacterName}");
        }
    }
}
