// See https://aka.ms/new-console-template for more information
using FrugtLib.Generic;
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

RepositoryGeneric<Frugt> fruitliste = new RepositoryGeneric<Frugt>();
fruitliste.Add(f1);
fruitliste.Add(f2);
fruitliste.Add(f2);
fruitliste.Add(f2);
fruitliste.GetAll();
Console.WriteLine(fruitliste);

Kunde kunde1 = new Kunde(1, "Peter", "12345678", "peter@mail.dk");
Kunde kunde2 = new Kunde(2, "Isak", "87654321", "isak@mail.dk");

RepositoryGeneric<Kunde> kundeliste = new RepositoryGeneric<Kunde>();
kundeliste.Add(kunde1);
kundeliste.Add(kunde2);

kundeliste.GetAll();
Console.WriteLine(kundeliste);
