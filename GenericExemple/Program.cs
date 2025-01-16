using GenericExemple;

int[] intArray = { 1, 2, 3, 4, 5 };
string[] stringArray = { "apple", "banana", "cherry" };

//Använder generiska metoden för att skriva ut arrayerna
Console.WriteLine("Printing integers: ");
GenericExample.PrintElements(intArray);

Console.WriteLine("Printing strings: ");
GenericExample.PrintElements(stringArray);

Console.WriteLine("----------------------------------");

//Använder generiska klassen för att instansiera och skriva ut arrayerna
GenericList<int> intList = new GenericList<int>(5);
intList.Add(10);
intList.Add(20);
intList.Add(30);

intList.PrintItems();


GenericList<string> stringList = new GenericList<string>(5);
stringList.Add("John");
stringList.Add("Paul");
stringList.Add("George");

stringList.PrintItems();