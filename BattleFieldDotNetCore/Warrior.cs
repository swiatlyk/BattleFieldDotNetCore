using System;

namespace BattleFieldDotNetCore
{
    public class Warrior
    {
         private int attackStrength;
        private int defenseStrenth;

        public Warrior(string name, int health, int attack, int defence)
        {
            this.WarriorName = name;
            this.InitHealth = health;
            this.attackStrength = attack;
            this.defenseStrenth = defence;
        }

        public void Attack(Warrior warrior)
        {
            warrior.InitHealth = warrior.InitHealth - warrior.AttackStrength + this.DefenseStrenth;
            Console.WriteLine($"{this.WarriorName} attacks {warrior.WarriorName}");
            Console.WriteLine($"{warrior.WarriorName} has {warrior.InitHealth} of life");
        }

        //Add propertys {get; set;}
        public string WarriorName { get; set; }

        public int InitHealth { get; set; }

        public int AttackStrength
        {
            get { return this.attackStrength; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Health must be bigger then 0");
                }
                this.attackStrength = value;
            }
        }

        public int DefenseStrenth
        {
            get { return this.defenseStrenth; }
            set { this.defenseStrenth = value; }
        }
        public bool Alive()
        {
                return (InitHealth > 0);
        }
    }
}
