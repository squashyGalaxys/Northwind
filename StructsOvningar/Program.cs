using StructsOvningar;

Console.WriteLine("Declare a simple structure: ");
Console.WriteLine("___________________________");
firstStruct exempel = new firstStruct();

exempel.x = 15;
exempel.y = 25;

int sum = exempel.x + exempel.y;

Console.WriteLine($"The sum of x and y is {sum}");
Console.ReadLine();