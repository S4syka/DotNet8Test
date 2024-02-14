using ParameterTest;

Person person1 = new (12, "Giorgi");
Person person2 = person1;

person1.Name = "kote";
Console.WriteLine(person2);
Console.WriteLine(person1);

person1 = person1 with { Name = "koswia" };
Console.WriteLine(person2);
Console.WriteLine(person1);