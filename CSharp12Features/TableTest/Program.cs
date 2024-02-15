using Spectre.Console;

Table table = new Table();

table.AddColumn("[blue]vax[/]");
table.AddColumn("[green]chemi[/]");
table.AddEmptyRow();
table.AddEmptyRow();
table.AddEmptyRow();
table.AddEmptyRow();
table.AddRow("[blue]es ramamagari[/]", "rame yofila");
//table.AddRow("pizdec?", "pizdec?", "pizdec?");
table.AddRow("pizdec?");

AnsiConsole.Write(table);