using System;

public class Potion : Item
{
  public bool isFull = true;

  public Potion()
  {
    name = "Health potion";
    weight = 1;
  }

  public override void Use(Character target)
  {
    base.Use(target);

    if (isFull)
    {
      Console.WriteLine("Yes, drink!");
      target.hp += 20;
      isFull = false;
    }
    else
    {
      Console.WriteLine("No, is empty!");
    }
  }
}
