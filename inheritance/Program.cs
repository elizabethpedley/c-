using System;

namespace human
{
    public class Human
    {
        public string name { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }
        public int health { get; set; }

        public Human()
        {
            name = "person";
            health = 100;
            strength = 3;
            dexterity = 3;
            intelligence = 3;

        }
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
    public class Wizard:Human
    {
        public Wizard()
        {
            this.health = 50;
            this.intelligence = 25;
        }
        public void Heal()
        {
            health += 10*intelligence;
        }
        public void Fireball(Human enemy)
        {
            Random rand = new Random();
            enemy.health -= rand.Next(20,50);

        }
    }
    public class Ninja:Human
    {
        public Ninja()
        {
            this.dexterity = 175;
        }
        public void Steal(Human other)
        {
            this.Attack(other);
            health += 10;

        }
        public void GetAway()
        {
            health -= 15;
        }
    }
    public class Samurai:Human{
        public Samurai()
        {
            this.health = 200;
        }
        public void deathBlow(Human enemy)
        {
            if(enemy.health<50)
            {
                enemy.health = 50;
            }
        }
        public void meditate()
        {
            health = 200;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Wizard dennis = new Wizard();
            Samurai liz = new Samurai();
            liz.Attack(dennis);
            System.Console.WriteLine(dennis.health);
        }
    }
}
