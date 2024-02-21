// See https://aka.ms/new-console-template for more information
using Datastrukturer.Model;
using Datastrukturer.RyCars;
using System.ComponentModel.DataAnnotations;

Car car1 = new Car(1,100,"AV12354","rød");
Car car2 = new Car(2, 200, "AB12354", "rød");
Car car3 = new Car(3, 300, "AQ12354", "blå");
Car car4 = new Car(4, 400, "AD12354", "grøn");
Car car5 = new Car(5, 500, "V12354", "rød");

IRyCars cars = new RyCarsDictionary();

cars.Add(car1);
cars.Add(car2);
cars.Add(car3);
cars.Add(car4);
cars.Add(car5);

Console.WriteLine("---GetAllCars-----");
cars.GetAllCars();
Console.WriteLine(cars);

Console.WriteLine("---FindCarById---");
cars.FindCarById(1);
Console.WriteLine(cars.FindCarById(1));

Console.WriteLine("---FindRedCars---");

foreach (Car car in cars.FindRedCars())
{
    Console.WriteLine(car);
}

Console.WriteLine("---FindCarByRegNo---");
cars.FindCarByRegNo("AD12354");
Console.WriteLine(cars.FindCarByRegNo("AD12354"));

Console.WriteLine("---FindOldestCar---");
cars.FindOldestCar();
Console.WriteLine(cars.FindOldestCar());

Console.WriteLine("---FindNewestCar---");
cars.FindNewestCar();
Console.WriteLine(cars.FindNewestCar());
