using System;

namespace BattleFieldDotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior1 = new Warrior("Maximus", 300, 190, 140);
            Dragon dragon1 = new Dragon("Smaug", 300, 190, 140);
            warrior1.SayName();
            dragon1.SayName();

            Battle.Start(warrior1, dragon1);

            //dodac nowe postacie krasnolud, elf, nekromanta....

            Console.ReadKey();
        }
    }
}
