using System;
using UnityEngine;
public class Character
{
    public string Name { get; set; }
    public int Health { get; set; }

    public virtual void TakeDamage(int amount)
    {
        Health -= amount;
        Console.WriteLine($"{Name} took {amount} damage!");
    }
}

