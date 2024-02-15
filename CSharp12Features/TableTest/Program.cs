using Spectre.Console;
using System.Runtime.CompilerServices;

Table driverInformation = new Table();
driverInformation.AddColumns("Driver Name", "Driver Type");

var driveInfo = DriveInfo.GetDrives();
foreach(var item in driveInfo)
{
    driverInformation.AddRow(item.Name, item.DriveType.ToString());
}
AnsiConsole.Write(driverInformation);