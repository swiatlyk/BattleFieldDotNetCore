using System;

namespace BattleFieldDotNetCore
{
    public class Battle
    {
        public static void Start(Warrior warrior1, Warrior warrior2)
        {
            //implement random in fight
            while (warrior1.Alive() && warrior2.Alive())
            {
                warrior1.Attack(warrior2);
                System.Console.WriteLine($"After attack {warrior2.WarriorName} has {warrior2.InitHealth} of life");
                if (warrior2.Alive())
                {
                    warrior2.Attack(warrior1);
                    System.Console.WriteLine($"After attack {warrior1.WarriorName} has {warrior1.InitHealth} of life");
                }
                //check if warrior is alive
                if (!warrior1.Alive())
                {
                    System.Console.WriteLine($"Warrior {warrior1.WarriorName} has died");
                }
                if (!warrior2.Alive())
                {
                    System.Console.WriteLine($"Warrior {warrior2.WarriorName} has died");
                }
            }
        }
    }
}