//Skriv en konsolapplikation som ska för angivna sidolängder av kvadrat och kuber,
//beräkna arean av en kvadrat och en kub, såväl som för ett givet arean för att bestämma
//sidolängder av kvadrat och kuber.

using Ex2;

Console.WriteLine("Ange sidlängd: ");
double sidlängd = double.Parse(Console.ReadLine());
//Bereknar arean av kvadrat och kub
Kvadrat kvadratet = new Kvadrat(sidlängd);
Kub kuben = new Kub(sidlängd);

//Skriver ut arean av kvadrat och kub
Console.WriteLine($"Arean av kvdaraten = {kvadratet.Area}");
Console.WriteLine($"Kubens yta är = {kuben.Area}");

Console.WriteLine();

//Areasinmatning:
Console.WriteLine("Ange arean: ");
double area = double.Parse(Console.ReadLine());
kvadratet.Area = area;
kuben.Area = area;

//Visa längden av kvadrat och kub
Console.WriteLine($"Sidolängden av kvadraten = {kvadratet.sida}");
Console.WriteLine($"Kubens sidlängd = {kuben.sida}");

Console.ReadLine();