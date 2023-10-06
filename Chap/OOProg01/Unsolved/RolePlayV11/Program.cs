
Warrior warriorA = new Warrior("Ragnar", 1);
Warrior warriorB = new Warrior("Lagertha", 10);

warriorB.Damage(10);

Console.WriteLine($"Warrior A is called {warriorA.Name}, " +
                  $"and is level {warriorA.Level}" + 
                  $" and his health is {warriorA.Health}" +
                  $" Dead = {warriorA.Dead}");
Console.WriteLine($"Warrior B is called {warriorB.Name}, " +
                  $"and is level {warriorB.Level}" +
                  $" and his health is {warriorB.Health}" +
                  $" Dead = {warriorB.Dead}");
