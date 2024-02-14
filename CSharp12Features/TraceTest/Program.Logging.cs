using Microsoft.Extensions.Configuration;
using System.Diagnostics;

partial class Program
{
    public static void SetupLogging()
    {
        string settingsFile = Path.Combine("Settings", "TraceSettings.json");
        string settingsPath = Path.Combine(Directory.GetCurrentDirectory(), settingsFile);

        ConfigurationBuilder builder = new ();
        builder.AddJsonFile(settingsPath);

        IConfigurationRoot config = builder.Build();
        TraceSwitch ts = new(displayName: "MySwitch", description: "TestSwitch");
        config.GetSection("MySwitch").Bind(ts);

        Debug.WriteLineIf(ts.TraceError, "Trace error");
        Debug.WriteLineIf(ts.TraceWarning, "Trace warning");
        Debug.WriteLineIf(ts.TraceInfo, "Trace information");
        Debug.WriteLineIf(ts.TraceVerbose, "Trace verbose");
    }
}