using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterTest;

public record Person
{
    private int _oe = 12;

    public int Age { get; set; }
    public string? Name { get; set; }

    public Person(int age, string name)
    {
        Age = age;
        Name = name;
    }

    public int ChangeOe()
    {
        return ++_oe;
    }
}
