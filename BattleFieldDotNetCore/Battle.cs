using System;

namespace BattleFieldDotNetCore
{
    public class Battle
    {
        public static void Start(Character character1, Character character2)
        {
            character1.SayName();
            character2.SayName();

            while (character1.Alive() && character2.Alive())
            {
                character1.Attack(character2);
                System.Console.WriteLine($"After attack {character2.CharacterName} has {character2.InitHealth} of life");
                if (character2.Alive())
                {
                    character2.Attack(character1);
                    System.Console.WriteLine($"After attack {character1.CharacterName} has {character1.InitHealth} of life");
                }
                //check if warrior is alive
                if (!character1.Alive())
                {
                    System.Console.WriteLine($"Warrior {character1.CharacterName} has died");
                }
                if (!character2.Alive())
                {
                    System.Console.WriteLine($"Warrior {character2.CharacterName} has died");
                }
            }
        }
    }
}