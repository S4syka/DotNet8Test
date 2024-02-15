using PolymorhismTest;

Person givi = new("Givi", 12);
Console.WriteLine(givi.Grows());

UkugmartiPerson goga = new UkugmartiPerson("Goga", 12);
Console.WriteLine(goga.Grows());
givi = goga;
Console.WriteLine(givi.Grows());


