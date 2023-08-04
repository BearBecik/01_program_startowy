using ChellengeApp;

Employee employee1 = new Employee("Arkadiusz", "Bett");
Employee employee2 = new Employee("Magdalena", "Kowalska");
Employee employee3 = new Employee("Zbigniew", "Malinowski");
Employee employee4 = new Employee("Pusta", "Lista");
Employee employee5 = new Employee("Janusz", "Kowalski");

Console.WriteLine($"Wyniki dla: {employee1.Name} {employee1.Surname}:");
employee1.AddGrade(32.0236f);
employee1.AddGrade(12.23233f);
employee1.AddGrade(60.59f);
employee1.AddGrade(-73.56f);
employee1.AddGrade(10.43f);
var statistics1 = employee1.GetStatisticsForEach();
Console.WriteLine($"Min: {statistics1.Min:N2} \tMax: {statistics1.Max:N2} \tAverage: {statistics1.Average:N2}");
Console.WriteLine();

Console.WriteLine($"Wyniki dla: {employee2.Name} {employee2.Surname}:");
employee2.AddGrade(26.026f);
employee2.AddGrade(78.78f);
employee2.AddGrade(87.5698f);
employee2.AddGrade(68.445f);
employee2.AddGrade("a1.00521f");
var statistics2 = employee2.GetStatisticsFor();
Console.WriteLine($"Min: {statistics2.Min:N2} \tMax: {statistics2.Max:N2} \tAverage: {statistics2.Average:N2}");
Console.WriteLine();

Console.WriteLine($"Wyniki dla: {employee3.Name} {employee3.Surname}:");
employee3.AddGrade(71.1212f);
employee3.AddGrade(16.7812f);
employee3.AddGrade(41.0f);
employee3.AddGrade(87.0023f);
employee3.AddGrade(43.005661f);
var statistics3 = employee3.GetStatisticsDoWhile();
Console.WriteLine($"Min: {statistics3.Min:N2} \tMax: {statistics3.Max:N2} \tAverage: {statistics3.Average:N2}");
Console.WriteLine();

Console.WriteLine($"Wyniki dla: {employee5.Name} {employee5.Surname}:");
employee5.AddGrade(42.0236f);
employee5.AddGrade(22.23f);
employee5.AddGrade(60.59f);
employee5.AddGrade(76.56f);
employee5.AddGrade(90.43f);
var statistics5 = employee5.GetStatisticsWhile();
Console.WriteLine($"Min: {statistics5.Min:N2} \tMax: {statistics5.Max:N2} \tAverage: {statistics5.Average:N2}");
Console.WriteLine();

Console.WriteLine($"Wyniki dla: {employee4.Name} {employee4.Surname}:");
var statistics4 = employee4.GetStatisticsDoWhile();
Console.WriteLine($"Min: {statistics4.Min:N2} \tMax: {statistics4.Max:N2} \tAverage: {statistics4.Average:N2}");
Console.WriteLine();



