Character micke = new Character() { name = "Micke" };

// Potion p = new Potion() {name = "Mega health potion"};

// p.Use(micke);
// p.Use(micke);
// Console.WriteLine(micke.hp);

micke.inv.items.Add(new Potion());

Console.WriteLine(micke.hp);
micke.inv.items[0].Use(micke);
Console.WriteLine(micke.hp);


Console.ReadLine();
