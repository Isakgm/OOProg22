// See https://aka.ms/new-console-template for more information
using UML;

Pizza pizza1 = new Pizza(1,"Pepperoni", 75, "Ost, Tomat og Pepperoni");
Pizza pizza2 = new Pizza(2, "Skinke", 75, "Ost, Tomat og Skinke");
Pizza pizza3 = new Pizza(3, "Italiano", 78, "Ost, Tomat, løg og Kødsovs");
Kunde kunde1 = new Kunde(1, "Mikkel", "12345678");
Kunde kunde2 = new Kunde(2, "Trine", "12344321");
Kunde kunde3 = new Kunde(3, "Kurt", "12332189");

Køb køb1 = new Køb(pizza1, kunde1);
Køb køb2 = new Køb(pizza2, kunde2);
Køb køb3 = new Køb(pizza3, kunde3);

Console.WriteLine(køb1);
Console.WriteLine(køb2);
Console.WriteLine(køb3);

KundeListe kundeliste = new KundeListe();
kundeliste.Tilføj(kunde1);
kundeliste.Tilføj(kunde2);
kundeliste.Tilføj(kunde3);

kunde1.Navn = "Jens";

Console.WriteLine(kundeliste);

PizzaListe pizzaListe = new PizzaListe();
pizzaListe.Tilføj(pizza1);
pizzaListe.Tilføj(pizza2);
pizzaListe.Tilføj(pizza3);

pizza1.Pris = 100;


Console.WriteLine(pizzaListe);

List<Kunde> findKundeUdFraNavn = kundeliste.HentFraNavn("Jens");

foreach (Kunde kunde in findKundeUdFraNavn)
{
    Console.WriteLine(kunde);
}

Console.WriteLine(pizzaListe.HentPizzaUdFraNummer(1));

kundeliste.Slet(kunde3);
pizzaListe.Slet(3);

Console.WriteLine(kundeliste);
Console.WriteLine(pizzaListe);




