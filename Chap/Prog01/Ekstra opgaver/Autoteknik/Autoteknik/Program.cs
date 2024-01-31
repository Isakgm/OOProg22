// See https://aka.ms/new-console-template for more information

using Autoteknik;
using System.ComponentModel;

Car car1 = new Car(1, "AD23412", 2011, "Ford", "Focus", 220000);
Car car2 = new Car(2, "AF23512", 2008, "Tesla", "Model Y", 230000);

Console.WriteLine(car1);
Console.WriteLine(car2);

CarRegister carregister = new CarRegister("John Sharp", 51626123);
carregister.Add(car1);
carregister.Add(car2);

carregister.GetListe();
Console.WriteLine(carregister);

AutoRepair autorepair1 = new AutoRepair(1, "Motorskift", 2000);
AutoRepair autorepair2 = new AutoRepair(2, "Motorskift og olieskift", 3000);

carregister.AddRepairToCar("AF23512", autorepair2);

Console.WriteLine(autorepair1);
Console.WriteLine(autorepair2);
car1.AddAutoRepair(autorepair1);
Console.WriteLine(car1);



