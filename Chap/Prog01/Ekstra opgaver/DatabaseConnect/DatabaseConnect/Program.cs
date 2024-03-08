// See https://aka.ms/new-console-template for more information
using DatabaseConnect;

Console.WriteLine("Hello, World!");

DB_Drink drinkRepo = new DB_Drink();

List<Drink> drinks = drinkRepo.GetAll();
foreach (Drink drink in drinks)
{
    Console.WriteLine(drink);
}

Drink nydrink = new Drink(123, "Gin hass", true);
drinkRepo.Add(nydrink); 

