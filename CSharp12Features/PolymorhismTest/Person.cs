using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorhismTest;

internal class Person (string name, int age)
{
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;

    public int Grows() => ++Age;
}


internal class UkugmartiPerson(string name, int age) : Person (name, age)
{
    public new int Grows() => --Age;
}