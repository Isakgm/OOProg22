// See https://aka.ms/new-console-template for more information


using Bike_Rental_System;
using System.Diagnostics;

Bike bike1 = new Bike(1, "Toyota", "Orange",2001);
Bike bike2 = new Bike(2, "Honda", "Yellow", 2005);
Bike bike3 = new Bike(3, "Kia", "Green", 2017);
Bike bike4 = new Bike(3, "Kia", "Green", 2017);
Bike bike5 = new Bike(6, "Kia", "Green", 2017);
EBike ebike1 = new EBike(4, "BMW", "Black", 2022, 750);
EBike ebike2 = new EBike(5, "Kia", "Red", 2021, 850);

Console.WriteLine(bike1);
Console.WriteLine(bike2);
Console.WriteLine(bike3);
Console.WriteLine(bike4);
Console.WriteLine(ebike1);
Console.WriteLine(ebike2);

BikeCatalog bikecatalog = new BikeCatalog();
bikecatalog.Add(bike1);
bikecatalog.Add(bike2);
bikecatalog.Add(bike3);
bikecatalog.Add(bike5);
bikecatalog.Add(ebike1);
bikecatalog.Add(ebike2);

try
{
    bikecatalog.Add(bike4);
}
catch (ArgumentException AE) 
{
    Console.WriteLine("Fejl: " + AE.Message);
}
Console.WriteLine(bikecatalog.SearchBike(2));

List<Bike> bikes = bikecatalog.GetAllBikes();
foreach  (Bike bike in bikes)
{
    Console.WriteLine(bike);
}

List<Bike> bikeFromKia = bikecatalog.SearchBikesOfModel("Kia");
foreach (Bike bike in bikeFromKia)
{
    Console.WriteLine(bike);
}

bikecatalog.removeAllBikesOfModel("Kia");
    foreach (Bike bike in bikes)
    {
        Console.WriteLine(bike);
    }
