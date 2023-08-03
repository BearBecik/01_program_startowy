using ChellengeApp;

Employee employee1 = new Employee("Arkadiusz", "Bett", 56);
Employee employee2 = new Employee("Magdalena", "Kowalska", 26);
Employee employee3 = new Employee("Zbigniew", "Malinowski", 37);

employee1.countPoint(3);
employee1.countPoint(2);
employee1.countPoint(10);
employee1.countPoint(3);
employee1.countPoint(10);

employee2.countPoint(2);
employee2.countPoint(8);
employee2.countPoint(7);
employee2.countPoint(6);
employee2.countPoint(1);

employee3.countPoint(1);
employee3.countPoint(6);
employee3.countPoint(4);
employee3.countPoint(8);
employee3.countPoint(3);

int max = -1;

////rozwiązanie pierwotne (samodzielne)
/////użyłem tablicy z sumą wyników - dla mnie kod czytelniejszy
int[] sumEmployee = new int[3];

sumEmployee[0] = employee1.employee.Sum();
sumEmployee[1] = employee2.employee.Sum();
sumEmployee[2] = employee3.employee.Sum();

if (sumEmployee[0] > sumEmployee[1] && sumEmployee[1] > sumEmployee[2]) { max = 0; }
else if (sumEmployee[1] > sumEmployee[0] && sumEmployee[1] > sumEmployee[2]) { max = 1; }
else if (sumEmployee[2] > sumEmployee[0] && sumEmployee[0] > sumEmployee[1]) { max = 2; }

if (max == 0) { Console.WriteLine($"'Samodzielne' - najlepszym pracownikiem {sumEmployee[max]} pkt może pochwalić się {employee1.Name} {employee1.Surname} - {employee1.Age} lat"); }
else if (max == 1) { Console.WriteLine($"'Samodzielne' - najlepszym pracownikiem {sumEmployee[max]} pkt może pochwalić się {employee2.Name} {employee2.Surname} - {employee2.Age} lat"); }
else if (max == 2) { Console.WriteLine($"'Samodzielne' - najlepszym pracownikiem {sumEmployee[max]} pkt może pochwalić się {employee3.Name} {employee3.Surname} - {employee3.Age} lat"); }
else Console.WriteLine("'Samodzielne' - Jest co najmniej 2-ch pracowników o tej samej liczbie punktów");

//rozwiązanie z podpowiedzią Adama
List<Employee> employess = new List<Employee>();
employess.Add(employee1);
employess.Add(employee2);
employess.Add(employee3);

max = -1;
Employee maxEmployes = null;

foreach (var item in employess)
{
    if (item.employee.Sum() > max)
    {
        max = item.employee.Sum();
        maxEmployes = item;
    }
}
Console.WriteLine();
Console.WriteLine($"'Pętla foreach' - najlepszym pracownikiem {max} pkt może pochwalić się {maxEmployes.Name} {maxEmployes.Surname} w wieku {maxEmployes.Age} lat");
