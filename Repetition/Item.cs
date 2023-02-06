using System;

public class Item
{
  public int weight;
  public string name;

  public virtual void Use(Character target)
  {
    Console.WriteLine($"Using the {name} on {target.name}!");
  }
}
