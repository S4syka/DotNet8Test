using CSharp12Features;
using System.Reflection;

//WriteLine(Env.MachineName);

Assembly mainAssembly = Assembly.GetEntryAssembly()!;

foreach (AssemblyName name in mainAssembly.GetReferencedAssemblies())
{
    Assembly assembly = Assembly.Load(name);

    int methodCount = 0;

    foreach (TypeInfo type in assembly.GetTypes())
    {
        methodCount += type.GetMethods().Length;
    }

    //WriteLine("{0:N0} types with {1:N0} methods in {2} assembly.", assembly.GetTypes().Length, methodCount, name.Name);
}

OutputEncoding = System.Text.Encoding.UTF8;
string grinningEmoji = char.ConvertFromUtf32(0x1F600);
//WriteLine(grinningEmoji);

var person = new { FirstName = "Alice", Age = 56 };

string json = $$"""
 {
    "first_name": "{{person.FirstName}}",
    "age": {{person.Age}},
    "calculation": "{{{1 + 2}}}"
 }
 """;

//WriteLine(json);
//WriteLine();

unsafe
{
    //WriteLine($"Half uses {sizeof(Half)} bytes and can store numbers in the range {Half.MinValue:N0} to {Half.MaxValue:N0}.");
    //WriteLine($"Int128 uses {sizeof(Int128)} bytes and can store numbers in the range {Int128.MinValue:N0} to {Int128.MaxValue:N0}.");
}

//dynamic something = new object();
//something.size();

//Test.PatternMatching();
Test.FilteredException("aa12");