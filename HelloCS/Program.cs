WriteLine($"There are {args.Length} arguments.");

if(args.Length < 3)
{
    WriteLine("You must provide two colors and cursor size, e.g.");
    WriteLine("dotnet run Red White 25");
    return; // stop the program
}

ForegroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[0],
    ignoreCase: true);

BackgroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[1],
    ignoreCase: true);

try
{
    CursorSize = int.Parse(args[2]);
}
catch (PlatformNotSupportedException)
{
    WriteLine("The current platform does not support changing the size of the cursor.");
}

//#if NET7_0_OR_GREATER
//// Komplilera  kod som fungerar bara på .NET 7.0 eller senare

//if (OperatingSystem.IsWindows())
//{
//    //Kör kod som fungerar bara på Windows
//}
//else if (OperatingSystem.IsLinux())
//{
//    //Kör kod som fungerar bara på Linux
//}
//else if (OperatingSystem.IsMacOS())
//{
//    //Kör kod som fungerar bara på MacOS
//}
//else
//{
//    WriteLine("The current operating system is not supported.");
//    return;
//}
