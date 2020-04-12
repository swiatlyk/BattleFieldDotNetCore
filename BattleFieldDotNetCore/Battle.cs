using System;

namespace BattleFieldDotNetCore
{
    public class Battle
    {
         //correct access level
        public static void Start(Warrior warrior1, Warrior warrior2)
        {
            //implement random in fight
            while (warrior1.InitHealth > 0 && warrior2.InitHealth > 0)
            {
                if (warrior2.InitHealth > 0)
                {
                    warrior1.Attack(warrior2);
                    if (warrior1.InitHealth > 0)
                    {
                        warrior2.Attack(warrior1);
                    }
                    else
                    {

                    }
                }
                else
                {
                    Console.WriteLine($"{warrior2.WarriorName} wins!");

                }
                Console.WriteLine($"{warrior1.WarriorName} wins!");
            }


        }
    }
}