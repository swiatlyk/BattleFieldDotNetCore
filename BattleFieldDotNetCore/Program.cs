using System;

namespace BattleFieldDotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Battle.Start(new Warrior("Maximus", 1000, 190, 140), new Warrior("Kommodus", 1000, 180, 160));

            Console.ReadKey();
        }
    }
}
