using StructsEx3;

int dd = 0, mm=0, yy=0;
int total = 2;

Console.WriteLine("Create a nested structure and store data in an array");

employee[] emp = new employee[total];

for (int i = 0; i < total; i++)
{
    Console.WriteLine( "Name of the employee: ");
    string nm = Console.ReadLine();
    emp[i].eName = nm;

    Console.WriteLine("Enter the date of birth: ");
    dd = Convert.ToInt32(Console.ReadLine());
    emp[i].Date.Day = dd;

    Console.WriteLine("Enter the month of birth: ");
    mm = Convert.ToInt32(Console.ReadLine());
    emp[i].Date.Month = mm;

    Console.WriteLine("Enter the year of birth: ");
    yy = Convert.ToInt32(Console.ReadLine());
    emp[i].Date.Year = yy;

}