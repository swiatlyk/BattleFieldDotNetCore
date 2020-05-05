using System;
using System.Collections.Generic;
using System.Text;

namespace BattleFieldDotNetCore
{
    public class Character
    {
        public int attackStrength;
        public int defenseStrenth;

        public Character(string name, int health, int attack, int defence)
        {
            this.CharacterName = name;
            this.InitHealth = health;
            this.attackStrength = attack;
            this.defenseStrenth = defence;
        }

        public void Attack(Character Character)
        {
            Character.InitHealth = Character.InitHealth - Character.AttackStrength + this.DefenseStrenth;
            if (Character.InitHealth <= 0)
            {
                Character.InitHealth = 0;
            }
            Console.WriteLine($"{this.CharacterName} attacks {Character.CharacterName}");
            Console.WriteLine($"{Character.CharacterName} has {Character.InitHealth} of life");
        }

        //Add propertys {get; set;}
        public string CharacterName { get; set; }

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

        public virtual void SayName()
        {
            Console.WriteLine($"I'm character. My name is {CharacterName}");
        }
    }
}
