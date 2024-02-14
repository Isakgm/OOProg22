// See https://aka.ms/new-console-template for more information
using FrugtLib.Model;
using FrugtLib.Repository;
using System.ComponentModel;

Frugt f1 = new Frugt(1, "Banan", 100, 5);
Frugt f2 = new Frugt(2, "Appelsin", 150, 6);

Console.WriteLine(f1);
Console.WriteLine(f2);

FrugtRepository frugtliste = new FrugtRepository();
frugtliste.Add(f1);
frugtliste.Add(f2);

frugtliste.GetAll();

Console.WriteLine(frugtliste);

frugtliste.GetById(1);
Console.WriteLine(frugtliste.GetById(1));

frugtliste.Update(1,f2);

frugtliste.Delete(2);

Console.WriteLine(frugtliste);
