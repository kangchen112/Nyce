using System;
public class Player : Character
{
    public void Attack()
    {
        Console.WriteLine($"{Name} attacks the enemy!");
    }
}

public class Enemy : Character
{
    public override void TakeDamage(int amount)
    {
        Health -= amount / 2; // Example: Enemy has damage resistance
        Console.WriteLine($"{Name} took reduced damage of {amount / 2}!");
    }
}
