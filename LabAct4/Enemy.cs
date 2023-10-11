using System;

class Enemy: Character
{
    public string? type;

    public Enemy():base ()
    {
        Random random = new Random ();
        string[] types = {"Orc", "Skeleton", "Goblins", "Slime"};
        int index = random.Next (0, types.Length);
        this.type = types[index];
    }

    public void printStats()
    {
        Console.WriteLine("{0} Stats:",type);
        Console.WriteLine("Health: " + this.Health);
        Console.WriteLine("Attack: " + this.Attack);
        Console.WriteLine("Defense: " + this.Defense);
    }

}