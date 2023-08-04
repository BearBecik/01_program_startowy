using ChellengeApp;
using Microsoft.VisualBasic;


Console.WriteLine();
Console.WriteLine(" Witamy w programie do obsługi oceny Pracowników");
Console.WriteLine("*************************************************");
Console.WriteLine();
Console.WriteLine("Oceny będą podawane: 'A' - literowo, 'L' - liczbowo?");
string evalutionType = null;
string evalutionTypeText = null;

while (true)
{
    evalutionType = Console.ReadLine().ToUpper();
    if (evalutionType == "L" || evalutionType == "L")
    { break; }
    Console.WriteLine("Podaj rodzaj wprowadzanech ocen: 'A' - literowo, 'L' - liczbowo");
}
if (evalutionType == "A")
{
    evalutionTypeText = "literowo";
}
else
{
    evalutionType = "liczbowo";
}

Console.WriteLine("Podaj imię Pracownika");
string name = Console.ReadLine();
Console.WriteLine("Podaj nazwisko Pracownika");
string surname = Console.ReadLine();

Employee employeeA = new Employee(name, surname);
Employee employeeL = new Employee(name, surname);

while (true)
{
    Console.WriteLine($"Podaj {evalutionTypeText} liczbę punktów, 'q' - zakonczenie podawania wyników, 's' - statystka chwilowa (bieżąca)");
    var input = Console.ReadLine();
    if (input == "q" || input == "Q")
    { 
        break; 
    }
    if (input == "s" || input == "S") 
    {
        //Console.WriteLine($"Wyniki dla: {employeeA.Name} {employeeA.Surname}:");
        //var statistics4 = employee4.GetStatistics();
        //Console.WriteLine($"Min: {statistics4.Min:N2} \tMax: {statistics4.Max:N2} \tAverage: {statistics4.Average:N2} \tOgólna ocena: {statistics4.AverageLetter}");


    }
    if (evalutionType == "A")
    {
        var inputChr = char.Parse(input);
        employeeA.AddGrade(inputChr);
    }
    else
    {
        employeeL.AddGrade(input);
    }
}

Console.WriteLine($"Wyniki dla: {employeeL} {employeeL.Surname}:");
var statisticsL = employeeL.GetStatistics();
Console.WriteLine($"Min: {statisticsL.Min:N2} \tMax: {statisticsL.Max:N2} \tAverage: {statisticsL.Average:N2} \tOgólna ocena: {statisticsL.AverageLetter}");

[private void Message()
{
    Console.WriteLine($"Wyniki dla: {employeeL} {employeeL.Surname}:");
    var statisticsL = employeeL.GetStatistics();
    Console.WriteLine($"Min: {statisticsL.Min:N2} \tMax: {statisticsL.Max:N2} \tAverage: {statisticsL.Average:N2} \tOgólna ocena: {statisticsL.AverageLetter}");
}



