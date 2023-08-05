using ChellengeApp;

while (true)
{
    Console.Clear();
    Console.WriteLine(" Witamy w programie do obsługi oceny Pracowników");
    Console.WriteLine("*************************************************");
    Console.WriteLine();
    Console.WriteLine("użycie 'q' powoduje zakończenie wprowadzania");
    Console.WriteLine("Oceny można wprowadzać zarówno literowo jak i liczbowo");
    Console.WriteLine();
    Console.WriteLine("Dane pracownika:");
    Console.Write("Imię \t\t");
    string name = Console.ReadLine().Trim();
    if (name == "q" || name == "Q")
    {
        break;
    }

    Console.Write("Nazwisko \t");
    string surname = Console.ReadLine().Trim();
    if (surname == "q" || surname == "Q")
    {
        break;
    }

    Employee employee = new Employee(name, surname);

    while (true)
    {
        Console.WriteLine($"Podaj ilość punktów, 'q-quit' koniec wprowadzania punktacji");
        var input = Console.ReadLine().ToUpper().Trim();

        if (input == "Q")
        {
            break;
        }

        if (char.TryParse(input, out char inputChar))
            switch (input)
            {
                case "A":
                case "B":
                case "C":
                case "D":
                case "E":
                    employee.AddGrade(inputChar);
                    break;
                default:
                    employee.AddGrade(input);
                    break;
            }
        else
        {
            employee.AddGrade(input);
        }
    }
    var statistics = employee.GetStatistics();
    Console.WriteLine($"Wyniki dla: {employee.Name} {employee.Surname}");
    Console.WriteLine($"Min: {statistics.Min:N2} \tMax: {statistics.Max:N2} \tŚrednia: {statistics.Average:N2} \tOgólna ocena: {statistics.AverageLetter}");
    Console.WriteLine();
    Console.WriteLine("zakończono wyświetlanie statystyk Pracownika, wciśnij dowolny klawisz, aby przejść do wprowadzania kolejnego pracownika");
    Console.ReadKey();
}