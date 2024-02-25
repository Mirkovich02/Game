using System;
using System.Security.Cryptography.X509Certificates;

public class Character
{
    public string name { get; set; }
    public int health { get; set; }
    public int attackPoints { get; set; }
    public int defence { get; set; }
    public double attackMultiplier { get; set; }

    public Character(string name, int health, int attackPoints, int defence, double attackMultiplier)
    {
        this.name = name;
        this.health = health;
        this.attackPoints = attackPoints;
        this.defence = defence;
        this.attackMultiplier = attackMultiplier;
    }

    public int RollDice()
    {
        Random random = new Random();
        return random.Next(1, 7);
    }

    public int Attack()
    {
        int damage = 0;
        for (int i = 0; i < 3; i++)
        {
            damage += RollDice();
        }
        return damage;
    }

    public void Defend(int incomingDamage)
    {
        int damageTaken = incomingDamage - defence;
        if (damageTaken > 0)
        {
            this.health -= damageTaken;
        }
        else
        {
            //Lose
        }

        if (this.health <= 0)
        {
            //Lose
        }
    }
}
