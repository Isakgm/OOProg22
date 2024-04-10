// See https://aka.ms/new-console-template for more information

using BakeryLib.Model;
using BakeryLib.Repository;
using System.ComponentModel;

Bread bread1 = new Bread("Trekornsbrød",1,20.00,false, 500, true);
Bread bread2 = new Bread("rugbrød", 2, 28.00, false, 600, true);
Cake cake1 = new Cake("Jordbærtærte", 3, 35.00, true, "Flødeskumskage");
Cake cake2 = new Cake("Studenterbrød", 4, 10.00, true, "Tørkage");

BakeryRepository bakeryItems = new BakeryRepository();
bakeryItems.Add(bread1);
bakeryItems.Add(bread2);
bakeryItems.Add(cake1);
bakeryItems.Add(cake2);

Console.WriteLine(bakeryItems);
Console.WriteLine("Kager");
bakeryItems.GetAllCake();
Console.WriteLine(bakeryItems.GetAllCake());
Console.WriteLine("Brød");
bakeryItems.GetAllBread();
Console.WriteLine(bakeryItems.GetAllBread());