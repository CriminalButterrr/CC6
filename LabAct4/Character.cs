using System;

class Character
{
    public int Health;
    public int Attack;
    public int Defense;

    public Character()
    {
        // Create a random number generator
        Random random = new Random();

        // Generate random values for health, attack, and defense
        Health = random.Next(25, 36); 
        Attack = random.Next(5, 10);
        Defense = random.Next(0, 5); 
    }

    public void attack()
    {
        Console.WriteLine("Player has attacked");
    }  

    public void heal()
    {
        Console.WriteLine("Player has healed");
    }

    public void isAlive()
    {
        Console.WriteLine("Player is stil alive");
    }
}