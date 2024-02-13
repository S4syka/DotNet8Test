using System.Reflection;

Console.WriteLine(Env.MachineName);

Assembly mainAssembly = Assembly.GetEntryAssembly()!;

foreach (AssemblyName name in mainAssembly.GetReferencedAssemblies())
{
    Assembly assembly = Assembly.Load(name);

    int methodCount = 0;

    foreach (TypeInfo type in assembly.GetTypes())
    {
        methodCount += type.GetMethods().Length;
    }

    Console.WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.", assembly.GetTypes().Length, methodCount, name.Name);
}

Console.OutputEncoding = System.Text.Encoding.UTF8;
string grinningEmoji = char.ConvertFromUtf32(0x1F600);
Console.WriteLine(grinningEmoji);

var person = new { FirstName = "Alice", Age = 56 };

string json = $$"""
 {
    "first_name": "{{person.FirstName}}",
    "age": {{person.Age}},
    "calculation": "{{{1 + 2}}}"
 }
 """;

Console.WriteLine(json);