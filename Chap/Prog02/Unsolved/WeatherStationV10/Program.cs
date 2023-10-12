Barometer barometer = new Barometer();

barometer.Pressure = 900;
Console.WriteLine($"The pressure is: {barometer.Pressure}, {barometer.WeatherDescription}");

//For loops gennemløber et fast antal gange
// for (initialisering; betingelse; ændring)
for (int i = 0; i < 2; i = i + 1)
{
    Console.WriteLine("tal: " + i);
}

//While Loops er til ikke et fast anatal gange
//initialisering
// while (betingelse)
// {
// ... kode ...
//   ændring
// }

int O = 0;
while (O < 10)
{
    Console.WriteLine("tal:" + O);
    O++;
}

string indtxt = "NotSlut";
while (indtxt != "slut")
{ 
    Console.WriteLine(indtxt);

    Console.WriteLine("indtast linje slut menes løkken stopper");
    indtxt = Console.ReadLine();
}