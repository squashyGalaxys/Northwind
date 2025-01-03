using Microsoft.Extensions.Configuration;
using System.Diagnostics;


string settingsFile = "appsettings.json";

string settingsPath = Path.Combine(Directory.GetCurrentDirectory(), settingsFile);

Console.WriteLine($"Processing...: {settingsPath}");
Console.WriteLine(File.ReadAllText(settingsPath));
Console.WriteLine("--------------------");

ConfigurationBuilder builder = new();

builder.SetBasePath(Directory.GetCurrentDirectory());

builder.AddJsonFile(settingsFile, 
    optional: false, reloadOnChange: true);

IConfigurationRoot configuration = builder.Build();

TraceSwitch ts = new(
    displayName: "NinSwitch",
    description: "This switch is set via a JSON config.");

configuration.GetSection("NinSwitch").Bind(ts);


Console.WriteLine($"TraceSwitch value: {ts.Value}");
Console.WriteLine($"TraceSwitch level: {ts.Level}");

Trace.WriteLineIf(ts.TraceError, "Trace error");
Trace.WriteLineIf(ts.TraceWarning, "Trace warning");
Trace.WriteLineIf(ts.TraceInfo, "Trace info");
Trace.WriteLineIf(ts.TraceVerbose, "Trace verbose");


Debug.Close();
Trace.Close();

Console.WriteLine("Done. Press enter to exit");
Console.ReadLine();




