using System;



class Program
{
    static void Main()
    {
        // Create a new character
        Character player = new Character();

        // Print the character's stats
        Console.WriteLine("Character Stats:");
        Console.WriteLine("Health: " + player.Health);
        Console.WriteLine("Attack: " + player.Attack);
        Console.WriteLine("Defense: " + player.Defense);

        
        player.attack();

        Enemy enemy= new Enemy();

        enemy.printStats();
    }
}
