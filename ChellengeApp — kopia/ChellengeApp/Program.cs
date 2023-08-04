using ChellengeApp;

Console.WriteLine();
Console.WriteLine(" Witamy w programie do obsługi oceny Pracowników");
Console.WriteLine("*************************************************");
Console.WriteLine();
Console.WriteLine("użycie 'q' powoduje zakończenie wprowadzania");
Console.WriteLine();

Console.WriteLine("Oceny będą podawane: 'A' - literowo, 'L' - liczbowo?");
string evalutionType = null;
string evalutionTypeText = null;

while (true)
{
    evalutionType = Console.ReadLine().ToUpper();
    if (evalutionType == "L" || evalutionType == "A")
    { break; }
    Console.WriteLine("Podaj rodzaj wprowadzanych ocen: 'A' - literowo, 'L' - liczbowo");
}

if (evalutionType == "A")
{
    evalutionTypeText = "literowo";
}
else
{
    evalutionTypeText = "liczbowo";
}

while (true)
{
    Console.WriteLine("Podaj imię Pracownika");
    string name = Console.ReadLine();
    if (name == "q" || name == "Q")
    {
        break;
    }

    Console.WriteLine("Podaj nazwisko Pracownika");
    string surname = Console.ReadLine();
    if (surname == "q" || surname == "Q")
    {
        break;
    }

    Employee employee = new Employee(name, surname);

    while (true)
    {
        Console.WriteLine($"Podaj {evalutionTypeText} ilość punktów, 'q-quit' koniec wprowadzania punktacji");
        var input = Console.ReadLine().ToUpper();

        if (input == "Q")
        {
            break;
        }
        if (evalutionType == "A")
        {
            employee.AddGrade(char.Parse(input.Substring(0, 1)));    //tu powinna być obsługa długości input, ale jeszcze nie wiem jak
        }
        else
        {
            employee.AddGrade(input);
        }
    }

    var statistics = employee.GetStatistics();
    Console.WriteLine($"Wyniki dla: {employee} {employee.Surname}");
    Console.WriteLine($"Min: {statistics.Min:N2} \tMax: {statistics.Max:N2} \tAverage: {statistics.Average:N2} \tOgólna ocena: {statistics.AverageLetter}");

    Console.WriteLine();
    Console.WriteLine("zakończono wyświetlanie statystyk, wciśnij dowolny klawisz, aby przejść do wprowadzania kolejnego pracownika");
    Console.ReadKey();
    //te teksty przydałoby się zrobić jako metody void, po też są na początku programu, tylko jak? new Class?
    Console.Clear();
    Console.WriteLine(" Witamy w programie do obsługi oceny Pracowników");
    Console.WriteLine("*************************************************");
    Console.WriteLine();
    Console.WriteLine("użycie 'q' powoduje zakończenie wprowadzania");
    Console.WriteLine();
}
