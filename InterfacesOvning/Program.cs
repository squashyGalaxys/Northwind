using InterfacesOvning;

Console.WriteLine("Ange antal bilar: ");
int n = int.Parse(Console.ReadLine());

//Skapa objekt array av klassen Bil
Bil[] arrayBilar = new Bil[n];
for (int i = 0; i < n; i++)
{
    arrayBilar[i] = new Bil("",0);
    InmätningBilar(arrayBilar[i]);
    Console.WriteLine();
}

Console.WriteLine("En osorterad array:");
UtskriftBilar(arrayBilar);
Console.WriteLine();

//Sortering i stigande ordning efter tillverkare
Array.Sort(arrayBilar);
Console.WriteLine("Array sorterad efter tillverkare (stigande ordning)");
UtskriftBilar(arrayBilar);
Console.WriteLine();

//Sortering i stigande ordning efter tillverkningsår med IComparer
Array.Sort(arrayBilar, Bil.sortYearAscending());
Console.WriteLine("Array sorterad efter tillverkningsår (stigande ordning)");
UtskriftBilar(arrayBilar);
Console.WriteLine();

//Sortering i fallande ordning efter tillverkare med IComparer
Array.Sort(arrayBilar, Bil.sortMakeDescending());
Console.WriteLine("Array sorterad efter tillverkare (fallande ordning)");
UtskriftBilar(arrayBilar);
Console.WriteLine();

//Sortering i fallande ordning efter tillverkningsår med IComparer
Array.Sort(arrayBilar, Bil.sortYearDescending());
Console.WriteLine("Array sorterad efter tillverkningsår (fallande ordning)");
UtskriftBilar(arrayBilar);
Console.WriteLine();

static void InmätningBilar(Bil c)
{
    Console.WriteLine("Ange bilinformation: ");
    Console.Write("Tillverkare: ");
    c.Tillverkare = Console.ReadLine();
    Console.Write("Tillverkningsår: ");
    c.År = int.Parse(Console.ReadLine());
}

static void UtskriftBilar(Bil[] arrayBilar)
{
    foreach (Bil c in arrayBilar)
    {
        Console.WriteLine("Tillverkare: " + c.Tillverkare + " Tillverkningsår: " + c.År);
    }
}

