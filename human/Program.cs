using System;

namespace human
{
    public class Human
    {
        public string name;
        public int strength;
        public int intelligence;
        public int dexterity;
        public int health;
        public Human(string title)
        {
            name = title;
        }
        public Human(string title,int healthy=100,int strong=3,int dex=3,int smarts=3)
        {
            name = title;
            health = healthy;
            strength = strong;
            intelligence = smarts;
            dexterity = dex;
        }
        public void Attack(object other)
        {
            if(other is Human)
            {
                Human person = other as Human;
                int damage = this.strength *5;
                System.Console.WriteLine(strength);
                person.health -= damage;
                System.Console.WriteLine(person.health);
            }
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Human dennis = new Human("dennis",100,3,3,3);
            Human liz = new Human("Liz",100,3,3,3);
            liz.Attack(dennis);
            System.Console.WriteLine(dennis.health);
        }
    }
}
